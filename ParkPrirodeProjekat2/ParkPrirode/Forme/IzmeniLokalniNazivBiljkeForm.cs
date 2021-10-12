using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkPrirode.Forme
{
    public partial class IzmeniLokalniNazivBiljkeForm : Form
    {
        public LokalniNazivBiljkeBasic biljka;
        public String staroIme;
        public IzmeniLokalniNazivBiljkeForm()
        {
            InitializeComponent();
        }

        public IzmeniLokalniNazivBiljkeForm(LokalniNazivBiljkeBasic b)
        {
            InitializeComponent();
            this.biljka = b;
            this.staroIme = b.LokalniNaziv;
            this.txtBoxId.Text = b.biljka.BiljkaId.ToString();
            this.txtBoxId.Enabled = false;
            this.txtBoxLokalniNaziv.Text = b.LokalniNaziv;
        }

        private void cmdIzmeni_Click(object sender, EventArgs e)
        {
            biljka.LokalniNaziv = txtBoxLokalniNaziv.Text; 
            if (biljka.LokalniNaziv == "")
            {
                MessageBox.Show("Niste upisali lokalni naziv biljke !");
                txtBoxLokalniNaziv.BackColor = Color.LightPink;
                return;
            }
            DTOManager.izmeniLokalniNazivBiljke(biljka,staroIme);
            MessageBox.Show("Uspesno ste izmenili lokalni naziv");
            BiljkaForm1 bf1 = new BiljkaForm1();
            bf1.Show();
            this.Close();
        }
    }
}
