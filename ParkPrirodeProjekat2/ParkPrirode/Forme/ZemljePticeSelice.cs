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
    public partial class ZemljePticeSeliceForm : Form
    {
        PticaSelicaBasic ptica;
        public ZemljePticeSeliceForm()
        {
            InitializeComponent();
        }

        public ZemljePticeSeliceForm(PticaSelicaBasic p)
        {
            InitializeComponent();
            this.ptica = p;
        }

        private void cmdNazad_Click(object sender, EventArgs e)
        {
            ZivotinjeForm zf = new ZivotinjeForm();
            zf.Show();
            this.Close();
        }

        private void ZemljePticeSeliceForm_Load(object sender, EventArgs e)
        {
            this.popuniFormu();
        }

        public void popuniFormu()
        {
            txtImePtice.Text = ptica.LokalniNaziv;
            txtImePtice.Enabled = false;
            listView1.Items.Clear();
            foreach (PticaSelicaZemljeBasic z in ptica.zemlje)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        z.zivotinja.IdZivotinje.ToString(),
                        z.zemlja
                    });
                    listView1.Items.Add(item);
            }
            listView1.Refresh();
        }

        private void cmdDodajZemlju_Click(object sender, EventArgs e)
        {
            DodajZemljuForm1 dzf1 = new DodajZemljuForm1(ptica);
            dzf1.Show();
            this.Close();
        }

        private void cmdObrisiZemlju_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite zemlju koju hocete da obrisete !", "OBAVESTENJE");
                return;
            }
            String zemlja = listView1.SelectedItems[0].SubItems[1].Text;
            DTOManager.ObrisiZemljuPticiSelici(zemlja);
            MessageBox.Show("Uspesno ste obrisali zemlju!");
            ZivotinjeForm zf = new ZivotinjeForm();
            zf.Show();
            this.Close();
        }
    }
}
