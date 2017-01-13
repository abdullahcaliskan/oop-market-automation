using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Okul
{
    public partial class PersonelListele : Form
    {
        Market market_glob;

        public PersonelListele(Market market_param)
        {
            market_glob = market_param;
            InitializeComponent();
        }

        private void PersonelListele_Load(object sender, EventArgs e)
        {
            gridMusteriler = market_glob.PersonelListele(gridMusteriler);
        }

        private void gridMusteriler_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
