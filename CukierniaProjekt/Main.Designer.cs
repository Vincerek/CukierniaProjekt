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
            this.components = new System.ComponentModel.Container();
            this.panelTop = new System.Windows.Forms.Panel();
            this.tlpMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnKonto = new FontAwesome.Sharp.IconButton();
            this.btnZamów = new FontAwesome.Sharp.IconButton();
            this.btnAktualnosci = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.menuFormularz = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stwórzTort = new System.Windows.Forms.ToolStripMenuItem();
            this.wybierzTort = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTop.SuspendLayout();
            this.tlpMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.menuFormularz.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.tlpMenu);
            this.panelTop.Controls.Add(this.panelLogo);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.tlpMenu.Controls.Add(this.btnKonto, 2, 0);
            this.tlpMenu.Controls.Add(this.btnZamów, 1, 0);
            this.tlpMenu.Controls.Add(this.btnAktualnosci, 0, 0);
            this.tlpMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMenu.Location = new System.Drawing.Point(150, 0);
            this.tlpMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlpMenu.Name = "tlpMenu";
            this.tlpMenu.RowCount = 1;
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMenu.Size = new System.Drawing.Size(762, 61);
            this.tlpMenu.TabIndex = 0;
            // 
            // btnKonto
            // 
            this.btnKonto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKonto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btnKonto.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnKonto.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btnKonto.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnKonto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKonto.Location = new System.Drawing.Point(508, 0);
            this.btnKonto.Margin = new System.Windows.Forms.Padding(0);
            this.btnKonto.Name = "btnKonto";
            this.btnKonto.Size = new System.Drawing.Size(254, 61);
            this.btnKonto.TabIndex = 5;
            this.btnKonto.Text = "Konto";
            this.btnKonto.UseVisualStyleBackColor = true;
            this.btnKonto.Click += new System.EventHandler(this.btnKonto_Click);
            // 
            // btnZamów
            // 
            this.btnZamów.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnZamów.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZamów.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZamów.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btnZamów.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnZamów.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btnZamów.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnZamów.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZamów.Location = new System.Drawing.Point(254, 0);
            this.btnZamów.Margin = new System.Windows.Forms.Padding(0);
            this.btnZamów.Name = "btnZamów";
            this.btnZamów.Size = new System.Drawing.Size(254, 61);
            this.btnZamów.TabIndex = 4;
            this.btnZamów.Text = "Zamów";
            this.btnZamów.UseVisualStyleBackColor = true;
            this.btnZamów.Click += new System.EventHandler(this.btnFormularz_Click);
            // 
            // btnAktualnosci
            // 
            this.btnAktualnosci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAktualnosci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAktualnosci.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAktualnosci.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btnAktualnosci.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.btnAktualnosci.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btnAktualnosci.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAktualnosci.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAktualnosci.Location = new System.Drawing.Point(0, 0);
            this.btnAktualnosci.Margin = new System.Windows.Forms.Padding(0);
            this.btnAktualnosci.Name = "btnAktualnosci";
            this.btnAktualnosci.Size = new System.Drawing.Size(254, 61);
            this.btnAktualnosci.TabIndex = 3;
            this.btnAktualnosci.Text = "Aktualności";
            this.btnAktualnosci.UseVisualStyleBackColor = true;
            this.btnAktualnosci.Click += new System.EventHandler(this.btnAktualnosci_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pbLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(150, 61);
            this.panelLogo.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.White;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.Image = global::CukierniaProjekt.Properties.Resources.Logo_Cukierkowe_urojenia;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(150, 61);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 61);
            this.panelMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(912, 357);
            this.panelMain.TabIndex = 2;
            // 
            // menuFormularz
            // 
            this.menuFormularz.AutoSize = false;
            this.menuFormularz.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuFormularz.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuFormularz.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stwórzTort,
            this.wybierzTort});
            this.menuFormularz.Name = "menuFormularz";
            this.menuFormularz.Size = new System.Drawing.Size(341, 104);
            // 
            // stwórzTort
            // 
            this.stwórzTort.AutoSize = false;
            this.stwórzTort.Name = "stwórzTort";
            this.stwórzTort.Size = new System.Drawing.Size(340, 36);
            this.stwórzTort.Text = "Stwórz własny tort";
            this.stwórzTort.Click += new System.EventHandler(this.stwórzTort_Click);
            // 
            // wybierzTort
            // 
            this.wybierzTort.AutoSize = false;
            this.wybierzTort.Name = "wybierzTort";
            this.wybierzTort.Size = new System.Drawing.Size(340, 36);
            this.wybierzTort.Text = "Wybierz z naszego menu";
            this.wybierzTort.Click += new System.EventHandler(this.wybierzTort_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 418);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Main";
            this.Text = "Cukiernia \"Cukierkowe urojenia\"";
            this.panelTop.ResumeLayout(false);
            this.tlpMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.menuFormularz.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.TableLayoutPanel tlpMenu;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel panelMain;
        private FontAwesome.Sharp.IconButton btnZamów;
        private FontAwesome.Sharp.IconButton btnAktualnosci;
        private FontAwesome.Sharp.IconButton btnKonto;
        private System.Windows.Forms.ContextMenuStrip menuFormularz;
        private System.Windows.Forms.ToolStripMenuItem stwórzTort;
        private System.Windows.Forms.ToolStripMenuItem wybierzTort;
    }
}

