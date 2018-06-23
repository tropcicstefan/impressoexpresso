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
    public partial class FrmNoviDobavljac : Form
    {
        private List<string> pozivniBroj = new List<string> { "01", "020", "021", "022",
                            "023","031","032","033","034","035","040","042","043","044",
                            "047","048","049","051","052","053","091","092","095","097",
                            "098","099"};

        private Dobavljaci dobavljac = new Dobavljaci();
        public FrmNoviDobavljac()
        {
            InitializeComponent();
        }

        private void FrmNoviDobavljac_Load(object sender, EventArgs e)
        {
            cbPozivniBroj.DataSource = pozivniBroj;
        }

        private void Pohrani_Click(object sender, EventArgs e)
        {
            dobavljac.Naziv = txtNaziv.Text;
            dobavljac.Adresa = txtAdresa.Text;
            dobavljac.Posta = txtPostanskiBroj.Text + txtGrad.Text;
            dobavljac.Telefon = cbPozivniBroj.SelectedText + txtTelefonskiBroj.Text;
            using(Entities db = new Entities())
            {
                db.Dobavljacis.Add(dobavljac);                
                db.SaveChanges();
            }
            Close();

        }
    }
}
