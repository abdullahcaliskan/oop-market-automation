using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Okul
{
    public class Personel : Kisi
    {
        public Int64 SGKNo { get; set; }
        public int PersonelNo { get; set; }
        public decimal Maas { get; set; }
        public DateTime GirisTarihi { get; set; }

        public override void BilgiGoster()
        {
            this.info = "SGKNo:" + SGKNo + Environment.NewLine +
                        " Personel No:" + PersonelNo + Environment.NewLine +
                        " Maaş:" + Maas + Environment.NewLine +
                        " GirisTarihi:" + GirisTarihi.ToString() + Environment.NewLine +
                        " AdSoyad:" + AdSoyad + Environment.NewLine +
                        " TelefonNO:" + TelefonNo + Environment.NewLine +
                        " Email:" + Email + Environment.NewLine +
                        " Adres:" + Adres.AdresConcat();
        }
        public override int Validation()
        {
            base.Validation();
            if (SGKNo == 0 || PersonelNo == 0 || Maas == 0)
            {
                this.info += "Personel için gerekli bilgiler girilmelidir.";
                return 1;
            }
            return 0;
                
        }
    }
}
