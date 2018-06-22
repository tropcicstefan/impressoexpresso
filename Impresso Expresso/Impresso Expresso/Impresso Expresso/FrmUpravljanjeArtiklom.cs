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
    public partial class FrmUpravljanjeArtiklom : Form
    {
        Entities db = new Entities();
        public FrmUpravljanjeArtiklom()
        {
            InitializeComponent();
            kategorijeBindingSource.DataSource = db.Kategorijes.ToList();
            OsvjeziArtikle();
            dgvPopisArtikala.Rows[0].DefaultCellStyle.ForeColor = Color.Gray;
        }
        /// <summary>
        /// Unos novog artikla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodajArtikl_Click(object sender, EventArgs e)
        {
            FrmUnosArtikla formaUnosArtikla = new FrmUnosArtikla();
            formaUnosArtikla.ShowDialog();
        }
        /// <summary>
        /// Ažuriranje artikla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUrediArtikl_Click(object sender, EventArgs e)
        {
            int odabraniArtikl = int.Parse(this.dgvPopisArtikala.SelectedRows[0].Cells[0].Value.ToString());
            FrmUnosArtikla formaUnosArtikla = new FrmUnosArtikla(odabraniArtikl);
            formaUnosArtikla.ShowDialog();
            OsvjeziArtikle();
        }

        #region OsvjezavanjePrikaza
        /// <summary>
        /// Provjera unesenih podataka za prijavu
        /// </summary>
        private  void OsvjeziArtikle()
        {
            Kategorije odabranaKategorija = lbPopisKategorija.SelectedItem as Kategorije;
            if (odabranaKategorija != null)
            {
                List<Artikli> artikliKategorije = db.Artiklis.Where(s => s.KategorijaID == odabranaKategorija.ID).ToList();
                dgvPopisArtikala.DataSource = null;
                dgvPopisArtikala.DataSource = artikliKategorije;
                this.dgvPopisArtikala.DefaultCellStyle.ForeColor = Color.Black;
            }
        }
        

        private void lbPopisKategorija_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.OsvjeziArtikle();
        }
        #endregion
    }
}
