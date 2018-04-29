namespace Impresso_Expresso
{
    partial class FrmUnosArtikla
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbUnosArtikla = new System.Windows.Forms.GroupBox();
            this.lblNazivArtikla = new System.Windows.Forms.Label();
            this.txtNazivArtikla = new System.Windows.Forms.TextBox();
            this.lblCijenaArtikla = new System.Windows.Forms.Label();
            this.txtCijenaArtikla = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbKategorijaArtikla = new System.Windows.Forms.ComboBox();
            this.btnSpremiArtikl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbUnosArtikla.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Impresso_Expresso.Properties.Resources.logo_banner;
            this.pictureBox1.Location = new System.Drawing.Point(155, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gbUnosArtikla
            // 
            this.gbUnosArtikla.Controls.Add(this.btnSpremiArtikl);
            this.gbUnosArtikla.Controls.Add(this.cbKategorijaArtikla);
            this.gbUnosArtikla.Controls.Add(this.label3);
            this.gbUnosArtikla.Controls.Add(this.txtCijenaArtikla);
            this.gbUnosArtikla.Controls.Add(this.lblCijenaArtikla);
            this.gbUnosArtikla.Controls.Add(this.txtNazivArtikla);
            this.gbUnosArtikla.Controls.Add(this.lblNazivArtikla);
            this.gbUnosArtikla.ForeColor = System.Drawing.Color.White;
            this.gbUnosArtikla.Location = new System.Drawing.Point(154, 124);
            this.gbUnosArtikla.Name = "gbUnosArtikla";
            this.gbUnosArtikla.Size = new System.Drawing.Size(460, 248);
            this.gbUnosArtikla.TabIndex = 1;
            this.gbUnosArtikla.TabStop = false;
            this.gbUnosArtikla.Text = "Unos artikla:";
            // 
            // lblNazivArtikla
            // 
            this.lblNazivArtikla.AutoSize = true;
            this.lblNazivArtikla.Location = new System.Drawing.Point(85, 39);
            this.lblNazivArtikla.Name = "lblNazivArtikla";
            this.lblNazivArtikla.Size = new System.Drawing.Size(47, 17);
            this.lblNazivArtikla.TabIndex = 0;
            this.lblNazivArtikla.Text = "Naziv;";
            // 
            // txtNazivArtikla
            // 
            this.txtNazivArtikla.Location = new System.Drawing.Point(183, 39);
            this.txtNazivArtikla.Name = "txtNazivArtikla";
            this.txtNazivArtikla.Size = new System.Drawing.Size(162, 22);
            this.txtNazivArtikla.TabIndex = 1;
            // 
            // lblCijenaArtikla
            // 
            this.lblCijenaArtikla.AutoSize = true;
            this.lblCijenaArtikla.Location = new System.Drawing.Point(85, 89);
            this.lblCijenaArtikla.Name = "lblCijenaArtikla";
            this.lblCijenaArtikla.Size = new System.Drawing.Size(51, 17);
            this.lblCijenaArtikla.TabIndex = 0;
            this.lblCijenaArtikla.Text = "Cijena:";
            // 
            // txtCijenaArtikla
            // 
            this.txtCijenaArtikla.Location = new System.Drawing.Point(183, 89);
            this.txtCijenaArtikla.Name = "txtCijenaArtikla";
            this.txtCijenaArtikla.Size = new System.Drawing.Size(162, 22);
            this.txtCijenaArtikla.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kategorija:";
            // 
            // cbKategorijaArtikla
            // 
            this.cbKategorijaArtikla.FormattingEnabled = true;
            this.cbKategorijaArtikla.Location = new System.Drawing.Point(183, 136);
            this.cbKategorijaArtikla.Name = "cbKategorijaArtikla";
            this.cbKategorijaArtikla.Size = new System.Drawing.Size(162, 24);
            this.cbKategorijaArtikla.TabIndex = 2;
            // 
            // btnSpremiArtikl
            // 
            this.btnSpremiArtikl.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnSpremiArtikl.Location = new System.Drawing.Point(184, 184);
            this.btnSpremiArtikl.Name = "btnSpremiArtikl";
            this.btnSpremiArtikl.Size = new System.Drawing.Size(160, 31);
            this.btnSpremiArtikl.TabIndex = 3;
            this.btnSpremiArtikl.Text = "Spremi";
            this.btnSpremiArtikl.UseVisualStyleBackColor = true;
            // 
            // FrmUnosArtikla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(34)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.gbUnosArtikla);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmUnosArtikla";
            this.Text = "FrmUnosArtikla";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbUnosArtikla.ResumeLayout(false);
            this.gbUnosArtikla.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbUnosArtikla;
        private System.Windows.Forms.Button btnSpremiArtikl;
        private System.Windows.Forms.ComboBox cbKategorijaArtikla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCijenaArtikla;
        private System.Windows.Forms.Label lblCijenaArtikla;
        private System.Windows.Forms.TextBox txtNazivArtikla;
        private System.Windows.Forms.Label lblNazivArtikla;
    }
}