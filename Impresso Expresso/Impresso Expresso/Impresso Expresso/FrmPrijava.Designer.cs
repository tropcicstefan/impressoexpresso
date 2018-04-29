namespace Impresso_Expresso
{
    partial class FrmPrijava
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
            this.txtKorIme = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.lblKorime = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbPrijava = new System.Windows.Forms.GroupBox();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.gbPrijava.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKorIme
            // 
            this.txtKorIme.Location = new System.Drawing.Point(198, 42);
            this.txtKorIme.Name = "txtKorIme";
            this.txtKorIme.Size = new System.Drawing.Size(160, 22);
            this.txtKorIme.TabIndex = 0;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(198, 94);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(160, 22);
            this.txtLozinka.TabIndex = 0;
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Location = new System.Drawing.Point(65, 94);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(61, 17);
            this.lblLozinka.TabIndex = 1;
            this.lblLozinka.Text = "Lozinka:";
            // 
            // lblKorime
            // 
            this.lblKorime.AutoSize = true;
            this.lblKorime.Location = new System.Drawing.Point(55, 42);
            this.lblKorime.Name = "lblKorime";
            this.lblKorime.Size = new System.Drawing.Size(103, 17);
            this.lblKorime.TabIndex = 2;
            this.lblKorime.Text = "Korisničko ime:";
            // 
            // gbPrijava
            // 
            this.gbPrijava.Controls.Add(this.btnPrijava);
            this.gbPrijava.Controls.Add(this.txtKorIme);
            this.gbPrijava.Controls.Add(this.lblKorime);
            this.gbPrijava.Controls.Add(this.txtLozinka);
            this.gbPrijava.Controls.Add(this.lblLozinka);
            this.gbPrijava.ForeColor = System.Drawing.Color.White;
            this.gbPrijava.Location = new System.Drawing.Point(196, 189);
            this.gbPrijava.Name = "gbPrijava";
            this.gbPrijava.Size = new System.Drawing.Size(405, 215);
            this.gbPrijava.TabIndex = 3;
            this.gbPrijava.TabStop = false;
            this.gbPrijava.Text = "Prijava";
            // 
            // btnPrijava
            // 
            this.btnPrijava.ForeColor = System.Drawing.Color.Black;
            this.btnPrijava.Location = new System.Drawing.Point(58, 140);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(299, 33);
            this.btnPrijava.TabIndex = 3;
            this.btnPrijava.Text = "Prijavi se";
            this.btnPrijava.UseVisualStyleBackColor = true;
            // 
            // FrmPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(34)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.gbPrijava);
            this.Name = "FrmPrijava";
            this.Text = "FrmPrijava";
            this.gbPrijava.ResumeLayout(false);
            this.gbPrijava.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtKorIme;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.Label lblKorime;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbPrijava;
        private System.Windows.Forms.Button btnPrijava;
    }
}