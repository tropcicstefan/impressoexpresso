﻿namespace Impresso_Expresso
{
    partial class FrmPopisPrimki
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPrimke = new System.Windows.Forms.DataGridView();
            this.btnObrisiArtikl = new System.Windows.Forms.Button();
            this.gbPrimka = new System.Windows.Forms.GroupBox();
            this.btnNovaPrimka = new System.Windows.Forms.Button();
            this.pDgv = new System.Windows.Forms.Panel();
            this.dgvStavkePrimke = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.primkaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artiklIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artikliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primkeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkePrimkeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobavljacIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumIVrijemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobavljaciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisniciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkePrimkesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primkeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimke)).BeginInit();
            this.gbPrimka.SuspendLayout();
            this.pDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkePrimke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrimke.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrimke.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvPrimke.Location = new System.Drawing.Point(3, 0);
            this.dgvPrimke.Name = "dgvPrimke";
            this.dgvPrimke.Size = new System.Drawing.Size(448, 207);
            this.dgvPrimke.TabIndex = 2;
            this.dgvPrimke.SelectionChanged += new System.EventHandler(this.dgvPrimke_SelectionChanged);
            // 
            // btnObrisiArtikl
            // 
            this.btnObrisiArtikl.ForeColor = System.Drawing.Color.Black;
            this.btnObrisiArtikl.Location = new System.Drawing.Point(244, 202);
            this.btnObrisiArtikl.Name = "btnObrisiArtikl";
            this.btnObrisiArtikl.Size = new System.Drawing.Size(74, 24);
            this.btnObrisiArtikl.TabIndex = 7;
            this.btnObrisiArtikl.Text = "Obrisi";
            this.btnObrisiArtikl.UseVisualStyleBackColor = true;
            // 
            // gbPrimka
            // 
            this.gbPrimka.Controls.Add(this.btnNovaPrimka);
            this.gbPrimka.Controls.Add(this.pDgv);
            this.gbPrimka.Controls.Add(this.btnObrisiArtikl);
            this.gbPrimka.ForeColor = System.Drawing.Color.White;
            this.gbPrimka.Location = new System.Drawing.Point(12, 113);
            this.gbPrimka.Name = "gbPrimka";
            this.gbPrimka.Size = new System.Drawing.Size(942, 418);
            this.gbPrimka.TabIndex = 13;
            this.gbPrimka.TabStop = false;
            this.gbPrimka.Text = "Primka";
            // 
            // btnNovaPrimka
            // 
            this.btnNovaPrimka.ForeColor = System.Drawing.Color.Black;
            this.btnNovaPrimka.Location = new System.Drawing.Point(244, 86);
            this.btnNovaPrimka.Name = "btnNovaPrimka";
            this.btnNovaPrimka.Size = new System.Drawing.Size(97, 24);
            this.btnNovaPrimka.TabIndex = 14;
            this.btnNovaPrimka.Text = "Nova Primka";
            this.btnNovaPrimka.UseVisualStyleBackColor = true;
            this.btnNovaPrimka.Click += new System.EventHandler(this.btnNovaPrimka_Click);
            // 
            // pDgv
            // 
            this.pDgv.Controls.Add(this.dgvStavkePrimke);
            this.pDgv.Controls.Add(this.dgvPrimke);
            this.pDgv.ForeColor = System.Drawing.Color.Black;
            this.pDgv.Location = new System.Drawing.Point(443, 19);
            this.pDgv.Name = "pDgv";
            this.pDgv.Size = new System.Drawing.Size(476, 379);
            this.pDgv.TabIndex = 13;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStavkePrimke.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStavkePrimke.Location = new System.Drawing.Point(3, 226);
            this.dgvStavkePrimke.Name = "dgvStavkePrimke";
            this.dgvStavkePrimke.Size = new System.Drawing.Size(344, 150);
            this.dgvStavkePrimke.TabIndex = 12;
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
            // stavkePrimkeBindingSource
            // 
            this.stavkePrimkeBindingSource.DataSource = typeof(Impresso_Expresso.StavkePrimke);
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
            // primkeBindingSource
            // 
            this.primkeBindingSource.DataSource = typeof(Impresso_Expresso.Primke);
            // 
            // FrmPopisPrimki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(34)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(992, 557);
            this.Controls.Add(this.gbPrimka);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmPopisPrimki";
            this.Text = "FrmPrimka";
            this.Load += new System.EventHandler(this.FrmPrimka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimke)).EndInit();
            this.gbPrimka.ResumeLayout(false);
            this.pDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkePrimke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkePrimkeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primkeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPrimke;
        private System.Windows.Forms.Button btnObrisiArtikl;
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
        private System.Windows.Forms.Panel pDgv;
        private System.Windows.Forms.Button btnNovaPrimka;
    }
}