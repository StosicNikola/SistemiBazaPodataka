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
    public partial class IzmeniRadnikaForm : Form
    {
        List<OblastBasic> oblasti;
        RadnikBasic radnik;
        
        public IzmeniRadnikaForm()
        {
            InitializeComponent();
        }

        public IzmeniRadnikaForm(RadnikBasic rad)
        {
            InitializeComponent();
            this.radnik = rad;
            this.labelOblast.Text = this.radnik.oblast.Ime;
            this.UcitajOblastiIzBaze();
            this.PopuniFormu();
            this.PopuniListViewPodacima(radnik.oblast.Ime);
            
        }

        public void PopuniFormu()
        {
            this.txtId.Text = this.radnik.Id_radnika.ToString();
            this.txtId.Enabled = false;
            this.txtIme.Text = this.radnik.Ime;
            this.txtPrezime.Text = this.radnik.Prezime;
            this.txtMbr.Text = this.radnik.MaticniBroj.ToString();
            this.txtAdresa.Text = this.radnik.Adresa;
            if(radnik.TipPosla == "Stalno zaposljen")
            {
                this.obrazacZaStalnoZaposljenog(true, true, true, true);
                StalnoZaposljenBasic stalnoZaposljen = (StalnoZaposljenBasic)radnik;
                this.txtBrojRadneKnjizice.Text = stalnoZaposljen.BrojRadneKnjizice.ToString();
                this.txtBrojLk.Text = stalnoZaposljen.BrojLicneKarte.ToString();
                this.txtMestolk.Text = stalnoZaposljen.MestoIzdavanjaLK;
                this.checkBox1.Enabled = true;
            }
            else
            {
                this.obrazacZaStalnoZaposljenog(false, false, false, false);
                this.checkBox1.Enabled = false;
            }
        }

        void obrazacZaStalnoZaposljenog(bool checkBox,bool brojRadneKnjizice, bool Brojlk, bool mesto)
        {
            this.checkBox1.Checked = checkBox;
            this.txtBrojRadneKnjizice.Enabled = brojRadneKnjizice;
            txtBrojLk.Enabled = Brojlk;
            txtMestolk.Enabled = mesto;

        }
        void UcitajOblastiIzBaze()
        {
            oblasti = DTOManager.GetOblasti();
        }

        void pocetnoStanjeDugmica()
        {
            this.checkBox1.Checked = false;
            this.StalnoZaposljenForma(false, false, false);
        }
        
        void StalnoZaposljenForma(bool brojRadneKnjizice, bool Brojlk, bool Mestolk)
        {
            this.txtBrojRadneKnjizice.Enabled = brojRadneKnjizice;
            this.txtBrojLk.Enabled = Brojlk;
            this.txtMestolk.Enabled = Mestolk;
        }

        void PopuniListViewPodacima(String imeOblasti)
        {
            listView1.Items.Clear();


            if (checkBox1.Checked == true)
            {
                foreach (OblastBasic ob in oblasti)
                {
                    if (ob.Ime != imeOblasti)
                    {
                        if (ob.GetType() == typeof(StalnaZastitaBasic))
                        {
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
                }
                listView1.Refresh();
            }
            else
            {
                foreach (OblastBasic ob in oblasti)
                {
                    if (ob.Ime != imeOblasti)
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
                        else if (ob.GetType() == typeof(PovremenaIntervencijaBasic))
                        {
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
                }
                listView1.Refresh();
            }
        }

        private void cmdNazad_Click(object sender, EventArgs e)
        {
            RadnikForm rf = new RadnikForm();
            rf.Show();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           /* if(this.checkBox1.Checked == true)
            {
                this.StalnoZaposljenForma(true, true, true);
                
            }
            else
            {
                this.StalnoZaposljenForma(false, false, false);
            }
            this.PopuniListViewPodacima(radnik.oblast.Ime);*/

        }

        private void cmdIzmeniRadnika_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(this.txtId.Text);
            if(this.txtIme.Text == "")
            {
                MessageBox.Show("Ostavili ste polje Ime prazno!");
                this.txtIme.BackColor = Color.LightPink;
                return;
            }
            String ime = txtIme.Text;

            if (this.txtPrezime.Text == "")
            {
                MessageBox.Show("Ostavili ste polje Prezime prazno!");
                this.txtPrezime.BackColor = Color.LightPink;
                return;
            }
            String prezime = txtPrezime.Text;

            if (this.txtMbr.Text == "")
            {
                MessageBox.Show("Ostavili ste polje Maticni broj prazno!");
                this.txtMbr.BackColor = Color.LightPink;
                return;
            }
            Int64 mbr = Int64.Parse(this.txtMbr.Text);

            if (this.txtAdresa.Text == "")
            {
                MessageBox.Show("Ostavili ste polje Adresa prazno!");
                this.txtAdresa.BackColor = Color.LightPink;
                return;
            }
            String adresa = this.txtAdresa.Text;

            OblastBasic oblastIz = new OblastBasic();
            if (listView1.SelectedItems.Count != 0)
            {
                oblastIz.OblastId = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                oblastIz.Ime = listView1.SelectedItems[0].SubItems[1].Text;
            }
            else
            {
                oblastIz.Ime = radnik.oblast.Ime;
                foreach(OblastBasic o in oblasti)
                {
                    if (radnik.oblast.Ime == o.Ime)
                    {
                        oblastIz.OblastId = o.OblastId;
                    }
                }
            }
            if(this.checkBox1.Checked == true)
            {
                int brojRadneKnj = Int32.Parse(this.txtBrojRadneKnjizice.Text);
                int brlk = Int32.Parse(this.txtBrojLk.Text);
                String mesto = this.txtMestolk.Text;
                StalnoZaposljenBasic st = new StalnoZaposljenBasic(id, mbr, ime, prezime, adresa, "Stalna zastita", brojRadneKnj, brlk, mesto, oblastIz);
                RadnikBasic rad1 = (RadnikBasic)st;
                DTOManager.IzmeniRadnika(rad1);
            }
            else
            {
                RadnikBasic rb = new RadnikBasic(id, mbr, ime, prezime, adresa, "Volonter", oblastIz);
                RadnikBasic rad1 = (RadnikBasic)rb;
                DTOManager.IzmeniRadnika(rad1);
            }
            RadnikForm rfn = new RadnikForm();
            rfn.Show();
            this.Close();
            
        }

      
    }
}
