using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CukierniaProjekt
{


    public partial class StwórzTort : Form
    {
        int indeksSmaku = 0;
        int indeksPosypki = 0;
        int indeksBazy = 0;
        String[] smaki = { "czekolada", "toffi", "truskawka" };
        String[] posypka = { "czekolada", "kolorowa", "kokos" };
        String[] baza = { "biszkopt", "brownie" };
        String aktualnySmak;
        String aktualnaPosypka;
        public StwórzTort()
        {
            InitializeComponent();

        }

        private void StwórzTort_Load(object sender, EventArgs e)
        {
            aktualnySmak = smaki[indeksSmaku];
            aktualnaPosypka = posypka[indeksPosypki];
        }

        //Klasa zajmująca się bazą danych
        class DataClass
        {
            private SQLiteConnection sqlite;

            public DataClass()
            {
                sqlite = new SQLiteConnection("Data Source=/Baza/cukierniaCiasta.db");
            }

            public DataTable selectQuery(string query)
            {
                SQLiteDataAdapter ad;
                DataTable dt = new DataTable();

                try
                {
                    SQLiteCommand cmd;
                    sqlite.Open();  //Zapoczątkuj połączenie do bazy danych 
                    cmd = sqlite.CreateCommand();
                    cmd.CommandText = query;  //ustaw zapytanie podane w argumencie
                    ad = new SQLiteDataAdapter(cmd);
                    ad.Fill(dt); //fill the datasource
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Błąd połączenia z bazą");
                }
                sqlite.Close();
                return dt;
            }
        }
    }
}
