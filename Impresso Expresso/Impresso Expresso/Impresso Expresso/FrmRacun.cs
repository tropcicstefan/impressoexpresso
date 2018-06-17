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
    public partial class FrmRacun : Form
    {
        private Racuni noviRacun = null;

        public FrmRacun(Narudzbe narudzba)
        {
            InitializeComponent();
            NapraviRacun();
            PohraniNarudzbu(narudzba);
        }

        private void PohraniNarudzbu(Narudzbe narudzba)
        {
            using (var db = new Entities())
            {
                db.Narudzbes.Attach(narudzba);
                narudzba.RacunID = noviRacun.ID;
                db.SaveChanges();
            }
        }

        private void NapraviRacun()
        {
            using(var db = new Entities())
            {
                noviRacun = new Racuni
                {
                    ID = 2,
                    Datum = DateTime.Today,
                    KorisnikID = 5,
                    KasaID = 1,
                    PlacanjeID = 2
                };
                db.Racunis.Add(noviRacun);
                db.SaveChanges();
            }
        }

        private void FrmRacun_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
