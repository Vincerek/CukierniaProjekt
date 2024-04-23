namespace CukierniaProjekt
{
    partial class WybierzTort
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelNaszeCiasta = new System.Windows.Forms.TableLayoutPanel();
            this.btnDalej = new FontAwesome.Sharp.IconButton();
            this.infOCiescie = new System.Windows.Forms.Label();
            this.btnPrawo = new FontAwesome.Sharp.IconButton();
            this.nazwaCiasta = new System.Windows.Forms.Label();
            this.btnLewo = new FontAwesome.Sharp.IconButton();
            this.zdjCiast = new System.Windows.Forms.Panel();
            this.iconSplitButton1 = new FontAwesome.Sharp.IconSplitButton();
            this.panelNaszeCiasta.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNaszeCiasta
            // 
            this.panelNaszeCiasta.ColumnCount = 3;
            this.panelNaszeCiasta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.panelNaszeCiasta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.panelNaszeCiasta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.panelNaszeCiasta.Controls.Add(this.btnDalej, 3, 2);
            this.panelNaszeCiasta.Controls.Add(this.infOCiescie, 0, 2);
            this.panelNaszeCiasta.Controls.Add(this.btnPrawo, 3, 1);
            this.panelNaszeCiasta.Controls.Add(this.nazwaCiasta, 0, 0);
            this.panelNaszeCiasta.Controls.Add(this.btnLewo, 0, 1);
            this.panelNaszeCiasta.Controls.Add(this.zdjCiast, 1, 1);
            this.panelNaszeCiasta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNaszeCiasta.Location = new System.Drawing.Point(0, 0);
            this.panelNaszeCiasta.Margin = new System.Windows.Forms.Padding(0);
            this.panelNaszeCiasta.Name = "panelNaszeCiasta";
            this.panelNaszeCiasta.RowCount = 3;
            this.panelNaszeCiasta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelNaszeCiasta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelNaszeCiasta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.panelNaszeCiasta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.panelNaszeCiasta.Size = new System.Drawing.Size(1282, 682);
            this.panelNaszeCiasta.TabIndex = 0;
            // 
            // btnDalej
            // 
            this.btnDalej.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.btnDalej.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDalej.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDalej.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDalej.ForeColor = System.Drawing.Color.White;
            this.btnDalej.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btnDalej.IconColor = System.Drawing.Color.White;
            this.btnDalej.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDalej.IconSize = 40;
            this.btnDalej.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDalej.Location = new System.Drawing.Point(1089, 477);
            this.btnDalej.Margin = new System.Windows.Forms.Padding(0);
            this.btnDalej.Name = "btnDalej";
            this.btnDalej.Size = new System.Drawing.Size(193, 205);
            this.btnDalej.TabIndex = 6;
            this.btnDalej.UseVisualStyleBackColor = false;
            this.btnDalej.Click += new System.EventHandler(this.btnDalej_Click_1);
            // 
            // infOCiescie
            // 
            this.infOCiescie.AutoSize = true;
            this.infOCiescie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.panelNaszeCiasta.SetColumnSpan(this.infOCiescie, 2);
            this.infOCiescie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infOCiescie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infOCiescie.ForeColor = System.Drawing.Color.White;
            this.infOCiescie.Location = new System.Drawing.Point(0, 477);
            this.infOCiescie.Margin = new System.Windows.Forms.Padding(0);
            this.infOCiescie.Name = "infOCiescie";
            this.infOCiescie.Size = new System.Drawing.Size(1089, 205);
            this.infOCiescie.TabIndex = 4;
            this.infOCiescie.Text = "Informacje o cieście";
            // 
            // btnPrawo
            // 
            this.btnPrawo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(152)))));
            this.btnPrawo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrawo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrawo.ForeColor = System.Drawing.Color.White;
            this.btnPrawo.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            this.btnPrawo.IconColor = System.Drawing.Color.White;
            this.btnPrawo.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnPrawo.IconSize = 60;
            this.btnPrawo.Location = new System.Drawing.Point(1089, 136);
            this.btnPrawo.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrawo.Name = "btnPrawo";
            this.btnPrawo.Size = new System.Drawing.Size(193, 341);
            this.btnPrawo.TabIndex = 2;
            this.btnPrawo.UseVisualStyleBackColor = false;
            this.btnPrawo.Click += new System.EventHandler(this.btnPrawo_Click);
            // 
            // nazwaCiasta
            // 
            this.nazwaCiasta.AutoSize = true;
            this.nazwaCiasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.panelNaszeCiasta.SetColumnSpan(this.nazwaCiasta, 3);
            this.nazwaCiasta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nazwaCiasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazwaCiasta.ForeColor = System.Drawing.Color.White;
            this.nazwaCiasta.Location = new System.Drawing.Point(0, 0);
            this.nazwaCiasta.Margin = new System.Windows.Forms.Padding(0);
            this.nazwaCiasta.Name = "nazwaCiasta";
            this.nazwaCiasta.Size = new System.Drawing.Size(1282, 136);
            this.nazwaCiasta.TabIndex = 0;
            this.nazwaCiasta.Text = "Nazwa Ciasta";
            this.nazwaCiasta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLewo
            // 
            this.btnLewo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(152)))));
            this.btnLewo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLewo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLewo.ForeColor = System.Drawing.Color.White;
            this.btnLewo.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            this.btnLewo.IconColor = System.Drawing.Color.White;
            this.btnLewo.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnLewo.IconSize = 60;
            this.btnLewo.Location = new System.Drawing.Point(0, 136);
            this.btnLewo.Margin = new System.Windows.Forms.Padding(0);
            this.btnLewo.Name = "btnLewo";
            this.btnLewo.Size = new System.Drawing.Size(192, 341);
            this.btnLewo.TabIndex = 1;
            this.btnLewo.UseVisualStyleBackColor = false;
            this.btnLewo.Click += new System.EventHandler(this.btnLewo_Click);
            // 
            // zdjCiast
            // 
            this.zdjCiast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zdjCiast.Location = new System.Drawing.Point(192, 136);
            this.zdjCiast.Margin = new System.Windows.Forms.Padding(0);
            this.zdjCiast.Name = "zdjCiast";
            this.zdjCiast.Size = new System.Drawing.Size(897, 341);
            this.zdjCiast.TabIndex = 3;
            // 
            // iconSplitButton1
            // 
            this.iconSplitButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconSplitButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconSplitButton1.IconColor = System.Drawing.Color.Black;
            this.iconSplitButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSplitButton1.IconSize = 48;
            this.iconSplitButton1.Name = "iconSplitButton1";
            this.iconSplitButton1.Rotation = 0D;
            this.iconSplitButton1.Size = new System.Drawing.Size(23, 23);
            this.iconSplitButton1.Text = "iconSplitButton1";
            // 
            // WybierzTort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1282, 682);
            this.ControlBox = false;
            this.Controls.Add(this.panelNaszeCiasta);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "WybierzTort";
            this.Load += new System.EventHandler(this.WybierzTort_Load);
            this.panelNaszeCiasta.ResumeLayout(false);
            this.panelNaszeCiasta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelNaszeCiasta;
        private System.Windows.Forms.Label nazwaCiasta;
        private FontAwesome.Sharp.IconButton btnPrawo;
        private FontAwesome.Sharp.IconButton btnLewo;
        private System.Windows.Forms.Panel zdjCiast;
        private System.Windows.Forms.Label infOCiescie;
        private FontAwesome.Sharp.IconSplitButton iconSplitButton1;
        private FontAwesome.Sharp.IconButton btnDalej;
    }
}