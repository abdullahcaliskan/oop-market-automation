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
    public partial class Form1 : Form
    {
        Market supermarket = new Market();
        public Form1()
        {
            InitializeComponent();
            Tedarikci t = new Tedarikci();
            t.AdSoyad = "Tedarikci1";
            t.Adres.Ilce = "ilce";
            t.Adres.PostaKodu = 4;
            t.Adres.AcikAdres = "acik";
            t.Email = "Email";
            t.KayitTarihi = Convert.ToDateTime("24.12.2016");
            t.TedarikciNo = 1;
            t.TelefonNo = 123123;
            t.Adres.Il = "İl";

            Urun u = new Urun();
            u.UrunEkle("gofret", 123, Convert.ToDateTime("26.12.2016"),"ek aciklama",t,2,12.98M);

            supermarket.Stok.UrunEkle(u);

            supermarket.ListeEkle(supermarket.Tedarikciler, t);
        }

        private void msUrunEkle_Click(object sender, EventArgs e)
        {
            // Aggregation yapısını burada kuruyoruz.
            if (supermarket.Stok.Urunler == null)
            {
                supermarket.Stok.Urunler = new List<Urun>();
            }
            else
            {
                UrunEkle frm_UrunEkle = new UrunEkle(supermarket);
                frm_UrunEkle.ShowDialog();
            }
        }

        private void msUrunListele_Click(object sender, EventArgs e)
        {
            UrunListele frm_UrunListele = new UrunListele(supermarket);
            frm_UrunListele.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "root" && txtPass.Text == "12345")
            {
                ustMenu.Visible = true;
                gbKullaniciGirisi.Visible = false;
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya parola hatalı!.");
            }
        }

        private void msCikis_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtPass.Text = "";
            ustMenu.Visible = false;
            gbKullaniciGirisi.Visible = true;
        }

        private void msTedarikciEkle_Click(object sender, EventArgs e)
        {
            TedarikciEkle frm_tedarikciEkle = new TedarikciEkle(supermarket);
            frm_tedarikciEkle.ShowDialog();
        }

        private void msTedarikciListele_Click(object sender, EventArgs e)
        {
            TedarikciListele frm_tedarikciListele = new TedarikciListele(supermarket);
            frm_tedarikciListele.ShowDialog();
        }

        private void msMusteriEkle_Click(object sender, EventArgs e)
        {
            MusteriEkle frm_musteriEkle = new MusteriEkle(supermarket);
            frm_musteriEkle.ShowDialog();
        }

        private void msMusteriListele_Click(object sender, EventArgs e)
        {
            MusteriListele frm_musteriListele = new MusteriListele(supermarket);
            frm_musteriListele.ShowDialog();
        }

        private void msPersonelEkle_Click(object sender, EventArgs e)
        {
            PersonelEkle frm_personelEkle = new PersonelEkle(supermarket);
            frm_personelEkle.ShowDialog();

        }

        private void msPersonelListele_Click(object sender, EventArgs e)
        {
            PersonelListele frm_personelListele = new PersonelListele(supermarket);
            frm_personelListele.ShowDialog();
        }

        private void msSatisYap_Click(object sender, EventArgs e)
        {
            SatisYap frm_satisYap = new SatisYap(supermarket);
            frm_satisYap.ShowDialog();
        }
    }
}
