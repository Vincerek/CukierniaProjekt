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
using CukierniaProjekt;

namespace CukierniaProjekt
{
    public partial class WybierzTort : Form
    {
        int indexCiastMin;
        int indexCiast;
        int indexCiastMax;

        object aktualneId;

        String[] posypkaTab = { "czekolada", "kolorowa" };
        String[] smakTab = { "czekolada", "toffi" };
        String[] bazaTab = { "biszkopt", "brownie" };

        public WybierzTort()
        {
            InitializeComponent();
            bazaOdczyt();
            indexCiast = 0;
        }

        private void btnPrawo_Click(object sender, EventArgs e)
        {
            if (indexCiast < posypkaTab.Length - 1)
            {
                indexCiast++;
            }
            else
            {
                indexCiast = 0;
            }
            bazaOdczyt();
        }

        private void btnLewo_Click(object sender, EventArgs e)
        {
            if(indexCiast > 0)
            {
                indexCiast--;
            }
            else
            {
                indexCiast = posypkaTab.Length - 1; ;
            }
            bazaOdczyt();
        }
        PictureBox pictures(Image obrazu)
        {
            pbCiasto.Image = obrazu;
            return pbCiasto;
        }

        public void bazaOdczyt()
        {
            using (SQLiteConnection connection = new SQLiteConnection(@"DataSource=..\..\Baza\cukierniaCiasta.db"))
            {
                connection.Open();
                string query = $"SELECT * FROM StworzoneCiasta WHERE Posypka = \"{posypkaTab[indexCiast]}\" AND Smak = \"{smakTab[indexCiast]}\" AND Baza=\"{bazaTab[indexCiast]}\";";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            aktualneId = reader["id"];
                            nazwaCiasta.Text = reader["Nazwa Ciasta"].ToString();
                            infOCiescie.Text = reader["Opis"].ToString();

                            byte[] pic = reader["Zdjecie"] as byte[] ?? null;
                            if (pic != null)
                            {
                                using (MemoryStream mstream = new MemoryStream(pic))
                                {
                                    pictures(Image.FromStream(mstream));
                                }
                            }

                        }
                    }
                }
                connection.Close();
            }
        }
        public void bazaZapis()
        {
            using (SQLiteConnection connection = new SQLiteConnection(@"DataSource=..\..\Baza\cukierniaCiasta.db"))
            {
                connection.Open();
                string queryTemp = $"SELECT idCiasta FROM koszykTemp WHERE idCiasta={aktualneId};";
                using (SQLiteCommand command = new SQLiteCommand(queryTemp, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string query = $"UPDATE koszykTemp SET sztuki = sztuki+1 WHERE idCiasta = {aktualneId};";
                            SQLiteCommand cmd = connection.CreateCommand();
                            cmd.CommandText = query;

                            int result = cmd.ExecuteNonQuery();
                            //sprawdzanie czy insert się wykonał
                            if (result == 1)
                            {
                                //MessageBox.Show("dziala");
                                connection.Close();
                            }
                            else
                            {
                                //MessageBox.Show("Błąd");
                            }

                        }
                        else
                        {
                            string query = $"INSERT INTO koszykTemp (idCiasta, sztuki) VALUES( {aktualneId}, 1);";
                            SQLiteCommand cmd = connection.CreateCommand();
                            cmd.CommandText = query;

                            int result = cmd.ExecuteNonQuery();
                            //sprawdzanie czy insert się wykonał
                            if (result == 1)
                            {
                                //MessageBox.Show("dziala");
                                connection.Close();
                            }
                            else
                            {
                                //MessageBox.Show("Błąd");
                            }
                        }
                    }
                }
                connection.Close();
            }
        }

        private void btnDalej_Click_1(object sender, EventArgs e)
        {
            okienkoKoszyk okienko = new okienkoKoszyk();
            okienko.ShowDialog();
            bazaZapis();
            if (okienko.koszyk == true)
            {
                Zamowienia zamowienia = new Zamowienia();
                var panelContainer = this.Parent as Panel;
                var Main = panelContainer.TopLevelControl as Form;
                zamowienia.TopLevel = false;
                zamowienia.FormBorderStyle = FormBorderStyle.None;
                zamowienia.Dock = DockStyle.Fill;
                ((Panel)Main.Controls.Find("panelMain", true)[0]).Controls.Add(zamowienia);
                (Main.Controls.Find("btnStworzCiasto", true)[0]).Font = new Font((Main.Controls.Find("btnStworzCiasto", true)[0]).Font, FontStyle.Regular);
                zamowienia.BringToFront();
                zamowienia.Show();
                this.Close();
            }
        }
    }
}
