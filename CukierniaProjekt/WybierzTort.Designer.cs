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
            this.sliderPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panelGrafika = new System.Windows.Forms.Panel();
            this.right = new FontAwesome.Sharp.IconButton();
            this.left = new FontAwesome.Sharp.IconButton();
            this.listaCiast = new System.Windows.Forms.ImageList(this.components);
            this.nazwaCiasta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UczuleniaPanel = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxUczulenia = new System.Windows.Forms.TextBox();
            this.WyswietlUczulenia = new System.Windows.Forms.TextBox();
            this.btnDodaj = new FontAwesome.Sharp.IconButton();
            this.textboxInformacje = new System.Windows.Forms.TextBox();
            this.sliderPanel.SuspendLayout();
            this.panelGrafika.SuspendLayout();
            this.UczuleniaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sliderPanel
            // 
            this.sliderPanel.BackColor = System.Drawing.Color.Chocolate;
            this.sliderPanel.ColumnCount = 4;
            this.sliderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.sliderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.sliderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.sliderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.sliderPanel.Controls.Add(this.textboxInformacje, 2, 1);
            this.sliderPanel.Controls.Add(this.panelGrafika, 0, 1);
            this.sliderPanel.Controls.Add(this.right, 3, 1);
            this.sliderPanel.Controls.Add(this.left, 0, 1);
            this.sliderPanel.Controls.Add(this.nazwaCiasta, 1, 0);
            this.sliderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.sliderPanel.Location = new System.Drawing.Point(0, 0);
            this.sliderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.sliderPanel.Name = "sliderPanel";
            this.sliderPanel.RowCount = 2;
            this.sliderPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.sliderPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.sliderPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.sliderPanel.Size = new System.Drawing.Size(1198, 216);
            this.sliderPanel.TabIndex = 0;
            // 
            // panelGrafika
            // 
            this.panelGrafika.BackColor = System.Drawing.Color.Peru;
            this.panelGrafika.Controls.Add(this.label1);
            this.panelGrafika.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrafika.Location = new System.Drawing.Point(179, 43);
            this.panelGrafika.Margin = new System.Windows.Forms.Padding(0);
            this.panelGrafika.Name = "panelGrafika";
            this.panelGrafika.Size = new System.Drawing.Size(419, 173);
            this.panelGrafika.TabIndex = 8;
            // 
            // right
            // 
            this.right.BackColor = System.Drawing.Color.Chocolate;
            this.right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.right.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            this.right.IconColor = System.Drawing.Color.SaddleBrown;
            this.right.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.right.IconSize = 100;
            this.right.Location = new System.Drawing.Point(1017, 43);
            this.right.Margin = new System.Windows.Forms.Padding(0);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(181, 173);
            this.right.TabIndex = 7;
            this.right.UseVisualStyleBackColor = false;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // left
            // 
            this.left.BackColor = System.Drawing.Color.Chocolate;
            this.left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.left.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            this.left.IconColor = System.Drawing.Color.SaddleBrown;
            this.left.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.left.IconSize = 100;
            this.left.Location = new System.Drawing.Point(0, 43);
            this.left.Margin = new System.Windows.Forms.Padding(0);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(179, 173);
            this.left.TabIndex = 6;
            this.left.UseVisualStyleBackColor = false;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // listaCiast
            // 
            this.listaCiast.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.listaCiast.ImageSize = new System.Drawing.Size(16, 16);
            this.listaCiast.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // nazwaCiasta
            // 
            this.nazwaCiasta.AutoSize = true;
            this.nazwaCiasta.BackColor = System.Drawing.Color.Chocolate;
            this.sliderPanel.SetColumnSpan(this.nazwaCiasta, 2);
            this.nazwaCiasta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nazwaCiasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazwaCiasta.Location = new System.Drawing.Point(179, 0);
            this.nazwaCiasta.Margin = new System.Windows.Forms.Padding(0);
            this.nazwaCiasta.Name = "nazwaCiasta";
            this.nazwaCiasta.Size = new System.Drawing.Size(838, 43);
            this.nazwaCiasta.TabIndex = 10;
            this.nazwaCiasta.Text = "Nazwa ciasta";
            this.nazwaCiasta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tu zdj ciasta";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Chocolate;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(0, 216);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1198, 43);
            this.label2.TabIndex = 11;
            this.label2.Text = "Wpisz na co jesteś uczulony";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UczuleniaPanel
            // 
            this.UczuleniaPanel.ColumnCount = 3;
            this.UczuleniaPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.UczuleniaPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.UczuleniaPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.UczuleniaPanel.Controls.Add(this.WyswietlUczulenia, 2, 0);
            this.UczuleniaPanel.Controls.Add(this.textBoxUczulenia, 0, 0);
            this.UczuleniaPanel.Controls.Add(this.btnDodaj, 1, 0);
            this.UczuleniaPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UczuleniaPanel.Location = new System.Drawing.Point(0, 259);
            this.UczuleniaPanel.Name = "UczuleniaPanel";
            this.UczuleniaPanel.RowCount = 1;
            this.UczuleniaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.UczuleniaPanel.Size = new System.Drawing.Size(1198, 56);
            this.UczuleniaPanel.TabIndex = 12;
            // 
            // textBoxUczulenia
            // 
            this.textBoxUczulenia.BackColor = System.Drawing.Color.Peru;
            this.textBoxUczulenia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUczulenia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxUczulenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxUczulenia.ForeColor = System.Drawing.Color.Black;
            this.textBoxUczulenia.Location = new System.Drawing.Point(0, 0);
            this.textBoxUczulenia.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxUczulenia.Multiline = true;
            this.textBoxUczulenia.Name = "textBoxUczulenia";
            this.textBoxUczulenia.Size = new System.Drawing.Size(718, 56);
            this.textBoxUczulenia.TabIndex = 0;
            // 
            // WyswietlUczulenia
            // 
            this.WyswietlUczulenia.BackColor = System.Drawing.Color.Peru;
            this.WyswietlUczulenia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WyswietlUczulenia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WyswietlUczulenia.Enabled = false;
            this.WyswietlUczulenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WyswietlUczulenia.ForeColor = System.Drawing.Color.Black;
            this.WyswietlUczulenia.Location = new System.Drawing.Point(897, 0);
            this.WyswietlUczulenia.Margin = new System.Windows.Forms.Padding(0);
            this.WyswietlUczulenia.Multiline = true;
            this.WyswietlUczulenia.Name = "WyswietlUczulenia";
            this.WyswietlUczulenia.Size = new System.Drawing.Size(301, 56);
            this.WyswietlUczulenia.TabIndex = 1;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.Chocolate;
            this.btnDodaj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnDodaj.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnDodaj.IconColor = System.Drawing.Color.SaddleBrown;
            this.btnDodaj.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDodaj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodaj.Location = new System.Drawing.Point(718, 0);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(0);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(179, 56);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // textboxInformacje
            // 
            this.textboxInformacje.BackColor = System.Drawing.Color.Peru;
            this.textboxInformacje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxInformacje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textboxInformacje.Enabled = false;
            this.textboxInformacje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textboxInformacje.ForeColor = System.Drawing.Color.Black;
            this.textboxInformacje.Location = new System.Drawing.Point(598, 43);
            this.textboxInformacje.Margin = new System.Windows.Forms.Padding(0);
            this.textboxInformacje.Multiline = true;
            this.textboxInformacje.Name = "textboxInformacje";
            this.textboxInformacje.Size = new System.Drawing.Size(419, 173);
            this.textboxInformacje.TabIndex = 2;
            this.textboxInformacje.Text = "Informacje o cieście";
            // 
            // WybierzTort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 422);
            this.ControlBox = false;
            this.Controls.Add(this.UczuleniaPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sliderPanel);
            this.Name = "WybierzTort";
            this.Load += new System.EventHandler(this.WybierzTort_Load);
            this.sliderPanel.ResumeLayout(false);
            this.sliderPanel.PerformLayout();
            this.panelGrafika.ResumeLayout(false);
            this.panelGrafika.PerformLayout();
            this.UczuleniaPanel.ResumeLayout(false);
            this.UczuleniaPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel sliderPanel;
        private System.Windows.Forms.ImageList listaCiast;
        private System.Windows.Forms.Panel panelGrafika;
        private FontAwesome.Sharp.IconButton right;
        private FontAwesome.Sharp.IconButton left;
        private System.Windows.Forms.Label nazwaCiasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel UczuleniaPanel;
        private System.Windows.Forms.TextBox textBoxUczulenia;
        private System.Windows.Forms.TextBox WyswietlUczulenia;
        private FontAwesome.Sharp.IconButton btnDodaj;
        private System.Windows.Forms.TextBox textboxInformacje;
    }
}