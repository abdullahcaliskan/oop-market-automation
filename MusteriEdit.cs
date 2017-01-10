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
    public partial class MusteriEdit : Form
    {
        Market market_global;
        Communicator comm_global;
        public MusteriEdit(Market market_param, Communicator comm)
        {
            InitializeComponent();
            market_global = market_param;
            comm_global = comm;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            Musteri m = new Musteri();
            m.AdSoyad = txtAd.Text;
            m.Email = txtEmail.Text;
            m.KayitTarihi = Convert.ToDateTime(dateKayitTarihi.Text);
            m.TelefonNo = Convert.ToInt64(txtTelefon.Text);
            m.Adres.Il = txtIl.Text;
            m.Adres.Ilce = txtIlce.Text;
            m.Adres.PostaKodu = Convert.ToInt32(txtPostaKodu.Text);
            m.Adres.AcikAdres = txtAcikAdres.Text;

            MessageBox.Show(market_global.ListGuncelle(market_global.Musteriler, m, comm_global.Miktar).ToString());
            comm_global.Response = "OK";
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            MessageBox.Show(market_global.ListRemoveAt(market_global.Musteriler, comm_global.Miktar).ToString());
            comm_global.Response = "OK";
            this.Close();
        }

        private void MusteriEdit_Load(object sender, EventArgs e)
        {
            // miktar , communicator classından gelirken index olarak ayarlandı
            Musteri m_list = market_global.GetObjectOnList(market_global.Musteriler, comm_global.Miktar);
            txtAd.Text = m_list.AdSoyad;
            txtEmail.Text = m_list.Email;
            dateKayitTarihi.Text = m_list.KayitTarihi.ToString();
            txtTelefon.Text = m_list.TelefonNo.ToString();
            txtIl.Text = m_list.Adres.Il;
            txtIlce.Text = m_list.Adres.Ilce;
            txtPostaKodu.Text = m_list.Adres.PostaKodu.ToString();
            txtAcikAdres.Text = m_list.Adres.AcikAdres;
        }
    }
}
