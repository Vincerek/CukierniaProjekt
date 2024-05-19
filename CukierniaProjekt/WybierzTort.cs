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
        //tworzenie zmiennych potrzebnych do wyciagania danych z tabeli z ciastami i zapisywania do koszykTemp
        int indexCiast;

        object aktualneId;


        public WybierzTort()
        {
            InitializeComponent();
            //Przypisanie wartości zmiennej potrzebnej do wyciągniecia danych z bazy danych na podstawie idCIasta
            indexCiast = 19;
            // wywołanie funkcji odczytującej dane z bazy danych i wyswietlanie ich w sliderze
            bazaOdczyt();
        }
        //funkcja inkrementujaca zmienną indexCiast i zmieniająca dane w sliderze
        private void btnPrawo_Click(object sender, EventArgs e)
        {
            indexCiast++;
            if (indexCiast == 26)
            {
                indexCiast = 19;
                
            }
            
            bazaOdczyt();
        }
        //funkcja dekrementująca zmienną indexCiast i zmieniająca dane w sliderze
        private void btnLewo_Click(object sender, EventArgs e)
        {
            indexCiast--;
            if (indexCiast == 18)
            {
                
                indexCiast = 25;
            }
            
            bazaOdczyt();
        }
        //funkcja potrzebna do wyświetlania obrazu z bazy danych
        PictureBox pictures(Image obrazu)
        {
            pbCiasto.Image = obrazu;
            return pbCiasto;
        }
        //funkcja wysyłająca zapytanie do bazy danych w celu pobrania rekordu dla danego id i wyświetlająca dane dla tego id w sliderze
        public void bazaOdczyt()
        {
            using (SQLiteConnection connection = new SQLiteConnection(@"DataSource=..\..\Baza\cukierniaCiasta.db"))
            {
                connection.Open();
                string query = $"SELECT * FROM StworzoneCiasta WHERE Id={indexCiast};";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            aktualneId = reader["id"];
                            nazwaCiasta.Text = reader["Nazwa Ciasta"].ToString() + "\n" + reader["cena"]+" zł";
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
        //funkcja wysyłająca zapytania do bazy danych w celu sprawdzenia czy nie dodaliśmy już do koszyka tego samego ciasta,
        //w przypadku gdy tak jest zwiększamy o jeden ilość sztuk w przeciwnym przypadku zapisujemy do tabeli koszykTemp id ciasta,
        //które dodajemy do koszyka i ustawiamy ilosc sztuk na 1
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
        //obsługa przycisku który dodaje ciasto do koszyka i otwiera okienko z zapytaniem czy chcemy przejść do koszyka czy kontynuować zakupy
        // jak klikniemy przejście do koszyka to funkcja wyswietli formularz Zamówienia
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
                (Main.Controls.Find("btnNaszeCIasta", true)[0]).Font = new Font((Main.Controls.Find("btnNaszeCIasta", true)[0]).Font, FontStyle.Regular);
                zamowienia.BringToFront();
                zamowienia.Show();
                this.Close();
            }
        }
    }
}
