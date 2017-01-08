using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace OOP_Okul
{
    public class Depo
    {
        // Aggregation Relationship.
        public List<Urun> Urunler = new List<Urun>();
        public string InfoMesaj;
        
        public void UrunArama(DataGridView grid, string barkodNo)
        {
            grid.Rows.Clear();
            this.FillGridColumn(grid);
            foreach (Urun u in Urunler)
            {
                if (Regex.IsMatch(u.UrunBilgi.BarkodNo.ToString(), barkodNo, RegexOptions.IgnoreCase))
                {
                    // Eşleşme sağlandı
                    grid.Rows.Add(ConvertToRow(u));
                }
            }
        }
        public int UrunArama(int barkodNo, List<Urun> SearchList)
        {
            int index = -1; // -1 ürün bulunamazsa diye.
            int i = 0;
            foreach (Urun item in SearchList)
            {
                if(item.UrunBilgi.BarkodNo == barkodNo) // barkod numarası uyustu urunu bulduk
                {
                    index = i;
                    return (index); // Buldugumuza gore return edebiliriz.
                }
                i++;
            }
            return (index);
        }
        public string UrunEkle(Urun u)
        {
            int i = 0;
            foreach (Urun urn in Urunler)
            {
                if(urn.UrunBilgi.BarkodNo == u.UrunBilgi.BarkodNo)
                {
                    this.UrunMiktarDegistir(urn, u.Miktar, i, 'a');
                    return ("Stok miktarı arttırıldı.");
                }
                i++;
            }
            this.Urunler.Add(u);
            return ("Ürün başarılı bir şekilde eklendi.");
        }
        public void UrunMiktarDegistir(Urun list_urun, int miktar, int sira_no, char proc)
        {
            if (proc == 'a')
                this.Urunler[sira_no].Miktar = list_urun.Miktar + miktar;
            else if(proc == 'c')
                this.Urunler[sira_no].Miktar = list_urun.Miktar - miktar;
        }
        public void UrunSil(int sira_no)
        {
            this.Urunler.RemoveAt(sira_no);
        }
        private string[] ConvertToRow(Urun urn)
        {
            string[] row_dizi = new string[6];
            row_dizi[0] = urn.UrunBilgi.BarkodNo.ToString();
            row_dizi[1] = urn.UrunBilgi.Ad;
            row_dizi[2] = urn.Miktar.ToString();
            row_dizi[3] = urn.tedarikci.AdSoyad;
            row_dizi[4] = urn.Fiyat.ToString();
            row_dizi[5] = urn.UrunBilgi.EkAciklama.ToString();

            return row_dizi;
        }
        public DataGridView FillGridColumn(DataGridView grid)
        {
            grid.ColumnCount = 6;
            grid.Columns[0].Name = "Barkod No";
            grid.Columns[1].Name = "Ad";
            grid.Columns[2].Name = "Miktar";
            grid.Columns[3].Name = "Tedarikci";
            grid.Columns[4].Name = "Fiyat";
            grid.Columns[5].Name = "Açıklama";
            grid.Columns[5].Width = 220;

            return grid;
        }
        public DataGridView UrunListele(DataGridView grid)
        {
            this.FillGridColumn(grid);

            this.UrunDongu(grid, this.Urunler);
            return grid;
        }
        public DataGridView UrunListele(DataGridView grid, int barkodNo)
        {
            this.FillGridColumn(grid);

            foreach (Urun u in this.Urunler)
            {
                if (u.UrunBilgi.BarkodNo == barkodNo)
                    grid.Rows.Add(this.ConvertToRow(u));
            }
            return grid;
        }
        private void UrunDongu(DataGridView grid, List<Urun> gelen_liste)
        {
            foreach (Urun u in gelen_liste)
            {
                grid.Rows.Add(this.ConvertToRow(u));
            }
        }
        public void UrunListele(DataGridView grid, List<Urun> gelen_liste)
        {
            this.FillGridColumn(grid);

            this.UrunDongu(grid, gelen_liste);
        }
    }
}
