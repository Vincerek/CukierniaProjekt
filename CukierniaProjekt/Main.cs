using FontAwesome.Sharp;
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
    public partial class Main : Form
    {
        public Form currentChildForm;
        public IconButton currentBtn;
        public Main()
        {
            InitializeComponent();
            OpenChildForm(new Aktualnosci());
            //Debugging
            //OpenChildForm(new Zamowienia());
            ActiveButton(btnAktualnosci);
        }
        public void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //MessageBox.Show("Wykonano");
        }
        private void ActiveButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.ForeColor = System.Drawing.Color.FromArgb(227, 23, 67);
                currentBtn.Font = new Font(currentBtn.Font, FontStyle.Bold);
                currentBtn.IconColor = System.Drawing.Color.FromArgb(227, 23, 67);
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.ForeColor = System.Drawing.Color.FromArgb(69, 69, 69);
                currentBtn.Font = new Font(currentBtn.Font, FontStyle.Regular);
                currentBtn.IconColor = System.Drawing.Color.FromArgb(69, 69, 69);
            }
        }

        private void btnAktualnosci_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new Aktualnosci());
        }


        private void btnNaszeCiasta_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new WybierzTort());
        }

        private void btnStworz_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new StwórzTort());
        }
    }
}
