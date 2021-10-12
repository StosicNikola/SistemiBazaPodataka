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
    public partial class ZatitiBiljkuForm : Form
    {
        BiljkaBasic biljka;
        public ZatitiBiljkuForm()
        {
            InitializeComponent();
        }

        public ZatitiBiljkuForm(BiljkaBasic b)
        {
            InitializeComponent();
            this.biljka = b;
            this.namestiPolja();
        }

        private void cmdSacuvaj_Click(object sender, EventArgs e)
        {
            ZasticenaBiljkaBasic zbb = new ZasticenaBiljkaBasic();
            zbb.BiljkaId = biljka.BiljkaId;
            zbb.LatinskiNaziv = biljka.LatinskiNaziv;
            zbb.Broj_odluke = Int32.Parse(numBrojOdluke.Value.ToString());
            zbb.Datum_pocetka = DateTime.Now;
            DTOManager.ZastitiBiljku(zbb);
            MessageBox.Show("Uspesno ste zastitili biljku");
            BiljkaForm1 bf1 = new BiljkaForm1();
            bf1.Show();
            this.Close();
        }

        private void namestiPolja()
        {
            this.txtId.Text = this.biljka.BiljkaId.ToString();
            this.txtId.Enabled = false;
            this.txtLatinskiNaziv.Text = this.biljka.LatinskiNaziv;
            this.txtLatinskiNaziv.Enabled = false;
        }
    }
}
