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
    public partial class OblastForm1 : Form
    {
        List<OblastBasic> oblasti;
        List<OblastPregled> obInfos;
        List<HranilisteBasic> hranilista;
        public OblastForm1()
        {
            InitializeComponent();
        }

        private void OblastForm1_Load(object sender, EventArgs e)
        {
            this.UcitajOblasti();
            this.PopuniComboBox();
        }

        public void UcitajOblasti()
        {
            oblasti = DTOManager.GetOblasti();
            obInfos = DTOManager.GetObInfos();
        }
     /*   private void PopuniInfos()
        {
            listView1.Items.Clear();
            List<OblastPregled> obInfos = DTOManager.GetObInfos();
            foreach (OblastPregled op in obInfos)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    op.OblastId.ToString(),
                    op.OblastIme,
                    op.OblastPovrsina.ToString(),
                    op.BrojSela.ToString(),
                    op.BrojZivotinja.ToString(),
                    op.BrojBiljaka.ToString(),
                    op.BrojRadnika.ToString(),
                    op.BrojHranilista.ToString()
                });
                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }*/


        private void PopuniComboBox()
        {
            this.comboBox1.Items.Clear();
            this.comboBox1.Items.Add("Sve oblasti");
            this.comboBox1.Items.Add("Monitoring");
            this.comboBox1.Items.Add("Povremena intervencija");
            this.comboBox1.Items.Add("Stalna zastita");
            this.comboBox1.SelectedIndex = 0;
        }

        private void PopuniMonitoring(OblastPregled oblast)
        {
            if (oblast.GetType() == typeof(OblastMonitoringPogled))
            {
                OblastMonitoringPogled op = (OblastMonitoringPogled)oblast;
                ListViewItem item = new ListViewItem(new string[]
                {
                            op.OblastId.ToString(),
                            op.OblastIme,
                            op.OblastPovrsina.ToString(),
                            op.BrojSela.ToString(),
                            op.BrojZivotinja.ToString(),
                            op.BrojBiljaka.ToString(),
                            op.BrojRadnika.ToString(),
                            op.BrojHranilista.ToString(),
                            op.TipZastite
                });
                listView1.Items.Add(item);
            }
        }

        private void PopuniPovremenuIntervenciju(OblastPregled oblast)
        {
            if (oblast.GetType() == typeof(OblastPovremenaIntervencijaPogled))
            {
                OblastPovremenaIntervencijaPogled op = (OblastPovremenaIntervencijaPogled)oblast;
                ListViewItem item = new ListViewItem(new string[]
                {
                            op.OblastId.ToString(),
                            op.OblastIme,
                            op.OblastPovrsina.ToString(),
                            op.BrojSela.ToString(),
                            op.BrojZivotinja.ToString(),
                            op.BrojBiljaka.ToString(),
                            op.BrojRadnika.ToString(),
                            op.BrojHranilista.ToString(),
                            op.TipZastite
                });
                listView1.Items.Add(item);
            }
        }

        private void PopuniStalnuZastitu(OblastPregled oblast)
        {
            if (oblast.GetType() == typeof(OblastStalnaZastitaPogled))
            {
                OblastStalnaZastitaPogled op = (OblastStalnaZastitaPogled)oblast;
                ListViewItem item = new ListViewItem(new string[]
                {
                            op.OblastId.ToString(),
                            op.OblastIme,
                            op.OblastPovrsina.ToString(),
                            op.BrojSela.ToString(),
                            op.BrojZivotinja.ToString(),
                            op.BrojBiljaka.ToString(),
                            op.BrojRadnika.ToString(),
                            op.BrojHranilista.ToString(),
                            op.TipZastite
                });
                listView1.Items.Add(item);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int selectedIndex = comboBox1.SelectedIndex;
            listView1.Items.Clear();
            if (selectedIndex == 0)
            {
                foreach (OblastPregled op in obInfos)
                {

                    this.PopuniMonitoring(op);
                    this.PopuniPovremenuIntervenciju(op);
                    this.PopuniStalnuZastitu(op);
                }
                listView1.Refresh();
            }
            else if (selectedIndex == 1)
            {
                foreach (OblastPregled op in obInfos)
                {
                    this.PopuniMonitoring(op);
                }
                listView1.Refresh();
            }
            else if (selectedIndex == 2)
            {
                foreach (OblastPregled op in obInfos)
                {
                    this.PopuniPovremenuIntervenciju(op);
                }
                listView1.Refresh();
            }
            else if (selectedIndex == 3)
            {
                foreach (OblastPregled op in obInfos)
                {
                    this.PopuniStalnuZastitu(op);
                }
                listView1.Refresh();
            }
        }

        private void cmdNazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdUcitajSelaOblasti_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite oblast za koju zelite da ucitate sela !");
                return;
            }
            int idOblasti = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            OblastBasic oblast = new OblastBasic();
            foreach(OblastBasic o in oblasti)
            {
                if(idOblasti == o.OblastId)
                {
                    oblast = o;
                }
            }
            NaziviSelaForm nzf = new NaziviSelaForm(oblast);
            nzf.Show();
            this.Close();
        }

        private void cmdUcitajZaposljene_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite oblast za koju zelite da ucitate radnike !");
                return;
            }
            int idOblasti = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            OblastBasic oblast = new OblastBasic();
            foreach (OblastBasic o in oblasti)
            {
                if (idOblasti == o.OblastId)
                {
                    oblast = o;
                }
            }

            RadniciOblastiForm rof = new RadniciOblastiForm(oblast);
            rof.Show();
            this.Close(); 
        }

        private void cmdUcitajHranilista_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite oblast za koju zelite da ucitate hranilista !");
                return;
            }
            int idOblasti = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            OblastBasic oblast = new OblastBasic();
            foreach (OblastBasic o in oblasti)
            {
                if (idOblasti == o.OblastId)
                {
                    oblast = o;
                }
            }
            if(oblast.GetType()!= typeof(StalnaZastitaBasic))
            {
                MessageBox.Show("Hranilista postoje samo u oblastima pod Stalnom zastitom !");
                return;
            }

            HranilistaForm hf = new HranilistaForm(oblast);
            hf.Show();
            this.Close();

        }

        private void cmdDodajOblast_Click(object sender, EventArgs e)
        {
            DodajOblastForm dof = new DodajOblastForm();
            dof.Show();
            this.Close();
        }

        private void cmdIzmeniOblast_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite oblast koju zelite da izmenite !");
                return;
            }
            int idOblasti = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            OblastBasic oblast = new OblastBasic();
            foreach (OblastBasic o in oblasti)
            {
                if (idOblasti == o.OblastId)
                {
                    oblast = o;
                }
            }
            IzmeniOblastForm izf = new IzmeniOblastForm(oblast);
            izf.Show();
            this.Close();
        }

        private void cmdObrisiOblat_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite oblast koje zelite da obrisete !", "OBAVESTENJE");
                return;
            }
            int IdOblasti = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            OblastBasic oblast = new OblastBasic();
            oblast.OblastId = IdOblasti;
            hranilista = DTOManager.GetHranilistaOblasti(oblast);
            
            string message = "Da li stvatno zelite da obrisete oblast?";
            string title = "Obrisi oblast";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                DTOManager.ObrisiVezuPripadaOblast(IdOblasti);
                DTOManager.ObrisiVezuRasteOblast(IdOblasti);
                foreach(HranilisteBasic h in hranilista) {
                    DTOManager.ObrisiVezuPrimecenaJeHraniliste(h.IdHranilista);
                    DTOManager.ObrisiHraniliste(h.IdHranilista);
                }
                


                DTOManager.ObrisiOblast(IdOblasti);

                this.UcitajOblasti();
                this.PopuniComboBox();

            }
        }
    }
}
