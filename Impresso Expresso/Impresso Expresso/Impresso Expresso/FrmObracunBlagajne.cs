using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impresso_Expresso
{
    /// <summary>
    /// <author>Rene Maruševec</author>
    /// </summary>
    public partial class FrmObracunBlagajne : Form
    {
        Entities db = new Entities();
        public FrmObracunBlagajne()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Otvaranje forme za unos nove transakcije
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTransakcije_Click(object sender, EventArgs e)
        {
            FrmTransakcija formaTransakcije = new FrmTransakcija();
            formaTransakcije.ShowDialog();
        }
        /// <summary>
        /// Funkcionalnost obračuna blagajne za današnji dan
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnObracunBlagajne_Click(object sender, EventArgs e)
        {
            Korisnici ulogiranKorisnik = FrmPrijava.korisnik;
            IzracunObracuna izracunObracuna = new IzracunObracuna(ulogiranKorisnik);
            izracunObracuna.IzracunIznosaKarticaUBlagajni();
            izracunObracuna.IzracunIznosaGotovineUBlagajni();
            izracunObracuna.IzracunPologa();
            izracunObracuna.UnosIzvjestajaUBazu();
            PrikaziIzvjestaj();
        }

        private void PrikaziIzvjestaj()
        {
            
            DateTime datum = DateTime.Now.Date;
            Izvjestaji izvjestaj = db.Izvjestajis.ToList().OrderByDescending(s => s.Datum).FirstOrDefault();
            Korisnici korisnik = db.Korisnicis.FirstOrDefault(s => s.ID == izvjestaj.KonobarID);
            if (izvjestaj != null)
            {
                txtDatum.Text = izvjestaj.Datum.ToString();
                txtGotovinaUBlagajni.Text = izvjestaj.PrometBlagajne.ToString();
                txtPologUBlagajni.Text = izvjestaj.PologUBlagajni.ToString();
                txtNovcanica.Text = izvjestaj.GotovinaUBlagajni.ToString();
                txtKartica.Text = izvjestaj.IznosKartica.ToString();
                txtIzradioKonobar.Text = korisnik.KorisnickoIme;
            }
        }

        private void FrmObracunBlagajne_Load(object sender, EventArgs e)
        {
            Izvjestaji izvjestaj = db.Izvjestajis.ToList().OrderByDescending(s => s.Datum).FirstOrDefault();
            Korisnici korisnik = db.Korisnicis.FirstOrDefault(s => s.ID == izvjestaj.KonobarID);
            this.reportViewer1.RefreshReport();
            IzvjestajiBindingSource.DataSource = izvjestaj;
        }
    }
}
