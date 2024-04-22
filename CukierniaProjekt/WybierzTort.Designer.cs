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
            this.textboxInformacje = new System.Windows.Forms.TextBox();
            this.panelGrafika = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.right = new FontAwesome.Sharp.IconButton();
            this.left = new FontAwesome.Sharp.IconButton();
            this.nazwaCiasta = new System.Windows.Forms.Label();
            this.listaCiast = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.UczuleniaPanel = new System.Windows.Forms.TableLayoutPanel();
            this.WyswietlUczulenia = new System.Windows.Forms.TextBox();
            this.btnDodaj = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPodsumowanie = new System.Windows.Forms.TableLayoutPanel();
            this.btnPodsumowanie = new FontAwesome.Sharp.IconButton();
            this.btnDalej = new FontAwesome.Sharp.IconButton();
            this.podsumowanie = new System.Windows.Forms.Label();
            this.comboBoxUczulenia = new System.Windows.Forms.ComboBox();
            this.sliderPanel.SuspendLayout();
            this.panelGrafika.SuspendLayout();
            this.UczuleniaPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelPodsumowanie.SuspendLayout();
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
            this.sliderPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.sliderPanel.Size = new System.Drawing.Size(896, 176);
            this.sliderPanel.TabIndex = 0;
            // 
            // textboxInformacje
            // 
            this.textboxInformacje.BackColor = System.Drawing.Color.Peru;
            this.textboxInformacje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxInformacje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textboxInformacje.Enabled = false;
            this.textboxInformacje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textboxInformacje.ForeColor = System.Drawing.Color.Black;
            this.textboxInformacje.Location = new System.Drawing.Point(447, 35);
            this.textboxInformacje.Margin = new System.Windows.Forms.Padding(0);
            this.textboxInformacje.Multiline = true;
            this.textboxInformacje.Name = "textboxInformacje";
            this.textboxInformacje.Size = new System.Drawing.Size(313, 141);
            this.textboxInformacje.TabIndex = 2;
            this.textboxInformacje.Text = "Informacje o cieście";
            // 
            // panelGrafika
            // 
            this.panelGrafika.BackColor = System.Drawing.Color.Peru;
            this.panelGrafika.Controls.Add(this.label1);
            this.panelGrafika.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrafika.Location = new System.Drawing.Point(134, 35);
            this.panelGrafika.Margin = new System.Windows.Forms.Padding(0);
            this.panelGrafika.Name = "panelGrafika";
            this.panelGrafika.Size = new System.Drawing.Size(313, 141);
            this.panelGrafika.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tu zdj ciasta";
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
            this.right.Location = new System.Drawing.Point(760, 35);
            this.right.Margin = new System.Windows.Forms.Padding(0);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(136, 141);
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
            this.left.Location = new System.Drawing.Point(0, 35);
            this.left.Margin = new System.Windows.Forms.Padding(0);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(134, 141);
            this.left.TabIndex = 6;
            this.left.UseVisualStyleBackColor = false;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // nazwaCiasta
            // 
            this.nazwaCiasta.AutoSize = true;
            this.nazwaCiasta.BackColor = System.Drawing.Color.Chocolate;
            this.sliderPanel.SetColumnSpan(this.nazwaCiasta, 2);
            this.nazwaCiasta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nazwaCiasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazwaCiasta.Location = new System.Drawing.Point(134, 0);
            this.nazwaCiasta.Margin = new System.Windows.Forms.Padding(0);
            this.nazwaCiasta.Name = "nazwaCiasta";
            this.nazwaCiasta.Size = new System.Drawing.Size(626, 35);
            this.nazwaCiasta.TabIndex = 10;
            this.nazwaCiasta.Text = "Nazwa ciasta";
            this.nazwaCiasta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listaCiast
            // 
            this.listaCiast.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.listaCiast.ImageSize = new System.Drawing.Size(16, 16);
            this.listaCiast.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Chocolate;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(0, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(896, 35);
            this.label2.TabIndex = 11;
            this.label2.Text = "Wpisz na co jesteś uczulony";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UczuleniaPanel
            // 
            this.UczuleniaPanel.BackColor = System.Drawing.Color.Peru;
            this.UczuleniaPanel.ColumnCount = 3;
            this.UczuleniaPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.UczuleniaPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.UczuleniaPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.UczuleniaPanel.Controls.Add(this.WyswietlUczulenia, 2, 0);
            this.UczuleniaPanel.Controls.Add(this.btnDodaj, 1, 0);
            this.UczuleniaPanel.Controls.Add(this.comboBoxUczulenia, 0, 0);
            this.UczuleniaPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UczuleniaPanel.Location = new System.Drawing.Point(0, 211);
            this.UczuleniaPanel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.UczuleniaPanel.Name = "UczuleniaPanel";
            this.UczuleniaPanel.RowCount = 1;
            this.UczuleniaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.UczuleniaPanel.Size = new System.Drawing.Size(896, 62);
            this.UczuleniaPanel.TabIndex = 12;
            // 
            // WyswietlUczulenia
            // 
            this.WyswietlUczulenia.BackColor = System.Drawing.Color.Peru;
            this.WyswietlUczulenia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WyswietlUczulenia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WyswietlUczulenia.Enabled = false;
            this.WyswietlUczulenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WyswietlUczulenia.ForeColor = System.Drawing.Color.Black;
            this.WyswietlUczulenia.Location = new System.Drawing.Point(671, 0);
            this.WyswietlUczulenia.Margin = new System.Windows.Forms.Padding(0);
            this.WyswietlUczulenia.Multiline = true;
            this.WyswietlUczulenia.Name = "WyswietlUczulenia";
            this.WyswietlUczulenia.Size = new System.Drawing.Size(225, 62);
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
            this.btnDodaj.IconSize = 40;
            this.btnDodaj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodaj.Location = new System.Drawing.Point(537, 0);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(0);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(134, 62);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelPodsumowanie);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 255);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 86);
            this.panel1.TabIndex = 13;
            // 
            // panelPodsumowanie
            // 
            this.panelPodsumowanie.BackColor = System.Drawing.Color.Chocolate;
            this.panelPodsumowanie.ColumnCount = 3;
            this.panelPodsumowanie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelPodsumowanie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.panelPodsumowanie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelPodsumowanie.Controls.Add(this.btnDalej, 2, 0);
            this.panelPodsumowanie.Controls.Add(this.btnPodsumowanie, 0, 0);
            this.panelPodsumowanie.Controls.Add(this.podsumowanie, 1, 0);
            this.panelPodsumowanie.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPodsumowanie.Location = new System.Drawing.Point(0, 0);
            this.panelPodsumowanie.Margin = new System.Windows.Forms.Padding(0);
            this.panelPodsumowanie.Name = "panelPodsumowanie";
            this.panelPodsumowanie.RowCount = 1;
            this.panelPodsumowanie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelPodsumowanie.Size = new System.Drawing.Size(896, 93);
            this.panelPodsumowanie.TabIndex = 0;
            // 
            // btnPodsumowanie
            // 
            this.btnPodsumowanie.BackColor = System.Drawing.Color.Chocolate;
            this.btnPodsumowanie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPodsumowanie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPodsumowanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPodsumowanie.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnPodsumowanie.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.btnPodsumowanie.IconColor = System.Drawing.Color.SaddleBrown;
            this.btnPodsumowanie.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnPodsumowanie.IconSize = 45;
            this.btnPodsumowanie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPodsumowanie.Location = new System.Drawing.Point(0, 0);
            this.btnPodsumowanie.Margin = new System.Windows.Forms.Padding(0);
            this.btnPodsumowanie.Name = "btnPodsumowanie";
            this.btnPodsumowanie.Size = new System.Drawing.Size(179, 93);
            this.btnPodsumowanie.TabIndex = 0;
            this.btnPodsumowanie.Text = "Podsumuj";
            this.btnPodsumowanie.UseVisualStyleBackColor = false;
            this.btnPodsumowanie.Click += new System.EventHandler(this.btnPodsumowanie_Click);
            // 
            // btnDalej
            // 
            this.btnDalej.BackColor = System.Drawing.Color.Chocolate;
            this.btnDalej.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDalej.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDalej.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDalej.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnDalej.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btnDalej.IconColor = System.Drawing.Color.SaddleBrown;
            this.btnDalej.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnDalej.IconSize = 45;
            this.btnDalej.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDalej.Location = new System.Drawing.Point(716, 0);
            this.btnDalej.Margin = new System.Windows.Forms.Padding(0);
            this.btnDalej.Name = "btnDalej";
            this.btnDalej.Size = new System.Drawing.Size(180, 93);
            this.btnDalej.TabIndex = 1;
            this.btnDalej.Text = "Dalej";
            this.btnDalej.UseVisualStyleBackColor = false;
            // 
            // podsumowanie
            // 
            this.podsumowanie.AutoSize = true;
            this.podsumowanie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.podsumowanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.podsumowanie.Location = new System.Drawing.Point(179, 0);
            this.podsumowanie.Margin = new System.Windows.Forms.Padding(0);
            this.podsumowanie.Name = "podsumowanie";
            this.podsumowanie.Size = new System.Drawing.Size(537, 93);
            this.podsumowanie.TabIndex = 2;
            // 
            // comboBoxUczulenia
            // 
            this.comboBoxUczulenia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxUczulenia.BackColor = System.Drawing.Color.White;
            this.comboBoxUczulenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxUczulenia.FormattingEnabled = true;
            this.comboBoxUczulenia.Items.AddRange(new object[] {
            "Laktoza",
            "Orzechy",
            "Jajka"});
            this.comboBoxUczulenia.Location = new System.Drawing.Point(188, 8);
            this.comboBoxUczulenia.Margin = new System.Windows.Forms.Padding(0, 0, 0, 18);
            this.comboBoxUczulenia.Name = "comboBoxUczulenia";
            this.comboBoxUczulenia.Size = new System.Drawing.Size(160, 28);
            this.comboBoxUczulenia.TabIndex = 3;
            // 
            // WybierzTort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 341);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UczuleniaPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sliderPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "WybierzTort";
            this.Load += new System.EventHandler(this.WybierzTort_Load);
            this.sliderPanel.ResumeLayout(false);
            this.sliderPanel.PerformLayout();
            this.panelGrafika.ResumeLayout(false);
            this.panelGrafika.PerformLayout();
            this.UczuleniaPanel.ResumeLayout(false);
            this.UczuleniaPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelPodsumowanie.ResumeLayout(false);
            this.panelPodsumowanie.PerformLayout();
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
        private System.Windows.Forms.TextBox WyswietlUczulenia;
        private FontAwesome.Sharp.IconButton btnDodaj;
        private System.Windows.Forms.TextBox textboxInformacje;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel panelPodsumowanie;
        private FontAwesome.Sharp.IconButton btnPodsumowanie;
        private FontAwesome.Sharp.IconButton btnDalej;
        private System.Windows.Forms.Label podsumowanie;
        private System.Windows.Forms.ComboBox comboBoxUczulenia;
    }
}