namespace Impresso_Expresso
{
    partial class FrmNovaPrimka
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
            this.gbNovaPrimka = new System.Windows.Forms.GroupBox();
            this.btnPohrani = new System.Windows.Forms.Button();
            this.dtpPrimke = new System.Windows.Forms.DateTimePicker();
            this.lblKorisnik = new System.Windows.Forms.Label();
            this.lblDobavljač = new System.Windows.Forms.Label();
            this.cbKorisnik = new System.Windows.Forms.ComboBox();
            this.cbDobavljac = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.korisniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dobavljaciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbNovaPrimka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljaciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbNovaPrimka
            // 
            this.gbNovaPrimka.Controls.Add(this.btnPohrani);
            this.gbNovaPrimka.Controls.Add(this.dtpPrimke);
            this.gbNovaPrimka.Controls.Add(this.lblKorisnik);
            this.gbNovaPrimka.Controls.Add(this.lblDobavljač);
            this.gbNovaPrimka.Controls.Add(this.cbKorisnik);
            this.gbNovaPrimka.Controls.Add(this.cbDobavljac);
            this.gbNovaPrimka.ForeColor = System.Drawing.Color.White;
            this.gbNovaPrimka.Location = new System.Drawing.Point(43, 165);
            this.gbNovaPrimka.Name = "gbNovaPrimka";
            this.gbNovaPrimka.Size = new System.Drawing.Size(688, 203);
            this.gbNovaPrimka.TabIndex = 1;
            this.gbNovaPrimka.TabStop = false;
            this.gbNovaPrimka.Text = "Nova primka";
            // 
            // btnPohrani
            // 
            this.btnPohrani.ForeColor = System.Drawing.Color.Black;
            this.btnPohrani.Location = new System.Drawing.Point(589, 129);
            this.btnPohrani.Name = "btnPohrani";
            this.btnPohrani.Size = new System.Drawing.Size(75, 23);
            this.btnPohrani.TabIndex = 5;
            this.btnPohrani.TabStop = false;
            this.btnPohrani.Text = "Pohrani";
            this.btnPohrani.UseVisualStyleBackColor = true;
            this.btnPohrani.Click += new System.EventHandler(this.btnPohrani_Click);
            // 
            // dtpPrimke
            // 
            this.dtpPrimke.Location = new System.Drawing.Point(464, 48);
            this.dtpPrimke.Name = "dtpPrimke";
            this.dtpPrimke.Size = new System.Drawing.Size(200, 20);
            this.dtpPrimke.TabIndex = 4;
            // 
            // lblKorisnik
            // 
            this.lblKorisnik.AutoSize = true;
            this.lblKorisnik.Location = new System.Drawing.Point(280, 24);
            this.lblKorisnik.Name = "lblKorisnik";
            this.lblKorisnik.Size = new System.Drawing.Size(44, 13);
            this.lblKorisnik.TabIndex = 3;
            this.lblKorisnik.Text = "Korisnik";
            // 
            // lblDobavljač
            // 
            this.lblDobavljač.AutoSize = true;
            this.lblDobavljač.Location = new System.Drawing.Point(64, 19);
            this.lblDobavljač.Name = "lblDobavljač";
            this.lblDobavljač.Size = new System.Drawing.Size(55, 13);
            this.lblDobavljač.TabIndex = 2;
            this.lblDobavljač.Text = "Dobavljac";
            // 
            // cbKorisnik
            // 
            this.cbKorisnik.FormattingEnabled = true;
            this.cbKorisnik.Location = new System.Drawing.Point(273, 47);
            this.cbKorisnik.Name = "cbKorisnik";
            this.cbKorisnik.Size = new System.Drawing.Size(121, 21);
            this.cbKorisnik.TabIndex = 1;
            // 
            // cbDobavljac
            // 
            this.cbDobavljac.FormattingEnabled = true;
            this.cbDobavljac.Location = new System.Drawing.Point(57, 47);
            this.cbDobavljac.Name = "cbDobavljac";
            this.cbDobavljac.Size = new System.Drawing.Size(121, 21);
            this.cbDobavljac.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Impresso_Expresso.Properties.Resources.logo_banner;
            this.pictureBox1.Location = new System.Drawing.Point(152, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // korisniciBindingSource
            // 
            this.korisniciBindingSource.DataSource = typeof(Impresso_Expresso.Korisnici);
            // 
            // dobavljaciBindingSource
            // 
            this.dobavljaciBindingSource.DataSource = typeof(Impresso_Expresso.Dobavljaci);
            // 
            // FrmNovaPrimka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(34)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(771, 398);
            this.Controls.Add(this.gbNovaPrimka);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmNovaPrimka";
            this.Text = "FrmDodajPrimku";
            this.Load += new System.EventHandler(this.FrmDodajPrimku_Load);
            this.gbNovaPrimka.ResumeLayout(false);
            this.gbNovaPrimka.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljaciBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbNovaPrimka;
        private System.Windows.Forms.Button btnPohrani;
        private System.Windows.Forms.DateTimePicker dtpPrimke;
        private System.Windows.Forms.Label lblKorisnik;
        private System.Windows.Forms.Label lblDobavljač;
        private System.Windows.Forms.ComboBox cbKorisnik;
        private System.Windows.Forms.BindingSource korisniciBindingSource;
        private System.Windows.Forms.ComboBox cbDobavljac;
        private System.Windows.Forms.BindingSource dobavljaciBindingSource;
    }
}