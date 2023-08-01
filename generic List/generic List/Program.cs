using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayiListesi = new List<int>(); // bir integer listesi olusturdum adi da sayiListesi

            // list classi methodlari
            sayiListesi.Add(8);// listeye oge ekledim // listin add metodunu listeye eleman ekleyecegimiz zaman bu sekilde kullanabiliyoruz
            sayiListesi.Add(18);
            sayiListesi.Add(88);

            List<string> hayvanListesi = new List<string>(); // string tutan liste olusturdum. ismi hayvanListesi

            hayvanListesi.Add("kedi");
            hayvanListesi.Add("inek");
            hayvanListesi.Add("kirpi");
            hayvanListesi.Add("rakun");

            Console.WriteLine(hayvanListesi.Count); // listenin eleman sayisini bu sekilde ogrenebiliyoruz
            Console.WriteLine(sayiListesi.Count);

            // listedeki tüm elemanlari gormek icin 2 sekilde foreach kullanabiliyoruz

            foreach (var item in sayiListesi)
            {
                Console.WriteLine(item);
            }

            hayvanListesi.ForEach(hayvan => Console.WriteLine(hayvan)); // yukaridaki foreachin ayni isini yapiyor ama daha tatli
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));

            sayiListesi.Remove(18); // listeden istenilen elemani siler
            hayvanListesi.Remove("rakun"); //

            sayiListesi.RemoveAt(0); // removeAt belirtilen indexteki elemani siler. REMOVE'da elemani REMOVEAT'te index veririz guzelim


            sayiListesi.Contains(8); // true false doner. liste icerisinde verilen eleman var mi ? liste elemani iceriyor mu ? 

            hayvanListesi.BinarySearch("kedi"); // binarySarch methodu ile elemanin indexini ogrenebiliyoruz

            // diziyi listeye cevirme

            string[] bibikoListesi = { "abc", "sdf", "jkh" };

            List<string> diziyiListeyeCevirdim = new List<string>(bibikoListesi); // bastan bos liste yaparken bu parantezleri bos birakiyorduk ama
                                                                                  // hali hazirda bir diziyi listeye cevirmek icin normal liste olusturup
                                                                                  // parantez icine dizi adini vermemiz yeterli

            diziyiListeyeCevirdim.Clear(); // listenin izine tamamen temizledim

            // olustudugumuz classlardan da bir liste olusturabiliriz once gidip bi class yapalim

            List<kullanicilar> kullaniciListesi = new List<kullanicilar>; // classin listesini yaptim üzerinde degisiklik yapabilirim bir sürü kullanici ekleyebilirim farkli ozelliklerde

            kullanicilar kullanici1 = new kullanicilar(); // ilk kullaniciyi OLUSTURDUM daha eklemedim asagida eklicem bak. nokta koyarak ozelliklere erisip atamalar yaptim
            kullanici1.name = "mimi";
            kullanici1.surname = "Kasal";
            kullanici1.age = 27;

            kullanicilar kullanici2 = new kullanicilar();
            kullanici2.name = "aysel";
            kullanici2.surname = "bisiler";
            kullanici2.age = 9;

            kullaniciListesi.Add(kullanici1); // ekleidm
            kullaniciListesi.Add(kullanici2);// ekledim

            foreach (var kullanici in kullaniciListesi) // bu sekilde de classtaki her kullanicinin istedigimiz ozelliklerini yazdirabiliriz
            {
                Console.WriteLine("isim" + kullanici.name);
                Console.WriteLine("soyisim" + kullanici.surname);
                Console.WriteLine("yas" + kullanici.age);
            }






        }
    }

    public class kullanicilar
    {
        public string name;
        public string surname;
        public int age;
    }
}
