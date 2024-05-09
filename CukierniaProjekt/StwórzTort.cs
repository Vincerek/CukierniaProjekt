using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CukierniaProjekt
{


    public partial class StwórzTort : Form
    {
        PictureBox zdjCiastoTemp;
        int indexPosypka = 0;
        int indexSmak = 0;
        int indexBaza = 0;

        String[] posypkaTab = { "czekolada", "kolorowa", "kokos" };
        String[] smakTab = { "czekolada", "toffi", "truskawka" };
        String[] bazaTab = { "biszkopt", "brownie" };

        String zapytanie = $"SELECT * FROM StworzoneCiasta WHERE Posypka = \"kokos\" AND Smak = \"czekolada\" AND Baza=\"biszkopt\";";
        //zapytanie = $"SELECT * FROM StworzoneCiasta WHERE Posypka = \"kokos\" AND Smak = \"czekolada\" AND Baza=\"biszkopt\";";
        public StwórzTort()
        {
            InitializeComponent();
            zdjCiastoTemp = zdjCiasto;

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
            baza();
        }
        public void dekrementacjaTablicyPosypek()
        {
            if (indexPosypka < 0)
            {
                indexPosypka--;
            }
            else
            {
                indexPosypka = posypkaTab.Length - 1;
            }
            baza();
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
            baza();
        }
        public void dekrementacjaTablicySmak() { 
            if (indexSmak < 0)
            {
                indexSmak--;
            }
            else
            {
                indexSmak = smakTab.Length-1;
            }
            baza();
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
            baza();
        }
        public void dekrementacjaTablicyBaz()
        {
            if (indexBaza < 0)
            {
                indexBaza--;
            }
            else
            {
                indexBaza = bazaTab.Length-1;
            }
            baza();
        }

        private void StwórzTort_Load(object sender, EventArgs e)
        {
            baza();
        }
        PictureBox pictures(Image obrazu)
        {
            zdjCiasto.Image = obrazu;
            return zdjCiasto;
        }
        public void baza()
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
                            nazwaCiasta.Text = reader["Nazwa Ciasta"].ToString();

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

        private void btnDalej_Click(object sender, EventArgs e)
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
