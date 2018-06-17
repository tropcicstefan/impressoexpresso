using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Impresso_Expresso
{
    public partial class FrmSkladiste : Form
    {
        public FrmSkladiste()
        {
            InitializeComponent();
        }
        private void FrmSkladiste_Load(object sender, EventArgs e)
        {
            PrikaziArtikle();
        }

        /// <summary>
        /// Metoda instancira i poziva formu FrmPrimka
        /// </summary>        
        private void btnPrimka_Click(object sender, EventArgs e)
        {
            FrmPopisPrimki formaPrimka = new FrmPopisPrimki();
            formaPrimka.ShowDialog();
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
            artikliBindingSource.DataSource = listaArtikala;
        }

        
    }
}
