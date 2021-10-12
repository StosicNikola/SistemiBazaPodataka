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
    public partial class RadniciOblastiForm : Form
    {
        OblastBasic oblast;
        List<RadnikBasic> radnici;
        public RadniciOblastiForm()
        {
            InitializeComponent();
        }

        public RadniciOblastiForm(OblastBasic o)
        {
            InitializeComponent();
            this.oblast = o;
        }
        private void UcitajRadnike()
        {
            radnici = DTOManager.GetRadnikeOblasti(oblast);
        }
        private void PopuniFormu()
        {
            this.txtImeOblasti.Text = oblast.Ime;
            this.txtImeOblasti.Enabled = false;
            this.txtBrRadnika.Text = radnici.Count.ToString();
            this.txtBrRadnika.Enabled = false; 
            listView1.Items.Clear();

            foreach (RadnikBasic r in radnici)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    r.Id_radnika.ToString(),
                    r.Ime,
                    r.Prezime,
                    r.Adresa,
                    r.MaticniBroj.ToString(),
                    r.TipPosla
                });
                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }

        private void RadniciOblastiForm_Load(object sender, EventArgs e)
        {
            this.UcitajRadnike();
            this.PopuniFormu();
        }

        private void cmdDodajRadnika_Click(object sender, EventArgs e)
        {
            DodajRadnikaForm drf = new DodajRadnikaForm(oblast);
            drf.Show();
            this.Close();
        }

        private void cmdObrisiRadnika_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite radnika kog zelite da obrisete !", "OBAVESTENJE");
                return;
            }
            int IdRadnika = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            string message = "Da li stvatno zelite da obrisete radnika?";
            string title = "Obrisi radnika";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                bool Test = DTOManager.ObrisiRadnika(IdRadnika);
                if (Test == true)
                {
                    this.UcitajRadnike();
                    this.PopuniFormu();
                }

            }
        }

        private void cmdNazad_Click(object sender, EventArgs e)
        {
            OblastForm1 of1 = new OblastForm1();
            of1.Show();
            this.Close();
        }
    }
}
