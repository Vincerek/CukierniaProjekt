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
    public partial class okienkoKoszyk : Form
    {
        public okienkoKoszyk()
        {
            InitializeComponent();
        }

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
