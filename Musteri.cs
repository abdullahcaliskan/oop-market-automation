using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Okul
{
    public class Musteri : Kisi
    {
        public int MusteriNo { get; set; }
        public int MusteriPuan { get; set; }

        public override void BilgiGoster()
        {
            this.info = "MüşteriNo:" + MusteriNo + Environment.NewLine +
                        " Müşteri Puan:"+ MusteriPuan + Environment.NewLine +
                        " AdSoyad:" + AdSoyad + Environment.NewLine +
                        " Email:" + Email + Environment.NewLine +
                        " TelefonNo:" + TelefonNo + Environment.NewLine +
                        " Adres:" + Adres.AdresConcat();
        }

        public override int Validation()
        {
            base.Validation();
            if (MusteriNo == 0 || MusteriPuan == 0)
            {

                this.info += "Müşteri için gerekli bilgileri giriniz.";
                return 1;
            }
            return 0;
                
        }
    }
}
