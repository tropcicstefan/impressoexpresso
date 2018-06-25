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
            this.components = new System.ComponentModel.Container();
            this.gbArtikli = new System.Windows.Forms.GroupBox();
            this.btnDodajArtikl = new System.Windows.Forms.Button();
            this.tbKolicinaArtikla = new System.Windows.Forms.TextBox();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.pbOduzmi = new System.Windows.Forms.PictureBox();
            this.pbDodaj = new System.Windows.Forms.PictureBox();
            this.cbKategorija = new System.Windows.Forms.ComboBox();
            this.lblKolicinaArtikla = new System.Windows.Forms.Label();
            this.lblKategorijaArtikla = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.dgvArtikliZaNarudzbu = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategorijaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stanjeNaSkladistuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategorijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkeNarudzbesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkePrimkesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbArtikli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOduzmi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDodaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikliZaNarudzbu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbArtikli
            // 
            this.gbArtikli.Controls.Add(this.dgvArtikliZaNarudzbu);
            this.gbArtikli.Controls.Add(this.btnDodajArtikl);
            this.gbArtikli.Controls.Add(this.tbKolicinaArtikla);
            this.gbArtikli.Controls.Add(this.btnPotvrdi);
            this.gbArtikli.Controls.Add(this.pbOduzmi);
            this.gbArtikli.Controls.Add(this.pbDodaj);
            this.gbArtikli.Controls.Add(this.cbKategorija);
            this.gbArtikli.Controls.Add(this.lblKolicinaArtikla);
            this.gbArtikli.Controls.Add(this.lblKategorijaArtikla);
            this.gbArtikli.Location = new System.Drawing.Point(155, 172);
            this.gbArtikli.Name = "gbArtikli";
            this.gbArtikli.Size = new System.Drawing.Size(480, 312);
            this.gbArtikli.TabIndex = 0;
            this.gbArtikli.TabStop = false;
            // 
            // btnDodajArtikl
            // 
            this.btnDodajArtikl.Location = new System.Drawing.Point(380, 122);
            this.btnDodajArtikl.Name = "btnDodajArtikl";
            this.btnDodajArtikl.Size = new System.Drawing.Size(94, 36);
            this.btnDodajArtikl.TabIndex = 7;
            this.btnDodajArtikl.Text = "Dodaj Artikl";
            this.btnDodajArtikl.UseVisualStyleBackColor = true;
            this.btnDodajArtikl.Click += new System.EventHandler(this.btnDodajArtikl_Click);
            // 
            // tbKolicinaArtikla
            // 
            this.tbKolicinaArtikla.Enabled = false;
            this.tbKolicinaArtikla.Location = new System.Drawing.Point(145, 88);
            this.tbKolicinaArtikla.Name = "tbKolicinaArtikla";
            this.tbKolicinaArtikla.Size = new System.Drawing.Size(129, 20);
            this.tbKolicinaArtikla.TabIndex = 6;
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(280, 122);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(94, 36);
            this.btnPotvrdi.TabIndex = 3;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // pbOduzmi
            // 
            this.pbOduzmi.Image = global::Impresso_Expresso.Properties.Resources.makni;
            this.pbOduzmi.Location = new System.Drawing.Point(280, 19);
            this.pbOduzmi.Name = "pbOduzmi";
            this.pbOduzmi.Size = new System.Drawing.Size(94, 89);
            this.pbOduzmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOduzmi.TabIndex = 2;
            this.pbOduzmi.TabStop = false;
            this.pbOduzmi.Click += new System.EventHandler(this.pbOduzmi_Click);
            // 
            // pbDodaj
            // 
            this.pbDodaj.Image = global::Impresso_Expresso.Properties.Resources.dodaj;
            this.pbDodaj.Location = new System.Drawing.Point(380, 19);
            this.pbDodaj.Name = "pbDodaj";
            this.pbDodaj.Size = new System.Drawing.Size(94, 89);
            this.pbDodaj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDodaj.TabIndex = 2;
            this.pbDodaj.TabStop = false;
            this.pbDodaj.Click += new System.EventHandler(this.pbDodaj_Click);
            // 
            // cbKategorija
            // 
            this.cbKategorija.FormattingEnabled = true;
            this.cbKategorija.Location = new System.Drawing.Point(145, 19);
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Size = new System.Drawing.Size(129, 21);
            this.cbKategorija.TabIndex = 1;
            this.cbKategorija.SelectedIndexChanged += new System.EventHandler(this.cbKategorija_SelectedIndexChanged);
            // 
            // lblKolicinaArtikla
            // 
            this.lblKolicinaArtikla.AutoSize = true;
            this.lblKolicinaArtikla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKolicinaArtikla.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblKolicinaArtikla.Location = new System.Drawing.Point(59, 88);
            this.lblKolicinaArtikla.Name = "lblKolicinaArtikla";
            this.lblKolicinaArtikla.Size = new System.Drawing.Size(63, 20);
            this.lblKolicinaArtikla.TabIndex = 0;
            this.lblKolicinaArtikla.Text = "Kolicina";
            // 
            // lblKategorijaArtikla
            // 
            this.lblKategorijaArtikla.AutoSize = true;
            this.lblKategorijaArtikla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategorijaArtikla.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblKategorijaArtikla.Location = new System.Drawing.Point(59, 20);
            this.lblKategorijaArtikla.Name = "lblKategorijaArtikla";
            this.lblKategorijaArtikla.Size = new System.Drawing.Size(80, 20);
            this.lblKategorijaArtikla.TabIndex = 0;
            this.lblKategorijaArtikla.Text = "Kategorija";
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
            // dgvArtikliZaNarudzbu
            // 
            this.dgvArtikliZaNarudzbu.AllowUserToAddRows = false;
            this.dgvArtikliZaNarudzbu.AllowUserToDeleteRows = false;
            this.dgvArtikliZaNarudzbu.AllowUserToResizeColumns = false;
            this.dgvArtikliZaNarudzbu.AllowUserToResizeRows = false;
            this.dgvArtikliZaNarudzbu.AutoGenerateColumns = false;
            this.dgvArtikliZaNarudzbu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikliZaNarudzbu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.kategorijaIDDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.stanjeNaSkladistuDataGridViewTextBoxColumn,
            this.kategorijeDataGridViewTextBoxColumn,
            this.stavkeNarudzbesDataGridViewTextBoxColumn,
            this.stavkePrimkesDataGridViewTextBoxColumn});
            this.dgvArtikliZaNarudzbu.DataSource = this.artikliBindingSource;
            this.dgvArtikliZaNarudzbu.Location = new System.Drawing.Point(6, 164);
            this.dgvArtikliZaNarudzbu.MultiSelect = false;
            this.dgvArtikliZaNarudzbu.Name = "dgvArtikliZaNarudzbu";
            this.dgvArtikliZaNarudzbu.RowHeadersVisible = false;
            this.dgvArtikliZaNarudzbu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArtikliZaNarudzbu.Size = new System.Drawing.Size(468, 142);
            this.dgvArtikliZaNarudzbu.TabIndex = 8;
            this.dgvArtikliZaNarudzbu.SelectionChanged += new System.EventHandler(this.dgvArtikliZaNarudzbu_SelectionChanged);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // kategorijaIDDataGridViewTextBoxColumn
            // 
            this.kategorijaIDDataGridViewTextBoxColumn.DataPropertyName = "KategorijaID";
            this.kategorijaIDDataGridViewTextBoxColumn.HeaderText = "KategorijaID";
            this.kategorijaIDDataGridViewTextBoxColumn.Name = "kategorijaIDDataGridViewTextBoxColumn";
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            // 
            // stanjeNaSkladistuDataGridViewTextBoxColumn
            // 
            this.stanjeNaSkladistuDataGridViewTextBoxColumn.DataPropertyName = "StanjeNaSkladistu";
            this.stanjeNaSkladistuDataGridViewTextBoxColumn.HeaderText = "StanjeNaSkladistu";
            this.stanjeNaSkladistuDataGridViewTextBoxColumn.Name = "stanjeNaSkladistuDataGridViewTextBoxColumn";
            // 
            // kategorijeDataGridViewTextBoxColumn
            // 
            this.kategorijeDataGridViewTextBoxColumn.DataPropertyName = "Kategorije";
            this.kategorijeDataGridViewTextBoxColumn.HeaderText = "Kategorije";
            this.kategorijeDataGridViewTextBoxColumn.Name = "kategorijeDataGridViewTextBoxColumn";
            this.kategorijeDataGridViewTextBoxColumn.Visible = false;
            // 
            // stavkeNarudzbesDataGridViewTextBoxColumn
            // 
            this.stavkeNarudzbesDataGridViewTextBoxColumn.DataPropertyName = "StavkeNarudzbes";
            this.stavkeNarudzbesDataGridViewTextBoxColumn.HeaderText = "StavkeNarudzbes";
            this.stavkeNarudzbesDataGridViewTextBoxColumn.Name = "stavkeNarudzbesDataGridViewTextBoxColumn";
            this.stavkeNarudzbesDataGridViewTextBoxColumn.Visible = false;
            // 
            // stavkePrimkesDataGridViewTextBoxColumn
            // 
            this.stavkePrimkesDataGridViewTextBoxColumn.DataPropertyName = "StavkePrimkes";
            this.stavkePrimkesDataGridViewTextBoxColumn.HeaderText = "StavkePrimkes";
            this.stavkePrimkesDataGridViewTextBoxColumn.Name = "stavkePrimkesDataGridViewTextBoxColumn";
            this.stavkePrimkesDataGridViewTextBoxColumn.Visible = false;
            // 
            // artikliBindingSource
            // 
            this.artikliBindingSource.DataSource = typeof(Impresso_Expresso.Artikli);
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
            this.Load += new System.EventHandler(this.FrmDodajNarudžbu_Load);
            this.gbArtikli.ResumeLayout(false);
            this.gbArtikli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOduzmi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDodaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikliZaNarudzbu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbArtikli;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.PictureBox pbOduzmi;
        private System.Windows.Forms.PictureBox pbDodaj;
        private System.Windows.Forms.ComboBox cbKategorija;
        private System.Windows.Forms.Label lblKolicinaArtikla;
        private System.Windows.Forms.Label lblKategorijaArtikla;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.TextBox tbKolicinaArtikla;
        private System.Windows.Forms.Button btnDodajArtikl;
        private System.Windows.Forms.DataGridView dgvArtikliZaNarudzbu;
        private System.Windows.Forms.BindingSource artikliBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategorijaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stanjeNaSkladistuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategorijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkeNarudzbesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkePrimkesDataGridViewTextBoxColumn;
    }
}