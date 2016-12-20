using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeFinal
{
    public class Personel : Kisi
    {
        public Int64 SGKNo { get; set; }
        public int PersonelNo { get; set; }
        public decimal Maas { get; set; }
        public DateTime GirisTarihi { get; set; }
    }
}
