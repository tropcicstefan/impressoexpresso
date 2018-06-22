﻿namespace Impresso_Expresso
{
    partial class FrmRegistracija
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
            this.pbBaner = new System.Windows.Forms.PictureBox();
            this.gbRegistracija = new System.Windows.Forms.GroupBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.cbUloga = new System.Windows.Forms.ComboBox();
            this.ulogeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtPosta = new System.Windows.Forms.TextBox();
            this.txtKorime = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.lblUloga = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblPosta = new System.Windows.Forms.Label();
            this.lblKorime = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lbIme = new System.Windows.Forms.Label();
            this.korisniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbBaner)).BeginInit();
            this.gbRegistracija.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ulogeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBaner
            // 
            this.pbBaner.Image = global::Impresso_Expresso.Properties.Resources.logo_banner;
            this.pbBaner.Location = new System.Drawing.Point(124, 1);
            this.pbBaner.Name = "pbBaner";
            this.pbBaner.Size = new System.Drawing.Size(538, 112);
            this.pbBaner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBaner.TabIndex = 0;
            this.pbBaner.TabStop = false;
            // 
            // gbRegistracija
            // 
            this.gbRegistracija.Controls.Add(this.btnSpremi);
            this.gbRegistracija.Controls.Add(this.cbUloga);
            this.gbRegistracija.Controls.Add(this.txtTelefon);
            this.gbRegistracija.Controls.Add(this.txtAdresa);
            this.gbRegistracija.Controls.Add(this.txtPosta);
            this.gbRegistracija.Controls.Add(this.txtKorime);
            this.gbRegistracija.Controls.Add(this.txtLozinka);
            this.gbRegistracija.Controls.Add(this.txtPrezime);
            this.gbRegistracija.Controls.Add(this.lblUloga);
            this.gbRegistracija.Controls.Add(this.lblTelefon);
            this.gbRegistracija.Controls.Add(this.lblAdresa);
            this.gbRegistracija.Controls.Add(this.txtIme);
            this.gbRegistracija.Controls.Add(this.lblPosta);
            this.gbRegistracija.Controls.Add(this.lblKorime);
            this.gbRegistracija.Controls.Add(this.lblLozinka);
            this.gbRegistracija.Controls.Add(this.lblPrezime);
            this.gbRegistracija.Controls.Add(this.lbIme);
            this.gbRegistracija.ForeColor = System.Drawing.Color.White;
            this.gbRegistracija.Location = new System.Drawing.Point(143, 119);
            this.gbRegistracija.Name = "gbRegistracija";
            this.gbRegistracija.Size = new System.Drawing.Size(489, 422);
            this.gbRegistracija.TabIndex = 1;
            this.gbRegistracija.TabStop = false;
            this.gbRegistracija.Text = "Registracija";
            // 
            // btnSpremi
            // 
            this.btnSpremi.ForeColor = System.Drawing.Color.Black;
            this.btnSpremi.Location = new System.Drawing.Point(179, 365);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(191, 31);
            this.btnSpremi.TabIndex = 3;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // cbUloga
            // 
            this.cbUloga.DataSource = this.ulogeBindingSource;
            this.cbUloga.DisplayMember = "Naziv";
            this.cbUloga.FormattingEnabled = true;
            this.cbUloga.Location = new System.Drawing.Point(179, 322);
            this.cbUloga.Name = "cbUloga";
            this.cbUloga.Size = new System.Drawing.Size(191, 24);
            this.cbUloga.TabIndex = 2;
            this.cbUloga.ValueMember = "ID";
            // 
            // ulogeBindingSource
            // 
            this.ulogeBindingSource.DataSource = typeof(Impresso_Expresso.Uloge);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(179, 282);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(191, 22);
            this.txtTelefon.TabIndex = 1;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(179, 194);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(191, 22);
            this.txtAdresa.TabIndex = 1;
            // 
            // txtPosta
            // 
            this.txtPosta.Location = new System.Drawing.Point(179, 240);
            this.txtPosta.Name = "txtPosta";
            this.txtPosta.Size = new System.Drawing.Size(191, 22);
            this.txtPosta.TabIndex = 1;
            // 
            // txtKorime
            // 
            this.txtKorime.Location = new System.Drawing.Point(179, 112);
            this.txtKorime.Name = "txtKorime";
            this.txtKorime.Size = new System.Drawing.Size(191, 22);
            this.txtKorime.TabIndex = 1;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(179, 152);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(191, 22);
            this.txtLozinka.TabIndex = 1;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(179, 70);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(191, 22);
            this.txtPrezime.TabIndex = 1;
            // 
            // lblUloga
            // 
            this.lblUloga.AutoSize = true;
            this.lblUloga.Location = new System.Drawing.Point(100, 322);
            this.lblUloga.Name = "lblUloga";
            this.lblUloga.Size = new System.Drawing.Size(49, 17);
            this.lblUloga.TabIndex = 0;
            this.lblUloga.Text = "Uloga:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(100, 282);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(60, 17);
            this.lblTelefon.TabIndex = 0;
            this.lblTelefon.Text = "Telefon:";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(100, 194);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(57, 17);
            this.lblAdresa.TabIndex = 0;
            this.lblAdresa.Text = "Adresa:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(179, 32);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(191, 22);
            this.txtIme.TabIndex = 1;
            // 
            // lblPosta
            // 
            this.lblPosta.AutoSize = true;
            this.lblPosta.Location = new System.Drawing.Point(100, 240);
            this.lblPosta.Name = "lblPosta";
            this.lblPosta.Size = new System.Drawing.Size(48, 17);
            this.lblPosta.TabIndex = 0;
            this.lblPosta.Text = "Pošta:";
            // 
            // lblKorime
            // 
            this.lblKorime.AutoSize = true;
            this.lblKorime.Location = new System.Drawing.Point(70, 112);
            this.lblKorime.Name = "lblKorime";
            this.lblKorime.Size = new System.Drawing.Size(103, 17);
            this.lblKorime.TabIndex = 0;
            this.lblKorime.Text = "Korisničko ime:";
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Location = new System.Drawing.Point(100, 152);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(61, 17);
            this.lblLozinka.TabIndex = 0;
            this.lblLozinka.Text = "Lozinka:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(100, 70);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(63, 17);
            this.lblPrezime.TabIndex = 0;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lbIme
            // 
            this.lbIme.AutoSize = true;
            this.lbIme.Location = new System.Drawing.Point(100, 32);
            this.lbIme.Name = "lbIme";
            this.lbIme.Size = new System.Drawing.Size(34, 17);
            this.lbIme.TabIndex = 0;
            this.lbIme.Text = "Ime:";
            // 
            // korisniciBindingSource
            // 
            this.korisniciBindingSource.DataSource = typeof(Impresso_Expresso.Korisnici);
            // 
            // FrmRegistracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(34)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.gbRegistracija);
            this.Controls.Add(this.pbBaner);
            this.Name = "FrmRegistracija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegistracija";
            ((System.ComponentModel.ISupportInitialize)(this.pbBaner)).EndInit();
            this.gbRegistracija.ResumeLayout(false);
            this.gbRegistracija.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ulogeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBaner;
        private System.Windows.Forms.GroupBox gbRegistracija;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.ComboBox cbUloga;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtPosta;
        private System.Windows.Forms.TextBox txtKorime;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label lblUloga;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblPosta;
        private System.Windows.Forms.Label lblKorime;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lbIme;
        private System.Windows.Forms.BindingSource ulogeBindingSource;
        private System.Windows.Forms.BindingSource korisniciBindingSource;
    }
}