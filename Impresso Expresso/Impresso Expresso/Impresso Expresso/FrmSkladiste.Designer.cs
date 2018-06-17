namespace Impresso_Expresso
{
    partial class FrmSkladiste
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
            this.dgvStanjeSkladišta = new System.Windows.Forms.DataGridView();
            this.btnUnosArtikla = new System.Windows.Forms.Button();
            this.btnPrimka = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbstanjeNaSkladistu = new System.Windows.Forms.GroupBox();
            this.pDgvArtikli = new System.Windows.Forms.Panel();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategorijaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stanjeNaSkladistuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategorijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkeNarudzbesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkePrimkesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStanjeSkladišta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbstanjeNaSkladistu.SuspendLayout();
            this.pDgvArtikli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStanjeSkladišta
            // 
            this.dgvStanjeSkladišta.AutoGenerateColumns = false;
            this.dgvStanjeSkladišta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStanjeSkladišta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.kategorijaIDDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.stanjeNaSkladistuDataGridViewTextBoxColumn,
            this.kategorijeDataGridViewTextBoxColumn,
            this.stavkeNarudzbesDataGridViewTextBoxColumn,
            this.stavkePrimkesDataGridViewTextBoxColumn});
            this.dgvStanjeSkladišta.DataSource = this.artikliBindingSource;
            this.dgvStanjeSkladišta.Location = new System.Drawing.Point(31, 3);
            this.dgvStanjeSkladišta.Name = "dgvStanjeSkladišta";
            this.dgvStanjeSkladišta.Size = new System.Drawing.Size(541, 254);
            this.dgvStanjeSkladišta.TabIndex = 1;
            // 
            // btnUnosArtikla
            // 
            this.btnUnosArtikla.ForeColor = System.Drawing.Color.Black;
            this.btnUnosArtikla.Location = new System.Drawing.Point(32, 52);
            this.btnUnosArtikla.Name = "btnUnosArtikla";
            this.btnUnosArtikla.Size = new System.Drawing.Size(75, 23);
            this.btnUnosArtikla.TabIndex = 2;
            this.btnUnosArtikla.Text = "Unos artikla";
            this.btnUnosArtikla.UseVisualStyleBackColor = true;
            // 
            // btnPrimka
            // 
            this.btnPrimka.ForeColor = System.Drawing.Color.Black;
            this.btnPrimka.Location = new System.Drawing.Point(167, 52);
            this.btnPrimka.Name = "btnPrimka";
            this.btnPrimka.Size = new System.Drawing.Size(75, 23);
            this.btnPrimka.TabIndex = 3;
            this.btnPrimka.Text = "Primke";
            this.btnPrimka.UseVisualStyleBackColor = true;
            this.btnPrimka.Click += new System.EventHandler(this.btnPrimka_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Impresso_Expresso.Properties.Resources.logo_banner;
            this.pictureBox1.Location = new System.Drawing.Point(152, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // gbstanjeNaSkladistu
            // 
            this.gbstanjeNaSkladistu.Controls.Add(this.pDgvArtikli);
            this.gbstanjeNaSkladistu.Controls.Add(this.btnPrimka);
            this.gbstanjeNaSkladistu.Controls.Add(this.btnUnosArtikla);
            this.gbstanjeNaSkladistu.ForeColor = System.Drawing.Color.White;
            this.gbstanjeNaSkladistu.Location = new System.Drawing.Point(33, 151);
            this.gbstanjeNaSkladistu.Name = "gbstanjeNaSkladistu";
            this.gbstanjeNaSkladistu.Size = new System.Drawing.Size(639, 376);
            this.gbstanjeNaSkladistu.TabIndex = 6;
            this.gbstanjeNaSkladistu.TabStop = false;
            this.gbstanjeNaSkladistu.Text = "Stanje na skladištu";
            // 
            // pDgvArtikli
            // 
            this.pDgvArtikli.Controls.Add(this.dgvStanjeSkladišta);
            this.pDgvArtikli.ForeColor = System.Drawing.Color.Black;
            this.pDgvArtikli.Location = new System.Drawing.Point(11, 97);
            this.pDgvArtikli.Name = "pDgvArtikli";
            this.pDgvArtikli.Size = new System.Drawing.Size(617, 273);
            this.pDgvArtikli.TabIndex = 5;
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
            // FrmSkladiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(34)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(696, 550);
            this.Controls.Add(this.gbstanjeNaSkladistu);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmSkladiste";
            this.Text = "FrmSkladiste";
            this.Load += new System.EventHandler(this.FrmSkladiste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStanjeSkladišta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbstanjeNaSkladistu.ResumeLayout(false);
            this.pDgvArtikli.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvStanjeSkladišta;
        private System.Windows.Forms.Button btnUnosArtikla;
        private System.Windows.Forms.Button btnPrimka;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbstanjeNaSkladistu;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategorijaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stanjeNaSkladistuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategorijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkeNarudzbesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkePrimkesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource artikliBindingSource;
        private System.Windows.Forms.Panel pDgvArtikli;
    }
}