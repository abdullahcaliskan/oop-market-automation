using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeFinal
{
    public enum eBirim
    {
        kilogram = 1,
        adet = 2
    };
    public class Urun
    {
        // Composition
        public UrunTanimi UrunBilgi = new UrunTanimi();
        // Aggregation
        public Tedarikci tedarikci;
        public int Miktar { get; set; }
        public decimal Fiyat { get; set; }
        public eBirim Birim { get; set; }

        public string BilgiGoster()
        {
            return ("Adı : " + this.UrunBilgi.Ad + Environment.NewLine +
                    "BarkodNo : " + this.UrunBilgi.BarkodNo + Environment.NewLine +
                    "Miktar : " + this.Miktar + Environment.NewLine +
                    "Birim : " + this.Birim + Environment.NewLine +
                    "Fiyat : " + this.Fiyat + Environment.NewLine +
                    "Ek Açıklama : " + this.UrunBilgi.EkAciklama);
        }
    }
}
