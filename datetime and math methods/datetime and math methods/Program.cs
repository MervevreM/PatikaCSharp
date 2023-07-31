using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datetime_and_math_methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Math.Abs(-5)); // mutlak degeri verir

            Console.WriteLine(Math.Sin(10)); // 10un sinusu
            Console.WriteLine(Math.Cos(10)); // 10un cosinusu
            Console.WriteLine(Math.Tan(10)); // 10un tanjantı


            Console.WriteLine(Math.Ceiling(21.1));// kusurati ne olursa olsun bir ust tam sayiyi verir baglamda 22
            Console.WriteLine(Math.Round(21.3)); // matematikteki yuvarlama islemini yapar hangi tam sayiya yakinsa ona yuvarlar yani
            Console.WriteLine(Math.Floor(21.9)); // kusurat ne olursa olsun verilen tami verir. Baglamd 21

            Console.WriteLine(Math.Max(5, 8)); //iki sayi arasinan en buyugu getirir.
            Console.WriteLine(Math.Min(5, 8)); // iki sayi arasindan en kucugu getirir.

            Console.WriteLine(Math.Pow(5, 8));// power. sayi ussu alir. 5 üssü 8 sonucunu getirir.
            Console.WriteLine(Math.Sqrt(12)); // 12nin karekokunu alir
            Console.WriteLine(Math.Log(9)); //9un e tabanindaki logaritmasini alir (e tabani??)
            Console.WriteLine(Math.Exp(3));// e üssü 3
        }
    }
}
