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
    public partial class DodajOblastForm : Form
    {
        public DodajOblastForm()
        {
            InitializeComponent();
        }

        private void cmdNazad_Click(object sender, EventArgs e)
        {
            OblastForm1 ob = new OblastForm1();
            ob.Show();
            this.Close();
        }

        private void DodajOblastForm_Load(object sender, EventArgs e)
        {
            this.PopuniComboBox();
        }
        private void PopuniComboBox()
        {
            this.comboBox1.Items.Clear();
            this.comboBox1.Items.Add("Monitoring");
            this.comboBox1.Items.Add("Povremena intervencija");
            this.comboBox1.Items.Add("Stalna zastita");
            this.comboBox1.SelectedIndex = 0;
        }

        private void cmdDodajOblast_Click(object sender, EventArgs e)
        {
            if(txtImeOblasti.Text == "")
            {
                MessageBox.Show("Niste uneli ime oblasti!");
                return;
            }
            String imeOblasti = txtImeOblasti.Text;
            if(txtPovrsina.Text == "")
            {
                MessageBox.Show("Niste uneli povrsinu!");
                return;
            }
            float povrsina = float.Parse(txtPovrsina.Text);
            int selectedIndex = comboBox1.SelectedIndex;
            if (selectedIndex == 0)
            {
                MonitoringBasic oblast = new MonitoringBasic(0, imeOblasti, povrsina, "");
                DTOManager.DodajOblast(oblast);
            }
            else if (selectedIndex == 1)
            {
                PovremenaIntervencijaBasic oblast = new PovremenaIntervencijaBasic(0, imeOblasti, povrsina, "");
                DTOManager.DodajOblast(oblast);
            }
            else if(selectedIndex == 2)
            {

                StalnaZastitaBasic oblast = new StalnaZastitaBasic(0, imeOblasti, povrsina, "");
                DTOManager.DodajOblast(oblast);
            }
           
            OblastForm1 ob = new OblastForm1();
            ob.Show();
            this.Close();
        }
    }
}
