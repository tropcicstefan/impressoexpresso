namespace Impresso_Expresso
{
    partial class FrmTransakcija
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUnesiTranskciju = new System.Windows.Forms.Button();
            this.cbTipTransakcije = new System.Windows.Forms.ComboBox();
            this.tipoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbKasa = new System.Windows.Forms.ComboBox();
            this.kaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtIznosTransakcije = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Impresso_Expresso.Properties.Resources.logo_banner;
            this.pictureBox1.Location = new System.Drawing.Point(155, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(101, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stanje blagajne:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUnesiTranskciju);
            this.groupBox1.Controls.Add(this.cbTipTransakcije);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbKasa);
            this.groupBox1.Controls.Add(this.txtIznosTransakcije);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.Snow;
            this.groupBox1.Location = new System.Drawing.Point(155, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 264);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unos transakcije";
            // 
            // btnUnesiTranskciju
            // 
            this.btnUnesiTranskciju.ForeColor = System.Drawing.Color.Black;
            this.btnUnesiTranskciju.Location = new System.Drawing.Point(112, 184);
            this.btnUnesiTranskciju.Name = "btnUnesiTranskciju";
            this.btnUnesiTranskciju.Size = new System.Drawing.Size(276, 34);
            this.btnUnesiTranskciju.TabIndex = 4;
            this.btnUnesiTranskciju.Text = "Unesi ";
            this.btnUnesiTranskciju.UseVisualStyleBackColor = true;
            this.btnUnesiTranskciju.Click += new System.EventHandler(this.btnUnesiTranskciju_Click);
            // 
            // cbTipTransakcije
            // 
            this.cbTipTransakcije.DataSource = this.tipoviBindingSource;
            this.cbTipTransakcije.DisplayMember = "Naziv";
            this.cbTipTransakcije.FormattingEnabled = true;
            this.cbTipTransakcije.Location = new System.Drawing.Point(217, 84);
            this.cbTipTransakcije.Name = "cbTipTransakcije";
            this.cbTipTransakcije.Size = new System.Drawing.Size(171, 24);
            this.cbTipTransakcije.TabIndex = 2;
            this.cbTipTransakcije.ValueMember = "ID";
            // 
            // tipoviBindingSource
            // 
            this.tipoviBindingSource.DataSource = typeof(Impresso_Expresso.Tipovi);
            // 
            // cbKasa
            // 
            this.cbKasa.DataSource = this.kaseBindingSource;
            this.cbKasa.DisplayMember = "StanjeKase";
            this.cbKasa.FormattingEnabled = true;
            this.cbKasa.Location = new System.Drawing.Point(217, 38);
            this.cbKasa.Name = "cbKasa";
            this.cbKasa.Size = new System.Drawing.Size(171, 24);
            this.cbKasa.TabIndex = 1;
            this.cbKasa.ValueMember = "ID";
            // 
            // kaseBindingSource
            // 
            this.kaseBindingSource.DataSource = typeof(Impresso_Expresso.Kase);
            // 
            // txtIznosTransakcije
            // 
            this.txtIznosTransakcije.Location = new System.Drawing.Point(217, 133);
            this.txtIznosTransakcije.Name = "txtIznosTransakcije";
            this.txtIznosTransakcije.Size = new System.Drawing.Size(171, 22);
            this.txtIznosTransakcije.TabIndex = 3;
            this.txtIznosTransakcije.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIznosTransakcije_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(101, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Iznos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(109, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kasa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(101, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tip transakcije:";
            // 
            // FrmTransakcija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(34)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(781, 521);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmTransakcija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTransakcija";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbKasa;
        private System.Windows.Forms.ComboBox cbTipTransakcije;
        private System.Windows.Forms.TextBox txtIznosTransakcije;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUnesiTranskciju;
        private System.Windows.Forms.BindingSource tipoviBindingSource;
        private System.Windows.Forms.BindingSource kaseBindingSource;
    }
}