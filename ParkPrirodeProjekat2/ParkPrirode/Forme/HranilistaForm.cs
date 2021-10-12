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
    public partial class HranilistaForm : Form
    {
        OblastBasic oblast;
        List<HranilisteBasic> hranilista;
        public HranilistaForm()
        {
            InitializeComponent();
        }

        public HranilistaForm(OblastBasic o)
        {
            InitializeComponent();
            this.oblast = o;
        }

        private void UcitajHranilista()
        {
            this.hranilista = DTOManager.GetHranilistaOblasti(oblast);
        }

        private void PopuniFormu()
        {
            this.txtImeOblati.Text = oblast.Ime;
            this.txtImeOblati.Enabled = false;

            this.listView1.Items.Clear();
            foreach (HranilisteBasic h in hranilista)
            {
                String aktivno = "Ne"; 
                if(h.DatumKraja > DateTime.Now)
                {
                    aktivno = "Da";
                }
                ListViewItem item = new ListViewItem(new string[]
                {
                    h.IdHranilista.ToString(),
                    h.DatumPocetka.ToShortDateString(),
                    h.DatumKraja.ToShortDateString(),
                    aktivno,
                    h.brojZivotinja.ToString()

                });
                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }

        private void HranilistaForm_Load(object sender, EventArgs e)
        {
            this.UcitajHranilista();
            this.PopuniFormu();
        }

        private void cmdNazad_Click(object sender, EventArgs e)
        {
            OblastForm1 of1 = new OblastForm1();
            of1.Show();
            this.Close();
        }

        private void cmdUcirajZivotinje_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite hraniliste za koje zelite da ucitate zivotinje !");
                return;
            }
            int idHranilista = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            HranilisteBasic h = new HranilisteBasic();
            foreach(HranilisteBasic h1 in hranilista)
            {
                if(h1.IdHranilista == idHranilista)
                {
                    h = h1;
                }
            }

            PrimecenaJeForm pjf = new PrimecenaJeForm(h);
            pjf.Show();
            this.Close();
           

        }

        private void cmdDodajHraniliste_Click(object sender, EventArgs e)
        {
            DodajHranilisteForm dhf = new DodajHranilisteForm(this.oblast);
            dhf.Show();
            this.Close();
        }

        private void cmdObrisiHraniliste_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite hraniliste koje zelite da obrisete !", "OBAVESTENJE");
                return;
            }
            int IdHranilista = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            string message = "Da li stvatno zelite da obrisete hraniliste?";
            string title = "Obrisi hraniliste";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                DTOManager.ObrisiVezuPrimecenaJeHraniliste(IdHranilista);
                DTOManager.ObrisiHraniliste(IdHranilista);
                this.UcitajHranilista();
                this.PopuniFormu();

            }
        }

        private void cmdIzmeniHraniliste_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite hraniliste koje zelite da izmenite !", "OBAVESTENJE");
                return;
            }
            int IdHranilista = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            HranilisteBasic hra = new HranilisteBasic();
            foreach(HranilisteBasic h in hranilista)
            {
                if(h.IdHranilista == IdHranilista)
                {
                    hra = h;
                }
            }
            IzmeniHranilisteForm izf = new IzmeniHranilisteForm(hra);
            izf.Show();
            this.Close();
        }
    }
}
