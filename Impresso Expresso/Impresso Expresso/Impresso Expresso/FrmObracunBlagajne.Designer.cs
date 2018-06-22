namespace Impresso_Expresso
{
    partial class FrmObracunBlagajne
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDatum = new System.Windows.Forms.Label();
            this.gbDnevniIzvještaj = new System.Windows.Forms.GroupBox();
            this.gbNacinPlacanja = new System.Windows.Forms.GroupBox();
            this.lblIznos = new System.Windows.Forms.Label();
            this.txtKartica = new System.Windows.Forms.TextBox();
            this.lblKartica = new System.Windows.Forms.Label();
            this.txtNovcanica = new System.Windows.Forms.TextBox();
            this.lblNovcanica = new System.Windows.Forms.Label();
            this.txtKonobar = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblKonobar = new System.Windows.Forms.Label();
            this.lblGotovinaUBlagajni = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblPolog = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPrometBlagajne = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbDnevniIzvještaj.SuspendLayout();
            this.gbNacinPlacanja.SuspendLayout();
            this.SuspendLayout();
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(783, 99);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(8, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.ForeColor = System.Drawing.Color.White;
            this.lblDatum.Location = new System.Drawing.Point(59, 43);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(53, 17);
            this.lblDatum.TabIndex = 2;
            this.lblDatum.Text = "Datum:";
            // 
            // gbDnevniIzvještaj
            // 
            this.gbDnevniIzvještaj.Controls.Add(this.gbNacinPlacanja);
            this.gbDnevniIzvještaj.Controls.Add(this.txtKonobar);
            this.gbDnevniIzvještaj.Controls.Add(this.textBox3);
            this.gbDnevniIzvještaj.Controls.Add(this.lblKonobar);
            this.gbDnevniIzvještaj.Controls.Add(this.lblGotovinaUBlagajni);
            this.gbDnevniIzvještaj.Controls.Add(this.textBox2);
            this.gbDnevniIzvještaj.Controls.Add(this.lblPolog);
            this.gbDnevniIzvještaj.Controls.Add(this.textBox1);
            this.gbDnevniIzvještaj.Controls.Add(this.lblPrometBlagajne);
            this.gbDnevniIzvještaj.Controls.Add(this.txtDatum);
            this.gbDnevniIzvještaj.Controls.Add(this.lblDatum);
            this.gbDnevniIzvještaj.ForeColor = System.Drawing.Color.White;
            this.gbDnevniIzvještaj.Location = new System.Drawing.Point(155, 106);
            this.gbDnevniIzvještaj.Name = "gbDnevniIzvještaj";
            this.gbDnevniIzvještaj.Size = new System.Drawing.Size(460, 430);
            this.gbDnevniIzvještaj.TabIndex = 3;
            this.gbDnevniIzvještaj.TabStop = false;
            this.gbDnevniIzvještaj.Text = "Dnevni izvještaj";
            // 
            // gbNacinPlacanja
            // 
            this.gbNacinPlacanja.Controls.Add(this.lblIznos);
            this.gbNacinPlacanja.Controls.Add(this.txtKartica);
            this.gbNacinPlacanja.Controls.Add(this.lblKartica);
            this.gbNacinPlacanja.Controls.Add(this.txtNovcanica);
            this.gbNacinPlacanja.Controls.Add(this.lblNovcanica);
            this.gbNacinPlacanja.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbNacinPlacanja.Location = new System.Drawing.Point(48, 285);
            this.gbNacinPlacanja.Name = "gbNacinPlacanja";
            this.gbNacinPlacanja.Size = new System.Drawing.Size(372, 116);
            this.gbNacinPlacanja.TabIndex = 4;
            this.gbNacinPlacanja.TabStop = false;
            this.gbNacinPlacanja.Text = "Način plačanja";
            // 
            // lblIznos
            // 
            this.lblIznos.AutoSize = true;
            this.lblIznos.Location = new System.Drawing.Point(214, 16);
            this.lblIznos.Name = "lblIznos";
            this.lblIznos.Size = new System.Drawing.Size(41, 17);
            this.lblIznos.TabIndex = 4;
            this.lblIznos.Text = "Iznos";
            // 
            // txtKartica
            // 
            this.txtKartica.Location = new System.Drawing.Point(140, 79);
            this.txtKartica.Name = "txtKartica";
            this.txtKartica.Size = new System.Drawing.Size(194, 22);
            this.txtKartica.TabIndex = 3;
            // 
            // lblKartica
            // 
            this.lblKartica.AutoSize = true;
            this.lblKartica.ForeColor = System.Drawing.Color.White;
            this.lblKartica.Location = new System.Drawing.Point(8, 79);
            this.lblKartica.Name = "lblKartica";
            this.lblKartica.Size = new System.Drawing.Size(56, 17);
            this.lblKartica.TabIndex = 2;
            this.lblKartica.Text = "Kartica:";
            // 
            // txtNovcanica
            // 
            this.txtNovcanica.Location = new System.Drawing.Point(140, 36);
            this.txtNovcanica.Name = "txtNovcanica";
            this.txtNovcanica.Size = new System.Drawing.Size(194, 22);
            this.txtNovcanica.TabIndex = 3;
            // 
            // lblNovcanica
            // 
            this.lblNovcanica.AutoSize = true;
            this.lblNovcanica.ForeColor = System.Drawing.Color.White;
            this.lblNovcanica.Location = new System.Drawing.Point(8, 36);
            this.lblNovcanica.Name = "lblNovcanica";
            this.lblNovcanica.Size = new System.Drawing.Size(78, 17);
            this.lblNovcanica.TabIndex = 2;
            this.lblNovcanica.Text = "Novčanica:";
            // 
            // txtKonobar
            // 
            this.txtKonobar.Location = new System.Drawing.Point(191, 217);
            this.txtKonobar.Name = "txtKonobar";
            this.txtKonobar.Size = new System.Drawing.Size(194, 22);
            this.txtKonobar.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(191, 172);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(194, 22);
            this.textBox3.TabIndex = 3;
            // 
            // lblKonobar
            // 
            this.lblKonobar.AutoSize = true;
            this.lblKonobar.ForeColor = System.Drawing.Color.White;
            this.lblKonobar.Location = new System.Drawing.Point(59, 217);
            this.lblKonobar.Name = "lblKonobar";
            this.lblKonobar.Size = new System.Drawing.Size(66, 17);
            this.lblKonobar.TabIndex = 2;
            this.lblKonobar.Text = "Konobar:";
            // 
            // lblGotovinaUBlagajni
            // 
            this.lblGotovinaUBlagajni.AutoSize = true;
            this.lblGotovinaUBlagajni.ForeColor = System.Drawing.Color.White;
            this.lblGotovinaUBlagajni.Location = new System.Drawing.Point(59, 172);
            this.lblGotovinaUBlagajni.Name = "lblGotovinaUBlagajni";
            this.lblGotovinaUBlagajni.Size = new System.Drawing.Size(134, 17);
            this.lblGotovinaUBlagajni.TabIndex = 2;
            this.lblGotovinaUBlagajni.Text = "Gotovina u blagajni:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(191, 127);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(194, 22);
            this.textBox2.TabIndex = 3;
            // 
            // lblPolog
            // 
            this.lblPolog.AutoSize = true;
            this.lblPolog.ForeColor = System.Drawing.Color.White;
            this.lblPolog.Location = new System.Drawing.Point(59, 127);
            this.lblPolog.Name = "lblPolog";
            this.lblPolog.Size = new System.Drawing.Size(118, 17);
            this.lblPolog.TabIndex = 2;
            this.lblPolog.Text = "Polog u blagajnu:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(191, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 22);
            this.textBox1.TabIndex = 3;
            // 
            // lblPrometBlagajne
            // 
            this.lblPrometBlagajne.AutoSize = true;
            this.lblPrometBlagajne.ForeColor = System.Drawing.Color.White;
            this.lblPrometBlagajne.Location = new System.Drawing.Point(59, 87);
            this.lblPrometBlagajne.Name = "lblPrometBlagajne";
            this.lblPrometBlagajne.Size = new System.Drawing.Size(115, 17);
            this.lblPrometBlagajne.TabIndex = 2;
            this.lblPrometBlagajne.Text = "Promet blagajne:";
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(191, 43);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(194, 22);
            this.txtDatum.TabIndex = 3;
            // 
            // FrmObracunBlagajne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(34)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.gbDnevniIzvještaj);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmObracunBlagajne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmObracunBlagajne";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbDnevniIzvještaj.ResumeLayout(false);
            this.gbDnevniIzvještaj.PerformLayout();
            this.gbNacinPlacanja.ResumeLayout(false);
            this.gbNacinPlacanja.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.GroupBox gbDnevniIzvještaj;
        private System.Windows.Forms.GroupBox gbNacinPlacanja;
        private System.Windows.Forms.Label lblIznos;
        private System.Windows.Forms.TextBox txtKartica;
        private System.Windows.Forms.Label lblKartica;
        private System.Windows.Forms.TextBox txtNovcanica;
        private System.Windows.Forms.Label lblNovcanica;
        private System.Windows.Forms.TextBox txtKonobar;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblKonobar;
        private System.Windows.Forms.Label lblGotovinaUBlagajni;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblPolog;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPrometBlagajne;
        private System.Windows.Forms.TextBox txtDatum;
    }
}