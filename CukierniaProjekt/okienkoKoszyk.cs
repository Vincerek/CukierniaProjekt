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
    public partial class okienkoKoszyk : Form
    {
        public okienkoKoszyk()
        {
            InitializeComponent();
        }
        /*
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
        }*/

        private void btnKoszyk_Click(object sender, EventArgs e)
        {
            this.Close();
            /*
            Zamowienia zamowienia = new Zamowienia();
            var panelContainer = this.Parent as Panel;
            var form1 = panelContainer.TopLevelControl as Form;
            zamowienia.TopLevel = false;
            zamowienia.FormBorderStyle = FormBorderStyle.None;
            zamowienia.Dock = DockStyle.Fill;
            ((Panel)form1.Controls.Find("panelMain", true)[0]).Controls.Add(zamowienia);
            zamowienia.BringToFront();
            zamowienia.Show();
            */



        }

        private void btnWroc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
