using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Impresso_Expresso
{
    public partial class FrmPopisPrimki : Form
    {
        public FrmPopisPrimki()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Dohvaća listu svih primki iz konteksta i prikazuje ih u dgv
        /// </summary>
        private void PrikaziPrimke()
        {
            BindingList<Primke> listaPrimki = null;
            using(var db = new Entities())
            {
                listaPrimki = new BindingList<Primke>(db.Primkes.ToList());
            }
            primkeBindingSource.DataSource = listaPrimki;
        }
        /// <summary>
        /// Dohvaća listu stavki primke proslijeđene primke i prikazuje u dgv
        /// </summary>
        /// <param name="primke"></param>
        private void PrikaziStavkePrimki(Primke primke)
        {
            BindingList<StavkePrimke> listaStavkiPrimke = null;
            using (var db = new Entities())
            {
                db.Primkes.Attach(primke);
                listaStavkiPrimke = new BindingList<StavkePrimke>(primke.StavkePrimkes.ToList());
            }
            stavkePrimkeBindingSource.DataSource = listaStavkiPrimke;
        }
        /// <summary>
        /// Na load forme pozovi metode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrimka_Load(object sender, System.EventArgs e)
        {
            PrikaziPrimke();
            PrikaziStavkePrimki(primkeBindingSource.Current as Primke);
        }
        /// <summary>
        /// Pri događaju promjene selekcije mijenja stavke
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPrimke_SelectionChanged(object sender, System.EventArgs e)
        {
            Primke selektiranaPrimka = primkeBindingSource.Current as Primke;
            if(selektiranaPrimka != null)
            {
                PrikaziStavkePrimki(selektiranaPrimka);
            }
        }

        /// <summary>
        /// otvara formu za upis nove primke
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNovaPrimka_Click(object sender, System.EventArgs e)
        {
            FrmNovaPrimka novaPrimka = new FrmNovaPrimka();
            novaPrimka.ShowDialog();
            PrikaziPrimke();
        }

        
    }
}
