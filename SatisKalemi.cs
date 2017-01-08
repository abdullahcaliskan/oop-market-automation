using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Okul
{
    public class SatisKalemi
    {
        public SatisKalemi()
        {
            SatilanUrunler = new List<Urun>();
        }
        public List<Urun> SatilanUrunler { get; private set; }
        public Musteri Alici { get; private set; }
        public decimal SatisToplam { get; private set; }
        public DateTime SatisTarihi { get; private set; }

        public void SatisToplamHesapla()
        {
            this.SatisToplam = 0;
            decimal tutar;
            foreach (Urun u in SatilanUrunler)
            {
                tutar = (decimal)u.Miktar * u.Fiyat;
                this.SatisToplam += tutar;
            }
            // Satışı kaydet dediğin zaman, bu method toplanır ve tarih burada güncellenir.
            this.SatisTarihi = DateTime.Now;
        }
        public void AliciGuncelle(Musteri m)
        {
            // Bu şekilde yapınca zaten, reference tipini alıyor içerik olarak
            this.Alici = m;
        }

     /*   public void DataTransferSingle(Market market_param, DataGridView sourceGrid, List<Urun> sourceList, List<Urun> targetList, char islem)
        {
            int sourceIndex = sourceGrid.CurrentCell.RowIndex;

            Urun sourceUrun = new Urun();
            sourceUrun = sourceList[sourceIndex];
            if(sourceUrun.Miktar <= 0) // Miktar yetersiz, urun çıkışı yapılamaz
            {
                MessageBox.Show("Miktar yetersiz.");
            }
            else // Miktar ile sorunumuz yok
            {
                Urun copyUrun = (Urun)sourceUrun.Kopyala();
                sourceUrun.Miktar--;
                copyUrun.Miktar = 1;

                // Karşı listeye aktarma yapılırken, Ürün orada bulunabilir varsa o değeri arttıracağız
                int ret_index = market_param.Stok.UrunArama(sourceUrun.UrunBilgi.BarkodNo, targetList);
                if ( ret_index == -1 ) // Ürün bulunamadıysa
                {
                    targetList.Add(copyUrun);
                }
                else
                {
                    targetList[ret_index].Miktar += 1;
                }
                if (islem == 'd' && sourceList[sourceIndex].Miktar <= 1) // Source List'ten sil.
                {
                    sourceList.RemoveAt(sourceIndex);
                }
            }
        }*/
    }
}
