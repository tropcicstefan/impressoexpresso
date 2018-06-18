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
    public partial class FrmStol : Form
    {
        public FrmStol()
        {
            InitializeComponent();
        }

        private void btnMeni_Click(object sender, EventArgs e)
        {
            FrmDodajNarudžbu formaDodajNarudžbu = new FrmDodajNarudžbu();
            formaDodajNarudžbu.ShowDialog();
        }

        private void btnRacun_Click(object sender, EventArgs e)
        {
            
            Narudzbe novaNarudzba1 = null;
            Narudzbe novaNarudzba2 = null;
            
            StavkeNarudzbe stavkaNarudzbe1 = null;
            StavkeNarudzbe stavkaNarudzbe2 = null;
            StavkeNarudzbe stavkaNarudzbe3 = null;


            using (var db = new Entities())
            {

                novaNarudzba1 = new Narudzbe
                {                    
                    StolID = 1,
                    KorisnikID = 7,
                    Datum = DateTime.Today
                };
                novaNarudzba2 = new Narudzbe
                {
                    StolID = 4,
                    KorisnikID = 6,
                    Datum = DateTime.Today
                };

                db.Narudzbes.Add(novaNarudzba1);
                db.Narudzbes.Add(novaNarudzba2);
                db.SaveChanges();
            }
            using (var db = new Entities())
            {
                stavkaNarudzbe1 = new StavkeNarudzbe
                {
                    NarudzbaID = novaNarudzba1.ID,
                    ArtiklID = 1002,
                    Kolicina = 2
                };
                stavkaNarudzbe2 = new StavkeNarudzbe
                {
                    NarudzbaID = novaNarudzba1.ID,
                    ArtiklID = 1005,
                    Kolicina = 1
                };
                stavkaNarudzbe3 = new StavkeNarudzbe
                {
                    NarudzbaID = novaNarudzba2.ID,
                    ArtiklID = 1002,
                    Kolicina = 3
                };

                db.StavkeNarudzbes.Add(stavkaNarudzbe1);
                db.StavkeNarudzbes.Add(stavkaNarudzbe2);
                db.StavkeNarudzbes.Add(stavkaNarudzbe3);
                db.SaveChanges();
            }
            List<Narudzbe> listaNarudzbi = new List<Narudzbe> { novaNarudzba1, novaNarudzba2 };
            
            FrmRacun Racun = new FrmRacun(listaNarudzbi);
            Racun.ShowDialog();
        }
    }
}
