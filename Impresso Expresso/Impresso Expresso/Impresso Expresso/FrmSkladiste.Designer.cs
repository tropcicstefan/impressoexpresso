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
            this.lblStanje = new System.Windows.Forms.Label();
            this.dgvStanjeSkladišta = new System.Windows.Forms.DataGridView();
            this.btnUnosArtikla = new System.Windows.Forms.Button();
            this.btnPrimka = new System.Windows.Forms.Button();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStanjeSkladišta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStanje
            // 
            this.lblStanje.AutoSize = true;
            this.lblStanje.Location = new System.Drawing.Point(62, 142);
            this.lblStanje.Name = "lblStanje";
            this.lblStanje.Size = new System.Drawing.Size(99, 13);
            this.lblStanje.TabIndex = 0;
            this.lblStanje.Text = "Stanje na skladištu:";
            // 
            // dgvStanjeSkladišta
            // 
            this.dgvStanjeSkladišta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStanjeSkladišta.Location = new System.Drawing.Point(55, 175);
            this.dgvStanjeSkladišta.Name = "dgvStanjeSkladišta";
            this.dgvStanjeSkladišta.Size = new System.Drawing.Size(708, 254);
            this.dgvStanjeSkladišta.TabIndex = 1;
            // 
            // btnUnosArtikla
            // 
            this.btnUnosArtikla.Location = new System.Drawing.Point(109, 53);
            this.btnUnosArtikla.Name = "btnUnosArtikla";
            this.btnUnosArtikla.Size = new System.Drawing.Size(75, 23);
            this.btnUnosArtikla.TabIndex = 2;
            this.btnUnosArtikla.Text = "Unos artikla";
            this.btnUnosArtikla.UseVisualStyleBackColor = true;
            // 
            // btnPrimka
            // 
            this.btnPrimka.Location = new System.Drawing.Point(219, 53);
            this.btnPrimka.Name = "btnPrimka";
            this.btnPrimka.Size = new System.Drawing.Size(75, 23);
            this.btnPrimka.TabIndex = 3;
            this.btnPrimka.Text = "Primka";
            this.btnPrimka.UseVisualStyleBackColor = true;
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(642, 142);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(121, 21);
            this.cbFilter.TabIndex = 4;
            // 
            // FrmSkladiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.btnPrimka);
            this.Controls.Add(this.btnUnosArtikla);
            this.Controls.Add(this.dgvStanjeSkladišta);
            this.Controls.Add(this.lblStanje);
            this.Name = "FrmSkladiste";
            this.Text = "FrmSkladiste";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStanjeSkladišta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStanje;
        private System.Windows.Forms.DataGridView dgvStanjeSkladišta;
        private System.Windows.Forms.Button btnUnosArtikla;
        private System.Windows.Forms.Button btnPrimka;
        private System.Windows.Forms.ComboBox cbFilter;
    }
}