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
    public partial class PrimecenaJeForm : Form
    {
        HranilisteBasic hraniliste;
        List<PrimecenaJeBasic> vezaPrimecena;
        public PrimecenaJeForm()
        {
            InitializeComponent();
        }

        public PrimecenaJeForm(HranilisteBasic h)
        {
            InitializeComponent();
            this.hraniliste = h;
        }

        private void UcitajZivotinje()
        {
           vezaPrimecena =  DTOManager.GetPrimeceneZivotinje(hraniliste);
        }

        private void PopuniFormu()
        {
            this.txtImeOblasti.Text = hraniliste.pripadaOblasti.Ime;
            this.txtImeOblasti.Enabled = false;
            this.txtIdHranilista.Text = hraniliste.IdHranilista.ToString();
            this.txtIdHranilista.Enabled = false;
        }

        private void PopuniListView1()
        {
            this.listView1.Items.Clear();
            foreach (PrimecenaJeBasic pj in vezaPrimecena)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                   pj.zivotinja.IdZivotinje.ToString(),
                   pj.zivotinja.SerijskiBrojPrstena.ToString(),
                   pj.zivotinja.LatinskiNaziv,
                   pj.zivotinja.LokalniNaziv,
                   pj.DatumVidjenja.ToShortDateString()

                });
                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }

        private void PrimecenaJeForm_Load(object sender, EventArgs e)
        {
            this.UcitajZivotinje();
            this.PopuniFormu();
            this.PopuniListView1();
        }

        private void cmdNazad_Click(object sender, EventArgs e)
        {
            HranilistaForm h = new HranilistaForm(hraniliste.pripadaOblasti);
            h.Show();
            this.Close();
        }

        private void cmdDodajZivotinjuUHraniliste_Click(object sender, EventArgs e)
        {
            DodajPrimecenuZivotinjuForm dfz = new DodajPrimecenuZivotinjuForm(hraniliste);
            dfz.Show();
            this.Close();
        }

        private void cmdObrisiZivotinjuIzHranilista_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite ZIVOTINJU kog zelite da obrisete !", "OBAVESTENJE");
                return;
            }
            int IdZivotinje = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            string message = "Da li stvatno zelite da obrisete zivotinju?";
            string title = "Obrisi zivotinju";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                DTOManager.ObrisiVezuPrimecenaJeZivotinja(IdZivotinje);
                this.UcitajZivotinje();
                this.PopuniFormu();
                this.PopuniListView1();

            }



        }

        private void cmdIzmeniZivotinju_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite ZIVOTINJU kojoj zelite da izmenite datum !", "OBAVESTENJE");
                return;
            }
            int idZivotinje = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            PrimecenaJeBasic p = new PrimecenaJeBasic();
            foreach(PrimecenaJeBasic p1 in vezaPrimecena)
            {
                if(p1.zivotinja.IdZivotinje == idZivotinje)
                {
                    p = p1;
                }
            }

            IzmeniDatumForm idf = new IzmeniDatumForm(p);
            idf.Show();
            this.Close();

        }
    }
}
