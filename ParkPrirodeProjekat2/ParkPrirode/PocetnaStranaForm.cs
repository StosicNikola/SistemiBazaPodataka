using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParkPrirode.Forme;


namespace ParkPrirode
{
    public partial class PocetnaStranaForm : Form
    {
        public PocetnaStranaForm()
        {
            InitializeComponent();
        }

        private void cmdOblast_Click(object sender, EventArgs e)
        {
            OblastForm1 of = new OblastForm1();
            of.Show();
        }

        private void cmdPrikaziBiljke_Click(object sender, EventArgs e)
        {
            BiljkaForm1 bf = new BiljkaForm1();
            bf.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdZaposljeni_Click(object sender, EventArgs e)
        {
            RadnikForm rk = new RadnikForm();
            rk.Show();
           
        }

        private void cmdZivotinje_Click(object sender, EventArgs e)
        {
            ZivotinjeForm zivotinjeForma = new ZivotinjeForm();
            zivotinjeForma.Show();
        }
    }
}

