using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Okul
{
    public class Market : IEklenebilen
    {
        public Market()
        {
            this.Personeller = new List<Personel>();
            this.Musteriler = new List<Musteri>();
            this.Tedarikciler = new List<Tedarikci>();
            this.UrunKatalogu = new List<Urun>();
            
        }
        public Depo Stok = new Depo();
        public List<Personel> Personeller { get; private set; }
        public List<Musteri> Musteriler { get; private set; }
        public List<Urun> UrunKatalogu { get; private set; }
        public List<Tedarikci> Tedarikciler { get; private set; }
        public string InfoMesaj { get; set; }
        public Muhasebe Hesaplar { get; set; }


        public string ListeEkle<T>(List<T> Param_List, T Param_Val)
        {
            Param_List.Add(Param_Val);
            return ("Ekleme işlemi başarılı.");
        }
        // Method OverLoading...
        
        public string ListGuncelle<T>(List<T> Param_list, T Param_val, int index)
        {
            Param_list[index] = Param_val;
            return ("Güncelleme işlemi başarılı.");
        }
        public string ListRemoveAt<T>(List<T> Param_List, int index)
        {
            Param_List.RemoveAt(index);
            return ("Silme işlemi başarılı");
        }

        public T GetObjectOnList<T>(List<T> Param_List, int index)
        {
            T data = Param_List[index];
            return (data);
        }


        public DataGridView TedarikciListele(DataGridView grid)
        {
            grid.Rows.Clear();
            grid.ColumnCount = 8;
            grid.Columns[0].Name = "Tedarikçi No";
            grid.Columns[1].Name = "İsim";
            grid.Columns[2].Name = "Telefon No";
            grid.Columns[3].Name = "E-Mail";
            grid.Columns[4].Name = "Adres";
            grid.Columns[5].Name = "İlçe";
            grid.Columns[6].Name = "İl";
            grid.Columns[7].Name = "Posta Kodu";

            string[] row_dizi = new string[8];

            foreach (Tedarikci t in this.Tedarikciler)
            {
                row_dizi[0] = t.TedarikciNo.ToString();
                row_dizi[1] = t.AdSoyad;
                row_dizi[2] = t.TelefonNo.ToString();
                row_dizi[3] = t.Email;
                row_dizi[4] = t.Adres.AcikAdres;
                row_dizi[5] = t.Adres.Ilce;
                row_dizi[6] = t.Adres.Il;
                row_dizi[7] = t.Adres.PostaKodu.ToString();
                grid.Rows.Add(row_dizi);
            }
            return grid;
        }
        public DataGridView MusteriListele(DataGridView grid)
        {
            grid.ColumnCount = 9;
            grid.Columns[0].Name = "Müşteri No";
            grid.Columns[1].Name = "Müşteri Puan";
            grid.Columns[2].Name = "İsim";
            grid.Columns[3].Name = "Telefon No";
            grid.Columns[4].Name = "E-Mail";
            grid.Columns[5].Name = "Adres";
            grid.Columns[6].Name = "İlçe";
            grid.Columns[7].Name = "İl";
            grid.Columns[8].Name = "Posta Kodu";

            string[] row_dizi = new string[9];

            foreach (Musteri m in this.Musteriler)
            {
                row_dizi[0] = m.MusteriNo.ToString();
                row_dizi[1] = m.MusteriPuan.ToString();
                row_dizi[2] = m.AdSoyad;
                row_dizi[3] = m.TelefonNo.ToString();
                row_dizi[4] = m.Email;
                row_dizi[5] = m.Adres.AcikAdres;
                row_dizi[6] = m.Adres.Ilce;
                row_dizi[7] = m.Adres.Il;
                row_dizi[8] = m.Adres.PostaKodu.ToString();
                grid.Rows.Add(row_dizi);
            }
            return grid;
        }

        public DataGridView PersonelListele(DataGridView grid)
        {
            grid.ColumnCount = 12;
            grid.Columns[0].Name = "Personel No";
            grid.Columns[1].Name = "SGK No";
            grid.Columns[2].Name = "TC No";
            grid.Columns[3].Name = "Ad Soyad";
            grid.Columns[4].Name = "Telefon No";
            grid.Columns[5].Name = "E-Mail";
            grid.Columns[6].Name = "Adres";
            grid.Columns[7].Name = "Maaş";
            grid.Columns[8].Name = "Kan Grubu";
            grid.Columns[9].Name = "Giriş Tarihi";
            grid.Columns[10].Name = "Cinsiyet";
            grid.Columns[11].Name = "Medeni Hal";

            string[] row_dizi = new string[12];

            foreach (Personel p in this.Personeller)
            {
                row_dizi[0] = p.PersonelNo.ToString();
                row_dizi[1] = p.SGKNo.ToString();
                row_dizi[2] = p.Kimlik.TCNo.ToString();
                row_dizi[3] = p.AdSoyad;
                row_dizi[4] = p.TelefonNo.ToString();
                row_dizi[5] = p.Email;
                row_dizi[6] = p.Adres.AdresConcat();
                row_dizi[7] = p.Maas.ToString();
                row_dizi[8] = p.Kimlik.KanGrubu;
                row_dizi[9] = p.GirisTarihi.ToString();
                row_dizi[10] = p.Kimlik.cinsiyet.ToString();
                row_dizi[11] = p.Kimlik.medeniHal.ToString();

                grid.Rows.Add(row_dizi);
            }
            return grid;
        }


    }
}
