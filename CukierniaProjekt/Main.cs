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
        private Form currentChildForm;
        private IconButton currentBtn;
        public Main()
        {
            InitializeComponent();
            OpenChildForm(new Aktualnosci());
            ActiveButton(btnAktualnosci);
        }
        private void OpenChildForm(Form childForm)
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

        private void btnFormularz_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new StwórzTort());
            menuFormularz.Show(btnZamów, new Point(0, btnZamów.Height));
            menuFormularz.Size = btnZamów.Size;
            stwórzTort.Width = btnZamów.Width;
            wybierzTort.Width = btnZamów.Width;
        }

        private void btnKonto_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new Konto());
        }

        private void stwórzTort_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StwórzTort());
        }

        private void wybierzTort_Click(object sender, EventArgs e)
        {
            OpenChildForm(new WybierzTort());
        }
    }
}
