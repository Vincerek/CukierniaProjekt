namespace CukierniaProjekt
{
    partial class Main
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.tlpMenu = new System.Windows.Forms.TableLayoutPanel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnAktualnosci = new FontAwesome.Sharp.IconButton();
            this.btnFormularz = new FontAwesome.Sharp.IconButton();
            this.btnKonto = new FontAwesome.Sharp.IconButton();
            this.panelTop.SuspendLayout();
            this.tlpMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.tlpMenu);
            this.panelTop.Controls.Add(this.panelLogo);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1216, 75);
            this.panelTop.TabIndex = 1;
            // 
            // tlpMenu
            // 
            this.tlpMenu.BackColor = System.Drawing.Color.White;
            this.tlpMenu.ColumnCount = 3;
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMenu.Controls.Add(this.btnKonto, 2, 0);
            this.tlpMenu.Controls.Add(this.btnFormularz, 1, 0);
            this.tlpMenu.Controls.Add(this.btnAktualnosci, 0, 0);
            this.tlpMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMenu.Location = new System.Drawing.Point(200, 0);
            this.tlpMenu.Name = "tlpMenu";
            this.tlpMenu.RowCount = 1;
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMenu.Size = new System.Drawing.Size(1016, 75);
            this.tlpMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pbLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 75);
            this.panelLogo.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.White;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.Image = global::CukierniaProjekt.Properties.Resources.Logo_Cukierkowe_urojenia;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(200, 75);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 75);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1216, 440);
            this.panelMain.TabIndex = 2;
            // 
            // btnAktualnosci
            // 
            this.btnAktualnosci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAktualnosci.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAktualnosci.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btnAktualnosci.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.btnAktualnosci.IconColor = System.Drawing.Color.Black;
            this.btnAktualnosci.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAktualnosci.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAktualnosci.Location = new System.Drawing.Point(0, 0);
            this.btnAktualnosci.Margin = new System.Windows.Forms.Padding(0);
            this.btnAktualnosci.Name = "btnAktualnosci";
            this.btnAktualnosci.Size = new System.Drawing.Size(338, 75);
            this.btnAktualnosci.TabIndex = 3;
            this.btnAktualnosci.Text = "Aktualności";
            this.btnAktualnosci.UseVisualStyleBackColor = true;
            this.btnAktualnosci.Click += new System.EventHandler(this.btnAktualnosci_Click);
            // 
            // btnFormularz
            // 
            this.btnFormularz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFormularz.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFormularz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btnFormularz.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnFormularz.IconColor = System.Drawing.Color.Black;
            this.btnFormularz.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnFormularz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormularz.Location = new System.Drawing.Point(338, 0);
            this.btnFormularz.Margin = new System.Windows.Forms.Padding(0);
            this.btnFormularz.Name = "btnFormularz";
            this.btnFormularz.Size = new System.Drawing.Size(338, 75);
            this.btnFormularz.TabIndex = 4;
            this.btnFormularz.Text = "Formularz";
            this.btnFormularz.UseVisualStyleBackColor = true;
            this.btnFormularz.Click += new System.EventHandler(this.btnFormularz_Click);
            // 
            // btnKonto
            // 
            this.btnKonto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btnKonto.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnKonto.IconColor = System.Drawing.Color.Black;
            this.btnKonto.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnKonto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKonto.Location = new System.Drawing.Point(676, 0);
            this.btnKonto.Margin = new System.Windows.Forms.Padding(0);
            this.btnKonto.Name = "btnKonto";
            this.btnKonto.Size = new System.Drawing.Size(340, 75);
            this.btnKonto.TabIndex = 5;
            this.btnKonto.Text = "Konto";
            this.btnKonto.UseVisualStyleBackColor = true;
            this.btnKonto.Click += new System.EventHandler(this.btnKonto_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 515);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.Name = "Main";
            this.Text = "Cukiernia \"Cukierkowe urojenia\"";
            this.panelTop.ResumeLayout(false);
            this.tlpMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.TableLayoutPanel tlpMenu;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel panelMain;
        private FontAwesome.Sharp.IconButton btnFormularz;
        private FontAwesome.Sharp.IconButton btnAktualnosci;
        private FontAwesome.Sharp.IconButton btnKonto;
    }
}

