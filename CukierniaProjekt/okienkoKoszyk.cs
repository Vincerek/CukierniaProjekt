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
        public bool koszyk = false;
        public okienkoKoszyk()
        {
            InitializeComponent();
        }
       

        private void btnKoszyk_Click(object sender, EventArgs e)
        {
            koszyk = true;

            

            this.Close();
        }

        private void btnWroc_Click(object sender, EventArgs e)
        {
            koszyk = false;
            this.Close();
        }
    }
}
