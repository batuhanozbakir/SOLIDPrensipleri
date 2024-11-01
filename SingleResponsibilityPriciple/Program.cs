using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPriciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    #region YanlısKullanim
    //public class Urun
    //{
    //    public int Id { get; set; }
    //    public string Ad { get; set; }
    //    public decimal Fiyat { get; set; }

    //    public void UrunEkle()
    //    {
    //        // ürün ekleme işlemleri
    //    }

    //    public void UrunSil()
    //    {
    //        // ürün silme işlemleri
    //    }

    //    public void UrunGuncelle()
    //    {
    //        // ürün güncelleme işlemleri
    //    }

    //    public void UrunRaporuOlustur()
    //    {
    //        // ürün rapor işlemleri
    //    }
    //}
    #endregion

    //DOĞRU KULLANIM

    public class Urun
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }
    }

    public class UrunYonetimi
    {
        public void UrunEkle(Urun urun)
        {

        }

        public void UrunSil(int urunId)
        {

        }

        public void UrunGuncelle(Urun urun)
        {

        }
    }

    public class UrunRaporYonetimi
    {
        public void UrunRaporuOlustur(List<Urun>urunler)
        {

        }
    }
}

