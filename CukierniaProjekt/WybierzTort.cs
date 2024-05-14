using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public WybierzTort()
        {
            InitializeComponent();

        }

        private void WybierzTort_Load(object sender, EventArgs e)
        {
            //tu bedzie wyswietlenie danych w sliderze       
            indexCiastMin = 0;
            indexCiast = 0;
            indexCiastMax = listaCiast.Images.Count-1;
            zdjCiast.BackgroundImage = listaCiast.Images[indexCiastMin];
        }

        private void btnPrawo_Click(object sender, EventArgs e)
        {
            indexCiast++;
            if (indexCiast>indexCiastMax)indexCiast = indexCiastMin;
            zdjCiast.BackgroundImage = listaCiast.Images[indexCiast];
        }

        private void btnLewo_Click(object sender, EventArgs e)
        {
            indexCiast--;
            if (indexCiast < indexCiastMin) indexCiast = indexCiastMax;
            zdjCiast.BackgroundImage = listaCiast.Images[indexCiast];
        }

        

        private void btnDalej_Click_1(object sender, EventArgs e)
        {
            okienkoKoszyk okienko = new okienkoKoszyk();
            okienko.ShowDialog();
            if (okienko.koszyk == true)
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
    }
}
