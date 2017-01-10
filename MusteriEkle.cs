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
    public partial class MusteriEkle : Form
    {
        Market market_global;
        public MusteriEkle(Market market_param)
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
        private void btnEkle_Click(object sender, EventArgs e)
        {
            string telefon = txtTelefon.Text;
            string postaKodu = txtPostaKodu.Text;

            Musteri m = new Musteri();
            m.AdSoyad = txtAd.Text;
            m.Email = txtEmail.Text;
            m.KayitTarihi = Convert.ToDateTime(dateKayitTarihi.Text);
            m.TelefonNo = Convert.ToInt64(txtTelefon.Text);
            
            m.Adres.Il = txtIl.Text;
            m.Adres.Ilce = txtIlce.Text;
            m.Adres.PostaKodu = Convert.ToInt32(txtPostaKodu.Text);
            m.Adres.AcikAdres = txtAcikAdres.Text;

            int lastIndex = market_global.Musteriler.Count;

            m.MusteriPuan = 0;
            if (lastIndex == 0)
                m.MusteriNo = 1;
            else
            {
                lastIndex--;
                m.MusteriNo = market_global.Musteriler[lastIndex].MusteriNo + 1;
            }
            if (m.Validation() == 1) // Validation hatası var
            {
                MessageBox.Show(m.Info + " Eklenemedi.");
            }
            else
            {
                string mesaj = market_global.ListeEkle(market_global.Musteriler, m);
                MessageBox.Show(mesaj);
            }
            
            FormClear();

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            FormClear();
        }
    }
}
