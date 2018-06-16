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
            this.components = new System.ComponentModel.Container();
            this.dgvPrimke = new System.Windows.Forms.DataGridView();
            this.btnObrisiArtikl = new System.Windows.Forms.Button();
            this.btnPohrani = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbPrimka = new System.Windows.Forms.GroupBox();
            this.dgvStavkePrimke = new System.Windows.Forms.DataGridView();
            this.stavkePrimkeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.primkeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobavljacIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumIVrijemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobavljaciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisniciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkePrimkesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primkaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artiklIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artikliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primkeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbPrimka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkePrimke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkePrimkeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primkeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrimke
            // 
            this.dgvPrimke.AutoGenerateColumns = false;
            this.dgvPrimke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrimke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.dobavljacIDDataGridViewTextBoxColumn,
            this.korisnikIDDataGridViewTextBoxColumn,
            this.datumIVrijemeDataGridViewTextBoxColumn,
            this.dobavljaciDataGridViewTextBoxColumn,
            this.korisniciDataGridViewTextBoxColumn,
            this.stavkePrimkesDataGridViewTextBoxColumn});
            this.dgvPrimke.DataSource = this.primkeBindingSource;
            this.dgvPrimke.Location = new System.Drawing.Point(274, 19);
            this.dgvPrimke.Name = "dgvPrimke";
            this.dgvPrimke.Size = new System.Drawing.Size(643, 207);
            this.dgvPrimke.TabIndex = 2;
            this.dgvPrimke.SelectionChanged += new System.EventHandler(this.dgvPrimke_SelectionChanged);
            // 
            // btnObrisiArtikl
            // 
            this.btnObrisiArtikl.ForeColor = System.Drawing.Color.Black;
            this.btnObrisiArtikl.Location = new System.Drawing.Point(24, 33);
            this.btnObrisiArtikl.Name = "btnObrisiArtikl";
            this.btnObrisiArtikl.Size = new System.Drawing.Size(74, 20);
            this.btnObrisiArtikl.TabIndex = 7;
            this.btnObrisiArtikl.Text = "Obrisi";
            this.btnObrisiArtikl.UseVisualStyleBackColor = true;
            // 
            // btnPohrani
            // 
            this.btnPohrani.ForeColor = System.Drawing.Color.Black;
            this.btnPohrani.Location = new System.Drawing.Point(24, 97);
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
            this.gbPrimka.Controls.Add(this.dgvStavkePrimke);
            this.gbPrimka.Controls.Add(this.dgvPrimke);
            this.gbPrimka.Controls.Add(this.btnPohrani);
            this.gbPrimka.Controls.Add(this.btnObrisiArtikl);
            this.gbPrimka.ForeColor = System.Drawing.Color.White;
            this.gbPrimka.Location = new System.Drawing.Point(12, 113);
            this.gbPrimka.Name = "gbPrimka";
            this.gbPrimka.Size = new System.Drawing.Size(942, 418);
            this.gbPrimka.TabIndex = 13;
            this.gbPrimka.TabStop = false;
            this.gbPrimka.Text = "Primka";
            // 
            // dgvStavkePrimke
            // 
            this.dgvStavkePrimke.AutoGenerateColumns = false;
            this.dgvStavkePrimke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkePrimke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.primkaIDDataGridViewTextBoxColumn,
            this.artiklIDDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.artikliDataGridViewTextBoxColumn,
            this.primkeDataGridViewTextBoxColumn});
            this.dgvStavkePrimke.DataSource = this.stavkePrimkeBindingSource;
            this.dgvStavkePrimke.Location = new System.Drawing.Point(274, 253);
            this.dgvStavkePrimke.Name = "dgvStavkePrimke";
            this.dgvStavkePrimke.Size = new System.Drawing.Size(539, 150);
            this.dgvStavkePrimke.TabIndex = 12;
            // 
            // stavkePrimkeBindingSource
            // 
            this.stavkePrimkeBindingSource.DataSource = typeof(Impresso_Expresso.StavkePrimke);
            // 
            // primkeBindingSource
            // 
            this.primkeBindingSource.DataSource = typeof(Impresso_Expresso.Primke);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // dobavljacIDDataGridViewTextBoxColumn
            // 
            this.dobavljacIDDataGridViewTextBoxColumn.DataPropertyName = "DobavljacID";
            this.dobavljacIDDataGridViewTextBoxColumn.HeaderText = "DobavljacID";
            this.dobavljacIDDataGridViewTextBoxColumn.Name = "dobavljacIDDataGridViewTextBoxColumn";
            // 
            // korisnikIDDataGridViewTextBoxColumn
            // 
            this.korisnikIDDataGridViewTextBoxColumn.DataPropertyName = "KorisnikID";
            this.korisnikIDDataGridViewTextBoxColumn.HeaderText = "KorisnikID";
            this.korisnikIDDataGridViewTextBoxColumn.Name = "korisnikIDDataGridViewTextBoxColumn";
            // 
            // datumIVrijemeDataGridViewTextBoxColumn
            // 
            this.datumIVrijemeDataGridViewTextBoxColumn.DataPropertyName = "DatumIVrijeme";
            this.datumIVrijemeDataGridViewTextBoxColumn.HeaderText = "DatumIVrijeme";
            this.datumIVrijemeDataGridViewTextBoxColumn.Name = "datumIVrijemeDataGridViewTextBoxColumn";
            // 
            // dobavljaciDataGridViewTextBoxColumn
            // 
            this.dobavljaciDataGridViewTextBoxColumn.DataPropertyName = "Dobavljaci";
            this.dobavljaciDataGridViewTextBoxColumn.HeaderText = "Dobavljaci";
            this.dobavljaciDataGridViewTextBoxColumn.Name = "dobavljaciDataGridViewTextBoxColumn";
            this.dobavljaciDataGridViewTextBoxColumn.Visible = false;
            // 
            // korisniciDataGridViewTextBoxColumn
            // 
            this.korisniciDataGridViewTextBoxColumn.DataPropertyName = "Korisnici";
            this.korisniciDataGridViewTextBoxColumn.HeaderText = "Korisnici";
            this.korisniciDataGridViewTextBoxColumn.Name = "korisniciDataGridViewTextBoxColumn";
            this.korisniciDataGridViewTextBoxColumn.Visible = false;
            // 
            // stavkePrimkesDataGridViewTextBoxColumn
            // 
            this.stavkePrimkesDataGridViewTextBoxColumn.DataPropertyName = "StavkePrimkes";
            this.stavkePrimkesDataGridViewTextBoxColumn.HeaderText = "StavkePrimkes";
            this.stavkePrimkesDataGridViewTextBoxColumn.Name = "stavkePrimkesDataGridViewTextBoxColumn";
            this.stavkePrimkesDataGridViewTextBoxColumn.Visible = false;
            // 
            // primkaIDDataGridViewTextBoxColumn
            // 
            this.primkaIDDataGridViewTextBoxColumn.DataPropertyName = "PrimkaID";
            this.primkaIDDataGridViewTextBoxColumn.HeaderText = "PrimkaID";
            this.primkaIDDataGridViewTextBoxColumn.Name = "primkaIDDataGridViewTextBoxColumn";
            // 
            // artiklIDDataGridViewTextBoxColumn
            // 
            this.artiklIDDataGridViewTextBoxColumn.DataPropertyName = "ArtiklID";
            this.artiklIDDataGridViewTextBoxColumn.HeaderText = "ArtiklID";
            this.artiklIDDataGridViewTextBoxColumn.Name = "artiklIDDataGridViewTextBoxColumn";
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            // 
            // artikliDataGridViewTextBoxColumn
            // 
            this.artikliDataGridViewTextBoxColumn.DataPropertyName = "Artikli";
            this.artikliDataGridViewTextBoxColumn.HeaderText = "Artikli";
            this.artikliDataGridViewTextBoxColumn.Name = "artikliDataGridViewTextBoxColumn";
            this.artikliDataGridViewTextBoxColumn.Visible = false;
            // 
            // primkeDataGridViewTextBoxColumn
            // 
            this.primkeDataGridViewTextBoxColumn.DataPropertyName = "Primke";
            this.primkeDataGridViewTextBoxColumn.HeaderText = "Primke";
            this.primkeDataGridViewTextBoxColumn.Name = "primkeDataGridViewTextBoxColumn";
            this.primkeDataGridViewTextBoxColumn.Visible = false;
            // 
            // FrmPrimka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(34)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(992, 557);
            this.Controls.Add(this.gbPrimka);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmPrimka";
            this.Text = "FrmPrimka";
            this.Load += new System.EventHandler(this.FrmPrimka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbPrimka.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkePrimke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkePrimkeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primkeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPrimke;
        private System.Windows.Forms.Button btnObrisiArtikl;
        private System.Windows.Forms.Button btnPohrani;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbPrimka;
        private System.Windows.Forms.BindingSource primkeBindingSource;
        private System.Windows.Forms.DataGridView dgvStavkePrimke;
        private System.Windows.Forms.BindingSource stavkePrimkeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobavljacIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumIVrijemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobavljaciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisniciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkePrimkesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primkaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artiklIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artikliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primkeDataGridViewTextBoxColumn;
    }
}