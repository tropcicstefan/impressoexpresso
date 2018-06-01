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
            this.pbUkloni = new System.Windows.Forms.PictureBox();
            this.btnMeni = new System.Windows.Forms.Button();
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
            this.dataGridView1.Location = new System.Drawing.Point(59, 171);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(699, 466);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnRacun
            // 
            this.btnRacun.Location = new System.Drawing.Point(792, 171);
            this.btnRacun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRacun.Name = "btnRacun";
            this.btnRacun.Size = new System.Drawing.Size(143, 43);
            this.btnRacun.TabIndex = 2;
            this.btnRacun.Text = "Ispisi racun";
            this.btnRacun.UseVisualStyleBackColor = true;
            // 
            // gbIzbor
            // 
            this.gbIzbor.Controls.Add(this.pbUkloni);
            this.gbIzbor.Controls.Add(this.btnMeni);
            this.gbIzbor.Location = new System.Drawing.Point(765, 439);
            this.gbIzbor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbIzbor.Name = "gbIzbor";
            this.gbIzbor.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbIzbor.Size = new System.Drawing.Size(197, 198);
            this.gbIzbor.TabIndex = 3;
            this.gbIzbor.TabStop = false;
            // 
            // pbUkloni
            // 
            this.pbUkloni.Location = new System.Drawing.Point(43, 81);
            this.pbUkloni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbUkloni.Name = "pbUkloni";
            this.pbUkloni.Size = new System.Drawing.Size(109, 96);
            this.pbUkloni.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUkloni.TabIndex = 1;
            this.pbUkloni.TabStop = false;
            // 
            // btnMeni
            // 
            this.btnMeni.Location = new System.Drawing.Point(27, 23);
            this.btnMeni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMeni.Name = "btnMeni";
            this.btnMeni.Size = new System.Drawing.Size(143, 46);
            this.btnMeni.TabIndex = 0;
            this.btnMeni.Text = "Meni";
            this.btnMeni.UseVisualStyleBackColor = true;
            this.btnMeni.Click += new System.EventHandler(this.btnMeni_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Impresso_Expresso.Properties.Resources.logo_banner;
            this.pictureBox1.Location = new System.Drawing.Point(207, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmStol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(34)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.gbIzbor);
            this.Controls.Add(this.btnRacun);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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