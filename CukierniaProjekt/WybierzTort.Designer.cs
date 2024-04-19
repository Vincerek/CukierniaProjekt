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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sliderPanel.SuspendLayout();
            this.panelGrafika.SuspendLayout();
            this.SuspendLayout();
            // 
            // sliderPanel
            // 
            this.sliderPanel.BackColor = System.Drawing.Color.Peru;
            this.sliderPanel.ColumnCount = 4;
            this.sliderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.sliderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.sliderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.sliderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.sliderPanel.Controls.Add(this.richTextBox1, 1, 1);
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
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Peru;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.Location = new System.Drawing.Point(598, 43);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(419, 173);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "Informacje o cieście wypisane";
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
            // WybierzTort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 422);
            this.ControlBox = false;
            this.Controls.Add(this.sliderPanel);
            this.Name = "WybierzTort";
            this.Load += new System.EventHandler(this.WybierzTort_Load);
            this.sliderPanel.ResumeLayout(false);
            this.sliderPanel.PerformLayout();
            this.panelGrafika.ResumeLayout(false);
            this.panelGrafika.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel sliderPanel;
        private System.Windows.Forms.ImageList listaCiast;
        private System.Windows.Forms.Panel panelGrafika;
        private FontAwesome.Sharp.IconButton right;
        private FontAwesome.Sharp.IconButton left;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label nazwaCiasta;
        private System.Windows.Forms.Label label1;
    }
}