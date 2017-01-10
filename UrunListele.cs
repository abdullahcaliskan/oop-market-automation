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
    public partial class UrunListele : Form
    {
        Market market_global;

        public UrunListele(Market market_param)
        {
            InitializeComponent();

            gridUrunler = market_param.Stok.UrunListele(gridUrunler);           
            market_global = market_param;
        }

        private void UrunListele_Load(object sender, EventArgs e)
        {

        }

        private void gridUrunler_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int index = gridUrunler.CurrentCell.RowIndex;
                int bNo = market_global.Stok.Urunler[index].UrunBilgi.BarkodNo;
                int adet = market_global.Stok.Urunler[index].Miktar;

                Communicator comm = new Communicator() { Miktar = adet };
                comm.InfoMessage = "Ürün miktarını giriniz. Şuan stokta: " + comm.Miktar.ToString();

                PromptDialog prompt = new PromptDialog(comm);
                prompt.Text = "Dikkat!";
                prompt.ShowDialog();
                

                // Yanıt kontrol
                //MessageBox.Show(comm.Response.ToString());
                if(comm.Response == "EKLE") // Miktar arttirma işlemi başlasın.
                {
                    market_global.Stok.UrunMiktarDegistir(market_global.Stok.Urunler[index],
                                                          comm.PromptMiktar,
                                                          index,
                                                          'a');
                }
                else if(comm.Response == "CIKAR")
                {
                    market_global.Stok.UrunMiktarDegistir(market_global.Stok.Urunler[index],
                                                          comm.PromptMiktar,
                                                          index,
                                                          'c');
                }
                else if(comm.Response == "SIL")
                {
                    market_global.Stok.UrunSil(index);
                }

                if(comm.Response != null)
                {
                    MessageBox.Show("İşlem başarılı bir şekilde tamamlandı.","Bilgi Ekranı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    gridUrunler.Rows.Clear();
                    gridUrunler = market_global.Stok.UrunListele(gridUrunler);
                }
                

            }
            catch (Exception)
            {
                MessageBox.Show("Bir sorunla karşılaşıldı. Feedbacklerinizi bekliyoruz, teşekkürler.","Uyarı Ekranı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                this.Close();
            }           
        }
    }
}
