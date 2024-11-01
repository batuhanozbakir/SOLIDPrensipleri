using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitionPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    #region YanlısKUllanim
    //public class Konaklama
    //{
    //    public virtual void SabahKahvaltisi() { }
    //    public virtual void AksamYemegi() { }
    //}
    //public class Oda : Konaklama
    //{
    //    public override void SabahKahvaltisi()
    //    {
    //    }

    //    public override void AksamYemegi()
    //    {
    //        throw new NotImplementedException(); // Normal Oda servisinde oda servisi yok
    //    }
    //}

    //public class SuitOda : Konaklama
    //{
    //    public override void SabahKahvaltisi()
    //    {
    //        //Sabah Kahvaltısı hizmeti
    //    }

    //    public override void AksamYemegi()
    //    {
    //       //Akşam yemeği hizmeti
    //    }
    //} 
    #endregion

    public abstract class Konaklama
    {
        public abstract void SabahKavaltisi();
    }
    public class Oda : Konaklama
    {
        public override void SabahKavaltisi()
        {
            Console.WriteLine("Rezervasyon İşlemleri");
        }
    }

    public class Suit : Konaklama
    {
        public override void SabahKavaltisi()
        {
            Console.WriteLine("Rezervasyon İşlemleri");
        }
        public void AksamYemegi()
        {
            Console.WriteLine("Rezervasyon İşlemleri");
        }
    }
}
