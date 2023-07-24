using System;
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

            int x = 8;
            int y = 6;
            bool sonuc = x < y; // bunlar bool doner x yden kucuk mu hayir sonuc boolu false

            // aritmetik operatorler + - * / % //

            int merveM = 20;
            int mimi = 3;
            int modluSonuc = merveM % mimi; // mod aliyor yni iki sayinin bolumunden klani hesapliyor. 
            // 20 bolu 3ten kaln 2 bu yuzden mod 2




            //************TYPE Conversions******************

            // implicit Conversion 


            byte a = 5;
            sbyte b = 10;
            short c = 15;

            int i = a + b

            long h = i;

            float g = h // ayni sayiyi oradan oraya veri tipini degistiebiliyoruz



            // explicit Conversions

            int x = 4;
            byte y = (byte)x; // bu yontem ile parantez sagindki veri parantez icerisindeki veriye donusturulebiliyor

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











        }
    }
}
