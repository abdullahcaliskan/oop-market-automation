using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeFinal
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
    }
}
