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
    public partial class IzmeniHranilisteForm : Form
    {
        HranilisteBasic hraniliste;
        public IzmeniHranilisteForm()
        {
            InitializeComponent();
        }
        public IzmeniHranilisteForm(HranilisteBasic h)
        {
            InitializeComponent();
            hraniliste = h;
        }

        private void popuniFormu()
        {
            this.dateTimePicker1.Value = hraniliste.DatumPocetka;
            this.dateTimePicker2.Value = hraniliste.DatumKraja;

        }

        private void cmdNazad_Click(object sender, EventArgs e)
        {
            HranilistaForm h = new HranilistaForm(hraniliste.pripadaOblasti);
            h.Show();
            this.Close();
        }

        private void cmdDodaj_Click(object sender, EventArgs e)
        {
            hraniliste.DatumKraja = this.dateTimePicker2.Value;
            hraniliste.DatumPocetka = this.dateTimePicker1.Value;

            DTOManager.IzmeniHraniliste(hraniliste);
            HranilistaForm h = new HranilistaForm(hraniliste.pripadaOblasti);
            h.Show();
            this.Close();
        }

        private void IzmeniHranilisteForm_Load(object sender, EventArgs e)
        {
            this.popuniFormu();
        }
    }
}
