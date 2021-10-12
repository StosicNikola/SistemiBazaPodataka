using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ParkPrirode
{
    public partial class OblastInformacije : Form
    {
        public OblastInformacije()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OblastInformacije_Load(object sender, EventArgs e)
        {
            this.PopuniInfos();
        }

        private void PopuniInfos()
        {
            listView1.Items.Clear();
            List<OblastPregled> obInfos = DTOManager.GetObInfos();
            foreach(OblastPregled op in obInfos)
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
        }
    }
}
