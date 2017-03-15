using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace OOP_Okul
{
    public partial class SatisYap : Form
    {
        Market market_global;
        SatisKalemi fis = new SatisKalemi();
        public SatisYap(Market market_param)
        {
            InitializeComponent();
            ComboboxItem item = new ComboboxItem();
            comboMusteri.DisplayMember = "Text";
            comboMusteri.ValueMember = "Value";

            foreach (Musteri m in market_param.Musteriler)
            {
                comboMusteri.Items.Add(new { Text = m.AdSoyad, Value = m });
            }
            market_global = market_param;
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            // Arama işlemi yapılabilir.
            if(txtBarkodNo.Text.Length >= 2)
            {
                market_global.Stok.UrunArama(gridStok, txtBarkodNo.Text);
            }
            else
            {
                gridStok.Rows.Clear();
            }
        }

        private void btnFiseEkle_Click(object sender, EventArgs e)
        {
            try
            {

                int selected_index = gridStok.CurrentCell.RowIndex;
                Urun selected_urun = new Urun();
                selected_urun = market_global.Stok.Urunler[selected_index];
                if (selected_urun.Miktar <= 0)
                    MessageBox.Show("Stok miktarı az.", "Uyarı Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    selected_urun.Miktar -= 1;
                    Urun copy_urun = new Urun();
                    copy_urun = (Urun)selected_urun.Kopyala();
                    copy_urun.Miktar = 1;

                    int ret_index = market_global.Stok.UrunArama(copy_urun.UrunBilgi.BarkodNo, fis.SatilanUrunler);
                    if(ret_index == -1)
                    {
                        fis.SatilanUrunler.Add(copy_urun);
                    }
                    else
                    {
                        fis.SatilanUrunler[ret_index].Miktar += 1;
                    }
                    gridFis.Rows.Clear();
                    gridStok.Rows.Clear();
                    market_global.Stok.UrunListele(gridFis, fis.SatilanUrunler);
                    market_global.Stok.UrunListele(gridStok, market_global.Stok.Urunler);
                    fis.SatisToplamHesapla();
                    lblToplam.Text = fis.SatisToplam.ToString();
                    lblTarih.Text = fis.SatisTarihi.ToString();
                    
                    
                }
            }
            catch
            {
                MessageBox.Show("Yazılım ekibi ile irtibata geçiniz.\nOlası çözümler: Ürün barkod numarasını girmeyi veya ürün seçmeyi deneyin.", "Uyarı Ekranı"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void SatisYap_Load(object sender, EventArgs e)
        {

        }

        private void btnFiseMultipleEkle_Click(object sender, EventArgs e)
        {
            try
            {
                int form_miktar = Convert.ToInt32(txtMiktar.Text);
                int selected_index = gridStok.CurrentCell.RowIndex;
                Urun selected_urun = new Urun();

                selected_urun = market_global.Stok.Urunler[selected_index];
                if (selected_urun.Miktar - form_miktar < 0)
                    MessageBox.Show("Stok miktarı az.", "Uyarı Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    selected_urun.Miktar -= form_miktar;
                    Urun copy_urun = new Urun();
                    copy_urun = (Urun)selected_urun.Kopyala();
                    copy_urun.Miktar = form_miktar;

                    int ret_index = market_global.Stok.UrunArama(copy_urun.UrunBilgi.BarkodNo, fis.SatilanUrunler);
                    if (ret_index == -1)
                    {
                        fis.SatilanUrunler.Add(copy_urun);
                    }
                    else
                    {
                        fis.SatilanUrunler[ret_index].Miktar += form_miktar;
                    }
                    gridFis.Rows.Clear();
                    gridStok.Rows.Clear();
                    market_global.Stok.UrunListele(gridFis, fis.SatilanUrunler);
                    market_global.Stok.UrunListele(gridStok, market_global.Stok.Urunler);
                    fis.SatisToplamHesapla();
                    lblToplam.Text = fis.SatisToplam.ToString();
                    lblTarih.Text = fis.SatisTarihi.ToString();
                    

                }
            }
            catch
            {
                MessageBox.Show("Yazılım ekibi ile irtibata geçiniz.\nOlası çözümler: Ürün barkod numarasını girmeyi veya ürün seçmeyi deneyin.", "Uyarı Ekranı"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFistenMultipleSil_Click(object sender, EventArgs e)
        {
            try
            {
                int form_miktar = Convert.ToInt32(txtMiktar.Text);
                int selected_index = gridFis.CurrentCell.RowIndex;
                Urun selected_urun = new Urun();

                selected_urun = fis.SatilanUrunler[selected_index];
                if (selected_urun.Miktar - form_miktar < 0)
                    MessageBox.Show("Stok miktarı az.","Uyarı Ekranı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                else
                {
                    selected_urun.Miktar -= form_miktar;
                    Urun copy_urun = new Urun();
                    copy_urun = (Urun)selected_urun.Kopyala();
                    copy_urun.Miktar = form_miktar;

                    int ret_index = market_global.Stok.UrunArama(copy_urun.UrunBilgi.BarkodNo, market_global.Stok.Urunler);
                    if (ret_index == -1)
                    {
                        market_global.Stok.Urunler.Add(copy_urun);
                    }
                    else
                    {
                        market_global.Stok.Urunler[ret_index].Miktar += form_miktar;
                    }
                    if(selected_urun.Miktar == 0)
                    {
                        fis.SatilanUrunler.RemoveAt(selected_index);
                    }
                    gridFis.Rows.Clear();
                    gridStok.Rows.Clear();
                    market_global.Stok.UrunListele(gridFis, fis.SatilanUrunler);
                    market_global.Stok.UrunListele(gridStok, market_global.Stok.Urunler);
                    fis.SatisToplamHesapla();
                    lblToplam.Text = fis.SatisToplam.ToString();
                    lblTarih.Text = fis.SatisTarihi.ToString();
                    

                }
            }
            catch
            {
                MessageBox.Show("Yazılım ekibi ile irtibata geçiniz.\nOlası çözümler: Ürün barkod numarasını girmeyi veya ürün seçmeyi deneyin.", "Uyarı Ekranı"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFisdenSil_Click(object sender, EventArgs e)
        {
            try
            {

                int selected_index = gridFis.CurrentCell.RowIndex;
                Urun selected_urun = new Urun();
                selected_urun = fis.SatilanUrunler[selected_index];
                if (selected_urun.Miktar <= 0)
                    MessageBox.Show("Stok miktarı az.");
                else
                {
                    selected_urun.Miktar -= 1;
                    Urun copy_urun = new Urun();
                    copy_urun = (Urun)selected_urun.Kopyala();
                    copy_urun.Miktar = 1;

                    int ret_index = market_global.Stok.UrunArama(copy_urun.UrunBilgi.BarkodNo, market_global.Stok.Urunler);
                    if (ret_index == -1)
                    {
                        fis.SatilanUrunler.Add(copy_urun);
                    }
                    else
                    {
                        market_global.Stok.Urunler[ret_index].Miktar += 1;
                    }
                    if(selected_urun.Miktar == 0)
                    {
                        fis.SatilanUrunler.RemoveAt(selected_index);
                    }
                    gridFis.Rows.Clear();
                    gridStok.Rows.Clear();
                    market_global.Stok.UrunListele(gridFis, fis.SatilanUrunler);
                    market_global.Stok.UrunListele(gridStok, market_global.Stok.Urunler);
                    fis.SatisToplamHesapla();
                    lblToplam.Text = fis.SatisToplam.ToString();
                    lblTarih.Text = fis.SatisTarihi.ToString();
                    

                }
            }
            catch
            {
                MessageBox.Show("Yazılım ekibi ile irtibata geçiniz.\nOlası çözümler: Ürün barkod numarasını girmeyi veya ürün seçmeyi deneyin.","Uyarı Ekranı"
                    ,MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            if (comboMusteri.SelectedIndex > -1) // Müşteri seçilmiş.
            {
                fis.AliciGuncelle((comboMusteri.SelectedItem as dynamic).Value);
                fis.Alici.MusteriPuan++;
            }
            market_global.Hesaplar.SatisEkle(fis);
            MessageBox.Show("Satış işlemi gerçekleştirildi.","Bilgi Ekranı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
        }
    }
}
