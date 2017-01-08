using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP_Okul
{
    public class Muhasebe
    {
        public Muhasebe()
        {
            Satislar = new List<SatisKalemi>();
        }
        public List<SatisKalemi> Satislar { get; private set; }
        public decimal GenelToplam { get; private set; }
        public int SatilanUrunSayisi { get; private set; }

        public void SatisEkle(SatisKalemi s)
        {
            this.Satislar.Add(s);
            this.GenelToplam += s.SatisToplam;
            foreach (Urun u in s.SatilanUrunler)
            {
                this.SatilanUrunSayisi += u.Miktar;
            }
        }

        public string Listele()
        {
            string temp = "";
            foreach (SatisKalemi item in this.Satislar)
            {
                if (item.Alici != null)
                    temp += item.Alici.AdSoyad + " :: ";
                else
                    temp += "[Bilinmeyen Alıcı] :: ";
                foreach (Urun u in item.SatilanUrunler)
                {
                    temp += u.UrunBilgi.BarkodNo + " :: " + u.UrunBilgi.Ad + " :: " + u.Miktar + " || ";
                }
                temp += "Toplam : " + item.SatisToplam + " Tarih : " + item.SatisTarihi + Environment.NewLine;
            }   
            return temp;
        }
    }
}
