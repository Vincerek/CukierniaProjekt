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
            this.left = new FontAwesome.Sharp.IconButton();
            this.right = new FontAwesome.Sharp.IconButton();
            this.panelGrafika = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.listaCiast = new System.Windows.Forms.ImageList(this.components);
            this.sliderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sliderPanel
            // 
            this.sliderPanel.ColumnCount = 4;
            this.sliderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.sliderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.sliderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.sliderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.sliderPanel.Controls.Add(this.right, 3, 0);
            this.sliderPanel.Controls.Add(this.panelGrafika, 1, 0);
            this.sliderPanel.Controls.Add(this.left, 0, 0);
            this.sliderPanel.Controls.Add(this.richTextBox1, 2, 0);
            this.sliderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.sliderPanel.Location = new System.Drawing.Point(0, 0);
            this.sliderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.sliderPanel.Name = "sliderPanel";
            this.sliderPanel.RowCount = 1;
            this.sliderPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sliderPanel.Size = new System.Drawing.Size(1198, 216);
            this.sliderPanel.TabIndex = 0;
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
            this.left.Location = new System.Drawing.Point(0, 0);
            this.left.Margin = new System.Windows.Forms.Padding(0);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(179, 216);
            this.left.TabIndex = 0;
            this.left.UseVisualStyleBackColor = false;
            this.left.Click += new System.EventHandler(this.left_Click);
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
            this.right.Location = new System.Drawing.Point(1017, 0);
            this.right.Margin = new System.Windows.Forms.Padding(0);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(181, 216);
            this.right.TabIndex = 4;
            this.right.UseVisualStyleBackColor = false;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // panelGrafika
            // 
            this.panelGrafika.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrafika.Location = new System.Drawing.Point(179, 0);
            this.panelGrafika.Margin = new System.Windows.Forms.Padding(0);
            this.panelGrafika.Name = "panelGrafika";
            this.panelGrafika.Size = new System.Drawing.Size(419, 216);
            this.panelGrafika.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Peru;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.Location = new System.Drawing.Point(598, 0);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(419, 216);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "Informacje o cieście wypisane";
            // 
            // listaCiast
            // 
            this.listaCiast.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.listaCiast.ImageSize = new System.Drawing.Size(16, 16);
            this.listaCiast.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // WybierzTort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 422);
            this.ControlBox = false;
            this.Controls.Add(this.sliderPanel);
            this.Name = "WybierzTort";
            this.sliderPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel sliderPanel;
        private FontAwesome.Sharp.IconButton left;
        private FontAwesome.Sharp.IconButton right;
        private System.Windows.Forms.Panel panelGrafika;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ImageList listaCiast;
    }
}