﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace CukierniaProjekt
{


    public partial class StwórzTort : Form
    {
        //tworzenie zmiennych do poruszania się po tabelach potrzebnych do wyciągania danych z tabeli z ciastami i zapisywania do koszykTemp
        int indexPosypka = 0;
        int indexSmak = 0;
        int indexBaza = 0;
        object aktualneId;

        //tabele potrzebne do wyciągania danych z tabeli z ciastami i zapisywania do koszykTemp
        String[] posypkaTab = { "czekolada", "kolorowa", "kokos" };
        String[] smakTab = { "czekolada", "toffi", "truskawka" };
        String[] bazaTab = { "biszkopt", "brownie" };

        public StwórzTort()
        {
            InitializeComponent();
        }

        //funkcje inkrementujące i dekrementujące zmienne potrzebne do poruszania się po tabelach i
        //wyswietlania danych z bazy i wyswietlanie w sliderze
        public void inkrementacjaTablicyPosypek()
        {
            if (indexPosypka < posypkaTab.Length-1)
            {
                indexPosypka++;
            }
            else
            {
                indexPosypka = 0;
            }
            bazaOdczyt();
        }
        public void dekrementacjaTablicyPosypek()
        {
            if (indexPosypka > 0)
            {
                indexPosypka--;
            }
            else
            {
                indexPosypka = posypkaTab.Length - 1;
            }
            bazaOdczyt();
        }
        public void inkrementacjaTablicySmak()
        {
            if (indexSmak < smakTab.Length - 1)
            {
                indexSmak++;
            }
            else
            {
                indexSmak = 0;
            }
            bazaOdczyt();
        }
        public void dekrementacjaTablicySmak() { 
            if (indexSmak > 0)
            {
                indexSmak--;
            }
            else
            {
                indexSmak = smakTab.Length-1;
            }
            bazaOdczyt();
        }
        public void inkrementacjaTablicyBaz()
        {
            if (indexBaza < bazaTab.Length - 1)
            {
                indexBaza++;
            }
            else
            {
                indexBaza = 0;
            }
            bazaOdczyt();
        }
        public void dekrementacjaTablicyBaz()
        {
            if (indexBaza > 0)
            {
                indexBaza--;
            }
            else
            {
                indexBaza = bazaTab.Length-1;
            }
            bazaOdczyt();
        }
        //wyświetlenie danych z bazy w sliderze po zaladowaniu formularza
        private void StwórzTort_Load(object sender, EventArgs e)
        {
            bazaOdczyt();
        }

        //funkcja potrzebna do wyświetlania obrazu z bazy danych
        PictureBox pictures(Image obrazu)
        {
            zdjCiasto.Image = obrazu;
            return zdjCiasto;
        }

        //funkcja wysyłająca zapytanie do bazy danych w celu pobrania rekordu dla danego id i wyświetlająca dane dla tego id w sliderze
        public void bazaOdczyt()
        {
            using (SQLiteConnection connection = new SQLiteConnection(@"DataSource=..\..\Baza\cukierniaCiasta.db"))
            {
                connection.Open();
                string query = $"SELECT * FROM StworzoneCiasta WHERE Posypka = \"{posypkaTab[indexPosypka]}\" AND Smak = \"{smakTab[indexSmak]}\" AND Baza=\"{bazaTab[indexBaza]}\";";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            aktualneId = reader["id"];
                            nazwaCiasta.Text = reader["Nazwa Ciasta"].ToString() + "\n" + reader["cena"] + " zł";
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
        private void btnDalej_Click(object sender, EventArgs e)
        {
            okienkoKoszyk okienko = new okienkoKoszyk();
            okienko.ShowDialog();
            bazaZapis();
            if (okienko.koszyk==true)
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


        //obsługa przycisków przewijające dane w sliderze
        private void posypkaLewo_Click(object sender, EventArgs e)
        {
            dekrementacjaTablicyPosypek();
        }
        private void posypkaPrawo_Click(object sender, EventArgs e)
        {
            inkrementacjaTablicyPosypek();
        }
        private void smakLewo_Click(object sender, EventArgs e)
        {
            dekrementacjaTablicySmak();
        }
        private void smakPrawo_Click(object sender, EventArgs e)
        {
            inkrementacjaTablicySmak();
        }
        private void bazaLewo_Click(object sender, EventArgs e)
        {
            dekrementacjaTablicyBaz();
        }
        private void bazaPrawo_Click(object sender, EventArgs e)
        {
            inkrementacjaTablicyBaz();
        }

    }
}
