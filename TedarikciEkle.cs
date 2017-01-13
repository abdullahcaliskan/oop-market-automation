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
    public partial class TedarikciEkle : Form
    {
        Market market_global;
        
        public TedarikciEkle(Market market_param)
        {
            InitializeComponent();
            market_global = market_param;
            
            
        }
        public void FormClear()
        {
            txtAcikAdres.Text = "";
            txtAd.Text = "";
            txtEmail.Text = "";
            txtIl.Text = "";
            txtIlce.Text = "";
            txtPostaKodu.Text = "";
            txtTelefon.Text = "";
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            FormClear();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Tedarikci t = new Tedarikci();
            t.AdSoyad = txtAd.Text;
            t.Email = txtEmail.Text;
            t.KayitTarihi = Convert.ToDateTime(dateKayitTarihi.Text);
            t.TelefonNo = Convert.ToInt64(txtTelefon.Text);
            t.Adres.Il = txtIl.Text;
            t.Adres.Ilce = txtIlce.Text;
            t.Adres.PostaKodu = Convert.ToInt16(txtPostaKodu.Text);
            t.Adres.AcikAdres = txtAcikAdres.Text;

            int lastIndex = market_global.Tedarikciler.Count;

            if (lastIndex == 0)
                t.TedarikciNo = 1;
            else
            {
                lastIndex--;
                t.TedarikciNo = market_global.Tedarikciler[lastIndex].TedarikciNo + 1;
            }
            string mesaj = market_global.ListeEkle(market_global.Tedarikciler, t);
            MessageBox.Show(mesaj);
            FormClear();
        }
    }
}
