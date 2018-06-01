namespace Impresso_Expresso
{
    partial class FrmPrimka
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
            this.dtpDatumPrimke = new System.Windows.Forms.DateTimePicker();
            this.txtDobavljac = new System.Windows.Forms.TextBox();
            this.dgvStavkePrimke = new System.Windows.Forms.DataGridView();
            this.cbArtiklID = new System.Windows.Forms.ComboBox();
            this.txtArtiklKolicina = new System.Windows.Forms.TextBox();
            this.btnDodajArtikl = new System.Windows.Forms.Button();
            this.btnIzmijeniArtikl = new System.Windows.Forms.Button();
            this.btnObrisiArtikl = new System.Windows.Forms.Button();
            this.lblDobavljac = new System.Windows.Forms.Label();
            this.lblArtikl = new System.Windows.Forms.Label();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.btnPohrani = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbPrimka = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkePrimke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbPrimka.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpDatumPrimke
            // 
            this.dtpDatumPrimke.Location = new System.Drawing.Point(36, 40);
            this.dtpDatumPrimke.Name = "dtpDatumPrimke";
            this.dtpDatumPrimke.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumPrimke.TabIndex = 0;
            // 
            // txtDobavljac
            // 
            this.txtDobavljac.Location = new System.Drawing.Point(123, 88);
            this.txtDobavljac.Name = "txtDobavljac";
            this.txtDobavljac.Size = new System.Drawing.Size(100, 20);
            this.txtDobavljac.TabIndex = 1;
            // 
            // dgvStavkePrimke
            // 
            this.dgvStavkePrimke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkePrimke.Location = new System.Drawing.Point(308, 149);
            this.dgvStavkePrimke.Name = "dgvStavkePrimke";
            this.dgvStavkePrimke.Size = new System.Drawing.Size(457, 208);
            this.dgvStavkePrimke.TabIndex = 2;
            // 
            // cbArtiklID
            // 
            this.cbArtiklID.FormattingEnabled = true;
            this.cbArtiklID.Location = new System.Drawing.Point(122, 149);
            this.cbArtiklID.Name = "cbArtiklID";
            this.cbArtiklID.Size = new System.Drawing.Size(121, 21);
            this.cbArtiklID.TabIndex = 3;
            // 
            // txtArtiklKolicina
            // 
            this.txtArtiklKolicina.Location = new System.Drawing.Point(122, 204);
            this.txtArtiklKolicina.Name = "txtArtiklKolicina";
            this.txtArtiklKolicina.Size = new System.Drawing.Size(119, 20);
            this.txtArtiklKolicina.TabIndex = 4;
            // 
            // btnDodajArtikl
            // 
            this.btnDodajArtikl.ForeColor = System.Drawing.Color.Black;
            this.btnDodajArtikl.Location = new System.Drawing.Point(22, 283);
            this.btnDodajArtikl.Name = "btnDodajArtikl";
            this.btnDodajArtikl.Size = new System.Drawing.Size(74, 20);
            this.btnDodajArtikl.TabIndex = 5;
            this.btnDodajArtikl.Text = "Dodaj";
            this.btnDodajArtikl.UseVisualStyleBackColor = true;
            // 
            // btnIzmijeniArtikl
            // 
            this.btnIzmijeniArtikl.ForeColor = System.Drawing.Color.Black;
            this.btnIzmijeniArtikl.Location = new System.Drawing.Point(128, 284);
            this.btnIzmijeniArtikl.Name = "btnIzmijeniArtikl";
            this.btnIzmijeniArtikl.Size = new System.Drawing.Size(74, 20);
            this.btnIzmijeniArtikl.TabIndex = 6;
            this.btnIzmijeniArtikl.Text = "Izmijeni";
            this.btnIzmijeniArtikl.UseVisualStyleBackColor = true;
            // 
            // btnObrisiArtikl
            // 
            this.btnObrisiArtikl.ForeColor = System.Drawing.Color.Black;
            this.btnObrisiArtikl.Location = new System.Drawing.Point(22, 331);
            this.btnObrisiArtikl.Name = "btnObrisiArtikl";
            this.btnObrisiArtikl.Size = new System.Drawing.Size(74, 20);
            this.btnObrisiArtikl.TabIndex = 7;
            this.btnObrisiArtikl.Text = "Obrisi";
            this.btnObrisiArtikl.UseVisualStyleBackColor = true;
            // 
            // lblDobavljac
            // 
            this.lblDobavljac.AutoSize = true;
            this.lblDobavljac.ForeColor = System.Drawing.Color.White;
            this.lblDobavljac.Location = new System.Drawing.Point(32, 88);
            this.lblDobavljac.Name = "lblDobavljac";
            this.lblDobavljac.Size = new System.Drawing.Size(55, 13);
            this.lblDobavljac.TabIndex = 8;
            this.lblDobavljac.Text = "Dobavljač";
            // 
            // lblArtikl
            // 
            this.lblArtikl.AutoSize = true;
            this.lblArtikl.ForeColor = System.Drawing.Color.White;
            this.lblArtikl.Location = new System.Drawing.Point(30, 156);
            this.lblArtikl.Name = "lblArtikl";
            this.lblArtikl.Size = new System.Drawing.Size(30, 13);
            this.lblArtikl.TabIndex = 9;
            this.lblArtikl.Text = "Artikl";
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.ForeColor = System.Drawing.Color.White;
            this.lblKolicina.Location = new System.Drawing.Point(33, 204);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(44, 13);
            this.lblKolicina.TabIndex = 10;
            this.lblKolicina.Text = "Kolicina";
            // 
            // btnPohrani
            // 
            this.btnPohrani.ForeColor = System.Drawing.Color.Black;
            this.btnPohrani.Location = new System.Drawing.Point(123, 332);
            this.btnPohrani.Name = "btnPohrani";
            this.btnPohrani.Size = new System.Drawing.Size(107, 19);
            this.btnPohrani.TabIndex = 11;
            this.btnPohrani.Text = "Pohrani";
            this.btnPohrani.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Impresso_Expresso.Properties.Resources.logo_banner;
            this.pictureBox1.Location = new System.Drawing.Point(377, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(376, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // gbPrimka
            // 
            this.gbPrimka.Controls.Add(this.lblKolicina);
            this.gbPrimka.Controls.Add(this.lblArtikl);
            this.gbPrimka.Controls.Add(this.btnPohrani);
            this.gbPrimka.Controls.Add(this.lblDobavljac);
            this.gbPrimka.Controls.Add(this.btnObrisiArtikl);
            this.gbPrimka.Controls.Add(this.txtArtiklKolicina);
            this.gbPrimka.Controls.Add(this.btnIzmijeniArtikl);
            this.gbPrimka.Controls.Add(this.cbArtiklID);
            this.gbPrimka.Controls.Add(this.btnDodajArtikl);
            this.gbPrimka.Controls.Add(this.txtDobavljac);
            this.gbPrimka.Controls.Add(this.dtpDatumPrimke);
            this.gbPrimka.ForeColor = System.Drawing.Color.White;
            this.gbPrimka.Location = new System.Drawing.Point(12, 54);
            this.gbPrimka.Name = "gbPrimka";
            this.gbPrimka.Size = new System.Drawing.Size(271, 383);
            this.gbPrimka.TabIndex = 13;
            this.gbPrimka.TabStop = false;
            this.gbPrimka.Text = "Primka";
            // 
            // FrmPrimka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(34)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbPrimka);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvStavkePrimke);
            this.Name = "FrmPrimka";
            this.Text = "FrmPrimka";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkePrimke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbPrimka.ResumeLayout(false);
            this.gbPrimka.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDatumPrimke;
        private System.Windows.Forms.TextBox txtDobavljac;
        private System.Windows.Forms.DataGridView dgvStavkePrimke;
        private System.Windows.Forms.ComboBox cbArtiklID;
        private System.Windows.Forms.TextBox txtArtiklKolicina;
        private System.Windows.Forms.Button btnDodajArtikl;
        private System.Windows.Forms.Button btnIzmijeniArtikl;
        private System.Windows.Forms.Button btnObrisiArtikl;
        private System.Windows.Forms.Label lblDobavljac;
        private System.Windows.Forms.Label lblArtikl;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.Button btnPohrani;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbPrimka;
    }
}