using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CukierniaProjekt
{
    public partial class Zamowienia : Form
    {
        public static string staticNazwa;
        public static long staticCena;
        public static byte[] staticZdj;

        string hintImie;
        string hintNazwisko;
        string hintMail;
        string hintTel;
        public double wartoscKoszyk;
        public Zamowienia()
        {
            InitializeComponent();
            hintImie = textImie.Text;
            hintNazwisko = textNazwisko.Text;
            hintMail = textMail.Text;
            hintTel = textTel.Text;
        }
        public void onHint(string hint, TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = hint;
                textBox.ForeColor = Color.DarkGray;
            }
        }
        public void offHint(string hint, TextBox textBox)
        {
            if (textBox.Text == hint)
            {
                textBox.Text = null;
                textBox.ForeColor = Color.Black;
            }
        }

        private void textImie_Enter(object sender, EventArgs e)
        {
            offHint(hintImie, textImie);
        }

        private void textImie_Leave(object sender, EventArgs e)
        {
            onHint(hintImie, textImie);
        }

        private void textNazwisko_Enter(object sender, EventArgs e)
        {
            offHint(hintNazwisko, textNazwisko);
        }

        private void textNazwisko_Leave(object sender, EventArgs e)
        {
            onHint(hintNazwisko, textNazwisko);
        }

        private void textMail_Enter(object sender, EventArgs e)
        {
            offHint(hintMail, textMail);
        }

        private void textMail_Leave(object sender, EventArgs e)
        {
            onHint(hintMail, textMail);
        }

        private void textTel_Enter(object sender, EventArgs e)
        {
            offHint(hintTel, textTel);
        }

        private void textTel_Leave(object sender, EventArgs e)
        {
            onHint(hintTel, textTel);
        }
        public void bazaOdczyt()
        {
            using (SQLiteConnection connection = new SQLiteConnection(@"DataSource=..\..\Baza\cukierniaCiasta.db"))
            {
                connection.Open();
                szczegZamow.Controls.Clear();
                string query = $"SELECT * FROM StworzoneCiasta INNER JOIN koszykTemp on StworzoneCiasta.Id = koszykTemp.idCiasta;";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        wartoscKoszyk = 0;
                        while (reader.Read())
                        {
                            staticNazwa = reader["Nazwa Ciasta"].ToString();
                            staticZdj = reader["Zdjecie"] as byte[] ?? null;
                            staticCena = (long)reader["Cena"];
                            wartoscKoszyk += staticCena*(long)reader["sztuki"];
                            wierszZamowien wierszZamowien= new wierszZamowien();
                            wierszZamowien.Tag = reader["Id"];
                            wierszZamowien.Dock = DockStyle.Top;
                            szczegZamow.Controls.Add(wierszZamowien);
                        }
                    }
                }
                connection.Close();
                lbkoszyk.Text = "wartosc koszyka: " + wartoscKoszyk + " zl";

            }
        }
        private void Zamowienia_Load(object sender, EventArgs e)
        {
            //Ustawianie ograniczeń daty odbioru po załadowaniu formularza
            //(minimalna 5dni od aktualnej daty, maksymalna rok do przodu)
            int todayD = DateTime.Now.Day;
            int todayM = DateTime.Now.Month;
            int todayY = DateTime.Now.Year;
            dataOdbioru.MinDate = new DateTime(todayY,todayM,todayD+5);
            dataOdbioru.MaxDate = new DateTime(todayY + 1, todayM, todayD);
            bazaOdczyt();            
        }

        private void btnWroc_Click(object sender, EventArgs e)
        {
            //powrót do formularza z wyborem tortów w celu kontynuowania zakupów
            WybierzTort wybierzTort = new WybierzTort();
            var panelContainer = this.Parent as Panel;
            var form1 = panelContainer.TopLevelControl as Form;
            wybierzTort.TopLevel = false;
            wybierzTort.FormBorderStyle = FormBorderStyle.None;
            wybierzTort.Dock = DockStyle.Fill;
            ((Panel)form1.Controls.Find("panelMain", true)[0]).Controls.Add(wybierzTort);
            wybierzTort.BringToFront();
            wybierzTort.Show();
            //przesył tortów dodanych do koszyka do bazy danych

        }

        private void btnZamow_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(@"DataSource=..\..\Baza\cukierniaCiasta.db"))
            {
                connection.Open();
                string query = "DELETE FROM koszykTemp";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                { 
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
            MessageBox.Show("Pomyślnie zamówiono ciasta, Płatność przy odbiorze");
            wartoscKoszyk = 0;
            bazaOdczyt();
            textImie.Text = string.Empty;
            textMail.Text = string.Empty;
            textNazwisko.Text = string.Empty;
            textTel.Text = string.Empty;
        }
    }
}
