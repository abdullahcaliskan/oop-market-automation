using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeFinal
{
    public class SatisKalemi
    {
        private List<Urun> SatilanUrunler = new List<Urun>();
        public Musteri Alici { get; private set; }
        public decimal SatisToplam { get; private set; }
        public DateTime SatisTarihi { get; private set; }

        public void SatisToplamHesapla()
        {
            decimal tutar;
            foreach (Urun u in SatilanUrunler)
            {
                tutar = u.Miktar * u.Fiyat;
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
    }
}
