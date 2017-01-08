using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Okul
{
    public abstract class Kisi
    {
        // Aggregation
        public KimlikBilgi Kimlik;
        // Composition
        public AdresBilgi Adres = new AdresBilgi();
        public string AdSoyad { get; set; }
        public Int64 TelefonNo { get; set; }
        public string Email { get; set; }
        public DateTime KayitTarihi { get; set; }
        protected string info;

        public string Info
        {
            get { return info; }
        }

        public abstract void BilgiGoster();
        public virtual int Validation()
        {
            if (AdSoyad == "" || TelefonNo == 0 || Email == "" || Kimlik.TCNo == 0 || Adres.AcikAdres == "")
            {
                this.info = "Alanların doldurulması gerekmektedir." + Environment.NewLine;
                return (1);
            }
            return (0);
                
        }

        
    }
}
