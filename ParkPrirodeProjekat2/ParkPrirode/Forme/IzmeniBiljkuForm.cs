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
    public partial class IzmeniBiljkuForm : Form
    {
        BiljkaBasic biljka;
        public IzmeniBiljkuForm()
        {
            InitializeComponent();
        }

        public IzmeniBiljkuForm(BiljkaBasic biljka)
        {
            InitializeComponent();
            this.biljka = biljka;
            this.popuniListBox();
            this.textBox1.Text = biljka.LatinskiNaziv;
        }

        private void cmdPromeniLatinskiNaziv_Click(object sender, EventArgs e)
        {
            if(this.textBox1.Text == "")
            {
                MessageBox.Show("Nista niste upisali za latinski naziv");
                return;
            }

            String latinskiNaziv = this.textBox1.Text;
            DTOManager.IzmeniLatinskiNaziv(this.biljka.BiljkaId, latinskiNaziv);
            MessageBox.Show("Uspesno ste promenili naziv");
            Nazad(); 
        }

        private void popuniListBox()
        {
            BiljkaBasic b1 = DTOManager.GetBiljka(biljka.BiljkaId);
            this.listView1.Items.Clear();
            this.listView2.Items.Clear();
            foreach (OblastBasic o in b1.pripadaOblasti)
            {
                ListViewItem item = new ListViewItem(new string[]
                   {
                    o.OblastId.ToString(),
                    o.Ime
                   });
                listView1.Items.Add(item);
            }
            listView2.Refresh();

            this.listView2.Items.Clear();
            List<OblastPregled> obInfos = DTOManager.GetObInfos();
            foreach (OblastPregled op in obInfos)
            {
                foreach(OblastBasic o1 in b1.pripadaOblasti)
                {
                    if(op.OblastIme != o1.Ime)
                    {
                        ListViewItem item = new ListViewItem(new string[]
                        {
                            op.OblastId.ToString(),
                            op.OblastIme
                        });
                        listView2.Items.Add(item);
                    }
                }
                
            }
            listView2.Refresh();
        }

        private void cmdNazad_Click(object sender, EventArgs e)
        {
            Nazad();
        }

        public void Nazad()
        {
            BiljkaForm1 bf1 = new BiljkaForm1();
            bf1.Show();
            this.Close();
        }

        private void cmdDodajOblast_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite oblast koju zelite da dodate !");
                return;
            }

            int id = Int32.Parse(listView2.SelectedItems[0].SubItems[0].Text);
            DTOManager.DodajOblastGdeBiljkaRaste(biljka, id);
            MessageBox.Show("Uspesno ste dodali oblast");
            popuniListBox();
        }

        private void cmdObrisiOblast_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite oblast koju zelite da obrisete !");
                return;
            }

            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            DTOManager.ObrisiOblastGdeBiljkaRaste(biljka, id);
            MessageBox.Show("Uspesno ste obrisali oblast");
            popuniListBox();
        }
    }
}
