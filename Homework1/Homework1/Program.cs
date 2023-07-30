
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main()
        {
            Homeworks sinifim = new Homeworks();
            // sinifim.EvenNumbersinInput();
            //sinifim.InputaEsityadaTamBolunenleriBulanMethod();
            //sinifim.InputKelimeleriterstenYazdıranMethod();
            sinifim.InputStringKelimeveKarakterAdedi();
            Console.ReadLine();
        }


    }

    class Homeworks
    {
        /*Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
         * Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının 
         * girmiş olduğu sayılardan çift olanlar console'a yazdırın.
         */
        #region verilen integer inputlar içerisnden çift olanları ekrana yazma methodu
        public void EvenNumbersinInput()
        {
            Console.WriteLine("Çift sayılarına bakmak istediginiz sayı adedini giriniz: ");
            int n = int.Parse(Console.ReadLine());
            int[] inputArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("lütfen " + (i + 1) + ". sayıyı giriniz: ");
                int inputSayi = int.Parse(Console.ReadLine());
                inputArray[i] = inputSayi;

            }

            Console.WriteLine("Girdiginiz sayılar içerisinde çift olanları aşağıda görebilirsiniz");
            foreach (int item in inputArray)
            {
                if (item % 2 == 0)
                    Console.WriteLine(item);
                else
                    continue;
            }
        }
        #endregion


        /* Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
         * Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş 
         * olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
         * */
        #region input integer'a esit ya da tam bolunenlerini bulan method
        public void InputaEsityadaTamBolunenleriBulanMethod()
        {
            Console.WriteLine("Girmek istediğiniz sayı adedini giriniz");
            int n = int.Parse(Console.ReadLine());
            int[] nArray = new int[n];
            for (int i = 0; i < n
                ; i++)
            {
                Console.WriteLine((i+1)+". sayıyı giriniz");
                nArray[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Eşit ya da tam bölen kontrolü yapmak istediğiniz sayıyı giriniz");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine(m + " sayısına eşit olan ya da tam bölünen sayılar aşağıda sıralanmıştır");

            foreach (var item in nArray)
            {
                if (m == item || m % item == 0)
                    Console.WriteLine(item);
                
            }
            Console.ReadLine();

        }
        #endregion

        /*Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
         * Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı 
         * kelimeleri sondan başa doğru console'a yazdırın.
         */
        #region input stringleri ters alfabetik(?:D) yazdıran method
        public void InputKelimeleriterstenYazdıranMethod()
        {
            
            Console.WriteLine("Girmek istediğiniz kelime adedini yazınız");
            int inputSayiAdedi = int.Parse(Console.ReadLine());
            string[] inputStrings = new string[inputSayiAdedi];
            for (int i = 0; i < inputSayiAdedi; i++)
            {
                Console.WriteLine((i + 1)+". kelimeyi giriniz");
                inputStrings[i] = Console.ReadLine();

            }
            Array.Sort(inputStrings);
            Array.Reverse(inputStrings); // bunu consolwritelinea yazamazsın mervecim :(bu sadece siraladi simdi tek tek yazdir guzelim :(

            foreach (var item in inputStrings)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }
        #endregion

        /*Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
         * Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
         */

        #region input stringin kelime ve harf adedini çıkaran method
        public void InputStringKelimeveKarakterAdedi()
        {
            Console.WriteLine("İşlem yapmak istediğiniz cümleyi girin:");
            string InputCumle = Console.ReadLine();
            string[] words = InputCumle.Split(' ');
            int wordCounter = 0;
            int letterCounter = 0;
            foreach (var item in words)
            {
                wordCounter++;
                foreach (var itemLetter in item)
                {
                    letterCounter++;
                }
            }
            Console.WriteLine("Kelime adedi : " + wordCounter);
            Console.WriteLine("Harf adedi : " + letterCounter);
            Console.ReadLine();

        }
        #endregion
    }
}
