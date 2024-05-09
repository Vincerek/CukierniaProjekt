using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CukierniaProjekt
{
    
    
    public partial class StwórzTort : Form
    {
        int indeksSmaku=0;
        int indeksPosypki=0;
        int indeksBazy=0;
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
    }
}
