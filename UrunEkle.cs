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
    public partial class UrunEkle : Form
    {
        public void FormClear()
        {
            txtAd.Text = "";
            txtBarkodNo.Text = "";
            txtEkAciklama.Text = "";
            txtFiyat.Text = "";
            txtMiktar.Text = "";

        }
        int time = 0;
        Market market_global;
        ~UrunEkle()
        {
            cmbTedarikci.Items.Clear(); 
        }
        public UrunEkle(Market market_param)
        {
            InitializeComponent();
            // Urun nesnesi oluşturulup datalar çekilecek. 
            // Ardından method run edilecek
            

            ComboboxItem item = new ComboboxItem();
            cmbTedarikci.DisplayMember = "Text";
            cmbTedarikci.ValueMember = "Value";

            foreach (Tedarikci tdr in market_param.Tedarikciler)
            {
                cmbTedarikci.Items.Add(new { Text = tdr.AdSoyad, Value = tdr });

            }
            cmbTedarikci.SelectedIndex = 0;
            market_global = market_param;          
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            pbYukleniyor.Value = 0;
            time = 0;
            Urun u = new Urun();
            u.UrunEkle(txtAd.Text,
                       Convert.ToInt32(txtBarkodNo.Text),
                       Convert.ToDateTime(dateSKT.Text),
                       txtEkAciklama.Text,
                       (cmbTedarikci.SelectedItem as dynamic).Value,
                       Convert.ToInt32(txtMiktar.Text),
                       Convert.ToDecimal(txtFiyat.Text)
                       );
            timer.Start();
            string temp = market_global.Stok.UrunEkle(u);
            
        }
        
        private void timer_Tick(object sender, EventArgs e)
        {
            time++;      
            if (time <= pbYukleniyor.Maximum)
            {
                pbYukleniyor.Value = time;
                lblYuzde.Text = "%" + time;
                if (pbYukleniyor.Value == 1)
                {
                    lblProgressState.Text = "Ürün tanım bilgileri ekleniyor...";
                }
                else if (pbYukleniyor.Value == 50)
                {
                    lblProgressState.Text = "Ürün ekleniyor...";
                }
                else if (pbYukleniyor.Value == 100)
                {
                    lblProgressState.Text = "Ürün eklendi.";
                    FormClear();
                }
            }
            
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            FormClear();
        }
    }
}

