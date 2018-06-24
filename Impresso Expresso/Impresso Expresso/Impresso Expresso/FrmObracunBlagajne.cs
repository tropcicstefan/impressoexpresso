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
    public partial class FrmObracunBlagajne : Form
    {
        Entities db = new Entities();
        public FrmObracunBlagajne()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Otvaranje forme za unos nove transakcije
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTransakcije_Click(object sender, EventArgs e)
        {
            FrmTransakcija formaTransakcije = new FrmTransakcija();
            formaTransakcije.ShowDialog();
        }
    }
}
