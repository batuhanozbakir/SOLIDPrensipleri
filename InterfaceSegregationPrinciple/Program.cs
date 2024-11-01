using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    #region YanlısOrnek
    //public interface ITicaretServisi
    //{
    //    void SiparisIsle();
    //    void MusteriSikayet();
    //    void UrunStokGuncelle();
    //}
    //public class MusteriServisi : ITicaretServisi
    //{
    //    public void MusteriSikayet()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void SiparisIsle()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void UrunStokGuncelle()
    //    {
    //        throw new NotImplementedException();
    //    }
    //} 
    #endregion

    public interface IsiparisIslemeServisi
    {
        void SiparisIsle();
    }

    public interface ImusteriHizmetleriServisi
    {
        void MusteriSikayetYonet();
    }

    public interface IUrunYonetimServisi
    {
        void UrunStokGuncelle();
    }

    public class MusteriHizmerleri : ImusteriHizmetleriServisi
    {
        public void MusteriSikayetYonet()
        {
            throw new NotImplementedException();
        }
    }
}
