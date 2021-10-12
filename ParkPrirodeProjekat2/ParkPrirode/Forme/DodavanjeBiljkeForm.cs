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
    public partial class DodavanjeBiljkeForm : Form
    {
        public DodavanjeBiljkeForm()
        {
            InitializeComponent();
            this.numBrojOdluke.Enabled = false;
            popuniListBox();
        }

        private void cmdNazad_Click(object sender, EventArgs e)
        {
            BiljkaForm1 bf = new BiljkaForm1();
            bf.Show();
            this.Close();
        }

        private void ckbZasticen_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbZasticen.Checked == true)
            {
                this.numBrojOdluke.Enabled = true;
            }
            else
            {
                this.numBrojOdluke.Enabled = false;
            }
        }

        private void cmdSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.txtBoxLatinskiNaziv.Text == "")
            {
                MessageBox.Show("Upisite Latinski naziv!");
                return;
            }
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite biljku !");
                return;
            }
            if (this.ckbZasticen.Checked == true)
            {
                ZasticenaBiljkaBasic zbb = new ZasticenaBiljkaBasic();
              
                zbb.LatinskiNaziv = this.txtBoxLatinskiNaziv.Text;
                zbb.Broj_odluke = Int32.Parse(this.numBrojOdluke.Value.ToString());
                OblastBasic oblast = new OblastBasic();
                    oblast.OblastId = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                DTOManager.DodajZasticenuBiljku(zbb, oblast);
            }
            else
            {
                BiljkaBasic bb = new BiljkaBasic();
                bb.LatinskiNaziv = this.txtBoxLatinskiNaziv.Text;
                OblastBasic oblast = new OblastBasic();
                oblast.OblastId = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                DTOManager.DodajBiljku(bb, oblast);
            }

            MessageBox.Show("Uspesno ste dodali biljku!");
            BiljkaForm1 bf = new BiljkaForm1();
            bf.Show();
            this.Close();
        }

        private void popuniListBox()
        {
            this.listView1.Items.Clear();
            List<OblastPregled> obInfos = DTOManager.GetObInfos();
            foreach (OblastPregled op in obInfos)
            {
                ListViewItem item = new ListViewItem(new string[]
                   {
                    op.OblastId.ToString(),
                    op.OblastIme
                   });
                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }
    }
}
