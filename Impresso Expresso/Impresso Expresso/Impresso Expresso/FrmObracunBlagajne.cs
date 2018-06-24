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
    public partial class FrmObracunBlagajne : Form
    {
        public FrmObracunBlagajne()
        {
            InitializeComponent();
        }

        private void FrmObracunBlagajne_Load(object sender, EventArgs e)
        {

        }

        private void btnTransakcije_Click(object sender, EventArgs e)
        {
            FrmTransakcija formaTransakcije = new FrmTransakcija();
            formaTransakcije.ShowDialog();
        }
    }
}
