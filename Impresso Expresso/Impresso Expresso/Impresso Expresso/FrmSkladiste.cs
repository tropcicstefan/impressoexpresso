using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Impresso_Expresso
{
    public partial class FrmSkladiste : Form
    {
        private enum opcijeSort { ID, AZ, ZA, Najskuplji, Najjeftiniji, Najviše, Najmanje };

        public FrmSkladiste()
        {
            InitializeComponent();
        }
        private void FrmSkladiste_Load(object sender, EventArgs e)
        {
           
            cbOpcijeSort.DataSource = Enum.GetValues(typeof(opcijeSort));
            PrikaziArtikle();
        }

        /// <summary>
        /// Metoda instancira i poziva formu FrmPrimka
        /// </summary>        
        private void btnPrimka_Click(object sender, EventArgs e)
        {
            FrmPopisPrimki formaPrimka = new FrmPopisPrimki();
            formaPrimka.ShowDialog();
            PrikaziArtikle();
        }

        /// <summary>
        /// Dohvaća listu svih artikala i prikazuje ih u dgv
        /// </summary>
        private void PrikaziArtikle()
        {
            BindingList<Artikli> listaArtikala = null;
            using (var db = new Entities())
            {
                listaArtikala = new BindingList<Artikli>(db.Artiklis.ToList());
            }

            artikliBindingSource.DataSource = Sortiraj(listaArtikala);
        }

        private BindingList<Artikli> Sortiraj(BindingList<Artikli> listaArtikala)
        {
            BindingList<Artikli> sortiranaLista = null;
            
            opcijeSort izabranaOpcija = (opcijeSort)cbOpcijeSort.SelectedItem;
            
            switch(izabranaOpcija)
            {
                case opcijeSort.AZ:
                    sortiranaLista = new BindingList<Artikli>(listaArtikala.OrderBy(x => x.Naziv).ToList());
                    break;
                case opcijeSort.ZA:
                    sortiranaLista = new BindingList<Artikli>(listaArtikala.OrderByDescending(x => x.Naziv).ToList());
                    break;
                case opcijeSort.Najjeftiniji:
                    sortiranaLista = new BindingList<Artikli>(listaArtikala.OrderBy(x => x.Cijena).ToList());
                    break;
                case opcijeSort.Najskuplji:
                    sortiranaLista = new BindingList<Artikli>(listaArtikala.OrderByDescending(x => x.Cijena).ToList());
                    break;
                case opcijeSort.Najmanje:
                    sortiranaLista = new BindingList<Artikli>(listaArtikala.OrderBy(x => x.StanjeNaSkladistu).ToList());
                    break;
                case opcijeSort.Najviše:
                    sortiranaLista = new BindingList<Artikli>(listaArtikala.OrderByDescending(x => x.StanjeNaSkladistu).ToList());
                    break;
                default:
                    sortiranaLista =  listaArtikala;
                    break;

            }
            return sortiranaLista;
        }

        private void cbOpcijeSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrikaziArtikle();
        }
    }
}
