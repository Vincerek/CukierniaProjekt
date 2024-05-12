namespace CukierniaProjekt
{
    partial class okienkoKoszyk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(okienkoKoszyk));
            this.okienko = new System.Windows.Forms.TableLayoutPanel();
            this.btnWroc = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKoszyk = new FontAwesome.Sharp.IconButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.okienko.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // okienko
            // 
            this.okienko.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            this.okienko.ColumnCount = 2;
            this.okienko.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.okienko.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.okienko.Controls.Add(this.logo, 0, 0);
            this.okienko.Controls.Add(this.btnKoszyk, 1, 1);
            this.okienko.Controls.Add(this.btnWroc, 0, 1);
            this.okienko.Controls.Add(this.panel1, 1, 0);
            this.okienko.Dock = System.Windows.Forms.DockStyle.Fill;
            this.okienko.Location = new System.Drawing.Point(0, 0);
            this.okienko.Margin = new System.Windows.Forms.Padding(0);
            this.okienko.Name = "okienko";
            this.okienko.RowCount = 2;
            this.okienko.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.okienko.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.okienko.Size = new System.Drawing.Size(464, 186);
            this.okienko.TabIndex = 0;
            // 
            // btnWroc
            // 
            this.btnWroc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(152)))));
            this.btnWroc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnWroc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWroc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWroc.ForeColor = System.Drawing.Color.White;
            this.btnWroc.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnWroc.IconColor = System.Drawing.Color.White;
            this.btnWroc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWroc.IconSize = 40;
            this.btnWroc.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWroc.Location = new System.Drawing.Point(25, 80);
            this.btnWroc.Margin = new System.Windows.Forms.Padding(25);
            this.btnWroc.Name = "btnWroc";
            this.btnWroc.Size = new System.Drawing.Size(182, 81);
            this.btnWroc.TabIndex = 1;
            this.btnWroc.Text = "Wróć do zakupów";
            this.btnWroc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnWroc.UseVisualStyleBackColor = false;
            this.btnWroc.Click += new System.EventHandler(this.btnWroc_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(232, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 55);
            this.panel1.TabIndex = 2;
            // 
            // btnKoszyk
            // 
            this.btnKoszyk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(152)))));
            this.btnKoszyk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKoszyk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKoszyk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKoszyk.ForeColor = System.Drawing.Color.White;
            this.btnKoszyk.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnKoszyk.IconColor = System.Drawing.Color.White;
            this.btnKoszyk.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKoszyk.IconSize = 40;
            this.btnKoszyk.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKoszyk.Location = new System.Drawing.Point(257, 80);
            this.btnKoszyk.Margin = new System.Windows.Forms.Padding(25);
            this.btnKoszyk.Name = "btnKoszyk";
            this.btnKoszyk.Size = new System.Drawing.Size(182, 81);
            this.btnKoszyk.TabIndex = 3;
            this.btnKoszyk.Text = "Przejdź do koszyka";
            this.btnKoszyk.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKoszyk.UseVisualStyleBackColor = false;
            this.btnKoszyk.Click += new System.EventHandler(this.btnKoszyk_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Margin = new System.Windows.Forms.Padding(0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(232, 55);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 11;
            this.logo.TabStop = false;
            // 
            // okienkoKoszyk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 186);
            this.ControlBox = false;
            this.Controls.Add(this.okienko);
            this.Name = "okienkoKoszyk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.okienko.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel okienko;
        private FontAwesome.Sharp.IconButton btnWroc;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnKoszyk;
        private System.Windows.Forms.PictureBox logo;
    }
}