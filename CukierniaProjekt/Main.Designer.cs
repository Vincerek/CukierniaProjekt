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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelTop = new System.Windows.Forms.Panel();
            this.tlpMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnKontakt = new FontAwesome.Sharp.IconButton();
            this.btnStworzCiasto = new FontAwesome.Sharp.IconButton();
            this.btnNaszeCIasta = new FontAwesome.Sharp.IconButton();
            this.btnAktualnosci = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnKoszyk = new FontAwesome.Sharp.IconButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.tlpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.panelTop.Controls.Add(this.tlpMenu);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1536, 75);
            this.panelTop.TabIndex = 1;
            // 
            // tlpMenu
            // 
            this.tlpMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.tlpMenu.ColumnCount = 7;
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 263F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tlpMenu.Controls.Add(this.btnKontakt, 4, 0);
            this.tlpMenu.Controls.Add(this.btnStworzCiasto, 3, 0);
            this.tlpMenu.Controls.Add(this.btnNaszeCIasta, 2, 0);
            this.tlpMenu.Controls.Add(this.btnAktualnosci, 1, 0);
            this.tlpMenu.Controls.Add(this.pictureBox1, 0, 0);
            this.tlpMenu.Controls.Add(this.iconButton1, 5, 0);
            this.tlpMenu.Controls.Add(this.btnKoszyk, 6, 0);
            this.tlpMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMenu.Location = new System.Drawing.Point(0, 0);
            this.tlpMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpMenu.Name = "tlpMenu";
            this.tlpMenu.RowCount = 1;
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMenu.Size = new System.Drawing.Size(1536, 75);
            this.tlpMenu.TabIndex = 0;
            // 
            // btnKontakt
            // 
            this.btnKontakt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.btnKontakt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKontakt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKontakt.FlatAppearance.BorderSize = 0;
            this.btnKontakt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(165)))), ((int)(((byte)(214)))));
            this.btnKontakt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(165)))), ((int)(((byte)(214)))));
            this.btnKontakt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKontakt.Font = new System.Drawing.Font("Inter", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKontakt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(28)))), ((int)(((byte)(117)))));
            this.btnKontakt.IconChar = FontAwesome.Sharp.IconChar.Phone;
            this.btnKontakt.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(28)))), ((int)(((byte)(117)))));
            this.btnKontakt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKontakt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKontakt.Location = new System.Drawing.Point(1103, 0);
            this.btnKontakt.Margin = new System.Windows.Forms.Padding(0);
            this.btnKontakt.Name = "btnKontakt";
            this.btnKontakt.Size = new System.Drawing.Size(280, 75);
            this.btnKontakt.TabIndex = 7;
            this.btnKontakt.Text = "Kontakt";
            this.btnKontakt.UseVisualStyleBackColor = false;
            this.btnKontakt.Click += new System.EventHandler(this.btnKontakt_Click);
            // 
            // btnStworzCiasto
            // 
            this.btnStworzCiasto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.btnStworzCiasto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStworzCiasto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStworzCiasto.FlatAppearance.BorderSize = 0;
            this.btnStworzCiasto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(165)))), ((int)(((byte)(214)))));
            this.btnStworzCiasto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(165)))), ((int)(((byte)(214)))));
            this.btnStworzCiasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStworzCiasto.Font = new System.Drawing.Font("Inter", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStworzCiasto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(28)))), ((int)(((byte)(117)))));
            this.btnStworzCiasto.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.btnStworzCiasto.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(28)))), ((int)(((byte)(117)))));
            this.btnStworzCiasto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStworzCiasto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStworzCiasto.Location = new System.Drawing.Point(823, 0);
            this.btnStworzCiasto.Margin = new System.Windows.Forms.Padding(0);
            this.btnStworzCiasto.Name = "btnStworzCiasto";
            this.btnStworzCiasto.Size = new System.Drawing.Size(280, 75);
            this.btnStworzCiasto.TabIndex = 5;
            this.btnStworzCiasto.Text = "Stwórz Ciasto";
            this.btnStworzCiasto.UseVisualStyleBackColor = false;
            this.btnStworzCiasto.Click += new System.EventHandler(this.btnStworz_Click);
            // 
            // btnNaszeCIasta
            // 
            this.btnNaszeCIasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.btnNaszeCIasta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNaszeCIasta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNaszeCIasta.FlatAppearance.BorderSize = 0;
            this.btnNaszeCIasta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(165)))), ((int)(((byte)(214)))));
            this.btnNaszeCIasta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(165)))), ((int)(((byte)(214)))));
            this.btnNaszeCIasta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNaszeCIasta.Font = new System.Drawing.Font("Inter", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNaszeCIasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(28)))), ((int)(((byte)(117)))));
            this.btnNaszeCIasta.IconChar = FontAwesome.Sharp.IconChar.CakeCandles;
            this.btnNaszeCIasta.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(28)))), ((int)(((byte)(117)))));
            this.btnNaszeCIasta.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnNaszeCIasta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNaszeCIasta.Location = new System.Drawing.Point(543, 0);
            this.btnNaszeCIasta.Margin = new System.Windows.Forms.Padding(0);
            this.btnNaszeCIasta.Name = "btnNaszeCIasta";
            this.btnNaszeCIasta.Size = new System.Drawing.Size(280, 75);
            this.btnNaszeCIasta.TabIndex = 4;
            this.btnNaszeCIasta.Text = "Nasze Ciasta";
            this.btnNaszeCIasta.UseVisualStyleBackColor = false;
            this.btnNaszeCIasta.Click += new System.EventHandler(this.btnNaszeCiasta_Click);
            // 
            // btnAktualnosci
            // 
            this.btnAktualnosci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.btnAktualnosci.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAktualnosci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAktualnosci.FlatAppearance.BorderSize = 0;
            this.btnAktualnosci.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(165)))), ((int)(((byte)(214)))));
            this.btnAktualnosci.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(165)))), ((int)(((byte)(214)))));
            this.btnAktualnosci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAktualnosci.Font = new System.Drawing.Font("Inter", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAktualnosci.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(28)))), ((int)(((byte)(117)))));
            this.btnAktualnosci.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnAktualnosci.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(28)))), ((int)(((byte)(117)))));
            this.btnAktualnosci.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAktualnosci.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAktualnosci.Location = new System.Drawing.Point(263, 0);
            this.btnAktualnosci.Margin = new System.Windows.Forms.Padding(0);
            this.btnAktualnosci.Name = "btnAktualnosci";
            this.btnAktualnosci.Size = new System.Drawing.Size(280, 75);
            this.btnAktualnosci.TabIndex = 3;
            this.btnAktualnosci.Text = "O Nas";
            this.btnAktualnosci.UseVisualStyleBackColor = false;
            this.btnAktualnosci.Click += new System.EventHandler(this.btnAktualnosci_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.iconButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(165)))), ((int)(((byte)(214)))));
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(165)))), ((int)(((byte)(214)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.List;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(28)))), ((int)(((byte)(117)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(1386, 2);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(70, 71);
            this.iconButton1.TabIndex = 9;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnKoszyk
            // 
            this.btnKoszyk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKoszyk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKoszyk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKoszyk.FlatAppearance.BorderSize = 0;
            this.btnKoszyk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKoszyk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.btnKoszyk.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnKoszyk.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(28)))), ((int)(((byte)(117)))));
            this.btnKoszyk.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKoszyk.Location = new System.Drawing.Point(1462, 2);
            this.btnKoszyk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKoszyk.Name = "btnKoszyk";
            this.btnKoszyk.Size = new System.Drawing.Size(71, 71);
            this.btnKoszyk.TabIndex = 10;
            this.btnKoszyk.UseVisualStyleBackColor = false;
            this.btnKoszyk.Click += new System.EventHandler(this.btnKoszyk_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 75);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1536, 508);
            this.panelMain.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1536, 583);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PixelCake";
            this.panelTop.ResumeLayout(false);
            this.tlpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TableLayoutPanel tlpMenu;
        public System.Windows.Forms.Panel panelMain;
        private FontAwesome.Sharp.IconButton btnNaszeCIasta;
        private FontAwesome.Sharp.IconButton btnAktualnosci;
        private FontAwesome.Sharp.IconButton btnStworzCiasto;
        private FontAwesome.Sharp.IconButton btnKontakt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnKoszyk;
    }
}

