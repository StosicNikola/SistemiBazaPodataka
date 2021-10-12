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
    public partial class IzmeniZivotinjuForm : Form
    {
        ZivotinjaBasic zivotinja;
        List<OblastBasic> oblasti;
        
        public IzmeniZivotinjuForm()
        {
            InitializeComponent();
        }

        public IzmeniZivotinjuForm(ZivotinjaBasic z)
        {
            InitializeComponent();
            this.zivotinja = z;
        }

        private void cmdNazad_Click(object sender, EventArgs e)
        {
            ZivotinjeForm zf = new ZivotinjeForm();
            zf.Show();
            this.Close();
        }

        void UcitajOblastiIzBaze()
        {
            oblasti = DTOManager.GetOblasti();
        }

        void PopuniListView2Podacima()
        {
            listView2.Items.Clear();
            foreach (OblastBasic ob in oblasti)
            {
                ListViewItem item = new ListViewItem(new string[]
                       {
                            ob.OblastId.ToString(),
                            ob.Ime
                       });
                listView2.Items.Add(item);
            }

            listView2.Refresh();
        }

        void PopuniListView1Podacima()
        {
            listView1.Items.Clear();
            foreach (OblastBasic ob in zivotinja.pripadaOblasti)
            {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                            ob.OblastId.ToString(),
                            ob.Ime
                    });
                    listView1.Items.Add(item);    
            }
            listView1.Refresh();
        }

        private void IzmeniZivotinjuForm_Load(object sender, EventArgs e)
        {
            this.UcitajOblastiIzBaze();
            this.PopuniListView1Podacima();
            this.PopuniListView2Podacima();
            this.popuniFormu();
        }

        void popuniFormu()
        {
            this.txtId.Text = this.zivotinja.IdZivotinje.ToString();
            this.txtId.Enabled = false;
            this.numSerijskiBroj.Value = Decimal.Parse(this.zivotinja.SerijskiBrojPrstena.ToString());
            this.txtLatinskiNaziv.Text = this.zivotinja.LatinskiNaziv;
            this.txtLokalniNaziv.Text = this.zivotinja.LokalniNaziv;
            if(zivotinja.GetType() == typeof(PticaSelicaBasic))
            {
                ckbPticaSelica.Checked = true;
                
            }
            ckbPticaSelica.Enabled = false;
        }

        private void cmdDodajOblast_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite oblast u koju zelite da dodate zivotinju !", "OBAVESTENJE");
                return;
            }
            int IdOblasti = Int32.Parse(listView2.SelectedItems[0].SubItems[0].Text);

            OblastBasic oblast = new OblastBasic();
            foreach(OblastBasic o in oblasti)
            {
                if(o.OblastId == IdOblasti)
                {
                    oblast = o;
                }
            }
            foreach(OblastBasic o in zivotinja.pripadaOblasti)
            {
                if(o.Ime == oblast.Ime)
                {
                    MessageBox.Show("Zivotinja vec postoji na toj oblasti");
                    return;
                }
            }
            zivotinja.pripadaOblasti.Add(oblast);

            this.PopuniListView1Podacima();

            this.PopuniListView2Podacima();
        }

        private void cmdObrisiOblast_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite oblast u koju zelite da dodate zivotinju !", "OBAVESTENJE");
                return;
            }
            int IdOblasti = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            OblastBasic oblast = new OblastBasic();
            foreach (OblastBasic o in zivotinja.pripadaOblasti)
            {
                if (o.OblastId == IdOblasti)
                {
                    oblast = o;
                }
            }
            zivotinja.pripadaOblasti.Remove(oblast);
            

            this.PopuniListView1Podacima();

            this.PopuniListView2Podacima();
        }

        private void cmdIzmeniZivotinju_Click(object sender, EventArgs e)
        {
            zivotinja.SerijskiBrojPrstena = Int32.Parse(numSerijskiBroj.Value.ToString());
            zivotinja.LokalniNaziv = txtLokalniNaziv.Text;
            zivotinja.LatinskiNaziv = txtLatinskiNaziv.Text;

            DTOManager.IzmeniZivotinju(zivotinja);
            ZivotinjeForm zf = new ZivotinjeForm();
            zf.Show();
            this.Close();
        }
    }
}

