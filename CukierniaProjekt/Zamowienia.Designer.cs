namespace CukierniaProjekt
{
    partial class Zamowienia
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textImie = new System.Windows.Forms.TextBox();
            this.textNazwisko = new System.Windows.Forms.TextBox();
            this.textMail = new System.Windows.Forms.TextBox();
            this.textTel = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textImie, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textNazwisko, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textMail, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textTel, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1282, 653);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textImie
            // 
            this.textImie.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textImie.ForeColor = System.Drawing.Color.DarkGray;
            this.textImie.Location = new System.Drawing.Point(0, 37);
            this.textImie.Margin = new System.Windows.Forms.Padding(0);
            this.textImie.Name = "textImie";
            this.textImie.Size = new System.Drawing.Size(100, 22);
            this.textImie.TabIndex = 0;
            this.textImie.Text = "Podaj Imię";
            this.textImie.TextChanged += new System.EventHandler(this.textImie_TextChanged);
            this.textImie.Enter += new System.EventHandler(this.textImie_Enter);
            this.textImie.Leave += new System.EventHandler(this.textImie_Leave);
            // 
            // textNazwisko
            // 
            this.textNazwisko.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textNazwisko.Location = new System.Drawing.Point(0, 134);
            this.textNazwisko.Margin = new System.Windows.Forms.Padding(0);
            this.textNazwisko.Name = "textNazwisko";
            this.textNazwisko.Size = new System.Drawing.Size(100, 22);
            this.textNazwisko.TabIndex = 1;
            this.textNazwisko.Enter += new System.EventHandler(this.textNazwisko_Enter);
            this.textNazwisko.Leave += new System.EventHandler(this.textNazwisko_Leave);
            // 
            // textMail
            // 
            this.textMail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textMail.Location = new System.Drawing.Point(0, 231);
            this.textMail.Margin = new System.Windows.Forms.Padding(0);
            this.textMail.Name = "textMail";
            this.textMail.Size = new System.Drawing.Size(100, 22);
            this.textMail.TabIndex = 2;
            // 
            // textTel
            // 
            this.textTel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textTel.Location = new System.Drawing.Point(0, 328);
            this.textTel.Margin = new System.Windows.Forms.Padding(0);
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(175, 22);
            this.textTel.TabIndex = 3;
            // 
            // Zamowienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Zamowienia";
            this.Text = "Zamowienia";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textImie;
        private System.Windows.Forms.TextBox textNazwisko;
        private System.Windows.Forms.TextBox textMail;
        private System.Windows.Forms.TextBox textTel;
    }
}