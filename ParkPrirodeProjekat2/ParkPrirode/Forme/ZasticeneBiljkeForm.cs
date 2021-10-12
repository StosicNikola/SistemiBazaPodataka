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
    public partial class ZasticeneBiljkeForm : Form
    {
        public ZasticeneBiljkeForm()
        {
            InitializeComponent();
        }

        private void ZasticeneBiljkeForm_Load(object sender, EventArgs e)
        {
            PopuniInfosZasticeneBiljke();
        }
       private void PopuniInfosZasticeneBiljke()
        {
            listView1.Items.Clear();
            List<ZasticenaBiljkaBasic> BiljkeInfos = DTOManager.GetZasticenaBiljkaInfos();
            foreach (ZasticenaBiljkaBasic op in BiljkeInfos)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    op.BiljkaId.ToString(),
                    op.LatinskiNaziv,
                    op.Broj_odluke.ToString(),
                    op.Datum_pocetka.ToString()
                });
                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }

        private void cmdObrisi_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite biljku !");
                return;
            }
            BiljkaBasic biljka = new BiljkaBasic();
            biljka.BiljkaId = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            
            DTOManager.obrisiZastituBiljke(biljka);
            listView1.Items.Clear();
            PopuniInfosZasticeneBiljke();
            
        }

        private void cmdNazad_Click(object sender, EventArgs e)
        {
            BiljkaForm1 bf1 = new BiljkaForm1();
            bf1.Show();
            this.Close();
        }
    }
}
