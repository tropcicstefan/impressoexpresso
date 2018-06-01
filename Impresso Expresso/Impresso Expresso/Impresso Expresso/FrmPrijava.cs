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
    public partial class FrmPrijava : Form
    {
        public FrmPrijava()
        {
            InitializeComponent();
        }

        private void FrmPrijava_Load(object sender, EventArgs e)
        {
            this.ControlBox = false; //makne minimize, enlarge i close gumbe
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            this.Close(); //samo za sad dok se ne postave uvijeti i rješi prijava
        }
    }
}
