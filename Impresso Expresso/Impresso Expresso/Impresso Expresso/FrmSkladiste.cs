using System;
using System.Windows.Forms;

namespace Impresso_Expresso
{
    public partial class FrmSkladiste : Form
    {
        public FrmSkladiste()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metoda instancira i poziva formu FrmPrimka
        /// </summary>
        
        private void btnPrimka_Click(object sender, EventArgs e)
        {
            FrmPrimka formaPrimka = new FrmPrimka();
            formaPrimka.ShowDialog();
        }
    }
}
