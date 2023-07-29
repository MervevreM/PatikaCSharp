using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    static class Program
    {
        static void Main(string[] args)
        {
            // extension methodu burada calistirdik
            Console.WriteLine(KalpKoymaca("merve")); 
            Console.ReadLine();
        }

        #region recursive method aciklama ve ornek
        // Recursive methodlar birebir cevirisinden de anlasilacagi gibi kendini yineleyen, tekrar eden methodlardir. 
        // bu methodlar kendi iclerinde kandilerini cagirarak devam ederler. Sonsuz donguye sokmayacak bir sistem kurmak onemlidir. 
        //bir oruntuden olusan islemlerde bu tip methodları kullanabiliriz. Orn: üs alma methodu, faktoriyel methodu gibi

        static int UsAlma(int taban, int us)
        {
            if (us == 0)
                return 1;
            return taban * UsAlma(taban, us - 1);
        }

        //yukaridaki method üs 1 olana kadar ic ice gecerek cozumluyor. bu sekilde modifiye edilmis(usttekinde üssü 1 azaltmak gibi)
        //olan kendi methodu kendinde cagirarak olusan methodlara recursive yani özyinelemeli method denir.
        //Yapisi for dongusune benzemektedir. Mantigi anlasildiginda for dongusu kullanımına oranla daha temiz kodlar ortaya cıkmaktadır.
        #endregion

        #region extension method aciklama ornek

        /*  Extension methodlar sayesinde .Net icerisinde bulunan classları genisletebiliyoruz. Yani classlarda veri tipine 
         *  gore degisiklik gostermekle birlikte . koydugumuzda intellisense ozelligiyle karsımıza cıkan methodlar var ya 
         *  heh iste onlara ekleme yapabiliyoruz. Stringin kendi methodları var intin kandi bu veritiplerinin classlarina method ekleyebiliyoruz. 
         *  Burda onemli noktalar class ve methodun static olmasi ve parametre kisminda veri tipinden once this kelimesini yazmamız
         *  this kelimesini yazmazsak bilgisayar onun extension method oldugunu anlamiyor
         * */

        public static string KalpKoymaca(this string param) //class static, method static, parametre kısmında this keywordu var
        {

            return param + "  <33";
        }

        // bu method sayesinde string classında olmayan bir fonksiyonu clasa ekleyebildim bu sayede string. dedigimde kalp koymacayı
        // kullanabilicem bu sekilde classta var olmayan fonksiyonları ekleyerek classı genisletebilir ya da kisisellestirebiliriz
        
        
        #endregion
    }
}
