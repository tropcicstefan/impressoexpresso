namespace Impresso_Expresso
{
    partial class FrmUpravljanjeArtiklom
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
            this.gbUpravljanjeArtiklima = new System.Windows.Forms.GroupBox();
            this.dgvPopisArtikala = new System.Windows.Forms.DataGridView();
            this.artikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblPopisArtikala = new System.Windows.Forms.Label();
            this.lblPopisKategorija = new System.Windows.Forms.Label();
            this.lbPopisKategorija = new System.Windows.Forms.ListBox();
            this.kategorijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnObrišiArtikl = new System.Windows.Forms.Button();
            this.btnUrediArtikl = new System.Windows.Forms.Button();
            this.btnDodajArtikl = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbUpravljanjeArtiklima.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisArtikala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbUpravljanjeArtiklima
            // 
            this.gbUpravljanjeArtiklima.Controls.Add(this.dgvPopisArtikala);
            this.gbUpravljanjeArtiklima.Controls.Add(this.lblPopisArtikala);
            this.gbUpravljanjeArtiklima.Controls.Add(this.lblPopisKategorija);
            this.gbUpravljanjeArtiklima.Controls.Add(this.lbPopisKategorija);
            this.gbUpravljanjeArtiklima.Controls.Add(this.btnObrišiArtikl);
            this.gbUpravljanjeArtiklima.Controls.Add(this.btnUrediArtikl);
            this.gbUpravljanjeArtiklima.Controls.Add(this.btnDodajArtikl);
            this.gbUpravljanjeArtiklima.ForeColor = System.Drawing.Color.White;
            this.gbUpravljanjeArtiklima.Location = new System.Drawing.Point(9, 70);
            this.gbUpravljanjeArtiklima.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbUpravljanjeArtiklima.Name = "gbUpravljanjeArtiklima";
            this.gbUpravljanjeArtiklima.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbUpravljanjeArtiklima.Size = new System.Drawing.Size(568, 370);
            this.gbUpravljanjeArtiklima.TabIndex = 1;
            this.gbUpravljanjeArtiklima.TabStop = false;
            this.gbUpravljanjeArtiklima.Text = "Upravljanje artiklima";
            // 
            // dgvPopisArtikala
            // 
            this.dgvPopisArtikala.AutoGenerateColumns = false;
            this.dgvPopisArtikala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisArtikala.DataSource = this.artikliBindingSource;
            this.dgvPopisArtikala.Location = new System.Drawing.Point(226, 108);
            this.dgvPopisArtikala.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPopisArtikala.MultiSelect = false;
            this.dgvPopisArtikala.Name = "dgvPopisArtikala";
            this.dgvPopisArtikala.RowTemplate.Height = 24;
            this.dgvPopisArtikala.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopisArtikala.Size = new System.Drawing.Size(325, 237);
            this.dgvPopisArtikala.TabIndex = 3;
            // 
            // lblPopisArtikala
            // 
            this.lblPopisArtikala.AutoSize = true;
            this.lblPopisArtikala.Location = new System.Drawing.Point(224, 84);
            this.lblPopisArtikala.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPopisArtikala.Name = "lblPopisArtikala";
            this.lblPopisArtikala.Size = new System.Drawing.Size(73, 13);
            this.lblPopisArtikala.TabIndex = 2;
            this.lblPopisArtikala.Text = "Popis artikala:";
            // 
            // lblPopisKategorija
            // 
            this.lblPopisKategorija.AutoSize = true;
            this.lblPopisKategorija.Location = new System.Drawing.Point(36, 84);
            this.lblPopisKategorija.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPopisKategorija.Name = "lblPopisKategorija";
            this.lblPopisKategorija.Size = new System.Drawing.Size(85, 13);
            this.lblPopisKategorija.TabIndex = 2;
            this.lblPopisKategorija.Text = "Popis kategorija:";
            // 
            // lbPopisKategorija
            // 
            this.lbPopisKategorija.DataSource = this.kategorijeBindingSource;
            this.lbPopisKategorija.DisplayMember = "Naziv";
            this.lbPopisKategorija.FormattingEnabled = true;
            this.lbPopisKategorija.Location = new System.Drawing.Point(38, 108);
            this.lbPopisKategorija.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbPopisKategorija.Name = "lbPopisKategorija";
            this.lbPopisKategorija.Size = new System.Drawing.Size(138, 238);
            this.lbPopisKategorija.TabIndex = 1;
            this.lbPopisKategorija.ValueMember = "ID";
            this.lbPopisKategorija.SelectedIndexChanged += new System.EventHandler(this.lbPopisKategorija_SelectedIndexChanged);
            // 
            // btnObrišiArtikl
            // 
            this.btnObrišiArtikl.ForeColor = System.Drawing.Color.Black;
            this.btnObrišiArtikl.Location = new System.Drawing.Point(413, 31);
            this.btnObrišiArtikl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnObrišiArtikl.Name = "btnObrišiArtikl";
            this.btnObrišiArtikl.Size = new System.Drawing.Size(137, 37);
            this.btnObrišiArtikl.TabIndex = 0;
            this.btnObrišiArtikl.Text = "Obriši artikl";
            this.btnObrišiArtikl.UseVisualStyleBackColor = true;
            this.btnObrišiArtikl.Click += new System.EventHandler(this.btnObrišiArtikl_Click);
            // 
            // btnUrediArtikl
            // 
            this.btnUrediArtikl.ForeColor = System.Drawing.Color.Black;
            this.btnUrediArtikl.Location = new System.Drawing.Point(226, 31);
            this.btnUrediArtikl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUrediArtikl.Name = "btnUrediArtikl";
            this.btnUrediArtikl.Size = new System.Drawing.Size(137, 37);
            this.btnUrediArtikl.TabIndex = 0;
            this.btnUrediArtikl.Text = "Uredi artikl";
            this.btnUrediArtikl.UseVisualStyleBackColor = true;
            this.btnUrediArtikl.Click += new System.EventHandler(this.btnUrediArtikl_Click);
            // 
            // btnDodajArtikl
            // 
            this.btnDodajArtikl.ForeColor = System.Drawing.Color.Black;
            this.btnDodajArtikl.Location = new System.Drawing.Point(38, 31);
            this.btnDodajArtikl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDodajArtikl.Name = "btnDodajArtikl";
            this.btnDodajArtikl.Size = new System.Drawing.Size(137, 37);
            this.btnDodajArtikl.TabIndex = 0;
            this.btnDodajArtikl.Text = "Dodaj artikl";
            this.btnDodajArtikl.UseVisualStyleBackColor = true;
            this.btnDodajArtikl.Click += new System.EventHandler(this.btnDodajArtikl_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Impresso_Expresso.Properties.Resources.logo_banner;
            this.pictureBox1.Location = new System.Drawing.Point(116, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmUpravljanjeArtiklom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(34)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(586, 449);
            this.Controls.Add(this.gbUpravljanjeArtiklima);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmUpravljanjeArtiklom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUpravljanjeArtiklom";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmUpravljanjeArtiklom_KeyDown);
            this.gbUpravljanjeArtiklima.ResumeLayout(false);
            this.gbUpravljanjeArtiklima.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisArtikala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbUpravljanjeArtiklima;
        private System.Windows.Forms.Label lblPopisArtikala;
        private System.Windows.Forms.Label lblPopisKategorija;
        private System.Windows.Forms.Button btnObrišiArtikl;
        private System.Windows.Forms.Button btnUrediArtikl;
        private System.Windows.Forms.Button btnDodajArtikl;
        private System.Windows.Forms.ListBox lbPopisKategorija;
        private System.Windows.Forms.BindingSource kategorijeBindingSource;
        private System.Windows.Forms.BindingSource artikliBindingSource;
        private System.Windows.Forms.DataGridView dgvPopisArtikala;
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