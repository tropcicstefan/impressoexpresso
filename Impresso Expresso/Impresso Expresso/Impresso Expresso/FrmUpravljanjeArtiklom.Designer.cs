﻿namespace Impresso_Expresso
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
            this.gbUpravljanjeArtiklima = new System.Windows.Forms.GroupBox();
            this.lblPopisArtikala = new System.Windows.Forms.Label();
            this.lblPopisKategorija = new System.Windows.Forms.Label();
            this.btnObrišiArtikl = new System.Windows.Forms.Button();
            this.btnUrediArtikl = new System.Windows.Forms.Button();
            this.btnDodajArtikl = new System.Windows.Forms.Button();
            this.dgvPopisArtikala = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbPopisKategorija = new System.Windows.Forms.ListBox();
            this.gbUpravljanjeArtiklima.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisArtikala)).BeginInit();
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
            this.gbUpravljanjeArtiklima.Location = new System.Drawing.Point(12, 86);
            this.gbUpravljanjeArtiklima.Name = "gbUpravljanjeArtiklima";
            this.gbUpravljanjeArtiklima.Size = new System.Drawing.Size(758, 455);
            this.gbUpravljanjeArtiklima.TabIndex = 1;
            this.gbUpravljanjeArtiklima.TabStop = false;
            this.gbUpravljanjeArtiklima.Text = "Upravljanje artiklima";
            // 
            // lblPopisArtikala
            // 
            this.lblPopisArtikala.AutoSize = true;
            this.lblPopisArtikala.Location = new System.Drawing.Point(298, 103);
            this.lblPopisArtikala.Name = "lblPopisArtikala";
            this.lblPopisArtikala.Size = new System.Drawing.Size(97, 17);
            this.lblPopisArtikala.TabIndex = 2;
            this.lblPopisArtikala.Text = "Popis artikala:";
            // 
            // lblPopisKategorija
            // 
            this.lblPopisKategorija.AutoSize = true;
            this.lblPopisKategorija.Location = new System.Drawing.Point(48, 103);
            this.lblPopisKategorija.Name = "lblPopisKategorija";
            this.lblPopisKategorija.Size = new System.Drawing.Size(113, 17);
            this.lblPopisKategorija.TabIndex = 2;
            this.lblPopisKategorija.Text = "Popis kategorija:";
            // 
            // btnObrišiArtikl
            // 
            this.btnObrišiArtikl.ForeColor = System.Drawing.Color.Black;
            this.btnObrišiArtikl.Location = new System.Drawing.Point(551, 38);
            this.btnObrišiArtikl.Name = "btnObrišiArtikl";
            this.btnObrišiArtikl.Size = new System.Drawing.Size(183, 46);
            this.btnObrišiArtikl.TabIndex = 0;
            this.btnObrišiArtikl.Text = "Obriši artikl";
            this.btnObrišiArtikl.UseVisualStyleBackColor = true;
            // 
            // btnUrediArtikl
            // 
            this.btnUrediArtikl.ForeColor = System.Drawing.Color.Black;
            this.btnUrediArtikl.Location = new System.Drawing.Point(301, 38);
            this.btnUrediArtikl.Name = "btnUrediArtikl";
            this.btnUrediArtikl.Size = new System.Drawing.Size(183, 46);
            this.btnUrediArtikl.TabIndex = 0;
            this.btnUrediArtikl.Text = "Uredi artikl";
            this.btnUrediArtikl.UseVisualStyleBackColor = true;
            // 
            // btnDodajArtikl
            // 
            this.btnDodajArtikl.ForeColor = System.Drawing.Color.Black;
            this.btnDodajArtikl.Location = new System.Drawing.Point(51, 38);
            this.btnDodajArtikl.Name = "btnDodajArtikl";
            this.btnDodajArtikl.Size = new System.Drawing.Size(183, 46);
            this.btnDodajArtikl.TabIndex = 0;
            this.btnDodajArtikl.Text = "Dodaj artikl";
            this.btnDodajArtikl.UseVisualStyleBackColor = true;
            // 
            // dgvPopisArtikala
            // 
            this.dgvPopisArtikala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisArtikala.Location = new System.Drawing.Point(301, 133);
            this.dgvPopisArtikala.Name = "dgvPopisArtikala";
            this.dgvPopisArtikala.RowTemplate.Height = 24;
            this.dgvPopisArtikala.Size = new System.Drawing.Size(432, 291);
            this.dgvPopisArtikala.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Impresso_Expresso.Properties.Resources.logo_banner;
            this.pictureBox1.Location = new System.Drawing.Point(155, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbPopisKategorija
            // 
            this.lbPopisKategorija.FormattingEnabled = true;
            this.lbPopisKategorija.ItemHeight = 16;
            this.lbPopisKategorija.Location = new System.Drawing.Point(51, 133);
            this.lbPopisKategorija.Name = "lbPopisKategorija";
            this.lbPopisKategorija.Size = new System.Drawing.Size(183, 292);
            this.lbPopisKategorija.TabIndex = 1;
            // 
            // FrmUpravljanjeArtiklom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(34)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.gbUpravljanjeArtiklima);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmUpravljanjeArtiklom";
            this.Text = "FrmUpravljanjeArtiklom";
            this.gbUpravljanjeArtiklima.ResumeLayout(false);
            this.gbUpravljanjeArtiklima.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisArtikala)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvPopisArtikala;
        private System.Windows.Forms.ListBox lbPopisKategorija;
    }
}