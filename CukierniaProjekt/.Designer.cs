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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WybierzTort));
            this.panelNaszeCiasta = new System.Windows.Forms.TableLayoutPanel();
            this.infOCiescie = new System.Windows.Forms.Label();
            this.nazwaCiasta = new System.Windows.Forms.Label();
            this.zdjCiast = new System.Windows.Forms.Panel();
            this.listaCiast = new System.Windows.Forms.ImageList(this.components);
            this.btnDalej = new FontAwesome.Sharp.IconButton();
            this.btnPrawo = new FontAwesome.Sharp.IconButton();
            this.btnLewo = new FontAwesome.Sharp.IconButton();
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
            this.panelNaszeCiasta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelNaszeCiasta.Size = new System.Drawing.Size(896, 341);
            this.panelNaszeCiasta.TabIndex = 0;
            // 
            // infOCiescie
            // 
            this.infOCiescie.AutoSize = true;
            this.infOCiescie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.panelNaszeCiasta.SetColumnSpan(this.infOCiescie, 2);
            this.infOCiescie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infOCiescie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infOCiescie.ForeColor = System.Drawing.Color.White;
            this.infOCiescie.Location = new System.Drawing.Point(0, 238);
            this.infOCiescie.Margin = new System.Windows.Forms.Padding(0);
            this.infOCiescie.Name = "infOCiescie";
            this.infOCiescie.Size = new System.Drawing.Size(761, 103);
            this.infOCiescie.TabIndex = 4;
            this.infOCiescie.Text = "Informacje o cieście";
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
            this.nazwaCiasta.Size = new System.Drawing.Size(896, 68);
            this.nazwaCiasta.TabIndex = 0;
            this.nazwaCiasta.Text = "Nazwa Ciasta";
            this.nazwaCiasta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zdjCiast
            // 
            this.zdjCiast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zdjCiast.Location = new System.Drawing.Point(134, 68);
            this.zdjCiast.Margin = new System.Windows.Forms.Padding(0);
            this.zdjCiast.Name = "zdjCiast";
            this.zdjCiast.Size = new System.Drawing.Size(627, 170);
            this.zdjCiast.TabIndex = 3;
            // 
            // listaCiast
            // 
            this.listaCiast.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listaCiast.ImageStream")));
            this.listaCiast.TransparentColor = System.Drawing.Color.Transparent;
            this.listaCiast.Images.SetKeyName(0, "ciasto3.png");
            this.listaCiast.Images.SetKeyName(1, "ciasto2.png");
            this.listaCiast.Images.SetKeyName(2, "ciasto1.jpg");
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
            this.btnDalej.Location = new System.Drawing.Point(761, 238);
            this.btnDalej.Margin = new System.Windows.Forms.Padding(0);
            this.btnDalej.Name = "btnDalej";
            this.btnDalej.Size = new System.Drawing.Size(135, 103);
            this.btnDalej.TabIndex = 6;
            this.btnDalej.Text = "Dalej";
            this.btnDalej.UseVisualStyleBackColor = false;
            this.btnDalej.Click += new System.EventHandler(this.btnDalej_Click_1);
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
            this.btnPrawo.Location = new System.Drawing.Point(761, 68);
            this.btnPrawo.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrawo.Name = "btnPrawo";
            this.btnPrawo.Size = new System.Drawing.Size(135, 170);
            this.btnPrawo.TabIndex = 2;
            this.btnPrawo.UseVisualStyleBackColor = false;
            this.btnPrawo.Click += new System.EventHandler(this.btnPrawo_Click);
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
            this.btnLewo.Location = new System.Drawing.Point(0, 68);
            this.btnLewo.Margin = new System.Windows.Forms.Padding(0);
            this.btnLewo.Name = "btnLewo";
            this.btnLewo.Size = new System.Drawing.Size(134, 170);
            this.btnLewo.TabIndex = 1;
            this.btnLewo.UseVisualStyleBackColor = false;
            this.btnLewo.Click += new System.EventHandler(this.btnLewo_Click);
            // 
            // WybierzTort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(896, 341);
            this.ControlBox = false;
            this.Controls.Add(this.panelNaszeCiasta);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private FontAwesome.Sharp.IconButton btnDalej;
        private System.Windows.Forms.ImageList listaCiast;
    }
}