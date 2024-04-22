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
    public partial class WybierzTort : Form
    {
        public WybierzTort()
        {
            InitializeComponent();
        }

        

        

        private void WybierzTort_Load(object sender, EventArgs e)
        {
            //tu bedzie wyswietlenie danych w sliderze
        }

        private void right_Click(object sender, EventArgs e)
        {

        }

        private void left_Click(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            WyswietlUczulenia.Text += comboBoxUczulenia.SelectedItem + ", ";
        }

        private void btnPodsumowanie_Click(object sender, EventArgs e)
        {
            podsumowanie.Text=nazwaCiasta.Text+"; \n"+textboxInformacje.Text+"; \n";
        }
    }
}
