﻿using System;
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
    public partial class okienkoZamowienie : Form
    {
        public okienkoZamowienie()
        {
            InitializeComponent();
        }
        //wyświetlanie odpowiedniego komunikatu w labelu w okienku na podstawie zmiennej typu bool(czyPusty) z formularza Zamowienia
        private void okienkoZamowienie_Load(object sender, EventArgs e)
        {
            if (Zamowienia.czyPusty == true) komunikat.Text = "Koszyk jest pusty, musisz dodać ciasto by złożyć zamowienie";
            
            else komunikat.Text = $"Dziękujemy za zakupy w naszym sklepie.\r\n\r\nElektroniczny paragon został wysłany na twoją skrzynkę mailową.\r\nPłatność przy odbiorzę.";
            
        }
        //zamknięcie okienka po kliknięciu przycisku z ikonką krzyżyka
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
