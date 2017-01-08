using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Okul
{
    public enum Cinsiyet
    {
        Bay,
        Bayan
    }
    public enum MedeniHal
    {
        Evli,
        Bekar
    }
    public class KimlikBilgi
    {
        public Int64 TCNo { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string KanGrubu { get; set; }
        public MedeniHal medeniHal{ get; set; }
        public Cinsiyet cinsiyet { get; set; }
    }
}
