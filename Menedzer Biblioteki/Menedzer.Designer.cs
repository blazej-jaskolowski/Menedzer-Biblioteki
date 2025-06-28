namespace Menedzer_Biblioteki
{
    partial class Menedzer
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
            this.grpDodawanie = new System.Windows.Forms.GroupBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtRok = new System.Windows.Forms.TextBox();
            this.lblRok = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtTytul = new System.Windows.Forms.TextBox();
            this.lblTytul = new System.Windows.Forms.Label();
            this.grpLista = new System.Windows.Forms.GroupBox();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.lstKsiazki = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSzukaj = new System.Windows.Forms.Button();
            this.txtSzukaj = new System.Windows.Forms.TextBox();
            this.grpZarzadzanie = new System.Windows.Forms.GroupBox();
            this.btnWczytaj = new System.Windows.Forms.Button();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.grpSortowanie = new System.Windows.Forms.GroupBox();
            this.btnSortuj = new System.Windows.Forms.Button();
            this.cmbSortuj = new System.Windows.Forms.ComboBox();
            this.grpDodawanie.SuspendLayout();
            this.grpLista.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpZarzadzanie.SuspendLayout();
            this.grpSortowanie.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDodawanie
            // 
            this.grpDodawanie.Controls.Add(this.btnDodaj);
            this.grpDodawanie.Controls.Add(this.txtRok);
            this.grpDodawanie.Controls.Add(this.lblRok);
            this.grpDodawanie.Controls.Add(this.txtAutor);
            this.grpDodawanie.Controls.Add(this.lblAutor);
            this.grpDodawanie.Controls.Add(this.txtTytul);
            this.grpDodawanie.Controls.Add(this.lblTytul);
            this.grpDodawanie.Location = new System.Drawing.Point(12, 12);
            this.grpDodawanie.Name = "grpDodawanie";
            this.grpDodawanie.Size = new System.Drawing.Size(159, 182);
            this.grpDodawanie.TabIndex = 0;
            this.grpDodawanie.TabStop = false;
            this.grpDodawanie.Text = "Dodawanie książki";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(27, 151);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(100, 23);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj książkę";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click_1);
            // 
            // txtRok
            // 
            this.txtRok.Location = new System.Drawing.Point(13, 125);
            this.txtRok.Name = "txtRok";
            this.txtRok.Size = new System.Drawing.Size(140, 20);
            this.txtRok.TabIndex = 5;
            // 
            // lblRok
            // 
            this.lblRok.AutoSize = true;
            this.lblRok.Location = new System.Drawing.Point(10, 108);
            this.lblRok.Name = "lblRok";
            this.lblRok.Size = new System.Drawing.Size(72, 13);
            this.lblRok.TabIndex = 4;
            this.lblRok.Text = "Rok wydania:";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(10, 81);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(143, 20);
            this.txtAutor.TabIndex = 3;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(10, 64);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(35, 13);
            this.lblAutor.TabIndex = 2;
            this.lblAutor.Text = "Autor:";
            // 
            // txtTytul
            // 
            this.txtTytul.Location = new System.Drawing.Point(10, 37);
            this.txtTytul.Name = "txtTytul";
            this.txtTytul.Size = new System.Drawing.Size(143, 20);
            this.txtTytul.TabIndex = 1;
            // 
            // lblTytul
            // 
            this.lblTytul.AutoSize = true;
            this.lblTytul.Location = new System.Drawing.Point(7, 20);
            this.lblTytul.Name = "lblTytul";
            this.lblTytul.Size = new System.Drawing.Size(38, 13);
            this.lblTytul.TabIndex = 0;
            this.lblTytul.Text = "Tytuł: ";
            // 
            // grpLista
            // 
            this.grpLista.Controls.Add(this.btnUsun);
            this.grpLista.Controls.Add(this.btnStatus);
            this.grpLista.Controls.Add(this.lstKsiazki);
            this.grpLista.Location = new System.Drawing.Point(177, 69);
            this.grpLista.Name = "grpLista";
            this.grpLista.Size = new System.Drawing.Size(592, 410);
            this.grpLista.TabIndex = 1;
            this.grpLista.TabStop = false;
            this.grpLista.Text = "Lista książek";
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(152, 373);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(75, 23);
            this.btnUsun.TabIndex = 2;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(7, 373);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(127, 23);
            this.btnStatus.TabIndex = 1;
            this.btnStatus.Text = "Wypożycz/Zwróć";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click_1);
            // 
            // lstKsiazki
            // 
            this.lstKsiazki.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstKsiazki.FormattingEnabled = true;
            this.lstKsiazki.Location = new System.Drawing.Point(7, 16);
            this.lstKsiazki.Name = "lstKsiazki";
            this.lstKsiazki.Size = new System.Drawing.Size(579, 342);
            this.lstKsiazki.TabIndex = 0;
            this.lstKsiazki.Tag = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSzukaj);
            this.groupBox1.Controls.Add(this.txtSzukaj);
            this.groupBox1.Location = new System.Drawing.Point(177, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 51);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Szukanie";
            // 
            // btnSzukaj
            // 
            this.btnSzukaj.Location = new System.Drawing.Point(279, 17);
            this.btnSzukaj.Name = "btnSzukaj";
            this.btnSzukaj.Size = new System.Drawing.Size(75, 23);
            this.btnSzukaj.TabIndex = 1;
            this.btnSzukaj.Text = "Szukaj";
            this.btnSzukaj.UseVisualStyleBackColor = true;
            this.btnSzukaj.Click += new System.EventHandler(this.btnSzukaj_Click);
            // 
            // txtSzukaj
            // 
            this.txtSzukaj.Location = new System.Drawing.Point(7, 19);
            this.txtSzukaj.Name = "txtSzukaj";
            this.txtSzukaj.Size = new System.Drawing.Size(266, 20);
            this.txtSzukaj.TabIndex = 0;
            // 
            // grpZarzadzanie
            // 
            this.grpZarzadzanie.Controls.Add(this.btnWczytaj);
            this.grpZarzadzanie.Controls.Add(this.btnZapisz);
            this.grpZarzadzanie.Location = new System.Drawing.Point(6, 394);
            this.grpZarzadzanie.Name = "grpZarzadzanie";
            this.grpZarzadzanie.Size = new System.Drawing.Size(159, 85);
            this.grpZarzadzanie.TabIndex = 3;
            this.grpZarzadzanie.TabStop = false;
            this.grpZarzadzanie.Text = "Zarządzanie";
            // 
            // btnWczytaj
            // 
            this.btnWczytaj.Location = new System.Drawing.Point(27, 48);
            this.btnWczytaj.Name = "btnWczytaj";
            this.btnWczytaj.Size = new System.Drawing.Size(100, 23);
            this.btnWczytaj.TabIndex = 1;
            this.btnWczytaj.Text = "Wczytaj listę...";
            this.btnWczytaj.UseVisualStyleBackColor = true;
            this.btnWczytaj.Click += new System.EventHandler(this.btnWczytaj_Click);
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(27, 19);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(100, 23);
            this.btnZapisz.TabIndex = 0;
            this.btnZapisz.Text = "Zapisz listę...";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // grpSortowanie
            // 
            this.grpSortowanie.Controls.Add(this.btnSortuj);
            this.grpSortowanie.Controls.Add(this.cmbSortuj);
            this.grpSortowanie.Location = new System.Drawing.Point(549, 12);
            this.grpSortowanie.Name = "grpSortowanie";
            this.grpSortowanie.Size = new System.Drawing.Size(220, 51);
            this.grpSortowanie.TabIndex = 4;
            this.grpSortowanie.TabStop = false;
            this.grpSortowanie.Text = "Sortowanie";
            // 
            // btnSortuj
            // 
            this.btnSortuj.Location = new System.Drawing.Point(134, 19);
            this.btnSortuj.Name = "btnSortuj";
            this.btnSortuj.Size = new System.Drawing.Size(75, 23);
            this.btnSortuj.TabIndex = 1;
            this.btnSortuj.Text = "Sortuj";
            this.btnSortuj.UseVisualStyleBackColor = true;
            this.btnSortuj.Click += new System.EventHandler(this.btnSortuj_Click);
            // 
            // cmbSortuj
            // 
            this.cmbSortuj.FormattingEnabled = true;
            this.cmbSortuj.Items.AddRange(new object[] {
            "tytul-ros",
            "tytul-mal",
            "autor-ros",
            "autor-mal",
            "rok-ros",
            "rok-mal"});
            this.cmbSortuj.Location = new System.Drawing.Point(7, 19);
            this.cmbSortuj.Name = "cmbSortuj";
            this.cmbSortuj.Size = new System.Drawing.Size(121, 21);
            this.cmbSortuj.TabIndex = 0;
            this.cmbSortuj.Text = "Sortuj weług...";
            // 
            // Menedzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 491);
            this.Controls.Add(this.grpSortowanie);
            this.Controls.Add(this.grpZarzadzanie);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpLista);
            this.Controls.Add(this.grpDodawanie);
            this.Name = "Menedzer";
            this.Text = "Menedżer Biblioteki";
            this.grpDodawanie.ResumeLayout(false);
            this.grpDodawanie.PerformLayout();
            this.grpLista.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpZarzadzanie.ResumeLayout(false);
            this.grpSortowanie.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDodawanie;
        private System.Windows.Forms.Label lblTytul;
        private System.Windows.Forms.TextBox txtTytul;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblRok;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtRok;
        private System.Windows.Forms.GroupBox grpLista;
        private System.Windows.Forms.ListBox lstKsiazki;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSzukaj;
        private System.Windows.Forms.TextBox txtSzukaj;
        private System.Windows.Forms.GroupBox grpZarzadzanie;
        private System.Windows.Forms.Button btnWczytaj;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.GroupBox grpSortowanie;
        private System.Windows.Forms.Button btnSortuj;
        private System.Windows.Forms.ComboBox cmbSortuj;
    }
}

