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
            this.pbCiasto = new System.Windows.Forms.PictureBox();
            this.panelNaszeCiasta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCiasto)).BeginInit();
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
            this.panelNaszeCiasta.Controls.Add(this.pbCiasto, 1, 1);
            this.panelNaszeCiasta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNaszeCiasta.Location = new System.Drawing.Point(0, 0);
            this.panelNaszeCiasta.Margin = new System.Windows.Forms.Padding(0);
            this.panelNaszeCiasta.Name = "panelNaszeCiasta";
            this.panelNaszeCiasta.Padding = new System.Windows.Forms.Padding(100, 20, 100, 20);
            this.panelNaszeCiasta.RowCount = 3;
            this.panelNaszeCiasta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelNaszeCiasta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelNaszeCiasta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.panelNaszeCiasta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.panelNaszeCiasta.Size = new System.Drawing.Size(1195, 454);
            this.panelNaszeCiasta.TabIndex = 0;
            // 
            // btnDalej
            // 
            this.btnDalej.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(152)))));
            this.btnDalej.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDalej.FlatAppearance.BorderSize = 0;
            this.btnDalej.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDalej.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDalej.ForeColor = System.Drawing.Color.White;
            this.btnDalej.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnDalej.IconColor = System.Drawing.Color.White;
            this.btnDalej.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDalej.IconSize = 40;
            this.btnDalej.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDalej.Location = new System.Drawing.Point(945, 329);
            this.btnDalej.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.btnDalej.Name = "btnDalej";
            this.btnDalej.Size = new System.Drawing.Size(150, 105);
            this.btnDalej.TabIndex = 6;
            this.btnDalej.Text = "Dodaj do koszyka";
            this.btnDalej.UseVisualStyleBackColor = false;
            this.btnDalej.Click += new System.EventHandler(this.btnDalej_Click_1);
            // 
            // infOCiescie
            // 
            this.infOCiescie.AutoSize = true;
            this.infOCiescie.BackColor = System.Drawing.Color.White;
            this.panelNaszeCiasta.SetColumnSpan(this.infOCiescie, 2);
            this.infOCiescie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infOCiescie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infOCiescie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(28)))), ((int)(((byte)(117)))));
            this.infOCiescie.Location = new System.Drawing.Point(100, 329);
            this.infOCiescie.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.infOCiescie.Name = "infOCiescie";
            this.infOCiescie.Padding = new System.Windows.Forms.Padding(10);
            this.infOCiescie.Size = new System.Drawing.Size(845, 105);
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
            this.btnPrawo.Location = new System.Drawing.Point(945, 102);
            this.btnPrawo.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrawo.Name = "btnPrawo";
            this.btnPrawo.Size = new System.Drawing.Size(150, 207);
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
            this.nazwaCiasta.Font = new System.Drawing.Font("Inter", 16.2F, System.Drawing.FontStyle.Bold);
            this.nazwaCiasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(28)))), ((int)(((byte)(117)))));
            this.nazwaCiasta.Location = new System.Drawing.Point(100, 20);
            this.nazwaCiasta.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.nazwaCiasta.Name = "nazwaCiasta";
            this.nazwaCiasta.Size = new System.Drawing.Size(995, 62);
            this.nazwaCiasta.TabIndex = 0;
            this.nazwaCiasta.Text = "Nazwa Ciasta\r\nCena: ";
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
            this.btnLewo.Location = new System.Drawing.Point(100, 102);
            this.btnLewo.Margin = new System.Windows.Forms.Padding(0);
            this.btnLewo.Name = "btnLewo";
            this.btnLewo.Size = new System.Drawing.Size(149, 207);
            this.btnLewo.TabIndex = 1;
            this.btnLewo.UseVisualStyleBackColor = false;
            this.btnLewo.Click += new System.EventHandler(this.btnLewo_Click);
            // 
            // pbCiasto
            // 
            this.pbCiasto.BackColor = System.Drawing.Color.White;
            this.pbCiasto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCiasto.Location = new System.Drawing.Point(249, 102);
            this.pbCiasto.Margin = new System.Windows.Forms.Padding(0);
            this.pbCiasto.Name = "pbCiasto";
            this.pbCiasto.Size = new System.Drawing.Size(696, 207);
            this.pbCiasto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCiasto.TabIndex = 7;
            this.pbCiasto.TabStop = false;
            // 
            // WybierzTort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1195, 454);
            this.ControlBox = false;
            this.Controls.Add(this.panelNaszeCiasta);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "WybierzTort";
            this.panelNaszeCiasta.ResumeLayout(false);
            this.panelNaszeCiasta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCiasto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelNaszeCiasta;
        private System.Windows.Forms.Label nazwaCiasta;
        private FontAwesome.Sharp.IconButton btnLewo;
        private System.Windows.Forms.Label infOCiescie;
        private FontAwesome.Sharp.IconButton btnDalej;
        private FontAwesome.Sharp.IconButton btnPrawo;
        private System.Windows.Forms.PictureBox pbCiasto;
    }
}