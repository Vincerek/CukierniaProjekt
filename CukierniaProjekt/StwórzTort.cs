using System;
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
        
        int indexPosypka = 0;
        int indexSmak = 0;
        int indexBaza = 0;

        
        object aktualneId;

        String[] posypkaTab = { "czekolada", "kolorowa", "kokos" };
        String[] smakTab = { "czekolada", "toffi", "truskawka" };
        String[] bazaTab = { "biszkopt", "brownie" };

        
        
        public StwórzTort()
        {
            InitializeComponent();
        }

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

        private void StwórzTort_Load(object sender, EventArgs e)
        {
            bazaOdczyt();
        }
        PictureBox pictures(Image obrazu)
        {
            zdjCiasto.Image = obrazu;
            return zdjCiasto;
        }
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


        private void btnDalej_Click(object sender, EventArgs e)
        {
            okienkoKoszyk okienko = new okienkoKoszyk();
            okienko.ShowDialog();
            bazaZapis();
            if (okienko.koszyk==true)
            {
                Zamowienia zamowienia = new Zamowienia();
                var panelContainer = this.Parent as Panel;
                var form1 = panelContainer.TopLevelControl as Form;
                zamowienia.TopLevel = false;
                zamowienia.FormBorderStyle = FormBorderStyle.None;
                zamowienia.Dock = DockStyle.Fill;
                ((Panel)form1.Controls.Find("panelMain", true)[0]).Controls.Add(zamowienia);
                zamowienia.BringToFront();
                zamowienia.Show();
                this.Close();
            }
        }

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
