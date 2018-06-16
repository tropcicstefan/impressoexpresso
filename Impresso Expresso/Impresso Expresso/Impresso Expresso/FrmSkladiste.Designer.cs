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
            this.dgvStanjeSkladišta = new System.Windows.Forms.DataGridView();
            this.btnUnosArtikla = new System.Windows.Forms.Button();
            this.btnPrimka = new System.Windows.Forms.Button();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbstanjeNaSkladistu = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStanjeSkladišta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbstanjeNaSkladistu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStanjeSkladišta
            // 
            this.dgvStanjeSkladišta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStanjeSkladišta.Location = new System.Drawing.Point(22, 103);
            this.dgvStanjeSkladišta.Name = "dgvStanjeSkladišta";
            this.dgvStanjeSkladišta.Size = new System.Drawing.Size(708, 254);
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
            this.btnPrimka.Text = "Primka";
            this.btnPrimka.UseVisualStyleBackColor = true;
            this.btnPrimka.Click += new System.EventHandler(this.btnPrimka_Click);
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(609, 52);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(121, 21);
            this.cbFilter.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Impresso_Expresso.Properties.Resources.logo_banner;
            this.pictureBox1.Location = new System.Drawing.Point(364, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // gbstanjeNaSkladistu
            // 
            this.gbstanjeNaSkladistu.Controls.Add(this.cbFilter);
            this.gbstanjeNaSkladistu.Controls.Add(this.btnPrimka);
            this.gbstanjeNaSkladistu.Controls.Add(this.btnUnosArtikla);
            this.gbstanjeNaSkladistu.Controls.Add(this.dgvStanjeSkladišta);
            this.gbstanjeNaSkladistu.ForeColor = System.Drawing.Color.White;
            this.gbstanjeNaSkladistu.Location = new System.Drawing.Point(33, 151);
            this.gbstanjeNaSkladistu.Name = "gbstanjeNaSkladistu";
            this.gbstanjeNaSkladistu.Size = new System.Drawing.Size(758, 376);
            this.gbstanjeNaSkladistu.TabIndex = 6;
            this.gbstanjeNaSkladistu.TabStop = false;
            this.gbstanjeNaSkladistu.Text = "Stanje na skladištu";
            // 
            // FrmSkladiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(34)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(823, 550);
            this.Controls.Add(this.gbstanjeNaSkladistu);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmSkladiste";
            this.Text = "FrmSkladiste";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStanjeSkladišta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbstanjeNaSkladistu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvStanjeSkladišta;
        private System.Windows.Forms.Button btnUnosArtikla;
        private System.Windows.Forms.Button btnPrimka;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbstanjeNaSkladistu;
    }
}