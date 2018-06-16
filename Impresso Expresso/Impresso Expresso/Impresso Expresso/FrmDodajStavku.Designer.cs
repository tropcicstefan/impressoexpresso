namespace Impresso_Expresso
{
    partial class FrmDodajStavku
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDodajStavku = new System.Windows.Forms.Button();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.lblArtikl = new System.Windows.Forms.Label();
            this.cbArtikl = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDodajStavku);
            this.panel1.Controls.Add(this.txtKolicina);
            this.panel1.Controls.Add(this.lblKolicina);
            this.panel1.Controls.Add(this.lblArtikl);
            this.panel1.Controls.Add(this.cbArtikl);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(233, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 183);
            this.panel1.TabIndex = 7;
            // 
            // btnDodajStavku
            // 
            this.btnDodajStavku.ForeColor = System.Drawing.Color.Black;
            this.btnDodajStavku.Location = new System.Drawing.Point(155, 132);
            this.btnDodajStavku.Name = "btnDodajStavku";
            this.btnDodajStavku.Size = new System.Drawing.Size(120, 23);
            this.btnDodajStavku.TabIndex = 4;
            this.btnDodajStavku.Text = "dodaj stavku";
            this.btnDodajStavku.UseVisualStyleBackColor = true;
            this.btnDodajStavku.Click += new System.EventHandler(this.btnDodajStavku_Click);
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(155, 83);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(100, 20);
            this.txtKolicina.TabIndex = 3;
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.ForeColor = System.Drawing.Color.White;
            this.lblKolicina.Location = new System.Drawing.Point(57, 83);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(44, 13);
            this.lblKolicina.TabIndex = 2;
            this.lblKolicina.Text = "Količina";
            // 
            // lblArtikl
            // 
            this.lblArtikl.AutoSize = true;
            this.lblArtikl.ForeColor = System.Drawing.Color.White;
            this.lblArtikl.Location = new System.Drawing.Point(52, 42);
            this.lblArtikl.Name = "lblArtikl";
            this.lblArtikl.Size = new System.Drawing.Size(30, 13);
            this.lblArtikl.TabIndex = 1;
            this.lblArtikl.Text = "Artikl";
            // 
            // cbArtikl
            // 
            this.cbArtikl.FormattingEnabled = true;
            this.cbArtikl.Location = new System.Drawing.Point(155, 34);
            this.cbArtikl.Name = "cbArtikl";
            this.cbArtikl.Size = new System.Drawing.Size(121, 21);
            this.cbArtikl.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Impresso_Expresso.Properties.Resources.logo_banner;
            this.pictureBox1.Location = new System.Drawing.Point(293, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FrmDodajStavku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(34)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDodajStavku";
            this.Text = "FrmDodajStavku";
            this.Load += new System.EventHandler(this.FrmDodajStavku_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDodajStavku;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.Label lblArtikl;
        private System.Windows.Forms.ComboBox cbArtikl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}