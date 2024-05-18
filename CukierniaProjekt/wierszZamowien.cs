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
        //funkcja potrzebna do wyświetlania obrazu z bazy danych
        PictureBox pictures(Image obrazu)
        {
            zdj.Image = obrazu;
            return zdj;
        }
        //zmienne do aktualizowania cen i ilości ciast
        long value;
        int cenaTemp;
        int cenaDanegoCiasta;
        
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
        //funkcja aktualizująca ilość sztuk ciast w tabeli koszykTemp oraz wyswietlajaca zaktualiozwane dane o cenie i ilości sztuk
        public void bazaUpdate(long value,int cenaTemp)
        {
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
            sztuki.Text = value.ToString();
            cena.Text = cenaTemp.ToString()+" zł";
            Zamowienia zamowienia = this.ParentForm as Zamowienia;
            if (zamowienia != null)
            {
                zamowienia.odswiezCene();
            }
        }
        //obsługa przycisku usuwającego dany wiersz z koszyka
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
        
        //wyświetlanie po załadowaniu kontrolki danych takich jak nazwa ciasta,cena, ilość sztuk w koszyku na
        //podstawie id przekazywanego za pomocą tagu kontrolki
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
                            value = (long)reader["sztuki"];
                            sztuki.Text = value.ToString();
                            cena.Text = (Zamowienia.staticCena * (long)reader["sztuki"]).ToString() + " zł";
                            cenaTemp = (int)(Zamowienia.staticCena * (long)reader["sztuki"]);
                            cenaDanegoCiasta = (int)(Zamowienia.staticCena);

                            connection.Close();
                        }
                    }
                }
                connection.Close();
            }

        }
        //przycisk zwiększający ilość sztuk
        private void btnPlus_Click(object sender, EventArgs e)
        {
            value++;
            cenaTemp += cenaDanegoCiasta;
            bazaUpdate(value,cenaTemp);
        }
        //przycisk zmniejszający ilość sztuk
        private void btnMinus_Click(object sender, EventArgs e)
        {
            value--;
            cenaTemp -= cenaDanegoCiasta;
            bazaUpdate(value,cenaTemp);
        }
    }
}
