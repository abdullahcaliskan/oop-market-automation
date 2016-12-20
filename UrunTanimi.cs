using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeFinal
{
    public class UrunTanimi
    {
        // Aggregation
        public UreticiFirma Uretici;
        public string Ad { get; set; }
        public int BarkodNo { get; set; }
        public DateTime SKT { get; set; }
        public string EkAciklama { get; set; }
        // TODO : Enum Kategori eklenecek
    }
}
