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
    public partial class FrmNovaPrimka : Form
    {
        private bool nova = true;
        private Primke primka;

        public FrmNovaPrimka()
        {
            InitializeComponent();
        }
        public FrmNovaPrimka(Primke poslanaPrimka)
        {
            InitializeComponent();
            primka = poslanaPrimka;
            nova = false;
            PrikaziStavkePrimki();
        }
        /// <summary>
        /// priprema podatke za formu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmNovaPrimka_Load(object sender, EventArgs e)
        {
            PrikaziDobavljace();
            PrikaziKorisnike();
            PrikaziArtikle();
            PrikaziKolicinu();
            PrikaziDatum();
        }

        #region Prikazi
        /// <summary>
        /// dohvaća popis dobavljača za combobox
        /// </summary>
        private void PrikaziDobavljace()
        {
            BindingList<Dobavljaci> listaDobavljaca = null;
            using (var db = new Entities())
            {
                listaDobavljaca = new BindingList<Dobavljaci>(db.Dobavljacis.ToList());
            }
            cbDobavljac.DataSource = listaDobavljaca;
            cbDobavljac.DisplayMember = "Naziv";
            cbDobavljac.ValueMember = "ID";
            cbDobavljac.SelectedIndex = -1;
            if (!nova)
            {
                cbDobavljac.SelectedValue = primka.DobavljacID;
                
            }
        }
        /// <summary>
        /// dohvaća popis korisnika za combobox
        /// </summary>
        private void PrikaziKorisnike()
        {
            BindingList<Korisnici> listaKorisnika = null;
            using (var db = new Entities())
            {
                listaKorisnika = new BindingList<Korisnici>(db.Korisnicis.ToList());
            }
            cbKorisnik.DataSource = listaKorisnika;
            cbKorisnik.DisplayMember = "KorisnickoIme";
            cbKorisnik.ValueMember = "ID";
            cbKorisnik.SelectedIndex = -1;
            if (!nova)
            {
                cbKorisnik.SelectedValue = primka.KorisnikID;
            }
        }

        /// <summary>
        /// dohvaća popis Artikala za combobox
        /// </summary>
        private void PrikaziArtikle()
        {
            BindingList<Artikli> listaArtikla = null;
            using (var db = new Entities())
            {
                listaArtikla = new BindingList<Artikli>(db.Artiklis.ToList());
            }
            cbArtikl.DataSource = listaArtikla;
            cbArtikl.DisplayMember = "Naziv";
            cbArtikl.ValueMember = "ID";
            cbArtikl.SelectedIndex = -1;
            if (!nova)
            {
                StavkePrimke privremenaStavkaPrimke = stavkePrimkeBindingSource.Current as StavkePrimke;
                if(privremenaStavkaPrimke != null)
                {
                    cbArtikl.SelectedValue = privremenaStavkaPrimke.ArtiklID;
                }
                
            }
        }
        /// <summary>
        /// Dohvaća listu stavki primke proslijeđene primke i prikazuje u dgv
        /// </summary>
        private void PrikaziStavkePrimki()
        {
            BindingList<StavkePrimke> listaStavkiPrimke = null;
            using (var db = new Entities())
            {
                db.Primkes.Attach(primka);
                listaStavkiPrimke = new BindingList<StavkePrimke>(primka.StavkePrimkes.ToList());
            }
            stavkePrimkeBindingSource.DataSource = listaStavkiPrimke;
        }
        private void PrikaziKolicinu()
        {
            if (!nova)
            {
                StavkePrimke privremenaStavkaPrimke = stavkePrimkeBindingSource.Current as StavkePrimke;
                if (privremenaStavkaPrimke != null)
                {
                    txtKolicina.Text = privremenaStavkaPrimke.Kolicina.ToString();
                }
            }            
        }
        private void PrikaziDatum()
        {
            if (!nova)
            {
                dtpPrimke.Value = primka.DatumIVrijeme;
            }            
        }
        #endregion

      

        #region Pohrani
        /// <summary>
        /// ef za spremanje primke na kojoj se radi
        /// </summary>
        private void PohraniPrimku()
        {
            using (var db = new Entities())
            {
                primka = new Primke
                {
                    DobavljacID = int.Parse(cbDobavljac.SelectedValue.ToString()),
                    KorisnikID = int.Parse(cbKorisnik.SelectedValue.ToString()),
                    DatumIVrijeme = dtpPrimke.Value
                };
                db.Primkes.Add(primka);
                db.SaveChanges();
            }
        }
        /// <summary>
        /// ef za spremanje stavkeprimke, primke na kojoj se radi
        /// </summary>
        private void PohraniStavkuPrimke()
        {
            using (var db = new Entities())
            {
                db.Primkes.Attach(primka);
                StavkePrimke stavka = new StavkePrimke
                {
                    ArtiklID = int.Parse(cbArtikl.SelectedValue.ToString()),
                    Kolicina = int.Parse(txtKolicina.Text),
                    Primke = primka

                };
                db.StavkePrimkes.Add(stavka);
                db.SaveChanges();
            }
        }
        #endregion
        private void BlokirajPromjene()
        {
            cbDobavljac.Enabled = false;
            cbKorisnik.Enabled = false;
            dtpPrimke.Enabled = false;
        }

        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            if (nova)
            {
                PohraniPrimku();
                nova = false;
            }
            PohraniStavkuPrimke();
            PrikaziStavkePrimki();
            BlokirajPromjene();
        }

        
    }
}
