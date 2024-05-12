namespace CukierniaProjekt
{
    partial class wierszZamowien
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.wiersz = new System.Windows.Forms.TableLayoutPanel();
            this.cena = new System.Windows.Forms.Label();
            this.nazwa = new System.Windows.Forms.Label();
            this.btnUsun = new FontAwesome.Sharp.IconButton();
            this.zdj = new System.Windows.Forms.PictureBox();
            this.sztuki = new System.Windows.Forms.NumericUpDown();
            this.wiersz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zdj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sztuki)).BeginInit();
            this.SuspendLayout();
            // 
            // wiersz
            // 
            this.wiersz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            this.wiersz.ColumnCount = 5;
            this.wiersz.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.wiersz.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.wiersz.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.wiersz.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.wiersz.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.wiersz.Controls.Add(this.cena, 2, 0);
            this.wiersz.Controls.Add(this.nazwa, 0, 0);
            this.wiersz.Controls.Add(this.btnUsun, 4, 0);
            this.wiersz.Controls.Add(this.zdj, 1, 0);
            this.wiersz.Controls.Add(this.sztuki, 3, 0);
            this.wiersz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wiersz.Location = new System.Drawing.Point(0, 0);
            this.wiersz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.wiersz.Name = "wiersz";
            this.wiersz.RowCount = 1;
            this.wiersz.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.wiersz.Size = new System.Drawing.Size(955, 91);
            this.wiersz.TabIndex = 0;
            // 
            // cena
            // 
            this.cena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            this.cena.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(152)))));
            this.cena.Location = new System.Drawing.Point(572, 0);
            this.cena.Margin = new System.Windows.Forms.Padding(0);
            this.cena.Name = "cena";
            this.cena.Size = new System.Drawing.Size(143, 91);
            this.cena.TabIndex = 6;
            this.cena.Text = "Cena";
            this.cena.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nazwa
            // 
            this.nazwa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            this.nazwa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nazwa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazwa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(152)))));
            this.nazwa.Location = new System.Drawing.Point(0, 0);
            this.nazwa.Margin = new System.Windows.Forms.Padding(0);
            this.nazwa.Name = "nazwa";
            this.nazwa.Size = new System.Drawing.Size(429, 91);
            this.nazwa.TabIndex = 1;
            this.nazwa.Text = "Nazwa Ciasta";
            this.nazwa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUsun
            // 
            this.btnUsun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUsun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            this.btnUsun.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnUsun.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(152)))));
            this.btnUsun.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsun.IconSize = 35;
            this.btnUsun.Location = new System.Drawing.Point(858, 0);
            this.btnUsun.Margin = new System.Windows.Forms.Padding(0);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(97, 91);
            this.btnUsun.TabIndex = 7;
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // zdj
            // 
            this.zdj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zdj.Image = global::CukierniaProjekt.Properties.Resources.Logo_Cukierkowe_urojenia;
            this.zdj.Location = new System.Drawing.Point(429, 0);
            this.zdj.Margin = new System.Windows.Forms.Padding(0);
            this.zdj.Name = "zdj";
            this.zdj.Size = new System.Drawing.Size(143, 91);
            this.zdj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.zdj.TabIndex = 8;
            this.zdj.TabStop = false;
            // 
            // sztuki
            // 
            this.sztuki.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            this.sztuki.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sztuki.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sztuki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sztuki.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(152)))));
            this.sztuki.Location = new System.Drawing.Point(715, 31);
            this.sztuki.Margin = new System.Windows.Forms.Padding(0, 31, 0, 31);
            this.sztuki.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.sztuki.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sztuki.Name = "sztuki";
            this.sztuki.Size = new System.Drawing.Size(143, 26);
            this.sztuki.TabIndex = 9;
            this.sztuki.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sztuki.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sztuki.ValueChanged += new System.EventHandler(this.sztuki_ValueChanged);
            // 
            // wierszZamowien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.wiersz);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "wierszZamowien";
            this.Size = new System.Drawing.Size(955, 91);
            this.wiersz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.zdj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sztuki)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel wiersz;
        private System.Windows.Forms.Label nazwa;
        private System.Windows.Forms.Label cena;
        private FontAwesome.Sharp.IconButton btnUsun;
        private System.Windows.Forms.PictureBox zdj;
        private System.Windows.Forms.NumericUpDown sztuki;
    }
}
