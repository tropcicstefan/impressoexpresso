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
    public partial class FrmUnosArtikla : Form
    {
        Entities db = new Entities();
        int idOdabranogArtikla = 0;
        public FrmUnosArtikla()
        {
            InitializeComponent();
            kategorijeBindingSource.DataSource = db.Kategorijes.ToList();
        }
        public FrmUnosArtikla(int ID)
        {
            InitializeComponent();
            idOdabranogArtikla = ID;
            PopunjavanjeElemenataForme();

        }
        #region Popunjavanje Elemenata
        /// <summary>
        /// Popunjavanje elemenata forme za ažuriranje artikala
        /// </summary>
        private void PopunjavanjeElemenataForme()
        {
            kategorijeBindingSource.DataSource = db.Kategorijes.ToList();
            Artikli artikli = db.Artiklis.FirstOrDefault(s => s.ID == idOdabranogArtikla);
            if (artikli != null)
            {
                txtNazivArtikla.Text = artikli.Naziv;
                txtCijenaArtikla.Text = artikli.Cijena.ToString();
                cbKategorijaArtikla.SelectedItem = artikli.KategorijaID;
            }
            else
            {
                MessageBox.Show("Greška kod slanja odabranog artikla!", "Pogreška!", MessageBoxButtons.OK);
            }
        }
        #endregion
        /// <summary>
        /// Unos ili ažuriranje artikla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpremiArtikl_Click(object sender, EventArgs e)
        {
            
            if (idOdabranogArtikla == 0)
            {
                int cijena = int.Parse(txtCijenaArtikla.Text);
                Artikli artikli = new Artikli();
                artikli.Naziv = txtNazivArtikla.Text;
                artikli.Cijena = int.Parse(cijena.ToString("#.##"));
                artikli.KategorijaID = int.Parse(cbKategorijaArtikla.SelectedValue.ToString());
                artikli.StanjeNaSkladistu = 0;
                db.Artiklis.Add(artikli);
                db.SaveChanges();
                this.Close();
            }
            else
            {
                int cijena = int.Parse(txtCijenaArtikla.Text);
                Artikli artikli = new Artikli();
                artikli.Naziv = txtNazivArtikla.Text;
                artikli.Cijena = int.Parse(cijena.ToString("#.##"));
                artikli.KategorijaID = int.Parse(cbKategorijaArtikla.SelectedValue.ToString());
               
                //db.Artiklis.Add(artikli);
                db.SaveChanges();
                this.Close();
            }

        }
    }
}
