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
    public partial class FrmUpravljanjeArtiklom : Form
    {
        public FrmUpravljanjeArtiklom()
        {
            InitializeComponent();
        }

        private void btnDodajArtikl_Click(object sender, EventArgs e)
        {
            FrmUnosArtikla formaUnosArtikla = new FrmUnosArtikla();
            formaUnosArtikla.ShowDialog();
        }
    }
}
