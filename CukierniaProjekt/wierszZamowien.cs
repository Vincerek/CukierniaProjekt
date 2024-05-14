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
    public partial class wierszZamowien : UserControl
    {
        PictureBox pictures(Image obrazu)
        {
            zdj.Image = obrazu;
            return zdj;
        }
        public wierszZamowien()
        {
            InitializeComponent();
            //przypisywanie wartości zmiennym potrzebnym do wyświetlenia informacji w wierszu za pomocą zmiennych statycznych
            //z formularza Zamowienia
            nazwa.Text = Zamowienia.staticNazwa;
            
            byte[] zdj = Zamowienia.staticZdj;
            if (zdj != null)
            {
                using (MemoryStream mstream = new MemoryStream(zdj))
                {
                    pictures(Image.FromStream(mstream));
                }
            }
            
            
        }

        //funkcja służąca do usuwania danego wiersza po kliknieciu przycisku
        public void bazaUsun()
        {
            using (SQLiteConnection connection = new SQLiteConnection(@"DataSource=..\..\Baza\cukierniaCiasta.db"))
            {
                connection.Open();
                string query = $"DELETE FROM koszykTemp WHERE idCiasta={this.Tag};";
                SQLiteCommand cmd = connection.CreateCommand();
                cmd.CommandText = query;

                int result = cmd.ExecuteNonQuery();
                //sprawdzanie czy delete się wykonał
                if (result == 1)
                {
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Błąd");
                }
                connection.Close();
            }
        }
        private void btnUsun_Click(object sender, EventArgs e)
        {
            bazaUsun();
            //Odświeżanie wierszów w panelu szczegZamow w formularzu zamowienia za pomocą wywołania funkcji tego formularza
            Zamowienia zamowienia = this.ParentForm as Zamowienia;
            if (zamowienia != null)
            {
                zamowienia.bazaOdczyt();
            }

        }

        private void sztuki_ValueChanged(object sender, EventArgs e)
        {
            long value = (long)sztuki.Value;
            /*
            using (SQLiteConnection connection = new SQLiteConnection(@"DataSource=..\..\Baza\cukierniaCiasta.db"))
            {
                connection.Open();
                string query = $"UPDATE koszykTemp SET sztuki = {value} WHERE idCiasta = {this.Tag};";
                SQLiteCommand cmd = connection.CreateCommand();
                cmd.CommandText = query;
                int result = cmd.ExecuteNonQuery();
                //sprawdzanie czy update się wykonał
                
                if (result == 1)
                {
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Błąd");
                }
                connection.Close();
                
            }
            */
        }

        private void wierszZamowien_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(@"DataSource=..\..\Baza\cukierniaCiasta.db"))
            {
                connection.Open();
                string queryTemp = $"SELECT sztuki FROM koszykTemp WHERE idCiasta={this.Tag};";
                using (SQLiteCommand command = new SQLiteCommand(queryTemp, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            sztuki.Value = (long)reader["sztuki"];
                            cena.Text = (Zamowienia.staticCena * (long)reader["sztuki"]).ToString() + " zł";
                            connection.Close();
                        }
                    }
                }
                connection.Close();
            }
            
        }
    }
}
