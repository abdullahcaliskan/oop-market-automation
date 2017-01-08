using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP_Okul
{
    public class Tedarikci : Kisi
    {
        public int TedarikciNo { get; set; }
        public override void BilgiGoster()
        {
            this.info = "TedarikciNo:" + TedarikciNo + Environment.NewLine +
                        " AdSoyad:" + AdSoyad + Environment.NewLine +
                        " Email:" + Email + Environment.NewLine +
                        " TelefonNo:" + TelefonNo + Environment.NewLine +
                        " Adres:" + Adres.AdresConcat();
        }
        public override int Validation()
        {
            base.Validation();
            if (TedarikciNo == 0)
            {
                this.info += "Tedarikçi için gerekli bilgileri giriniz.";
                return (1);
            }
            return (0);
        }

    }
}
