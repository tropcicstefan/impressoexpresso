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
            this.btnIspis = new System.Windows.Forms.Button();
            this.lblIznos = new System.Windows.Forms.Label();
            this.lblNacinPlacanja = new System.Windows.Forms.Label();
            this.cbNacinPlacanja = new System.Windows.Forms.ComboBox();
            this.txtUkupniIznos = new System.Windows.Forms.TextBox();
            this.lblPrimljeniIznos = new System.Windows.Forms.Label();
            this.txtPrimljeniIznos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(409, 69);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(75, 23);
            this.btnIspis.TabIndex = 0;
            this.btnIspis.Text = "Ispis";
            this.btnIspis.UseVisualStyleBackColor = true;
            // 
            // lblIznos
            // 
            this.lblIznos.AutoSize = true;
            this.lblIznos.Location = new System.Drawing.Point(21, 21);
            this.lblIznos.Name = "lblIznos";
            this.lblIznos.Size = new System.Drawing.Size(74, 13);
            this.lblIznos.TabIndex = 1;
            this.lblIznos.Text = "Ukupni iznos: ";
            // 
            // lblNacinPlacanja
            // 
            this.lblNacinPlacanja.AutoSize = true;
            this.lblNacinPlacanja.Location = new System.Drawing.Point(24, 71);
            this.lblNacinPlacanja.Name = "lblNacinPlacanja";
            this.lblNacinPlacanja.Size = new System.Drawing.Size(84, 13);
            this.lblNacinPlacanja.TabIndex = 2;
            this.lblNacinPlacanja.Text = "Način plaćanja: ";
            // 
            // cbNacinPlacanja
            // 
            this.cbNacinPlacanja.FormattingEnabled = true;
            this.cbNacinPlacanja.Location = new System.Drawing.Point(151, 71);
            this.cbNacinPlacanja.Name = "cbNacinPlacanja";
            this.cbNacinPlacanja.Size = new System.Drawing.Size(121, 21);
            this.cbNacinPlacanja.TabIndex = 3;
            // 
            // txtUkupniIznos
            // 
            this.txtUkupniIznos.Location = new System.Drawing.Point(151, 21);
            this.txtUkupniIznos.Name = "txtUkupniIznos";
            this.txtUkupniIznos.Size = new System.Drawing.Size(100, 20);
            this.txtUkupniIznos.TabIndex = 4;
            // 
            // lblPrimljeniIznos
            // 
            this.lblPrimljeniIznos.AutoSize = true;
            this.lblPrimljeniIznos.Location = new System.Drawing.Point(25, 130);
            this.lblPrimljeniIznos.Name = "lblPrimljeniIznos";
            this.lblPrimljeniIznos.Size = new System.Drawing.Size(75, 13);
            this.lblPrimljeniIznos.TabIndex = 5;
            this.lblPrimljeniIznos.Text = "Primljeni iznos:";
            // 
            // txtPrimljeniIznos
            // 
            this.txtPrimljeniIznos.Location = new System.Drawing.Point(151, 123);
            this.txtPrimljeniIznos.Name = "txtPrimljeniIznos";
            this.txtPrimljeniIznos.Size = new System.Drawing.Size(100, 20);
            this.txtPrimljeniIznos.TabIndex = 6;
            // 
            // FrmRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 188);
            this.Controls.Add(this.txtPrimljeniIznos);
            this.Controls.Add(this.lblPrimljeniIznos);
            this.Controls.Add(this.txtUkupniIznos);
            this.Controls.Add(this.cbNacinPlacanja);
            this.Controls.Add(this.lblNacinPlacanja);
            this.Controls.Add(this.lblIznos);
            this.Controls.Add(this.btnIspis);
            this.Name = "FrmRacun";
            this.Text = "FrmRacun";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.Label lblIznos;
        private System.Windows.Forms.Label lblNacinPlacanja;
        private System.Windows.Forms.ComboBox cbNacinPlacanja;
        private System.Windows.Forms.TextBox txtUkupniIznos;
        private System.Windows.Forms.Label lblPrimljeniIznos;
        private System.Windows.Forms.TextBox txtPrimljeniIznos;
    }
}