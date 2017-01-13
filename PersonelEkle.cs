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
    public partial class PersonelEkle : Form
    {
        Market market_global;
        public PersonelEkle(Market market_param)
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
            txtTC.Text = "";
            txtSGK.Text = "";
            txtMaas.Text = "";
            txtKanGrubu.Text = "";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Personel p = new Personel();
            // Aggregation yapısı oldugu için nesnemizi burada oluşturuyoruz.
            p.Kimlik = new KimlikBilgi();
            p.AdSoyad = txtAd.Text;
            p.Email = txtEmail.Text;
            p.KayitTarihi = Convert.ToDateTime(dateKayitTarihi.Text);
            p.TelefonNo = Convert.ToInt64(txtTelefon.Text);
            p.Adres.Il = txtIl.Text;
            p.Kimlik.KanGrubu = txtKanGrubu.Text;
            p.Adres.Ilce = txtIlce.Text;
            p.Adres.PostaKodu = Convert.ToInt32(txtPostaKodu.Text);
            p.Adres.AcikAdres = txtAcikAdres.Text;
            p.Kimlik.DogumTarihi = Convert.ToDateTime(dateDogumTarihi.Text);
            p.Kimlik.TCNo = Convert.ToInt64(txtTC.Text);
            if (radioBay.Checked)
                p.Kimlik.cinsiyet = Cinsiyet.Bay;
            else
                p.Kimlik.cinsiyet = Cinsiyet.Bayan;
            if (radioEvli.Checked)
                p.Kimlik.medeniHal = MedeniHal.Evli;
            else
                p.Kimlik.medeniHal = MedeniHal.Bekar;

            p.SGKNo = Convert.ToInt64(txtSGK.Text);
            p.Maas = Convert.ToDecimal(txtMaas.Text);
            p.GirisTarihi = DateTime.Now;

            int last_index = market_global.Personeller.Count;
            if(last_index == 0) // Hiç personel ekli değilse.
            {
                p.PersonelNo = 1;
            }
            else
            {
                // Son personel numarasını alıp onu 1 arttırmak
                p.PersonelNo = market_global.Personeller[last_index - 1].PersonelNo + 1;
            }

            MessageBox.Show(market_global.ListeEkle(market_global.Personeller, p).ToString());
            FormClear();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            FormClear();
        }
    }
}
