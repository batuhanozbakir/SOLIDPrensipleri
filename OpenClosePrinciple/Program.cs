using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    #region YanlisKullanim
    //public class OdemeIslemleri
    //{
    //    public void Ode(string odemeTuru)
    //    {
    //        if (odemeTuru == "KrediKarti")
    //        {
    //            //Kredi kartı Odeme işlemleri
    //        }
    //        else if (odemeTuru == "Nakit")
    //        {
    //            // nakit ödeme işlemleri
    //        }
    //        else if (odemeTuru == "Pypal")
    //        {

    //        }
    //        //yeni ödeme türü oldukça sınıf değiştirilmek zorunda
    //    }
    //} 
    #endregion

    public abstract class Odeme
    {
        public abstract void Ode();
    }

    public class KrediKartiOdeme : Odeme
    {
        public override void Ode()
        {
            throw new NotImplementedException();
        }
    }
    public class NakitOdeme : Odeme
    {
        public override void Ode()
        {
            throw new NotImplementedException();
        }
    }
    public class PaypalOdeme : Odeme
    {
        public override void Ode()
        {
            throw new NotImplementedException();
        }
    }
}
