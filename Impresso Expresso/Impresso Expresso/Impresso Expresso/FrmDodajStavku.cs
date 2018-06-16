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
    public partial class FrmDodajStavku : Form
    {
        private Primke selektiranaPrimka;

        public FrmDodajStavku(Primke primka)
        {
            InitializeComponent();
            selektiranaPrimka = primka;
        }

        private void FrmDodajStavku_Load(object sender, EventArgs e)
        {
            PrikaziArtikle();
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
        }

        
        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            using (var db = new Entities())
            {
                StavkePrimke stavka = new StavkePrimke
                {
                    PrimkaID = selektiranaPrimka.ID,
                    ArtiklID = int.Parse(cbArtikl.SelectedValue.ToString()),
                    Kolicina = int.Parse(txtKolicina.Text)

                };
                
                db.StavkePrimkes.Add(stavka);
                db.SaveChanges();
            }
            Close();
        }
    }
}
