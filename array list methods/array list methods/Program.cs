using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_list_methods
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList liste = new ArrayList(); // arraylist olusturduk
            liste.Add("merve"); // array listlere her tipten veri atabiliriz. Yaparken de add methodunu kullaniriz
            liste.Add(8);
            liste.Add(false);
            liste.Add('E');

            Console.WriteLine(liste[1]); // indexindeki veriyi yazdirdik

            foreach (var item in liste)
            {
                Console.WriteLine(item); // her veriyi yazdirdik dizi icerisindeki
            }

            // addrange methodu ile birden fazla elemani ayni anda ekleyebiliyoruz. 

            string[] isimler = { "merve", "samet", "elif", "aysel" };

            liste.AddRange(isimler); // isimler adli listeyi addrange ile diger listeme ekledim. tek tek yazmak zorunda kalmadim

            List<int> sayilarList = new List<int>() { 1, 5, 7, 8, 9, 6, 5 }; // listeyi yapip direkt atamasini yaptik

            liste.AddRange(sayilarList); // diger listeyi de array listime attim

            liste.Sort(); // compile timeda sikinti cikarmaz ama runda kafasi karisir cunku icinde bool char falan var nereye koyacagini bilemiyor

            Console.WriteLine(liste.BinarySearch(8)); // 8i arayip bulup indexini verecek

            liste.Reverse(); // listeyi terse cevirir

            liste.Clear(); // listedeki her elemani sildi
        }
    }
}
