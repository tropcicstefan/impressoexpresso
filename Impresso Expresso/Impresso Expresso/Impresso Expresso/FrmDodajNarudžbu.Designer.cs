namespace Impresso_Expresso
{
    partial class FrmDodajNarudžbu
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
            this.gbArtikli = new System.Windows.Forms.GroupBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblNazivArtikla = new System.Windows.Forms.Label();
            this.lblKolicinaArtikla = new System.Windows.Forms.Label();
            this.cbNazivArtikla = new System.Windows.Forms.ComboBox();
            this.pbDodaj = new System.Windows.Forms.PictureBox();
            this.pbOduzmi = new System.Windows.Forms.PictureBox();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.gbArtikli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDodaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOduzmi)).BeginInit();
            this.SuspendLayout();
            // 
            // gbArtikli
            // 
            this.gbArtikli.Controls.Add(this.btnPotvrdi);
            this.gbArtikli.Controls.Add(this.pbOduzmi);
            this.gbArtikli.Controls.Add(this.pbDodaj);
            this.gbArtikli.Controls.Add(this.cbNazivArtikla);
            this.gbArtikli.Controls.Add(this.lblKolicinaArtikla);
            this.gbArtikli.Controls.Add(this.lblNazivArtikla);
            this.gbArtikli.Location = new System.Drawing.Point(183, 172);
            this.gbArtikli.Name = "gbArtikli";
            this.gbArtikli.Size = new System.Drawing.Size(429, 312);
            this.gbArtikli.TabIndex = 0;
            this.gbArtikli.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::Impresso_Expresso.Properties.Resources.logo_banner;
            this.pbLogo.Location = new System.Drawing.Point(155, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(480, 100);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // lblNazivArtikla
            // 
            this.lblNazivArtikla.AutoSize = true;
            this.lblNazivArtikla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivArtikla.Location = new System.Drawing.Point(16, 38);
            this.lblNazivArtikla.Name = "lblNazivArtikla";
            this.lblNazivArtikla.Size = new System.Drawing.Size(47, 20);
            this.lblNazivArtikla.TabIndex = 0;
            this.lblNazivArtikla.Text = "Naziv";
            // 
            // lblKolicinaArtikla
            // 
            this.lblKolicinaArtikla.AutoSize = true;
            this.lblKolicinaArtikla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKolicinaArtikla.Location = new System.Drawing.Point(240, 38);
            this.lblKolicinaArtikla.Name = "lblKolicinaArtikla";
            this.lblKolicinaArtikla.Size = new System.Drawing.Size(63, 20);
            this.lblKolicinaArtikla.TabIndex = 0;
            this.lblKolicinaArtikla.Text = "Kolicina";
            // 
            // cbNazivArtikla
            // 
            this.cbNazivArtikla.FormattingEnabled = true;
            this.cbNazivArtikla.Location = new System.Drawing.Point(69, 40);
            this.cbNazivArtikla.Name = "cbNazivArtikla";
            this.cbNazivArtikla.Size = new System.Drawing.Size(121, 21);
            this.cbNazivArtikla.TabIndex = 1;
            // 
            // pbDodaj
            // 
            this.pbDodaj.Location = new System.Drawing.Point(309, 38);
            this.pbDodaj.Name = "pbDodaj";
            this.pbDodaj.Size = new System.Drawing.Size(94, 66);
            this.pbDodaj.TabIndex = 2;
            this.pbDodaj.TabStop = false;
            // 
            // pbOduzmi
            // 
            this.pbOduzmi.Location = new System.Drawing.Point(309, 133);
            this.pbOduzmi.Name = "pbOduzmi";
            this.pbOduzmi.Size = new System.Drawing.Size(94, 66);
            this.pbOduzmi.TabIndex = 2;
            this.pbOduzmi.TabStop = false;
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(309, 258);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(94, 36);
            this.btnPotvrdi.TabIndex = 3;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            // 
            // FrmDodajNarudžbu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(34)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.gbArtikli);
            this.Name = "FrmDodajNarudžbu";
            this.Text = "FrmDodajNarudžbu";
            this.gbArtikli.ResumeLayout(false);
            this.gbArtikli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDodaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOduzmi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbArtikli;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.PictureBox pbOduzmi;
        private System.Windows.Forms.PictureBox pbDodaj;
        private System.Windows.Forms.ComboBox cbNazivArtikla;
        private System.Windows.Forms.Label lblKolicinaArtikla;
        private System.Windows.Forms.Label lblNazivArtikla;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}