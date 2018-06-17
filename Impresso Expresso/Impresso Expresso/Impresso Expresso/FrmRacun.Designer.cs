namespace Impresso_Expresso
{
    partial class FrmRacun
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
            this.btnIspis = new System.Windows.Forms.Button();
            this.lblIznos = new System.Windows.Forms.Label();
            this.lblNacinPlacanja = new System.Windows.Forms.Label();
            this.cbNacinPlacanja = new System.Windows.Forms.ComboBox();
            this.placanjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtUkupniIznos = new System.Windows.Forms.TextBox();
            this.lblPrimljeniIznos = new System.Windows.Forms.Label();
            this.txtPrimljeniIznos = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbRacun = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.placanjaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbRacun.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIspis
            // 
            this.btnIspis.ForeColor = System.Drawing.Color.Black;
            this.btnIspis.Location = new System.Drawing.Point(421, 99);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(75, 23);
            this.btnIspis.TabIndex = 0;
            this.btnIspis.Text = "Ispis";
            this.btnIspis.UseVisualStyleBackColor = true;
            // 
            // lblIznos
            // 
            this.lblIznos.AutoSize = true;
            this.lblIznos.Location = new System.Drawing.Point(33, 51);
            this.lblIznos.Name = "lblIznos";
            this.lblIznos.Size = new System.Drawing.Size(74, 13);
            this.lblIznos.TabIndex = 1;
            this.lblIznos.Text = "Ukupni iznos: ";
            // 
            // lblNacinPlacanja
            // 
            this.lblNacinPlacanja.AutoSize = true;
            this.lblNacinPlacanja.Location = new System.Drawing.Point(36, 101);
            this.lblNacinPlacanja.Name = "lblNacinPlacanja";
            this.lblNacinPlacanja.Size = new System.Drawing.Size(84, 13);
            this.lblNacinPlacanja.TabIndex = 2;
            this.lblNacinPlacanja.Text = "Način plaćanja: ";
            // 
            // cbNacinPlacanja
            // 
            this.cbNacinPlacanja.FormattingEnabled = true;
            this.cbNacinPlacanja.Location = new System.Drawing.Point(163, 101);
            this.cbNacinPlacanja.Name = "cbNacinPlacanja";
            this.cbNacinPlacanja.Size = new System.Drawing.Size(121, 21);
            this.cbNacinPlacanja.TabIndex = 3;
            // 
            // placanjaBindingSource
            // 
            this.placanjaBindingSource.DataSource = typeof(Impresso_Expresso.Placanja);
            // 
            // txtUkupniIznos
            // 
            this.txtUkupniIznos.Location = new System.Drawing.Point(163, 51);
            this.txtUkupniIznos.Name = "txtUkupniIznos";
            this.txtUkupniIznos.Size = new System.Drawing.Size(100, 20);
            this.txtUkupniIznos.TabIndex = 4;
            // 
            // lblPrimljeniIznos
            // 
            this.lblPrimljeniIznos.AutoSize = true;
            this.lblPrimljeniIznos.Location = new System.Drawing.Point(37, 160);
            this.lblPrimljeniIznos.Name = "lblPrimljeniIznos";
            this.lblPrimljeniIznos.Size = new System.Drawing.Size(75, 13);
            this.lblPrimljeniIznos.TabIndex = 5;
            this.lblPrimljeniIznos.Text = "Primljeni iznos:";
            // 
            // txtPrimljeniIznos
            // 
            this.txtPrimljeniIznos.Location = new System.Drawing.Point(163, 153);
            this.txtPrimljeniIznos.Name = "txtPrimljeniIznos";
            this.txtPrimljeniIznos.Size = new System.Drawing.Size(100, 20);
            this.txtPrimljeniIznos.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Impresso_Expresso.Properties.Resources.logo_banner;
            this.pictureBox1.Location = new System.Drawing.Point(115, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // gbRacun
            // 
            this.gbRacun.Controls.Add(this.txtPrimljeniIznos);
            this.gbRacun.Controls.Add(this.lblPrimljeniIznos);
            this.gbRacun.Controls.Add(this.txtUkupniIznos);
            this.gbRacun.Controls.Add(this.cbNacinPlacanja);
            this.gbRacun.Controls.Add(this.lblNacinPlacanja);
            this.gbRacun.Controls.Add(this.lblIznos);
            this.gbRacun.Controls.Add(this.btnIspis);
            this.gbRacun.ForeColor = System.Drawing.Color.White;
            this.gbRacun.Location = new System.Drawing.Point(28, 171);
            this.gbRacun.Name = "gbRacun";
            this.gbRacun.Size = new System.Drawing.Size(584, 229);
            this.gbRacun.TabIndex = 8;
            this.gbRacun.TabStop = false;
            this.gbRacun.Text = "Račun";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(589, 171);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 9;
            // 
            // FrmRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(34)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(997, 560);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.gbRacun);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmRacun";
            this.Text = "FrmRacun";
            this.Load += new System.EventHandler(this.FrmRacun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.placanjaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbRacun.ResumeLayout(false);
            this.gbRacun.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.Label lblIznos;
        private System.Windows.Forms.Label lblNacinPlacanja;
        private System.Windows.Forms.ComboBox cbNacinPlacanja;
        private System.Windows.Forms.TextBox txtUkupniIznos;
        private System.Windows.Forms.Label lblPrimljeniIznos;
        private System.Windows.Forms.TextBox txtPrimljeniIznos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbRacun;
        private System.Windows.Forms.BindingSource placanjaBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}