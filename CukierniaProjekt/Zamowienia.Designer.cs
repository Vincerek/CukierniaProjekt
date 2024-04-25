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
            this.btnZamow = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textImie, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textNazwisko, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textMail, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textTel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnZamow, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1282, 699);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textImie
            // 
            this.textImie.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textImie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.textImie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textImie.ForeColor = System.Drawing.Color.DarkGray;
            this.textImie.Location = new System.Drawing.Point(0, 37);
            this.textImie.Margin = new System.Windows.Forms.Padding(0);
            this.textImie.Name = "textImie";
            this.textImie.Size = new System.Drawing.Size(254, 30);
            this.textImie.TabIndex = 0;
            this.textImie.Text = "Podaj imię";
            this.textImie.TextChanged += new System.EventHandler(this.textImie_TextChanged);
            this.textImie.Enter += new System.EventHandler(this.textImie_Enter);
            this.textImie.Leave += new System.EventHandler(this.textImie_Leave);
            // 
            // textNazwisko
            // 
            this.textNazwisko.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textNazwisko.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.textNazwisko.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textNazwisko.ForeColor = System.Drawing.Color.DarkGray;
            this.textNazwisko.Location = new System.Drawing.Point(0, 141);
            this.textNazwisko.Margin = new System.Windows.Forms.Padding(0);
            this.textNazwisko.Name = "textNazwisko";
            this.textNazwisko.Size = new System.Drawing.Size(254, 30);
            this.textNazwisko.TabIndex = 1;
            this.textNazwisko.Text = "Podaj nazwisko";
            this.textNazwisko.Enter += new System.EventHandler(this.textNazwisko_Enter);
            this.textNazwisko.Leave += new System.EventHandler(this.textNazwisko_Leave);
            // 
            // textMail
            // 
            this.textMail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.textMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textMail.ForeColor = System.Drawing.Color.DarkGray;
            this.textMail.Location = new System.Drawing.Point(0, 245);
            this.textMail.Margin = new System.Windows.Forms.Padding(0);
            this.textMail.Name = "textMail";
            this.textMail.Size = new System.Drawing.Size(254, 30);
            this.textMail.TabIndex = 2;
            this.textMail.Text = "Podaj e-mail";
            this.textMail.Enter += new System.EventHandler(this.textMail_Enter);
            this.textMail.Leave += new System.EventHandler(this.textMail_Leave);
            // 
            // textTel
            // 
            this.textTel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.textTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textTel.ForeColor = System.Drawing.Color.DarkGray;
            this.textTel.Location = new System.Drawing.Point(0, 349);
            this.textTel.Margin = new System.Windows.Forms.Padding(0);
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(254, 30);
            this.textTel.TabIndex = 3;
            this.textTel.Text = "Podaj numer telefonu";
            this.textTel.Enter += new System.EventHandler(this.textTel_Enter);
            this.textTel.Leave += new System.EventHandler(this.textTel_Leave);
            // 
            // btnZamow
            // 
            this.btnZamow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnZamow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.btnZamow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZamow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(28)))), ((int)(((byte)(117)))));
            this.btnZamow.IconChar = FontAwesome.Sharp.IconChar.TruckFast;
            this.btnZamow.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(28)))), ((int)(((byte)(117)))));
            this.btnZamow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnZamow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZamow.Location = new System.Drawing.Point(869, 514);
            this.btnZamow.Name = "btnZamow";
            this.btnZamow.Size = new System.Drawing.Size(184, 86);
            this.btnZamow.TabIndex = 4;
            this.btnZamow.Text = "Zamów";
            this.btnZamow.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(641, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(641, 104);
            this.label1.TabIndex = 5;
            this.label1.Text = "Zamówienie";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Zamowienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 699);
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
        private FontAwesome.Sharp.IconButton btnZamow;
        private System.Windows.Forms.Label label1;
    }
}