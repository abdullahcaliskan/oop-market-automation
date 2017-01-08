using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Okul
{
    public class Urun : IKopyalanabilir
    {
        
        // Composition
        public UrunTanimi UrunBilgi = new UrunTanimi();
        public Tedarikci tedarikci = new Tedarikci();
        public int Miktar { get; set; }
        public decimal Fiyat { get; set; }

        public string BilgiGoster()
        {
            // Message box için kullanılabilir durumdaki 
            return (this.UrunBilgi.BarkodNo + " :: " +
                    this.UrunBilgi.Ad + " :: " +
                    Miktar + " :: " +
                    tedarikci.AdSoyad + " :: " +
                    UrunBilgi.EkAciklama + Environment.NewLine);
        }
        public void UrunEkle(string ad, int b_no, DateTime skt, string ek_aciklama, Tedarikci tdarikci, int miktar, decimal fiyat)
        {
            // TODO : Validation gerekli
            this.UrunBilgi.Ad = ad;
            this.UrunBilgi.BarkodNo = b_no;
            this.UrunBilgi.SKT = skt;
            this.UrunBilgi.EkAciklama = ek_aciklama;
            this.Miktar = miktar;
            this.Fiyat = fiyat;
            this.tedarikci = tdarikci;
        }

        public object Kopyala()
        {
            return this.MemberwiseClone();
        }
    }
}
