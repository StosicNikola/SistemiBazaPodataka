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
    public partial class DodajRadnikaForm : Form
    {
        List<OblastBasic> oblasti;
        OblastBasic oblast;
        bool status = false;
        public DodajRadnikaForm()
        {
            InitializeComponent();
        }

        public DodajRadnikaForm(OblastBasic o)
        {
            InitializeComponent();
            oblast = o;
        }


        private void DodajRadnikaForm_Load(object sender, EventArgs e)
        {
            if (oblast == null)
            {
                this.UcitajOblastiIzBaze();
                this.pocetnoStanjeDugmica();
                this.PopuniListViewPodacima();
            }
            else
            {
                this.PopuniListViewOblast();
                this.listView1.Enabled = false;
                if(status == true)
                {
                    this.checkBox1.Checked = true;
                    this.checkBox1.Enabled = false;
                    this.StalnoZaposljenForma(true, true, true);
                }
                else
                {
                    pocetnoStanjeDugmica();
                    this.checkBox1.Enabled = false;
                }
            }
        }
        void PopuniListViewOblast()
        {
            listView1.Items.Clear();
            if (oblast.GetType() == typeof(StalnaZastitaBasic))
            {
                StalnaZastitaBasic ob1 = (StalnaZastitaBasic)oblast;
                status = true;
                ListViewItem item = new ListViewItem(new string[]
                {
                            ob1.OblastId.ToString(),
                            ob1.Ime,
                            ob1.Tip_zastite
                });
                listView1.Items.Add(item);
            }
            else if (oblast.GetType() == typeof(MonitoringBasic))
            {
                 MonitoringBasic ob1 = (MonitoringBasic)oblast;
                 ListViewItem item = new ListViewItem(new string[]
                 {
                            ob1.OblastId.ToString(),
                            ob1.Ime,
                            ob1.Tip_zastite
                 });
                 listView1.Items.Add(item);
            }
            else if (oblast.GetType() == typeof(PovremenaIntervencijaBasic))
            {
                  PovremenaIntervencijaBasic ob1 = (PovremenaIntervencijaBasic)oblast;
                  ListViewItem item = new ListViewItem(new string[]
                  {
                            ob1.OblastId.ToString(),
                            ob1.Ime,
                            ob1.Tip_zastite
                  });
                        listView1.Items.Add(item);
            } 
            listView1.Refresh();  
        }

        void UcitajOblastiIzBaze()
        {
            oblasti = DTOManager.GetOblasti();
        }

        void PopuniListViewPodacima()
        {
            listView1.Items.Clear();
            if(checkBox1.Checked == true)
            {
                foreach (OblastBasic ob in oblasti)
                {
                    if (ob.GetType() == typeof(StalnaZastitaBasic)) {
                        StalnaZastitaBasic ob1 = (StalnaZastitaBasic)ob;
                        ListViewItem item = new ListViewItem(new string[]
                        {
                            ob1.OblastId.ToString(),
                            ob1.Ime,
                            ob1.Tip_zastite
                        });
                        listView1.Items.Add(item);
                    }
                }
                listView1.Refresh();
            }
            else
            {
                foreach (OblastBasic ob in oblasti)
                {
                    if (ob.GetType() == typeof(MonitoringBasic))
                    {
                        MonitoringBasic ob1 = (MonitoringBasic)ob;
                        ListViewItem item = new ListViewItem(new string[]
                        {
                            ob1.OblastId.ToString(),
                            ob1.Ime,
                            ob1.Tip_zastite
                        });
                        listView1.Items.Add(item);
                    }
                    else if (ob.GetType() == typeof(PovremenaIntervencijaBasic)) {
                        PovremenaIntervencijaBasic ob1 = (PovremenaIntervencijaBasic)ob;
                        ListViewItem item = new ListViewItem(new string[]
                        {
                            ob1.OblastId.ToString(),
                            ob1.Ime,
                            ob1.Tip_zastite
                        });
                        listView1.Items.Add(item);
                    }
                }
                listView1.Refresh();
            }
        }


        void pocetnoStanjeDugmica()
        {
            this.checkBox1.Checked = false;
            this.StalnoZaposljenForma(false, false, false);
        }

        void StalnoZaposljenForma(bool brojRadneKnjizice,bool Brojlk, bool Mestolk)
        {
            this.txtBrojRadneKnjizice.Enabled = brojRadneKnjizice;
            this.txtBrojLk.Enabled = Brojlk;
            this.txtMestolk.Enabled = Mestolk;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                this.StalnoZaposljenForma(true, true, true);
            }
            else
            {
                this.StalnoZaposljenForma(false, false, false);
            }
            if (oblast == null)
            {
                this.PopuniListViewPodacima();
            }
        }

        private void cmdNazad_Click(object sender, EventArgs e)
        {
            RadnikForm rf = new RadnikForm();
            rf.Show();
            this.Close();
        }

        private void cmdDodajRadnika_Click(object sender, EventArgs e)
        {
            if(txtIme.Text == "")
            {
                MessageBox.Show("Niste uneli ime!", "OBAVESTENJE");
                return;
            }


            String ime = txtIme.Text;


            if (txtPrezime.Text == "")
            {
                MessageBox.Show("Niste uneli prezime!", "OBAVESTENJE");
                return;
            }


            String prezime = txtPrezime.Text;

            if (txtMbr.Text == "")
            {
                MessageBox.Show("Niste uneli maticni broj!", "OBAVESTENJE");
                return;
            }

            Int64 mbr = Int64.Parse(txtMbr.Text);

            String adresa = txtAdresa.Text;

            OblastBasic o = new OblastBasic();
            
            if (oblast == null)
            {
                if (listView1.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Izaberite oblast !", "OBAVESTENJE");
                    return;
                }
                o.OblastId = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            }
            else
            {
                o = oblast;
            }

            if (checkBox1.Checked == true)
            {
                if (txtBrojRadneKnjizice.Text == "")
                {
                    MessageBox.Show("Niste uneli ime!", "OBAVESTENJE");
                    return;
                }
                int brRadnek = Int32.Parse(txtBrojRadneKnjizice.Text);
                if (txtBrojLk.Text == "")
                {
                    MessageBox.Show("Niste uneli ime!", "OBAVESTENJE");
                    return;
                }
                int brLk = Int32.Parse(txtBrojLk.Text);
                if (txtMestolk.Text == "")
                {
                    MessageBox.Show("Niste uneli ime!", "OBAVESTENJE");
                    return;
                }
                String mesto = txtMestolk.Text;
                StalnoZaposljenBasic szb = new StalnoZaposljenBasic(0, mbr, ime, prezime, adresa, null, brRadnek, brLk, mesto, o);
                DTOManager.DodajStalnoZaposljenog(szb);
            }
            else
            {
                VolonterBasic vo = new VolonterBasic(0, mbr, ime, prezime, adresa, null, o);
                DTOManager.DodajVolontera(vo);
            }
            MessageBox.Show("Uspesno ste dodali radnika");
            if (oblast == null)
            {
                RadnikForm rf = new RadnikForm();
                rf.Show();
            }
            else
            {
                RadniciOblastiForm rof = new RadniciOblastiForm(oblast);
                rof.Show();
            }
            this.Close();
        }
    }
}
