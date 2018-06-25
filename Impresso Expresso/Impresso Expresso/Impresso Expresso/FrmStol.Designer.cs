namespace Impresso_Expresso
{
    partial class FrmStol
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
            this.dgvPrikazNarudzba = new System.Windows.Forms.DataGridView();
            this.btnRacun = new System.Windows.Forms.Button();
            this.gbIzbor = new System.Windows.Forms.GroupBox();
            this.pbUkloni = new System.Windows.Forms.PictureBox();
            this.btnMeni = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._18018_DBDataSet = new Impresso_Expresso._18018_DBDataSet();
            this.cbOdaberiNarudžbu = new System.Windows.Forms.ComboBox();
            this.lblOdaberiNarudzbu = new System.Windows.Forms.Label();
            this.lbNarudzbeZaRacun = new System.Windows.Forms.ListBox();
            this.lblListBoxNarudzbe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazNarudzba)).BeginInit();
            this.gbIzbor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUkloni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._18018_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrikazNarudzba
            // 
            this.dgvPrikazNarudzba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikazNarudzba.Location = new System.Drawing.Point(44, 139);
            this.dgvPrikazNarudzba.Name = "dgvPrikazNarudzba";
            this.dgvPrikazNarudzba.Size = new System.Drawing.Size(524, 379);
            this.dgvPrikazNarudzba.TabIndex = 1;
            // 
            // btnRacun
            // 
            this.btnRacun.Location = new System.Drawing.Point(594, 139);
            this.btnRacun.Name = "btnRacun";
            this.btnRacun.Size = new System.Drawing.Size(107, 35);
            this.btnRacun.TabIndex = 2;
            this.btnRacun.Text = "Ispisi racun";
            this.btnRacun.UseVisualStyleBackColor = true;
            this.btnRacun.Click += new System.EventHandler(this.btnRacun_Click_1);
            // 
            // gbIzbor
            // 
            this.gbIzbor.Controls.Add(this.pbUkloni);
            this.gbIzbor.Controls.Add(this.btnMeni);
            this.gbIzbor.Location = new System.Drawing.Point(574, 357);
            this.gbIzbor.Name = "gbIzbor";
            this.gbIzbor.Size = new System.Drawing.Size(148, 161);
            this.gbIzbor.TabIndex = 3;
            this.gbIzbor.TabStop = false;
            // 
            // pbUkloni
            // 
            this.pbUkloni.Image = global::Impresso_Expresso.Properties.Resources.brisiNarudzbe;
            this.pbUkloni.Location = new System.Drawing.Point(32, 66);
            this.pbUkloni.Name = "pbUkloni";
            this.pbUkloni.Size = new System.Drawing.Size(82, 78);
            this.pbUkloni.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUkloni.TabIndex = 1;
            this.pbUkloni.TabStop = false;
            this.pbUkloni.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbUkloni_MouseClick);
            this.pbUkloni.MouseEnter += new System.EventHandler(this.pbUkloni_MouseEnter);
            this.pbUkloni.MouseLeave += new System.EventHandler(this.pbUkloni_MouseLeave);
            // 
            // btnMeni
            // 
            this.btnMeni.Location = new System.Drawing.Point(20, 19);
            this.btnMeni.Name = "btnMeni";
            this.btnMeni.Size = new System.Drawing.Size(107, 37);
            this.btnMeni.TabIndex = 0;
            this.btnMeni.Text = "Meni";
            this.btnMeni.UseVisualStyleBackColor = true;
            this.btnMeni.Click += new System.EventHandler(this.btnMeni_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Impresso_Expresso.Properties.Resources.logo_banner;
            this.pictureBox1.Location = new System.Drawing.Point(155, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // _18018_DBDataSet
            // 
            this._18018_DBDataSet.DataSetName = "_18018_DBDataSet";
            this._18018_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbOdaberiNarudžbu
            // 
            this.cbOdaberiNarudžbu.FormattingEnabled = true;
            this.cbOdaberiNarudžbu.Location = new System.Drawing.Point(461, 112);
            this.cbOdaberiNarudžbu.Name = "cbOdaberiNarudžbu";
            this.cbOdaberiNarudžbu.Size = new System.Drawing.Size(107, 21);
            this.cbOdaberiNarudžbu.TabIndex = 4;
            // 
            // lblOdaberiNarudzbu
            // 
            this.lblOdaberiNarudzbu.AutoSize = true;
            this.lblOdaberiNarudzbu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdaberiNarudzbu.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblOdaberiNarudzbu.Location = new System.Drawing.Point(234, 113);
            this.lblOdaberiNarudzbu.Name = "lblOdaberiNarudzbu";
            this.lblOdaberiNarudzbu.Size = new System.Drawing.Size(221, 20);
            this.lblOdaberiNarudzbu.TabIndex = 5;
            this.lblOdaberiNarudzbu.Text = "Odaberite narudžbu za prikaz:";
            // 
            // lbNarudzbeZaRacun
            // 
            this.lbNarudzbeZaRacun.FormattingEnabled = true;
            this.lbNarudzbeZaRacun.Location = new System.Drawing.Point(597, 204);
            this.lbNarudzbeZaRacun.Name = "lbNarudzbeZaRacun";
            this.lbNarudzbeZaRacun.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbNarudzbeZaRacun.Size = new System.Drawing.Size(107, 147);
            this.lbNarudzbeZaRacun.TabIndex = 6;
            // 
            // lblListBoxNarudzbe
            // 
            this.lblListBoxNarudzbe.AutoSize = true;
            this.lblListBoxNarudzbe.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblListBoxNarudzbe.Location = new System.Drawing.Point(574, 188);
            this.lblListBoxNarudzbe.Name = "lblListBoxNarudzbe";
            this.lblListBoxNarudzbe.Size = new System.Drawing.Size(157, 13);
            this.lblListBoxNarudzbe.TabIndex = 7;
            this.lblListBoxNarudzbe.Text = "Odaberite narudžbe za plaćanje";
            // 
            // FrmStol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(34)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblListBoxNarudzbe);
            this.Controls.Add(this.lbNarudzbeZaRacun);
            this.Controls.Add(this.lblOdaberiNarudzbu);
            this.Controls.Add(this.cbOdaberiNarudžbu);
            this.Controls.Add(this.gbIzbor);
            this.Controls.Add(this.btnRacun);
            this.Controls.Add(this.dgvPrikazNarudzba);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmStol";
            this.Text = "FrmStol";
            this.Activated += new System.EventHandler(this.FrmStol_Activated);
            this.Load += new System.EventHandler(this.FrmStol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazNarudzba)).EndInit();
            this.gbIzbor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUkloni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._18018_DBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvPrikazNarudzba;
        private System.Windows.Forms.Button btnRacun;
        private System.Windows.Forms.GroupBox gbIzbor;
        private System.Windows.Forms.PictureBox pbUkloni;
        private System.Windows.Forms.Button btnMeni;
        private _18018_DBDataSet _18018_DBDataSet;
        private System.Windows.Forms.ComboBox cbOdaberiNarudžbu;
        private System.Windows.Forms.Label lblOdaberiNarudzbu;
        private System.Windows.Forms.ListBox lbNarudzbeZaRacun;
        private System.Windows.Forms.Label lblListBoxNarudzbe;
    }
}