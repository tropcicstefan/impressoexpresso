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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRacun = new System.Windows.Forms.Button();
            this.gbIzbor = new System.Windows.Forms.GroupBox();
            this.btnMeni = new System.Windows.Forms.Button();
            this.pbUkloni = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbIzbor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUkloni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(524, 379);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnRacun
            // 
            this.btnRacun.Location = new System.Drawing.Point(594, 139);
            this.btnRacun.Name = "btnRacun";
            this.btnRacun.Size = new System.Drawing.Size(107, 35);
            this.btnRacun.TabIndex = 2;
            this.btnRacun.Text = "Ispisi racun";
            this.btnRacun.UseVisualStyleBackColor = true;
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
            // btnMeni
            // 
            this.btnMeni.Location = new System.Drawing.Point(20, 19);
            this.btnMeni.Name = "btnMeni";
            this.btnMeni.Size = new System.Drawing.Size(107, 37);
            this.btnMeni.TabIndex = 0;
            this.btnMeni.Text = "Meni";
            this.btnMeni.UseVisualStyleBackColor = true;
            // 
            // pbUkloni
            // 
            this.pbUkloni.Image = global::Impresso_Expresso.Properties.Resources.if_Bin_2202256;
            this.pbUkloni.Location = new System.Drawing.Point(32, 66);
            this.pbUkloni.Name = "pbUkloni";
            this.pbUkloni.Size = new System.Drawing.Size(82, 78);
            this.pbUkloni.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUkloni.TabIndex = 1;
            this.pbUkloni.TabStop = false;
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
            // FrmStol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(34)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gbIzbor);
            this.Controls.Add(this.btnRacun);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmStol";
            this.Text = "FrmStol";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbIzbor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUkloni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRacun;
        private System.Windows.Forms.GroupBox gbIzbor;
        private System.Windows.Forms.PictureBox pbUkloni;
        private System.Windows.Forms.Button btnMeni;
    }
}