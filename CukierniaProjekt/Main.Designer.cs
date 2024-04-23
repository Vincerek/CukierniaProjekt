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
            this.btnStworzCiasto = new FontAwesome.Sharp.IconButton();
            this.btnNaszeCIasta = new FontAwesome.Sharp.IconButton();
            this.btnAktualnosci = new FontAwesome.Sharp.IconButton();
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
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.panelTop.Controls.Add(this.tlpMenu);
            this.panelTop.Controls.Add(this.panelLogo);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(912, 61);
            this.panelTop.TabIndex = 1;
            // 
            // tlpMenu
            // 
            this.tlpMenu.BackColor = System.Drawing.Color.White;
            this.tlpMenu.ColumnCount = 3;
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMenu.Controls.Add(this.btnStworzCiasto, 2, 0);
            this.tlpMenu.Controls.Add(this.btnNaszeCIasta, 1, 0);
            this.tlpMenu.Controls.Add(this.btnAktualnosci, 0, 0);
            this.tlpMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMenu.Location = new System.Drawing.Point(150, 0);
            this.tlpMenu.Margin = new System.Windows.Forms.Padding(2);
            this.tlpMenu.Name = "tlpMenu";
            this.tlpMenu.RowCount = 1;
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMenu.Size = new System.Drawing.Size(762, 61);
            this.tlpMenu.TabIndex = 0;
            // 
            // btnStworzCiasto
            // 
            this.btnStworzCiasto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.btnStworzCiasto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStworzCiasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStworzCiasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStworzCiasto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(28)))), ((int)(((byte)(117)))));
            this.btnStworzCiasto.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.btnStworzCiasto.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(28)))), ((int)(((byte)(117)))));
            this.btnStworzCiasto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStworzCiasto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStworzCiasto.Location = new System.Drawing.Point(508, 0);
            this.btnStworzCiasto.Margin = new System.Windows.Forms.Padding(0);
            this.btnStworzCiasto.Name = "btnStworzCiasto";
            this.btnStworzCiasto.Size = new System.Drawing.Size(254, 61);
            this.btnStworzCiasto.TabIndex = 5;
            this.btnStworzCiasto.Text = "Stwórz Ciasto";
            this.btnStworzCiasto.UseVisualStyleBackColor = false;
            this.btnStworzCiasto.Click += new System.EventHandler(this.btnStworz_Click);
            // 
            // btnNaszeCIasta
            // 
            this.btnNaszeCIasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.btnNaszeCIasta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNaszeCIasta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNaszeCIasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNaszeCIasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(28)))), ((int)(((byte)(117)))));
            this.btnNaszeCIasta.IconChar = FontAwesome.Sharp.IconChar.CakeCandles;
            this.btnNaszeCIasta.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(28)))), ((int)(((byte)(117)))));
            this.btnNaszeCIasta.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnNaszeCIasta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNaszeCIasta.Location = new System.Drawing.Point(254, 0);
            this.btnNaszeCIasta.Margin = new System.Windows.Forms.Padding(0);
            this.btnNaszeCIasta.Name = "btnNaszeCIasta";
            this.btnNaszeCIasta.Size = new System.Drawing.Size(254, 61);
            this.btnNaszeCIasta.TabIndex = 4;
            this.btnNaszeCIasta.Text = "Nasze ciasta";
            this.btnNaszeCIasta.UseVisualStyleBackColor = false;
            this.btnNaszeCIasta.Click += new System.EventHandler(this.btnNaszeCiasta_Click);
            // 
            // btnAktualnosci
            // 
            this.btnAktualnosci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.btnAktualnosci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAktualnosci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAktualnosci.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAktualnosci.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(28)))), ((int)(((byte)(117)))));
            this.btnAktualnosci.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.btnAktualnosci.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(28)))), ((int)(((byte)(117)))));
            this.btnAktualnosci.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAktualnosci.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAktualnosci.Location = new System.Drawing.Point(0, 0);
            this.btnAktualnosci.Margin = new System.Windows.Forms.Padding(0);
            this.btnAktualnosci.Name = "btnAktualnosci";
            this.btnAktualnosci.Size = new System.Drawing.Size(254, 61);
            this.btnAktualnosci.TabIndex = 3;
            this.btnAktualnosci.Text = "Aktualności";
            this.btnAktualnosci.UseVisualStyleBackColor = false;
            this.btnAktualnosci.Click += new System.EventHandler(this.btnAktualnosci_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pbLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(150, 61);
            this.panelLogo.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.Image = global::CukierniaProjekt.Properties.Resources.Logo_Cukierkowe_urojenia;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(150, 61);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 61);
            this.panelMain.Margin = new System.Windows.Forms.Padding(2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(912, 357);
            this.panelMain.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 418);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private FontAwesome.Sharp.IconButton btnNaszeCIasta;
        private FontAwesome.Sharp.IconButton btnAktualnosci;
        private FontAwesome.Sharp.IconButton btnStworzCiasto;
    }
}

