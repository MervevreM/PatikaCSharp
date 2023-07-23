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

            char ch = "M"; // 2 byte
            string merve = "MErve kasal falan"; // sınırsız


            bool b1 = true;
            bool b2 = false;

            DateTime Dt = DateTime.Now; // anlik zamani yazDirir

            object a1 = "x";
            object a2 = "y";
            object a3 = 4;
            object a4 = 4.8;

            // string ifadeler

            string = str1 = string.Empty;
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








        }
    }
}
