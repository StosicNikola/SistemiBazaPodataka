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
    public partial class NaziviSelaForm : Form
    {
        OblastBasic oblast;
        List<NazivSelaOblastBasic> sela;
        public NaziviSelaForm()
        {
            InitializeComponent();
        }

        public NaziviSelaForm(OblastBasic oblast)
        {
            InitializeComponent();
            this.oblast = oblast;
        }

        private void cmdNazad_Click(object sender, EventArgs e)
        {
            OblastForm1 of = new OblastForm1();
            of.Show();
            this.Close();
        }

        private void UcitajSela()
        {
            sela = DTOManager.GetNazivSela(oblast.OblastId);
        }
        private void PopuniFormu()
        {
            this.txtImeOblasti.Text = oblast.Ime;
            this.txtImeOblasti.Enabled = false;
        }
        private void NaziviSelaForm_Load(object sender, EventArgs e)
        {
            this.UcitajSela();
            this.PopuniFormu();
            this.UcitajListView();
        }

        private void UcitajListView()
        {
            this.listView1.Items.Clear();
            foreach(NazivSelaOblastBasic ns in sela)
            {
                ListViewItem item = new ListViewItem(new string[]
                        {
                           ns.imeSela
                        });
                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }

        private void cmdDodajSelo_Click(object sender, EventArgs e)
        {
            DodajSeloForm dsf = new DodajSeloForm(this.oblast);
            dsf.Show();
            this.Close();
        }

        private void cmdObrisiSelo_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite ime sela koje zelite da obrisete !");
                return;
            }
            String ime = listView1.SelectedItems[0].SubItems[0].Text;
            string message = "Da li stvatno zelite da obrisete selo?";
            string title = "Obrisi selo";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                bool Test = DTOManager.ObrisiNazivSelaOblast(ime);
                if (Test == true)
                {
                    this.UcitajSela();
                    this.PopuniFormu();
                    this.UcitajListView();
                }

            }
        }
    }
}
