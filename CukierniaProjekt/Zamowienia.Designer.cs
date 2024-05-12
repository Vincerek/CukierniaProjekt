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
            this.panelZamow = new System.Windows.Forms.TableLayoutPanel();
            this.textImie = new System.Windows.Forms.TextBox();
            this.textNazwisko = new System.Windows.Forms.TextBox();
            this.textMail = new System.Windows.Forms.TextBox();
            this.textTel = new System.Windows.Forms.TextBox();
            this.szczeg = new System.Windows.Forms.Label();
            this.dataOdbioru = new System.Windows.Forms.DateTimePicker();
            this.lokalOdbioru = new System.Windows.Forms.ComboBox();
            this.szczegZamow = new System.Windows.Forms.Panel();
            this.btnWroc = new FontAwesome.Sharp.IconButton();
            this.btnZamow = new FontAwesome.Sharp.IconButton();
            this.panelZamow.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelZamow
            // 
            this.panelZamow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            this.panelZamow.ColumnCount = 4;
            this.panelZamow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelZamow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelZamow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelZamow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelZamow.Controls.Add(this.btnWroc, 2, 5);
            this.panelZamow.Controls.Add(this.textImie, 0, 0);
            this.panelZamow.Controls.Add(this.textNazwisko, 0, 1);
            this.panelZamow.Controls.Add(this.textMail, 0, 2);
            this.panelZamow.Controls.Add(this.textTel, 0, 3);
            this.panelZamow.Controls.Add(this.szczeg, 1, 0);
            this.panelZamow.Controls.Add(this.dataOdbioru, 0, 4);
            this.panelZamow.Controls.Add(this.btnZamow, 1, 5);
            this.panelZamow.Controls.Add(this.lokalOdbioru, 0, 5);
            this.panelZamow.Controls.Add(this.szczegZamow, 1, 1);
            this.panelZamow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelZamow.Location = new System.Drawing.Point(0, 0);
            this.panelZamow.Margin = new System.Windows.Forms.Padding(0);
            this.panelZamow.Name = "panelZamow";
            this.panelZamow.RowCount = 6;
            this.panelZamow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.panelZamow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.panelZamow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.panelZamow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.panelZamow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelZamow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelZamow.Size = new System.Drawing.Size(1283, 699);
            this.panelZamow.TabIndex = 0;
            // 
            // textImie
            // 
            this.textImie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.textImie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textImie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textImie.ForeColor = System.Drawing.Color.DarkGray;
            this.textImie.Location = new System.Drawing.Point(29, 30);
            this.textImie.Margin = new System.Windows.Forms.Padding(29, 30, 29, 30);
            this.textImie.Name = "textImie";
            this.textImie.Size = new System.Drawing.Size(262, 36);
            this.textImie.TabIndex = 0;
            this.textImie.Text = "Podaj imię";
            this.textImie.Enter += new System.EventHandler(this.textImie_Enter);
            this.textImie.Leave += new System.EventHandler(this.textImie_Leave);
            // 
            // textNazwisko
            // 
            this.textNazwisko.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.textNazwisko.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNazwisko.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textNazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textNazwisko.ForeColor = System.Drawing.Color.DarkGray;
            this.textNazwisko.Location = new System.Drawing.Point(29, 134);
            this.textNazwisko.Margin = new System.Windows.Forms.Padding(29, 30, 29, 30);
            this.textNazwisko.Name = "textNazwisko";
            this.textNazwisko.Size = new System.Drawing.Size(262, 36);
            this.textNazwisko.TabIndex = 1;
            this.textNazwisko.Text = "Podaj nazwisko";
            this.textNazwisko.Enter += new System.EventHandler(this.textNazwisko_Enter);
            this.textNazwisko.Leave += new System.EventHandler(this.textNazwisko_Leave);
            // 
            // textMail
            // 
            this.textMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.textMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textMail.ForeColor = System.Drawing.Color.DarkGray;
            this.textMail.Location = new System.Drawing.Point(29, 238);
            this.textMail.Margin = new System.Windows.Forms.Padding(29, 30, 29, 30);
            this.textMail.Name = "textMail";
            this.textMail.Size = new System.Drawing.Size(262, 36);
            this.textMail.TabIndex = 2;
            this.textMail.Text = "Podaj e-mail";
            this.textMail.Enter += new System.EventHandler(this.textMail_Enter);
            this.textMail.Leave += new System.EventHandler(this.textMail_Leave);
            // 
            // textTel
            // 
            this.textTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.textTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textTel.ForeColor = System.Drawing.Color.DarkGray;
            this.textTel.Location = new System.Drawing.Point(29, 342);
            this.textTel.Margin = new System.Windows.Forms.Padding(29, 30, 29, 30);
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(262, 36);
            this.textTel.TabIndex = 3;
            this.textTel.Text = "Podaj numer telefonu";
            this.textTel.Enter += new System.EventHandler(this.textTel_Enter);
            this.textTel.Leave += new System.EventHandler(this.textTel_Leave);
            // 
            // szczeg
            // 
            this.szczeg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(152)))));
            this.panelZamow.SetColumnSpan(this.szczeg, 3);
            this.szczeg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.szczeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szczeg.ForeColor = System.Drawing.Color.White;
            this.szczeg.Location = new System.Drawing.Point(320, 0);
            this.szczeg.Margin = new System.Windows.Forms.Padding(0);
            this.szczeg.Name = "szczeg";
            this.szczeg.Size = new System.Drawing.Size(963, 104);
            this.szczeg.TabIndex = 5;
            this.szczeg.Text = "Szczegóły Zamówienia";
            this.szczeg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataOdbioru
            // 
            this.dataOdbioru.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataOdbioru.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(28)))), ((int)(((byte)(117)))));
            this.dataOdbioru.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.dataOdbioru.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.dataOdbioru.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.dataOdbioru.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.dataOdbioru.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataOdbioru.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataOdbioru.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataOdbioru.Location = new System.Drawing.Point(29, 446);
            this.dataOdbioru.Margin = new System.Windows.Forms.Padding(29, 30, 29, 30);
            this.dataOdbioru.Name = "dataOdbioru";
            this.dataOdbioru.Size = new System.Drawing.Size(262, 36);
            this.dataOdbioru.TabIndex = 6;
            // 
            // lokalOdbioru
            // 
            this.lokalOdbioru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.lokalOdbioru.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lokalOdbioru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lokalOdbioru.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lokalOdbioru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(28)))), ((int)(((byte)(117)))));
            this.lokalOdbioru.FormattingEnabled = true;
            this.lokalOdbioru.Items.AddRange(new object[] {
            "ul. Maurycego Beniowskiego 20/22, 81-226 Gdynia",
            "al. Jana Pawła II 3, 81-345 Gdynia",
            "ul. Morska 81/87, 81-225 Gdynia"});
            this.lokalOdbioru.Location = new System.Drawing.Point(20, 585);
            this.lokalOdbioru.Margin = new System.Windows.Forms.Padding(20, 30, 20, 30);
            this.lokalOdbioru.Name = "lokalOdbioru";
            this.lokalOdbioru.Size = new System.Drawing.Size(280, 37);
            this.lokalOdbioru.TabIndex = 8;
            this.lokalOdbioru.Text = "Lokalizacja odbioru";
            // 
            // szczegZamow
            // 
            this.panelZamow.SetColumnSpan(this.szczegZamow, 3);
            this.szczegZamow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.szczegZamow.Location = new System.Drawing.Point(320, 104);
            this.szczegZamow.Margin = new System.Windows.Forms.Padding(0);
            this.szczegZamow.Name = "szczegZamow";
            this.panelZamow.SetRowSpan(this.szczegZamow, 4);
            this.szczegZamow.Size = new System.Drawing.Size(963, 451);
            this.szczegZamow.TabIndex = 9;
            // 
            // btnWroc
            // 
            this.btnWroc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.btnWroc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnWroc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWroc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWroc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(28)))), ((int)(((byte)(117)))));
            this.btnWroc.IconChar = FontAwesome.Sharp.IconChar.TruckFast;
            this.btnWroc.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(28)))), ((int)(((byte)(117)))));
            this.btnWroc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWroc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWroc.Location = new System.Drawing.Point(669, 585);
            this.btnWroc.Margin = new System.Windows.Forms.Padding(29, 30, 29, 30);
            this.btnWroc.Name = "btnWroc";
            this.btnWroc.Size = new System.Drawing.Size(262, 84);
            this.btnWroc.TabIndex = 7;
            this.btnWroc.Text = "Wróć do zakupów";
            this.btnWroc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWroc.UseVisualStyleBackColor = false;
            this.btnWroc.Click += new System.EventHandler(this.btnWroc_Click);
            // 
            // btnZamow
            // 
            this.btnZamow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.btnZamow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnZamow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZamow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZamow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(28)))), ((int)(((byte)(117)))));
            this.btnZamow.IconChar = FontAwesome.Sharp.IconChar.TruckFast;
            this.btnZamow.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(28)))), ((int)(((byte)(117)))));
            this.btnZamow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnZamow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZamow.Location = new System.Drawing.Point(349, 585);
            this.btnZamow.Margin = new System.Windows.Forms.Padding(29, 30, 29, 30);
            this.btnZamow.Name = "btnZamow";
            this.btnZamow.Size = new System.Drawing.Size(262, 84);
            this.btnZamow.TabIndex = 4;
            this.btnZamow.Text = "Zamów";
            this.btnZamow.UseVisualStyleBackColor = false;
            // 
            // Zamowienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 699);
            this.Controls.Add(this.panelZamow);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Zamowienia";
            this.Text = "Zamowienia";
            this.Load += new System.EventHandler(this.Zamowienia_Load);
            this.panelZamow.ResumeLayout(false);
            this.panelZamow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelZamow;
        private System.Windows.Forms.TextBox textImie;
        private System.Windows.Forms.TextBox textNazwisko;
        private System.Windows.Forms.TextBox textMail;
        private System.Windows.Forms.TextBox textTel;
        private FontAwesome.Sharp.IconButton btnZamow;
        private System.Windows.Forms.Label szczeg;
        private System.Windows.Forms.DateTimePicker dataOdbioru;
        private FontAwesome.Sharp.IconButton btnWroc;
        private System.Windows.Forms.ComboBox lokalOdbioru;
        private System.Windows.Forms.Panel szczegZamow;
    }
}