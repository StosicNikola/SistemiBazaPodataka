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
    public partial class ZivotinjeForm : Form
    {
        List<ZivotinjaBasic> zivotinje;
        public ZivotinjeForm()
        {
            InitializeComponent();
        }

        private void PopuniComboBox()
        {
            this.comboBox1.Items.Clear();
            this.comboBox1.Items.Add("Sve zivotinje");
            this.comboBox1.Items.Add("Ptice selice");
            this.comboBox1.SelectedIndex = 0;
        }

        private void UcitajInfoZivotinje()
        {
            zivotinje = DTOManager.getZivotinjeInfo();

        }

        private void ZivotinjeForm_Load(object sender, EventArgs e)
        {
            this.UcitajInfoZivotinje();
            this.PopuniComboBox();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;
            listView1.Items.Clear();
            if (selectedIndex == 0)
            {
                foreach (ZivotinjaBasic z in zivotinje)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        z.IdZivotinje.ToString(),
                        z.SerijskiBrojPrstena.ToString(),
                        z.LokalniNaziv,
                        z.LatinskiNaziv,
                        z.statusPticaSelica,
                        z.pripadaOblasti.Count.ToString()
                    });
                    listView1.Items.Add(item);
                }
                listView1.Refresh();
            }
            else if (selectedIndex == 1)
            {
                foreach (ZivotinjaBasic z in zivotinje)
                {
                    if (z.statusPticaSelica == "Da")
                    {
                        ListViewItem item = new ListViewItem(new string[]
                        {
                           z.IdZivotinje.ToString(),
                            z.SerijskiBrojPrstena.ToString(),
                            z.LokalniNaziv,
                            z.LatinskiNaziv,
                            z.statusPticaSelica,
                            z.pripadaOblasti.Count.ToString()
                        });
                        listView1.Items.Add(item);
                    }
                }
                listView1.Refresh();
            }
            this.txtUkupanBrojZivotinja.Text = zivotinje.Count.ToString();
            this.txtUkupanBrojZivotinja.Enabled = false;
            
        }

        private void cmdNazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdZemlje_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite pticu selicu !", "OBAVESTENJE");
                return;
            }
            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            ZivotinjaBasic zivotinja = new ZivotinjaBasic();
            foreach(ZivotinjaBasic z in zivotinje)
            {
                if(id == z.IdZivotinje)
                {
                    zivotinja = z;
                }
            }
            if(zivotinja.statusPticaSelica == "Ne")
            {
                MessageBox.Show("Niste izabrali pticu selicu !", "OBAVESTENJE");
                return;
            }
            PticaSelicaBasic ptica = (PticaSelicaBasic)zivotinja;
            ZemljePticeSeliceForm zpsf = new ZemljePticeSeliceForm(ptica);
            zpsf.Show();
            this.Close();
        }

        private void cmdDodajZivotinju_Click(object sender, EventArgs e)
        {
            DodajZivotinjuForm dzf = new DodajZivotinjuForm();
            dzf.Show();
            this.Close();
        }

        private void cmdObrisiZivotinju_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite zivotinju koju zelite da obrisete !", "OBAVESTENJE");
                return;
            }
            int IdZivotinja = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            string message = "Da li stvatno zelite da obrisete zivotinju?";
            string title = "Obrisi zivotinju";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                DTOManager.ObrisiVezuPripadaZivotinja(IdZivotinja);
                DTOManager.ObrisiVezuPrimecenaJeZivotinja(IdZivotinja);
                bool Test = DTOManager.ObrisiZivotinju(IdZivotinja);
                if (Test == true)
                {
                    this.UcitajInfoZivotinje();
                    this.PopuniComboBox();
                }

            }
        }

        private void cmdIzmeniZivotinju_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite zivotinju koju zelite da izmenite !", "OBAVESTENJE");
                return;
            }
            int IdZivotinja = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            ZivotinjaBasic zivot1 = new ZivotinjaBasic();
            foreach(ZivotinjaBasic z in zivotinje)
            {
                if(z.IdZivotinje == IdZivotinja)
                {
                    zivot1 = z;
                }
            }

            IzmeniZivotinjuForm izf = new IzmeniZivotinjuForm(zivot1);
            izf.Show();
            this.Close();
        }
    }
}
