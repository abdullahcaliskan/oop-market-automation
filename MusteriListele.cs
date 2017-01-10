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
    public partial class MusteriListele : Form
    {
        Market market_global;
        public MusteriListele(Market market_param)
        {
            InitializeComponent();
            market_global = market_param;

        }

        private void gridMusteriler_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
                if (market_global.Musteriler.Count == 0)
                    MessageBox.Show("Hiç müşteri yok ve değişiklik yapamazsınız.","Uyarı Ekranı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                else
                {
                    int index = gridMusteriler.CurrentCell.RowIndex;
                    Communicator comm = new Communicator();
                    comm.Miktar = index;
                    MusteriEdit frm_musteriEdit = new MusteriEdit(market_global, comm);
                    frm_musteriEdit.ShowDialog();
                    if(comm.Response == "OK")
                    {
                        gridMusteriler.Rows.Clear();
                        gridMusteriler = market_global.MusteriListele(gridMusteriler);
                    }
                }            
            
        }

        private void MusteriListele_Load(object sender, EventArgs e)
        {
            gridMusteriler.Rows.Clear();
            gridMusteriler = market_global.MusteriListele(gridMusteriler);
        }
    }
}
