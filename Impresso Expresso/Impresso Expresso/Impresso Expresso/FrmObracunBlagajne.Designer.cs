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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
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
            this.txtGotovinaUBlagajni = new System.Windows.Forms.TextBox();
            this.lblGotovinaUBlagajni = new System.Windows.Forms.Label();
            this.txtIzradioKonobar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPologUBlagajni = new System.Windows.Forms.TextBox();
            this.lblPolog = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.btnTransakcije = new System.Windows.Forms.Button();
            this.btnObracunBlagajne = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.IzvjestajiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbDnevniIzvještaj.SuspendLayout();
            this.gbNacinPlacanja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IzvjestajiBindingSource)).BeginInit();
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
            this.gbDnevniIzvještaj.Controls.Add(this.txtGotovinaUBlagajni);
            this.gbDnevniIzvještaj.Controls.Add(this.lblGotovinaUBlagajni);
            this.gbDnevniIzvještaj.Controls.Add(this.txtIzradioKonobar);
            this.gbDnevniIzvještaj.Controls.Add(this.label1);
            this.gbDnevniIzvještaj.Controls.Add(this.txtPologUBlagajni);
            this.gbDnevniIzvještaj.Controls.Add(this.lblPolog);
            this.gbDnevniIzvještaj.Controls.Add(this.txtDatum);
            this.gbDnevniIzvještaj.Controls.Add(this.lblDatum);
            this.gbDnevniIzvještaj.ForeColor = System.Drawing.Color.White;
            this.gbDnevniIzvještaj.Location = new System.Drawing.Point(155, 106);
            this.gbDnevniIzvještaj.Name = "gbDnevniIzvještaj";
            this.gbDnevniIzvještaj.Size = new System.Drawing.Size(460, 389);
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
            this.gbNacinPlacanja.Location = new System.Drawing.Point(47, 234);
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
            // txtGotovinaUBlagajni
            // 
            this.txtGotovinaUBlagajni.Location = new System.Drawing.Point(191, 87);
            this.txtGotovinaUBlagajni.Name = "txtGotovinaUBlagajni";
            this.txtGotovinaUBlagajni.Size = new System.Drawing.Size(194, 22);
            this.txtGotovinaUBlagajni.TabIndex = 3;
            // 
            // lblGotovinaUBlagajni
            // 
            this.lblGotovinaUBlagajni.AutoSize = true;
            this.lblGotovinaUBlagajni.ForeColor = System.Drawing.Color.White;
            this.lblGotovinaUBlagajni.Location = new System.Drawing.Point(59, 87);
            this.lblGotovinaUBlagajni.Name = "lblGotovinaUBlagajni";
            this.lblGotovinaUBlagajni.Size = new System.Drawing.Size(134, 17);
            this.lblGotovinaUBlagajni.TabIndex = 2;
            this.lblGotovinaUBlagajni.Text = "Gotovina u blagajni:";
            // 
            // txtIzradioKonobar
            // 
            this.txtIzradioKonobar.Location = new System.Drawing.Point(191, 168);
            this.txtIzradioKonobar.Name = "txtIzradioKonobar";
            this.txtIzradioKonobar.Size = new System.Drawing.Size(194, 22);
            this.txtIzradioKonobar.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Izradio Konobar";
            // 
            // txtPologUBlagajni
            // 
            this.txtPologUBlagajni.Location = new System.Drawing.Point(191, 127);
            this.txtPologUBlagajni.Name = "txtPologUBlagajni";
            this.txtPologUBlagajni.Size = new System.Drawing.Size(194, 22);
            this.txtPologUBlagajni.TabIndex = 3;
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
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(191, 43);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(194, 22);
            this.txtDatum.TabIndex = 3;
            // 
            // btnTransakcije
            // 
            this.btnTransakcije.Location = new System.Drawing.Point(652, 394);
            this.btnTransakcije.Name = "btnTransakcije";
            this.btnTransakcije.Size = new System.Drawing.Size(95, 42);
            this.btnTransakcije.TabIndex = 4;
            this.btnTransakcije.Text = "Transakcije";
            this.btnTransakcije.UseVisualStyleBackColor = true;
            this.btnTransakcije.Click += new System.EventHandler(this.btnTransakcije_Click);
            // 
            // btnObracunBlagajne
            // 
            this.btnObracunBlagajne.Location = new System.Drawing.Point(652, 454);
            this.btnObracunBlagajne.Name = "btnObracunBlagajne";
            this.btnObracunBlagajne.Size = new System.Drawing.Size(95, 42);
            this.btnObracunBlagajne.TabIndex = 4;
            this.btnObracunBlagajne.Text = "Obračun";
            this.btnObracunBlagajne.UseVisualStyleBackColor = true;
            this.btnObracunBlagajne.Click += new System.EventHandler(this.btnObracunBlagajne_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetIzvjestaja";
            reportDataSource1.Value = this.IzvjestajiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Impresso_Expresso.DnevniIzvjestaj.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(39, 526);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(708, 390);
            this.reportViewer1.TabIndex = 5;
            // 
            // IzvjestajiBindingSource
            // 
            this.IzvjestajiBindingSource.DataSource = typeof(Impresso_Expresso.Izvjestaji);
            // 
            // FrmObracunBlagajne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(34)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(782, 937);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnObracunBlagajne);
            this.Controls.Add(this.btnTransakcije);
            this.Controls.Add(this.gbDnevniIzvještaj);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmObracunBlagajne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmObracunBlagajne";
            this.Load += new System.EventHandler(this.FrmObracunBlagajne_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbDnevniIzvještaj.ResumeLayout(false);
            this.gbDnevniIzvještaj.PerformLayout();
            this.gbNacinPlacanja.ResumeLayout(false);
            this.gbNacinPlacanja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IzvjestajiBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox txtPologUBlagajni;
        private System.Windows.Forms.Label lblPolog;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Button btnTransakcije;
        private System.Windows.Forms.Button btnObracunBlagajne;
        private System.Windows.Forms.TextBox txtGotovinaUBlagajni;
        private System.Windows.Forms.Label lblGotovinaUBlagajni;
        private System.Windows.Forms.TextBox txtIzradioKonobar;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource IzvjestajiBindingSource;
    }
}