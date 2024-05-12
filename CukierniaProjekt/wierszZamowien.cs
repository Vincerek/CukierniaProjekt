using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            nazwa.Text = Zamowienia.publicNazwa;
            byte[] zdj = Zamowienia.publicZdj;

            if (zdj != null)
            {
                using (MemoryStream mstream = new MemoryStream(zdj))
                {
                    pictures(Image.FromStream(mstream));
                }
            }
            
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            
        }

        private void sztuki_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
