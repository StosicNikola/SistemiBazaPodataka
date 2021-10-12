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
    public partial class IzmeniDatumForm : Form
    {
        PrimecenaJeBasic primecena;
        public IzmeniDatumForm()
        {
            InitializeComponent();
        }

        public IzmeniDatumForm(PrimecenaJeBasic pjb)
        {
            InitializeComponent();
            this.primecena = pjb;
        }

        private void podesiDatum()
        {
            this.dateTimePicker1.Value = primecena.DatumVidjenja;
        }

        private void IzmeniDatumForm_Load(object sender, EventArgs e)
        {
            this.podesiDatum();
        }

        private void cmdNazad_Click(object sender, EventArgs e)
        {
            PrimecenaJeForm pj = new PrimecenaJeForm(primecena.hraniliste);
            pj.Show();
            this.Close();
        }

        private void cmdIzmeni_Click(object sender, EventArgs e)
        {
            DateTime novo = this.dateTimePicker1.Value;
            PrimecenaJeBasic p = new PrimecenaJeBasic(primecena.zivotinja, primecena.hraniliste, novo);
            DTOManager.ObrisiVezuPrimecenaJeZivotinja(p.zivotinja.IdZivotinje);
            DTOManager.DodajNovuZivotinjuUHraniliste(p);
            PrimecenaJeForm pj = new PrimecenaJeForm(primecena.hraniliste);
            pj.Show();
            this.Close();
        }
    }
}
