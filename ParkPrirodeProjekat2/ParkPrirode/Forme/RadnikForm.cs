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
    public partial class RadnikForm : Form
    {
        List<RadnikBasic> radnici;
        public RadnikForm()
        {
            InitializeComponent();
        }

        private void RadnikForm_Load(object sender, EventArgs e)
        {
            this.PopuniInfosRadnika();
            this.PopuniComboBox();
            
        }

        private void PopuniInfosRadnika()
        {
            listView1.Items.Clear();
            radnici = DTOManager.GetRadnikInfos();
        
        }

        private void PopuniComboBox()
        {
            this.comboBox1.Items.Clear();
            this.comboBox1.Items.Add("Svi radnici");
            this.comboBox1.Items.Add("Volonteri");
            this.comboBox1.Items.Add("Stalno zaposljeni");
            this.comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;
            listView1.Items.Clear();
            if (selectedIndex == 0)
            {
                foreach (RadnikBasic r in radnici)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                    r.Id_radnika.ToString(),
                    r.Ime,
                    r.Prezime,
                    r.Adresa,
                    r.MaticniBroj.ToString(),
                    r.TipPosla,
                    r.oblast.Ime,
                    r.oblast.Povrsina.ToString()
                    });
                    listView1.Items.Add(item);
                }
                listView1.Refresh();
            }
            else if(selectedIndex == 1)
            {
                foreach (RadnikBasic r in radnici)
                {
                    if (r.TipPosla == "Volonter")
                    {
                        ListViewItem item = new ListViewItem(new string[]
                        {
                           r.Id_radnika.ToString(),
                           r.Ime,
                           r.Prezime,
                           r.Adresa,
                           r.MaticniBroj.ToString(),
                           r.TipPosla,
                           r.oblast.Ime,
                           r.oblast.Povrsina.ToString()
                        });
                        listView1.Items.Add(item);
                    }
                }
                listView1.Refresh();
            }
            else if(selectedIndex == 2)
            {
                foreach (RadnikBasic r in radnici)
                {
                    if (r.TipPosla == "Stalno zaposljen")
                    {
                        ListViewItem item = new ListViewItem(new string[]
                        {
                           r.Id_radnika.ToString(),
                           r.Ime,
                           r.Prezime,
                           r.Adresa,
                           r.MaticniBroj.ToString(),
                           r.TipPosla,
                           r.oblast.Ime,
                           r.oblast.Povrsina.ToString()
                        });
                        listView1.Items.Add(item);
                    }
                }
                listView1.Refresh();
            }
        }

        private void cmdUcitajDodatnoOSR_Click(object sender, EventArgs e)
        {
            StalnoZaposljenBasic szb;
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite stalno zaposljenog radnika !");
                return;
            }
            int idRadnika = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            foreach(RadnikBasic r in radnici)
            {
                if(r.Id_radnika == idRadnika)
                {
                    if (r.TipPosla == "Stalno zaposljen")
                    {
                        szb = (StalnoZaposljenBasic)r;
                        MessageBox.Show("Ime:\t\t" + szb.Ime + "\nPrezime:\t\t" + szb.Prezime + "\nMaticni broj:\t" + szb.MaticniBroj + "\nTip posla: \tStalno zaposljen"
                           + "\nBroj radne knjizice: " + szb.BrojRadneKnjizice
                           + "\nBroj licne karte:\t " + szb.BrojLicneKarte
                           + "\nMesto izdavanja:\t " + szb.MestoIzdavanjaLK,"Radnik");
                    }
                    else
                    {
                        MessageBox.Show("Izabraliste Volontera!\nIzaberite Stalno zaposljenog radnika");
                        return;
                    }
                }
            }

        }

        private void cmdNazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdDodajRadnika_Click(object sender, EventArgs e)
        {
            DodajRadnikaForm drf = new DodajRadnikaForm();
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
                    this.PopuniInfosRadnika();
                    this.PopuniComboBox();
                }
                
            }
            
        }

        private void cmdIzmeniRadnika_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite radnika kog zelite da izmenite !", "OBAVESTENJE");
                return;
            }
            int idRadnika = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            RadnikBasic rad = new RadnikBasic();
            foreach(RadnikBasic r in radnici)
            {
                if(r.Id_radnika == idRadnika)
                {
                    rad = r;
                }
            }
            IzmeniRadnikaForm irf = new IzmeniRadnikaForm(rad);
            irf.Show();
            this.Close();
        }
    }
}
