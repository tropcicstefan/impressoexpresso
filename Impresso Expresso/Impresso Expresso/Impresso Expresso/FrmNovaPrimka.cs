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
        public FrmNovaPrimka()
        {
            InitializeComponent();
        }
        /// <summary>
        /// rukuje događajem klika na gumb pohrani
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPohrani_Click(object sender, EventArgs e)
        {
            using(var db = new Entities())
            {
                Primke primka = new Primke
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
        }

        
        /// <summary>
        /// priprema podatke za formu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmDodajPrimku_Load(object sender, EventArgs e)
        {
            PrikaziDobavljace();
            PrikaziKorisnike();
        }

          
    }
}
