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
            this.btnKonto = new System.Windows.Forms.Button();
            this.btnFormularz = new System.Windows.Forms.Button();
            this.btnAktualnosci = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
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
            // btnKonto
            // 
            this.btnKonto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKonto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKonto.FlatAppearance.BorderSize = 0;
            this.btnKonto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKonto.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btnKonto.Location = new System.Drawing.Point(679, 3);
            this.btnKonto.Name = "btnKonto";
            this.btnKonto.Size = new System.Drawing.Size(334, 69);
            this.btnKonto.TabIndex = 2;
            this.btnKonto.Text = "Konto";
            this.btnKonto.UseVisualStyleBackColor = true;
            this.btnKonto.Click += new System.EventHandler(this.btnKonto_Click);
            // 
            // btnFormularz
            // 
            this.btnFormularz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFormularz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFormularz.FlatAppearance.BorderSize = 0;
            this.btnFormularz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormularz.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFormularz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btnFormularz.Location = new System.Drawing.Point(341, 3);
            this.btnFormularz.Name = "btnFormularz";
            this.btnFormularz.Size = new System.Drawing.Size(332, 69);
            this.btnFormularz.TabIndex = 1;
            this.btnFormularz.Text = "Formularz";
            this.btnFormularz.UseVisualStyleBackColor = true;
            this.btnFormularz.Click += new System.EventHandler(this.btnFormularz_Click);
            // 
            // btnAktualnosci
            // 
            this.btnAktualnosci.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAktualnosci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAktualnosci.FlatAppearance.BorderSize = 0;
            this.btnAktualnosci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAktualnosci.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAktualnosci.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btnAktualnosci.Location = new System.Drawing.Point(3, 3);
            this.btnAktualnosci.Name = "btnAktualnosci";
            this.btnAktualnosci.Size = new System.Drawing.Size(332, 69);
            this.btnAktualnosci.TabIndex = 0;
            this.btnAktualnosci.Text = "Aktualności";
            this.btnAktualnosci.UseVisualStyleBackColor = true;
            this.btnAktualnosci.Click += new System.EventHandler(this.btnAktualnosci_Click);
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
        private System.Windows.Forms.Button btnAktualnosci;
        private System.Windows.Forms.Button btnKonto;
        private System.Windows.Forms.Button btnFormularz;
        private System.Windows.Forms.Panel panelMain;
    }
}

