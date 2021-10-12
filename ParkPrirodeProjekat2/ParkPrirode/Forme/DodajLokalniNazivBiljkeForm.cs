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
    public partial class DodajLokalniNazivBiljkeForm : Form
    {
        BiljkaBasic biljka1;
        public DodajLokalniNazivBiljkeForm()
        {
            InitializeComponent();
        }

        public DodajLokalniNazivBiljkeForm(BiljkaBasic b)
        {
            InitializeComponent();
            this.biljka1 = b;
            this.txtBoxBiljka.Text = biljka1.BiljkaId.ToString();
            this.txtBoxBiljka.Enabled = false;
        }

        private void cmdDodaj_Click(object sender, EventArgs e)
        {
            LokalniNazivBiljkeBasic lnbb = new LokalniNazivBiljkeBasic();
            lnbb.LokalniNaziv = txtBoxLokalniNaziv.Text;
            if(lnbb.LokalniNaziv == "")
            {
                MessageBox.Show("Niste upisali lokalni naziv biljke !");
                txtBoxLokalniNaziv.BackColor = Color.LightPink;
                return;
            }
            lnbb.biljka = biljka1 ;
            DTOManager.sacuvajLokalniNazivBiljke(lnbb);
            MessageBox.Show("Uspesno ste dodali novi lokalni naziv");
            BiljkaForm1 b1 = new BiljkaForm1();
            b1.Show();
            this.Close();
        }
    }
}
