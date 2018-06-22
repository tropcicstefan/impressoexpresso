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
    public partial class FrmIzbornik : Form
    {
        public FrmIzbornik()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metoda koja hendla event kad se klikne na stol
        /// Poziva se unutar Button_Click metode
        /// </summary>
        public void EventZaStol()
        {
            FrmStol formaStol = new FrmStol();
            formaStol.ShowDialog();
        }

        private void FrmIzbornik_Load(object sender, EventArgs e)
        {
            FrmPrijava formaPrijava = new FrmPrijava();
            formaPrijava.ShowDialog();
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            FrmRegistracija formaRegistracija = new FrmRegistracija();
            formaRegistracija.ShowDialog();
        }

        private void pbStol1_Click(object sender, EventArgs e)
        {
            EventZaStol();
        }

        private void pbStol2_Click(object sender, EventArgs e)
        {
            EventZaStol();
        }
        /// <summary>
        /// Metoda koja instancira i poziva novu formu frmSkladište
        /// </summary>
       
        private void btnSkladiste_Click(object sender, EventArgs e)
        {
            FrmSkladiste formaSkladište = new FrmSkladiste();
            formaSkladište.ShowDialog();
        }

        private void btnKasa_Click(object sender, EventArgs e)
        {
            FrmObracunBlagajne frmObracunBlagajne = new FrmObracunBlagajne();
            frmObracunBlagajne.ShowDialog();
        }
    }
}
