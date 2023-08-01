using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionaries_notes
{
    class Program
    {
        static void Main(string[] args)
        {   // dictionaryilerde veriler key value pair seklinde tutulur.
            // her key unique olmak zorundaa. tanimlarken carrot icine ilk key tipi virgulle ayirip value tipi yazilir
            // altta ornegi var. system.collections.generic namespaceinde tutulur dikkat et
            Dictionary<int, string> kullanicilar = new Dictionary<int, string>();

            kullanicilar.Add(8, "merve"); // veri eklerken key value pair kuralina devam ediyoruz
            kullanicilar.Add(45, "mert");
            kullanicilar.Add(86, "meryem");
            kullanicilar.Add(1, "mer");

            Console.WriteLine(kullanicilar[8]); // dictionary icerisinden 8 key'ine sahip valueyu döndürür

            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item); // key value pair seklinde yazdirir
            }

            Console.WriteLine(kullanicilar.Count); // key value pair sayisini verir

            Console.WriteLine(kullanicilar.ContainsKey(89)); // 89 keyi dictionaryde var mı. diger dizi containslerinden farkli burda key value contains denetlemesi yapabiliyoruz
            Console.WriteLine(kullanicilar.ContainsValue("bla bla"));

            kullanicilar.Remove(8); // 8 keyine sahip pairi silecek

            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item.Key); // item.key item.value ile sadece key ya da value yazdirabiliriz. bunu in kısminda yapabiliyoruz asagida
            }

            // KEYS
            foreach (var item in kullanicilar.Keys)
            {
                Console.WriteLine(item); // sadece keys yazdirir cünkü foreach icerisinde belirttik
            }
            foreach (var item in kullanicilar.Values)
            {
                Console.WriteLine(item); // sadece values yazdirir cünkü foreach icerisinde belirttik
            }

        }
    }
}
