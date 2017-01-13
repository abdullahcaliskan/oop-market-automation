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
    public partial class HesapDokumu : Form
    {
        Market market_global;
        public HesapDokumu(Market market_param)
        {
            InitializeComponent();
            market_global = market_param;
        }

        private void HesapDokumu_Load(object sender, EventArgs e)
        {
            txtKayitlar.Text = market_global.Hesaplar.Listele();
            lblSayi.Text = market_global.Hesaplar.SatilanUrunSayisi.ToString();
            lblTutar.Text =  market_global.Hesaplar.GenelToplam.ToString();
        }
    }
}
