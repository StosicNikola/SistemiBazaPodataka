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
    public partial class DodajHranilisteForm : Form
    {
        OblastBasic oblast;
        public DodajHranilisteForm()
        {
            InitializeComponent();
        }

        public DodajHranilisteForm(OblastBasic o)
        {
            InitializeComponent();
            this.oblast = o;
        }

        private void cmdNazad_Click(object sender, EventArgs e)
        {
            HranilistaForm hf = new HranilistaForm(oblast);
            hf.Show();
            this.Close();
        }

        private void cmdDodaj_Click(object sender, EventArgs e)
        {
            HranilisteBasic novoHra = new HranilisteBasic();
            novoHra.DatumPocetka = this.dateTimePicker1.Value;
            novoHra.DatumKraja = this.dateTimePicker2.Value;
            novoHra.pripadaOblasti = oblast;
            DTOManager.DodajHraniliste(novoHra);
            HranilistaForm hf = new HranilistaForm(oblast);
            hf.Show();
            this.Close();
        }
    }
}
