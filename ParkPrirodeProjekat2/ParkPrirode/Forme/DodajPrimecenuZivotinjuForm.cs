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
    public partial class DodajPrimecenuZivotinjuForm : Form
    {
        HranilisteBasic hraniliste;
        List<PrimecenaJeBasic> vezaPrimecena;
        List<ZivotinjaBasic> zivotinjeOblasti;
        List<ZivotinjaBasic> noveZivotinje =new List<ZivotinjaBasic>();
        
        public DodajPrimecenuZivotinjuForm()
        {
            InitializeComponent();
        }

        public DodajPrimecenuZivotinjuForm(HranilisteBasic h)
        {
            InitializeComponent();
            hraniliste = h;
        }

        private void UcitajZivotinje()
        {
            vezaPrimecena = DTOManager.GetPrimeceneZivotinje(hraniliste);
            zivotinjeOblasti = DTOManager.getZivotinjeOblasti(hraniliste.pripadaOblasti);
        }

        public bool proveri(ZivotinjaBasic z)
        {
            bool test = false;
            foreach(PrimecenaJeBasic pj in vezaPrimecena)
            {
                if(z.IdZivotinje == pj.zivotinja.IdZivotinje)
                {
                    test = true;
                }
            }
            return test;
        }

        private void NoveZivotinje()
        {
            foreach(ZivotinjaBasic z1 in zivotinjeOblasti)
            {
                if (!proveri(z1))
                {
                    noveZivotinje.Add(z1);
                }
            }
        }

        

        private void PopuniListView1()
        {
            this.listView1.Items.Clear();

            foreach (ZivotinjaBasic pj in noveZivotinje)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                   pj.IdZivotinje.ToString(),
                   pj.SerijskiBrojPrstena.ToString(),
                   pj.LatinskiNaziv,
                   pj.LokalniNaziv
                });
                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }

        private void DodajPrimecenuZivotinjuForm_Load(object sender, EventArgs e)
        {
            this.UcitajZivotinje();
            this.NoveZivotinje();
            this.PopuniListView1();
        }

        private void cmdNazad_Click(object sender, EventArgs e)
        {
            PrimecenaJeForm PJ = new PrimecenaJeForm(hraniliste);
            PJ.Show();
            this.Close();
        }

        private void cmdDodaj_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite zivotinju koju zelite da dodate u hraniliste !");
                return;
            }
            int idZivotinje = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            ZivotinjaBasic z = new ZivotinjaBasic();
            foreach (ZivotinjaBasic z1 in noveZivotinje)
            {
                if (z1.IdZivotinje == idZivotinje )
                {
                    z = z1;
                }
            }
            PrimecenaJeBasic pjb = new PrimecenaJeBasic(z, hraniliste, DateTime.Now);
            DTOManager.DodajNovuZivotinjuUHraniliste(pjb);

            PrimecenaJeForm PJ = new PrimecenaJeForm(hraniliste);
            PJ.Show();
            this.Close();
        }
    }
}
