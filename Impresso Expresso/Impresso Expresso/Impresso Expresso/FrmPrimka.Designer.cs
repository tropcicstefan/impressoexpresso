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
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkePrimke)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDatumPrimke
            // 
            this.dtpDatumPrimke.Location = new System.Drawing.Point(86, 77);
            this.dtpDatumPrimke.Name = "dtpDatumPrimke";
            this.dtpDatumPrimke.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumPrimke.TabIndex = 0;
            // 
            // txtDobavljac
            // 
            this.txtDobavljac.Location = new System.Drawing.Point(158, 132);
            this.txtDobavljac.Name = "txtDobavljac";
            this.txtDobavljac.Size = new System.Drawing.Size(100, 20);
            this.txtDobavljac.TabIndex = 1;
            // 
            // dgvStavkePrimke
            // 
            this.dgvStavkePrimke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkePrimke.Location = new System.Drawing.Point(297, 175);
            this.dgvStavkePrimke.Name = "dgvStavkePrimke";
            this.dgvStavkePrimke.Size = new System.Drawing.Size(457, 208);
            this.dgvStavkePrimke.TabIndex = 2;
            // 
            // cbArtiklID
            // 
            this.cbArtiklID.FormattingEnabled = true;
            this.cbArtiklID.Location = new System.Drawing.Point(134, 203);
            this.cbArtiklID.Name = "cbArtiklID";
            this.cbArtiklID.Size = new System.Drawing.Size(121, 21);
            this.cbArtiklID.TabIndex = 3;
            // 
            // txtArtiklKolicina
            // 
            this.txtArtiklKolicina.Location = new System.Drawing.Point(135, 258);
            this.txtArtiklKolicina.Name = "txtArtiklKolicina";
            this.txtArtiklKolicina.Size = new System.Drawing.Size(119, 20);
            this.txtArtiklKolicina.TabIndex = 4;
            // 
            // btnDodajArtikl
            // 
            this.btnDodajArtikl.Location = new System.Drawing.Point(306, 418);
            this.btnDodajArtikl.Name = "btnDodajArtikl";
            this.btnDodajArtikl.Size = new System.Drawing.Size(74, 20);
            this.btnDodajArtikl.TabIndex = 5;
            this.btnDodajArtikl.Text = "Dodaj";
            this.btnDodajArtikl.UseVisualStyleBackColor = true;
            // 
            // btnIzmijeniArtikl
            // 
            this.btnIzmijeniArtikl.Location = new System.Drawing.Point(412, 419);
            this.btnIzmijeniArtikl.Name = "btnIzmijeniArtikl";
            this.btnIzmijeniArtikl.Size = new System.Drawing.Size(74, 20);
            this.btnIzmijeniArtikl.TabIndex = 6;
            this.btnIzmijeniArtikl.Text = "Izmijeni";
            this.btnIzmijeniArtikl.UseVisualStyleBackColor = true;
            // 
            // btnObrisiArtikl
            // 
            this.btnObrisiArtikl.Location = new System.Drawing.Point(522, 419);
            this.btnObrisiArtikl.Name = "btnObrisiArtikl";
            this.btnObrisiArtikl.Size = new System.Drawing.Size(74, 20);
            this.btnObrisiArtikl.TabIndex = 7;
            this.btnObrisiArtikl.Text = "Obrisi";
            this.btnObrisiArtikl.UseVisualStyleBackColor = true;
            // 
            // lblDobavljac
            // 
            this.lblDobavljac.AutoSize = true;
            this.lblDobavljac.Location = new System.Drawing.Point(44, 142);
            this.lblDobavljac.Name = "lblDobavljac";
            this.lblDobavljac.Size = new System.Drawing.Size(55, 13);
            this.lblDobavljac.TabIndex = 8;
            this.lblDobavljac.Text = "Dobavljač";
            // 
            // lblArtikl
            // 
            this.lblArtikl.AutoSize = true;
            this.lblArtikl.Location = new System.Drawing.Point(42, 210);
            this.lblArtikl.Name = "lblArtikl";
            this.lblArtikl.Size = new System.Drawing.Size(30, 13);
            this.lblArtikl.TabIndex = 9;
            this.lblArtikl.Text = "Artikl";
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(45, 258);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(44, 13);
            this.lblKolicina.TabIndex = 10;
            this.lblKolicina.Text = "Kolicina";
            // 
            // FrmPrimka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.lblArtikl);
            this.Controls.Add(this.lblDobavljac);
            this.Controls.Add(this.btnObrisiArtikl);
            this.Controls.Add(this.btnIzmijeniArtikl);
            this.Controls.Add(this.btnDodajArtikl);
            this.Controls.Add(this.txtArtiklKolicina);
            this.Controls.Add(this.cbArtiklID);
            this.Controls.Add(this.dgvStavkePrimke);
            this.Controls.Add(this.txtDobavljac);
            this.Controls.Add(this.dtpDatumPrimke);
            this.Name = "FrmPrimka";
            this.Text = "FrmPrimka";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkePrimke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}