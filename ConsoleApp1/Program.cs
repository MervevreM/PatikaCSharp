﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.ReadLine();


            byte b = 5; // 1 byte
            sbyte a = 5; // 1 byte

            short s = 5; // 2 byte
            ushort us = 5;  //2 byte

            Int16 i16 = 3; // 2 byte
            int i = 1; // 4 byte
            Int32 i32 = 3; //4 byte
            Int64 i64 = 5; // 8 byte

            uint ui = 3; // 4 byte
            long lu = 5; // 8 byte
            ulong ul = 6; // 8 byte

            float f = 3; // 4 byte
            decimal dec = 5; // 8 byte
            double db = 5; // 16 byte

            char ch = 'M'  ; // 2 byte
            string merve = "MErve kasal falan"; // sınırsız


            bool b1 = true;
            bool b2 = false;

            DateTime Dt = DateTime.Now; // anlik zamani yazDirir

            object a1 = "x";
            object a2 = "y";
            object a3 = 4;
            object a4 = 4.8;

            // string ifadeler

            string  str1 = string.Empty;
            str1 = "Mimilota";
            string ad = "MErve";
            string soyad = "Kasal";
            string adSoyd = ad + " " + soyad;

            //integer tanimlama sekilleri
            int integer1 = 5;
            int integer2 = 8;
            int integerTotal = integer1 + integer2;

            // bollean

            bool bool1 = 10 < 2;


            // degisken donusumleri


            string str20 = "20";
            int int20 = 20;
            string yenideger = str20 + int20.ToString(); // ciktisi 2020
            int yenideger2 = int20 + Convert.ToInt32(str20); // ciktisi 40

            int yenideger3 = int20 + int.Parse(str20);// ciktisi 40 


            string datetime1 = DateTime.Now.ToString("MM.dd.yyyy"); // aralarinda noktalarla ay gun yıl verir
            string datetime2 = DateTime.Now.ToString("hh:mm"); // arasında iki noktayla saati ve dakikayi verir




            //****************OPERATORLER************************//


            // atama ve islemli atama


            int x = 2;
            int y = 3;
            y = y + 2; //deger 5

            x += 3; // deger 5
            y /= 5; // y 5 olmustu bolu esit ile 1e esitledik

            x *= 4; // 5 olmustu 5 ile 4 carpip x'e esitledik

            // Mantiksal operatorler

            bool IsSuccess = true;
            bool IsCompleted = false;

            if (IsSuccess && IsCompleted)
                Console.WriteLine("Perfect");

            if (IsSuccess || IsCompleted)
                Console.WriteLine("Maybe perfect");

            if (!IsSuccess && !IsCompleted)
                Console.WriteLine("Not good :(");


            if (!IsSuccess || !IsCompleted)
                Console.WriteLine("Maybe Not good, maybe not :(");


            // iliskisel operatorler =, <,>, != ,>= . <=

            int xxx = 8;
            int yxy = 6;
            bool sonuc = xxx < yxy; // bunlar bool doner x yden kucuk mu hayir sonuc boolu false

            // aritmetik operatorler + - * / % //

            int merveM = 20;
            int mimi = 3;
            int modluSonuc = merveM % mimi; // mod aliyor yni iki sayinin bolumunden klani hesapliyor. 
            // 20 bolu 3ten kaln 2 bu yuzden mod 2




            //************TYPE Conversions******************

            // implicit Conversion 


            byte abc = 5;
            sbyte bec = 10;
            short c = 15;

            int ii = abc + bec;

            long h = ii;

            float g = h; // ayni sayiyi oradan oraya veri tipini degistiebiliyoruz



            // explicit Conversions

            int xa = 4;
            byte yyyy = (byte)xa; // bu yontem ile parantez sagindki veri parantez icerisindeki veriye donusturulebiliyor

            int xx = 6;
            string yy = xx.ToString(); // veri . tostring metodu ile veriyi stringe cevirebiliyoruz.


            string bla = "5";
            string blaa = "8";
            int blablaa = Convert.ToInt32(bla) + Convert.ToInt32(blaa); // convert.toint() ile parantez icerisine yazmis oldugumuz degiskeni int'e onusturebiliyoruz.


            string metin1 = "18";
            string metin2 = "15";

            int rakam1;
            double rakam2;

            rakam1 = Int32.Parse(metin1); // donusturulecek olan veri tipi ve parse methodu ile methodu icerisine yazdıgımız veriyi ilk yazdıgımız veriye donusturuyor.
            rakam2 = double.Parse(metin2); // yukaridaki aciklamanin aynisi sadece donusturulmek istenen veri farklı


            ///******************************  Try Catch Finally ***********************//////////
            ///

            try
            { // burada bir hata olusursa catch calisacak
                int ab = int.Parse(Console.ReadLine()); // kullanicidan veri aldik int degiskene atadik

                int be = int.Parse(Console.ReadLine()); // aynisini buradada yaptik

                int cL = ab + be;

                Console.WriteLine(c);
            }
            catch (Exception ex) // hangi hata olursa olsun bir hata olustu yazarak hata mesajını ekrana verecek
            {
                Console.WriteLine("Bir Hata Oluştu: " + ex.Message);
            }
            finally // try ya da catch calismasi fark etmeksizin islem sonrası burasi calisacak
            {
                Console.WriteLine("İşlem tamamlandı.");
            }

            ZamanaGoreSelam();



            // ******************* If else if and ternary if**************
            // 

             void ZamanaGoreSelam()
            {
                int TimeNow = DateTime.Now.Hour;


                if ( TimeNow >= 6 && TimeNow <= 11 )
                {
                    Console.WriteLine("GÜnaydın");
                    Console.ReadLine();
                }
                else if ( TimeNow >=12 && TimeNow <= 19)
                {
                    Console.WriteLine("İyi ksamlar");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("İyi Geceler");
                    Console.ReadLine();
                }


                // boyle mini kosullari tek satir da yazabiliyoruz.

                // string sonucMesaj = TimeNow < 6 ? "Gunaydin" : "İyi gunler";

                string sonucMesaj = TimeNow >= 6 && TimeNow <= 11 ? "Gunaydin" : TimeNow >= 12 && TimeNow <= 19 ? "iyi gunler" : "İyi geceler";
                Console.WriteLine(sonucMesaj);
                Console.ReadLine();



                //********************* switchCase *****************


                int monthIn = DateTime.Now.Month; // datetime month integer donu ve monthIn degiskenine atandı

                switch (monthIn) // her ay icin case yazildı
                {
                    case 1:
                        Console.WriteLine("Ocak ayındasınız");
                        break;
                    case 2:
                        Console.WriteLine("Şubat ayındasınız");
                        break;
                    case 3:
                        Console.WriteLine("Mart ayındasınız");
                        break;
                    case 4:
                        Console.WriteLine("Nisan ayındasınız");
                        break;
                    case 5:
                        Console.WriteLine("Mayıs ayındasınız");
                        break;
                    case 6:
                        Console.WriteLine("Haziran ayındasınız");
                        Console.ReadLine();
                        break;
                    case 7:
                        Console.WriteLine("Temmuz ayındasınız");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("bilmem");
                        break;

                }

                switch (monthIn) // caseleri bu sekilde gruplayabiliyoruz
                {
                    case 12:
                    case 1:
                    case 2:
                        Console.WriteLine("Kış mevsimindesiniz");
                        Console.ReadLine();
                        break;
                    case 3:
                    case 4:
                    case 5:
                        Console.WriteLine("İlkbahar mevsimindesiniz");
                        Console.ReadLine();
                        break;
                    case 6:
                    case 7:
                    case 8:
                        Console.WriteLine("yaz mevsimindesiniz");
                        Console.ReadLine();
                        break;
                    case 9:
                    case 10:
                    case 11:
                        Console.WriteLine("Sonbahar mevsimindesiniz");
                        Console.ReadLine();
                        break;
                }

            }












        }
    }
}
