using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Okul
{
    public class AdresBilgi
    {
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string AcikAdres { get; set; }
        public int PostaKodu { get; set; }

        public string AdresConcat()
        {
            string full_address = "";
            full_address = this.AcikAdres + " " + this.Ilce + " " + this.Il + " " + this.PostaKodu;
            return (full_address);
        }
    }
}
