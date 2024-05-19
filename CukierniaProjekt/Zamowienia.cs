using CukierniaProjekt.Properties;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CukierniaProjekt
{
    public partial class Zamowienia : Form
    {
        //zmienne statyczne odczytywane w kontrolce  użytkownika wierszZamowien
        public static string staticNazwa;
        
        public static long staticCena;
        public static byte[] staticZdj;

        //zmienna statyczna potrzebna do sprawdzenia czy koszyk jest pusty i do wyświetlenia odpowiedniego komunikatu w okienku okienkoKoszyk
        public static bool czyPusty = false;


        string hintImie;
        string hintNazwisko;
        string hintMail;
        string hintTel;
        public double wartoscKoszyk;
        string idCiast;
        string iloscCiast;
        string mailPDF;
        public Zamowienia()
        {
            InitializeComponent();
            hintImie = textImie.Text;
            hintNazwisko = textNazwisko.Text;
            hintMail = textMail.Text;
            hintTel = textTel.Text;
        }
        
        public void onHint(string hint, System.Windows.Forms.TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = hint;
                textBox.ForeColor = Color.DarkGray;
            }
        }
        public void offHint(string hint, System.Windows.Forms.TextBox textBox)
        {
            if (textBox.Text == hint)
            {
                textBox.Text = "";
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
        //funkcja odświeżająca cenę całościową ciast w koszyku
        public void odswiezCene()
        {
            long wart;
            using (SQLiteConnection connection = new SQLiteConnection(@"DataSource=..\..\Baza\cukierniaCiasta.db"))
            {
                connection.Open();
                string query = $"SELECT Cena*sztuki AS wartosc FROM StworzoneCiasta INNER JOIN koszykTemp on StworzoneCiasta.Id = koszykTemp.idCiasta;";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        wart=0;
                        while (reader.Read())
                        {
                            wart += (long)reader["wartosc"];
                        }
                        connection.Close();
                    }
                }
            }
            lbkoszyk.Text = "Wartość koszyka: "+wart + " zł";
            wartoscKoszyk = wart;
        }
        //funkcja odczytująca dane z tabeli ciasta połączoenj relacja z koszyk temp i wyświetlanie jeden pod drugim wiersze
        //z informacjami o ciastach dodanych do koszyka
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
                            idCiast += reader["Id"] + ";"; 
                            iloscCiast +=reader["sztuki"]+";";
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
            //wywołanie funkcji wyswietlajacej dane w koszyku
            bazaOdczyt();            
        }



        private void btnZamow_Click(object sender, EventArgs e)
        {

            


            //MessageBox.Show(idCiast);
            if (regexCheck())
            {

                if (wartoscKoszyk > 0)
                {


                    //MessageBox.Show("Pomyślnie zamówiono ciasta, Płatność przy odbiorze");
                    using (SQLiteConnection connection = new SQLiteConnection(@"DataSource=..\..\Baza\cukierniaCiasta.db"))
                    {
                        connection.Open();
                        string queryInsert = $"INSERT INTO Zamowienia (imie,nazwisko,mail,nrTel,data,lokalOdbioru,idCiast,cena,iloscCiast) VALUES( '{textImie.Text}', '{textNazwisko.Text}', '{textMail.Text}', '{textTel.Text}', '{dataOdbioru.Text}', '{lokalOdbioru.Text}', '{idCiast}', '{wartoscKoszyk}', '{iloscCiast}');";
                        using (SQLiteCommand command = new SQLiteCommand(queryInsert, connection))
                        {
                            command.ExecuteNonQuery();
                        }

                        
                            //connection.Open();
                            string queryTemp = $"SELECT * FROM Zamowienia WHERE mail='{textMail.Text}';";
                            using (SQLiteCommand command = new SQLiteCommand(queryTemp, connection))
                            {
                                using (SQLiteDataReader reader = command.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        Document document = new Document(PageSize.A4.Rotate());
                                        PdfWriter.GetInstance(document, new FileStream($"..\\..\\PDF\\{reader["imie"]}_{reader["nazwisko"]}_zamowienie.pdf", FileMode.Create));
                                        document.Open();

                                        BaseFont helvetica = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, BaseFont.EMBEDDED);
                                        iTextSharp.text.Font helvetica16 = new iTextSharp.text.Font(helvetica, 16);
                                        iTextSharp.text.Font helvetica24 = new iTextSharp.text.Font(helvetica, 24);

                                        Paragraph header = new Paragraph("Zamowienie w cukierni internetowej \n", helvetica24);
                                        header.Alignment = Element.ALIGN_CENTER;
                                        document.Add(header);
                                        iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(Resources.logo_PixelCake, System.Drawing.Imaging.ImageFormat.Png);
                                        image.ScaleAbsoluteHeight(document.PageSize.Height / 5);
                                        image.ScaleAbsoluteWidth(document.PageSize.Width / 3);
                                        image.Alignment = Element.ALIGN_CENTER;
                                        document.Add(image);


                                        Paragraph p1 = new Paragraph($"\n\nImie i nazwisko zamawiającego: {reader["imie"]} {reader["nazwisko"]}", helvetica16);
                                        document.Add(p1);

                                        Paragraph p2 = new Paragraph($"\nDane kontaktowe zamawiającego: \n\t     Nr. telefonu: {reader["nrTel"]} \n     Adres e-mail: {reader["mail"]}", helvetica16);
                                        document.Add(p2);

                                        Paragraph p3 = new Paragraph($"\nZamówienie będzie do odbioru dnia {reader["data"]} w naszym lokalu pod adresem: {reader["lokalOdbioru"]}. \nKwota do zapłaty na miejscu przy odbiorze: {reader["cena"]} zł.(Płatność kartą lub gotówką)", helvetica16);
                                        p3.Alignment = Element.ALIGN_CENTER;
                                        document.Add(p3);
                                        Paragraph p4 = new Paragraph($"\n\n\nZamówione ciasta:", helvetica16);
                                        document.Add(p4);

                                        string[] ciasta = reader["idCiast"].ToString().Split(';');
                                        string[] sztuki = reader["iloscCiast"].ToString().Split(';');
                                        string[] wiersz;
                                        for (int i = 0; i < ciasta.Length - 1; i++)
                                        {
                                            string query = $"SELECT * FROM StworzoneCiasta WHERE Id={ciasta[i]};";
                                            using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                                            {
                                                using (SQLiteDataReader readerTemp = cmd.ExecuteReader())
                                                {
                                                    while (readerTemp.Read())
                                                    {
                                                        Paragraph ciasto = new Paragraph($"\n-{readerTemp["Nazwa Ciasta"]} {readerTemp["Cena"]} zł X {sztuki[i]}", helvetica16);
                                                        document.Add(ciasto);
                                                    }
                                                }
                                            }

                                        }
                                        Paragraph p5 = new Paragraph($"\n\nW razie pytań proszę kontaktować się z nami telefonicznie lub mailowo: \n     tel: +48 824 123 987\n     tel: +48 765 321 789\n     e-mail: PixelCake@gmail.com", helvetica16);
                                        document.Add(p5);
                                        document.Close();
                                    }
                                }
                            }
                        string queryDelete = "DELETE FROM koszykTemp";
                        using (SQLiteCommand command = new SQLiteCommand(queryDelete, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                        connection.Close();
                    }

                    wartoscKoszyk = 0;
                    bazaOdczyt();
                    textImie.Text = string.Empty;
                    textMail.Text = string.Empty;
                    textNazwisko.Text = string.Empty;
                    textTel.Text = string.Empty;

                    Aktualnosci aktualnosci = new Aktualnosci();
                    var panelContainer = this.Parent as System.Windows.Forms.Panel;
                    var Main = panelContainer.TopLevelControl as Form;
                    aktualnosci.TopLevel = false;
                    aktualnosci.FormBorderStyle = FormBorderStyle.None;
                    aktualnosci.Dock = DockStyle.Fill;
                    ((System.Windows.Forms.Panel)Main.Controls.Find("panelMain", true)[0]).Controls.Add(aktualnosci);
                    aktualnosci.BringToFront();
                    aktualnosci.Show();
                    this.Close();
                }
                else
                {
                    czyPusty = true;
                }
                okienkoZamowienie okienko = new okienkoZamowienie();
                okienko.ShowDialog();



                
            }
           
        }

        private void textImie_TextChanged(object sender, EventArgs e)
        {            

        }

        bool regexCheck()
        {
           
            bool regex = true;
            String s = "";
            StringBuilder sB = new StringBuilder(s);
                if (!System.Text.RegularExpressions.Regex.IsMatch(textImie.Text, "^[a-zA-Z]+$"))
                {
                    sB.Append("Imię powinno zawierać tylko litery\n");
                    regex = false;
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(textNazwisko.Text, "^[a-zA-Z]+$"))
                {
                    sB.Append("Nazwisko powinno zawierać tylko litery\n");
                    regex = false;
                }
                if(!System.Text.RegularExpressions.Regex.IsMatch(textMail.Text, "^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$"))
                {
                    sB.Append("Mail nie poprawny, przykład: \"adam@gmail.com\" \n");
                    regex = false;
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(textTel.Text, "^[0-9]{3}-?[0-9]{3}-?[0-9]{3}$"))
                {
                    sB.Append("Numer telefonu jest nie poprawny, poprawmy format to 111-222-333\n");
                    regex = false;
                }
                if (lokalOdbioru.SelectedItem == null)
                {
                    sB.Append("Wybierz lokal do odebrania zamówienia");
                    regex = false;
                }
                if (!regex) 
                {
                    s = sB.ToString();
                    MessageBox.Show(s);
                }
            return regex;
        }
    }
}
