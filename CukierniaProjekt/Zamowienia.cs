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
    public partial class Zamowienia : Form
    {
        string hintImie;
        string hintNazwisko;
        string hintMail;
        string hintTel;
        public Zamowienia()
        {
            InitializeComponent();
            hintImie = textImie.Text;
            hintImie = textImie.Text;
            hintImie = textImie.Text;
            hintImie = textImie.Text;


        }
        public void onHint(string hint, TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = hint;
                textBox.ForeColor = Color.DarkGray;
            }

        }
        public void offHint(string hint, TextBox textBox)
        {
            if (textBox.Text == hint)
            {
                textBox.Text = null;
                textBox.ForeColor = Color.Black;
            }
        }

        private void textImie_Enter(object sender, EventArgs e)
        {
            offHint(hintImie, textImie);
        }

        private void textImie_Leave(object sender, EventArgs e)
        {
            onHint(hintImie, textImie);
        }

        private void textImie_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNazwisko_Enter(object sender, EventArgs e)
        {
            offHint(hintImie, textNazwisko);
        }

        private void textNazwisko_Leave(object sender, EventArgs e)
        {
            onHint(hintImie, textNazwisko);
        }
    }
}
