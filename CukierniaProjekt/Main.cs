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
        public IconButton currentBtn;
        public Main()
        {
            InitializeComponent();
            //Otwieranie aktualności jako strony początkowej
            OpenChildForm(new Aktualnosci());
            //ustawieie btnAktualnosci jako aktywny na start
            ActiveButton(btnAktualnosci);
        }
        //Funkcja odpowiadająca za otwieranie formatki wewnątrz panelu formatki Main
        
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
        }
        //Funkcja Odznaczająca button dla lepszego wyglądu i czytelnosci strony
        private void ActiveButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.Font = new Font(currentBtn.Font, FontStyle.Bold);
            }
        }
        //zdejmowanie wyrużnienia przycisku
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.Font = new Font(currentBtn.Font, FontStyle.Regular);
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

        private void btnKontakt_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new Kontakt());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new Status());
        }

        private void btnKoszyk_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new Zamowienia());
        }
    }
}
