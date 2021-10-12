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
    public partial class IzmeniOblastForm : Form
    {
        OblastBasic oblast;
        public IzmeniOblastForm()
        {
            InitializeComponent();
        }

        public IzmeniOblastForm(OblastBasic ob)
        {
            InitializeComponent();
            oblast = ob;
        }

        private void PopuniFormu()
        {
            this.txtImeOblasti.Text = this.oblast.Ime;
            this.txtPovrsina.Text = this.oblast.Povrsina.ToString();
        }

        private void cmdNazad_Click(object sender, EventArgs e)
        {
            OblastForm1 ob = new OblastForm1();
            ob.Show();
            this.Close();
        }

        private void IzmeniOblastForm_Load(object sender, EventArgs e)
        {
            this.PopuniFormu();
        }

        private void cmdDodajOblast_Click(object sender, EventArgs e)
        {
            if (txtImeOblasti.Text == "")
            {
                MessageBox.Show("Niste uneli ime oblasti!");
                return;
            }
            String imeOblasti = txtImeOblasti.Text;
            if (txtPovrsina.Text == "")
            {
                MessageBox.Show("Niste uneli povrsinu!");
                return;
            }
            float povrsina = float.Parse(txtPovrsina.Text);
            OblastBasic o = new OblastBasic(oblast.OblastId, imeOblasti, povrsina);
            DTOManager.IzmeniOblast(o);
            OblastForm1 ob = new OblastForm1();
            ob.Show();
            this.Close();
        }
    }
}
