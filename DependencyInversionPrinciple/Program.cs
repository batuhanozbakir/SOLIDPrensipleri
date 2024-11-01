using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    internal class Program
    {
        static void Main(string[] args)

        {
            IOdemeServisi nakitOdeme = new PayPalOdemeServisi();

            //  IOdemeServisi nakitOdeme = new NakitOdemeServisi();

            OdemeIslemleri odemeIslemleri = new OdemeIslemleri(nakitOdeme);

            odemeIslemleri.OdemeYap(12312312);

            Console.ReadKey();
        }
    }

    //yanlış örnek 

    #region MyRegion

    //public class PaypalOdemeServisi

    //{

    //    public void OdemeYap()

    //    {

    //    }

    //}

    //public class OdemeIslemleri

    //{

    //    private readonly PaypalOdemeServisi _paypalOdemeServisi;

    //    public OdemeIslemleri()

    //    {

    //        _paypalOdemeServisi = new PaypalOdemeServisi();//doğrudan bir bağımlılık

    //    }

    //    public void OdemeYap()

    //    {

    //        _paypalOdemeServisi.OdemeYap();

    //    }

    //} 

    #endregion

    //doğru kullanım 

    public interface IOdemeServisi
    {
       void OdemeYap(decimal tutar);
    }

    public class PayPalOdemeServisi : IOdemeServisi
    {
        public void OdemeYap(decimal tutar)
        {
            Console.WriteLine("paypal odemesi");
        }
    }

    public class NakitOdemeServisi : IOdemeServisi
    {
        public void OdemeYap(decimal tutar)
        {
            Console.WriteLine("nakit odeme");
        }
    }

    public class OdemeIslemleri
    {
        private readonly IOdemeServisi _odemeServisi;
        public OdemeIslemleri(IOdemeServisi odemeServisi)
        {
            _odemeServisi = odemeServisi;
        }
        public void OdemeYap(decimal tutar)
        {
           _odemeServisi.OdemeYap(tutar);
        }
    }
}

