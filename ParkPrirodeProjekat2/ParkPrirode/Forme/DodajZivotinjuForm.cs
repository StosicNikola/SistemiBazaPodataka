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
    
    public partial class DodajZivotinjuForm : Form
    {
        PticaSelicaBasic ptica = new PticaSelicaBasic();
        
        List<OblastBasic> oblasti;
        public DodajZivotinjuForm()
        {
            InitializeComponent();
        }

        private void DodajZivotinjuForm_Load(object sender, EventArgs e)
        {
            this.formaPticaSelica(false, false, false, false);
            this.UcitajOblastiIzBaze();
            this.PopuniListViewPodacima();
        }
        
        public void formaPticaSelica(bool txt,bool d,bool o,bool lv)
        {
            this.txtZemlja.Enabled = txt;
            this.cmdDodajZemlju.Enabled = d;
            this.cmdObrisiZemlju.Enabled = o;
            this.listView2.Enabled = lv;
        }

        void UcitajOblastiIzBaze()
        {
            oblasti = DTOManager.GetOblasti();
        }

        void PopuniListViewPodacima()
        {
            listView1.Items.Clear();
            foreach (OblastBasic ob in oblasti)
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
                else if (ob.GetType() == typeof(MonitoringBasic))
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
            listView1.Refresh();
        }

        private void cmdNazad_Click(object sender, EventArgs e)
        {
            ZivotinjeForm z = new ZivotinjeForm();
            z.Show();
            this.Close();
        }

        private void ckbPticaSelica_CheckedChanged(object sender, EventArgs e)
        {
            if(this.ckbPticaSelica.Checked == true)
            {
                this.formaPticaSelica(true, true, true, true);
            }
            else
            {
                this.listView2.Items.Clear();
                
                this.formaPticaSelica(false, false, false, false);
            }
        }

        private void cmdDodajZemlju_Click(object sender, EventArgs e)
        {
            if(txtZemlja.Text == "")
            {
                MessageBox.Show("Polje zemlja je prazno!");
                return;
            }
            PticaSelicaZemljeBasic novaZemlja = new PticaSelicaZemljeBasic(null, this.txtZemlja.Text);
            ptica.zemlje.Add(novaZemlja);
            this.txtZemlja.Text = "";
            this.popuniList2();
        }

        void popuniList2()
        {
            this.listView2.Items.Clear();
            foreach(PticaSelicaZemljeBasic p in ptica.zemlje)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                            p.zemlja
                    });
                listView2.Items.Add(item);
            }
            listView2.Refresh();
        }

        private void cmdObrisiZemlju_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite zemlju koju zelite da obrisete !", "OBAVESTENJE");
                return;
            }
            String zemlja = listView2.SelectedItems[0].SubItems[0].Text;
            PticaSelicaZemljeBasic zemlje = new PticaSelicaZemljeBasic();
            foreach(PticaSelicaZemljeBasic p in ptica.zemlje)
            {
                if(p.zemlja == zemlja)
                {
                    zemlje = p;
                }
            }
            ptica.zemlje.Remove(zemlje);
            this.popuniList2();
        }

        private void cmdDodajZivotinju_Click(object sender, EventArgs e)
        {
            if(txtLatinskiNaziv.Text == "")
            {
                MessageBox.Show("Niste upisali latinski naziv!");
                return;
            }
            String latinskiNaziv = txtLatinskiNaziv.Text;

            if (txtLokalniNaziv.Text == "")
            {
                MessageBox.Show("Niste upisali Lokalni naziv!");
                return;
            }
            String lokalniNaziv = txtLokalniNaziv.Text;

            int serijskiBroj = Int32.Parse( this.numSerijskiBroj.Value.ToString());

            OblastBasic o = new OblastBasic();

            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite oblast u koju zelite da stavite zivotinju!", "OBAVESTENJE");
                return;
            }

            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            foreach (OblastBasic o1 in oblasti)
            {
                if(o1.OblastId == id)
                {
                    o = o1;
                }
            }

            if (ckbPticaSelica.Checked == false)
            {
                ZivotinjaBasic zivotinja = new ZivotinjaBasic(0, serijskiBroj, lokalniNaziv, latinskiNaziv, "Ne");
                DTOManager.DodajZivotinju(zivotinja, o);
               
                

            }
            else
            {
                ptica.LokalniNaziv = lokalniNaziv;
                ptica.SerijskiBrojPrstena = serijskiBroj;
                ptica.LatinskiNaziv = latinskiNaziv;
                bool t = DTOManager.DodajPticuSelicu(ptica, o);
                if(t== true)
                {
                    PticaSelicaBasic p = DTOManager.GetPticaSelica(lokalniNaziv);
                    foreach(PticaSelicaZemljeBasic z in ptica.zemlje)
                    {
                        z.zivotinja = p;
                        DTOManager.DodajZemljuPticiSelici(z);
                    }
                    
                }
            }
            MessageBox.Show("Uspesno ste dodali zivotinju!");
            ZivotinjeForm zf = new ZivotinjeForm();
            zf.Show();
            this.Close();
        }
    }
}
