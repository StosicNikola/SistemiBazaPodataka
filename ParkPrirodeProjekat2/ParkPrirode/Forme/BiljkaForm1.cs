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
    public partial class BiljkaForm1 : Form
    {

        int BiljkaID;
        public BiljkaForm1()
        {
            InitializeComponent();
        }

        private void BiljkaForm1_Load(object sender, EventArgs e)
        {
            PopuniInfosBiljke();
            PocetnoStanjeDugmica(false,false);
        }

        public void PocetnoStanjeDugmica(bool a, bool b)
        {
            this.cmdIzmeniLokalniNaziv.Enabled = a;
            this.cmdObrisiLokalniNaziv.Enabled = b;
        }
        private void PopuniInfosBiljke()
        {
            listView1.Items.Clear();
            List<BiljkaPregled> BiljkeInfos = DTOManager.GetBiljkaInfos();
            foreach (BiljkaPregled op in BiljkeInfos)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    op.Id_biljke.ToString(),
                    op.LatinskiNaziv,
                    op.Zasticena
                });
                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }

        private void cmdLokalniNazivBiljke_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            if(listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite biljku !");
                return;
            }
            this.BiljkaID = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            this.PopuniListViewLokalnihNaziva(this.BiljkaID);
            this.PocetnoStanjeDugmica(true, true);
        }

        private void PopuniListViewLokalnihNaziva(int idBiljke)
        {
            this.listView2.Items.Clear();
            BiljkaBasic biljka = DTOManager.GetBiljka(this.BiljkaID);
            foreach (LokalniNazivBiljkeBasic b in biljka.LokalniNaziviBiljke)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    biljka.BiljkaId.ToString(),
                    b.LokalniNaziv
                });
                listView2.Items.Add(item);
            }
            listView2.Refresh();
        }

        private void cmdDodajLokalniNaziv_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite biljku !");
                return;
            }
            this.BiljkaID = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            BiljkaBasic biljka = new BiljkaBasic();
            biljka.BiljkaId = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            DodajLokalniNazivBiljkeForm dlnbf = new DodajLokalniNazivBiljkeForm(biljka);
            dlnbf.Show();
            this.Close();
        }

        private void cmdObrisiLokalniNaziv_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite lokalni naziv biljke koju zelite da obrisete!");
                return;
            }
            BiljkaBasic biljka = new BiljkaBasic();
            biljka.BiljkaId = Int32.Parse(listView2.SelectedItems[0].SubItems[0].Text);
            LokalniNazivBiljkeBasic lnbb = new LokalniNazivBiljkeBasic();
            lnbb.biljka = biljka;
            lnbb.LokalniNaziv = listView2.SelectedItems[0].SubItems[1].Text;
            DTOManager.obrisiLokalniNazivBiljke(lnbb);
            MessageBox.Show("Uspesno ste obrisali podatak!");
            listView2.Refresh();
            this.PopuniListViewLokalnihNaziva(this.BiljkaID);
        }

        private void cmdIzmeniLokalniNaziv_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite biljku !");
                return;
            }
            BiljkaBasic biljka = new BiljkaBasic();
            LokalniNazivBiljkeBasic lnb = new LokalniNazivBiljkeBasic();
            biljka.BiljkaId = Int32.Parse(listView2.SelectedItems[0].SubItems[0].Text);
            lnb.biljka = biljka;
            lnb.LokalniNaziv = listView2.SelectedItems[0].SubItems[1].Text;
            IzmeniLokalniNazivBiljkeForm dlnbf = new IzmeniLokalniNazivBiljkeForm(lnb);
            dlnbf.Show();
            this.Close();
        }

        private void cmdUcitajZaticeneBiljke_Click(object sender, EventArgs e)
        {
            
            ZasticeneBiljkeForm zbf = new ZasticeneBiljkeForm();
            zbf.Show();
            this.Close();
        }

        private void cmdZastitiBiljku_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite biljku !");
                return;
            }
            String zasticena = listView1.SelectedItems[0].SubItems[2].Text;
            if(zasticena == "Ne")
            {
                BiljkaBasic zbb = new BiljkaBasic();
                zbb.BiljkaId = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                zbb.LatinskiNaziv = listView1.SelectedItems[0].SubItems[1].Text;
                ZatitiBiljkuForm zbf = new ZatitiBiljkuForm(zbb);
                zbf.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Biljka je vec zasticena");
                return;
            }
        }

        private void cmdDodajBiljku_Click(object sender, EventArgs e)
        {
            DodavanjeBiljkeForm dbf = new DodavanjeBiljkeForm();
            dbf.Show();
            this.Close();
        }

        private void cmdObrisiBiljku_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite biljku koju zelis da obrises !");
                return;
            }
            String zasticena = listView1.SelectedItems[0].SubItems[2].Text;
            BiljkaBasic biljka = new BiljkaBasic();
            biljka.BiljkaId = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            DTOManager.ObrisiVezuRasteBiljka(biljka.BiljkaId);
            DTOManager.ObrisiBiljku(biljka);
          
            MessageBox.Show("Obrisali ste biljku!");
            this.PopuniInfosBiljke();
                

        }

        private void cmdIzmeniBiljku_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite biljku koju zelis da izmenis !");
                return;
            }

            BiljkaBasic biljka1 = new BiljkaBasic();
            biljka1.BiljkaId = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            biljka1.LatinskiNaziv = listView1.SelectedItems[0].SubItems[1].Text;
            IzmeniBiljkuForm ibf = new IzmeniBiljkuForm(biljka1);
            ibf.Show();
            this.Close();
        }
    }
}
