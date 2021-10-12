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
    public partial class DodajZemljuForm1 : Form
    {
        public PticaSelicaBasic ptica;
        public DodajZemljuForm1()
        {
            InitializeComponent();
        }

        public DodajZemljuForm1(PticaSelicaBasic ptica)
        {
            InitializeComponent();
            this.ptica = ptica;
          
        }

        private void DodajZemljuForm1_Load(object sender, EventArgs e)
        {
            this.tbxImePtice.Text = ptica.LokalniNaziv;
            this.tbxImePtice.Enabled = false;
        }

        private void cmdDodajZemlju_Click(object sender, EventArgs e)
        {
            if (this.txtZemlja.Text == "")
            {
                MessageBox.Show("Niste popunili polje zemlja!");
                return;
            }
            String zemlja = txtZemlja.Text;
            PticaSelicaZemljeBasic novaZemlja = new PticaSelicaZemljeBasic(ptica, zemlja);
            DTOManager.DodajZemljuPticiSelici(novaZemlja);
            MessageBox.Show("Uspesno ste dodali zemlju");
            ZivotinjeForm zf = new ZivotinjeForm();
            zf.Show();
            this.Close();
            
        }
    }
}
