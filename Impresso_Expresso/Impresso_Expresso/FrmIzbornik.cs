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

        private void FrmIzbornik_Load(object sender, EventArgs e)
        {
            FrmPrijava formaPrijava = new FrmPrijava();
            formaPrijava.ControlBox = false; //makne ikone za minimizaciju, enlarge i zatvaranje,
                                             //tako da se nemoze zatvoriti forma manualno nego samo putem registracije

            formaPrijava.ShowDialog(); //prikaz forme kao popupa, glavni izbornik se otvara nakon zatvaranja ovog
        }
    }
}
