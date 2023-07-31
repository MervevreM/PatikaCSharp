using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            string var1 = "dersimiz cSharp";
            string var2 = "dersimiz cSharp, Selam";

            Console.WriteLine(var1.Length); // degiskenin karakter sayisiniz doner
            Console.WriteLine(var2.ToLower()); // tüm karakterleri lower case yazar
            Console.WriteLine(var1.ToUpper()); // tüm karakterleri upper case yazar
            Console.WriteLine(string.Concat(var2, " Tekrar selam")); // string classından cagirmamiz gerekiyor bu methodu.
                                                                     // var olan degiskene yeni seyler kleyebiliyoruz.
                                                                     // concatten sonra parantez icerisinde uzerine ekleme yapilacak degisken vigul eklenen sey yazilacak.

            Console.WriteLine(var1.CompareTo(var2)); //bu methodla karakter uzunluklarını karsılastırıyouz
                                                     //ilk degisken ile compreto prantezlri icerisindeki degiskenin karakter uzunlugunu krsılastıran
                                                     //bu methodda esit ise 0 ilk degiskenin krakter sayisi daha fazlaysa 1, ilk degiskenin krakter sayisi daha azsa -1 yazar

            Console.WriteLine(string.Compare(var1, var2, true)); // bu methodla stringin icindeki degerleri karsilastiriyorum. yazilar aynı ise 1 farklı ise 0 doner
                                                                 // 3. prametre ignore case durumu.
                                                                 // yani karsilastirma yaparken buyuk kucuk harfe dikkat etsin mi etmesin mi. Ignore case true dersek
                                                                 // anlasilacagi uzere buyugu kucugu ignorelicak, onemsemicek sadece yaziyi karsilastiricak
                                                                 // ignore case false dersek ayni yazı ve farklı buyukluklerdeki harflerden olusan karsilastimalar 1 doner

            Console.WriteLine(var1.Contains(var2)); // ilk degisken ikinci degiskeni iceriyor mu ? iceriyorsa true doner, icermiyorsa false
            Console.WriteLine(var2.StartsWith("ders")); // degisken tirnak icerisinde verdigimiz stringle mi basliyor evetse true, aksi halde false
            Console.WriteLine(var2.StartsWith("cSharp")); // degisken verdigimiz stringle mi bitiyor evetse true aksi halde false

            Console.WriteLine(var2.IndexOf("Sha")); // aradigimiz krakter grubunu buldugu ilk yerde ilk karakterin indexini doner 
                                                    // verileni bulamazsa -1 doner

            Console.WriteLine(var2.Insert(0, "Merhaba")); // verdigimiz indexten baslayarak araya tıkıstırmak istedigimizi yazar
            Console.WriteLine(var2.LastIndexOf("i")); // degiskende bulunan karakterin en sonuncusunun indexini verir // tam cikllayamadim tek cumlede aciklamak zormus bunu

            Console.WriteLine(var1 + var2.PadLeft(30)); //var1 ve var2yi birlestirirken var2nin soluna (bu baglamda iki degiskenin arasina olmus oldu).
                                                        //karakter sayisini 30'a tamamlayacak kadar bosluk ekler. 

            Console.WriteLine(var1 + var2.PadLeft(30, '*')); //Burada ise birlesitrme yaparken 30'a tamamlayacak kadar yildiz ekler. 
                                                             //Anlayacagin bir sey yazmazsak defaltta bosluktur bu padding.

            Console.WriteLine(var1.PadRight(30) + var2); // burada methodu bir degiskene verdik ve left yerine right kullandik
                                                         // yani ilk degiskenin sagina karakter uzunlugu 30 olacak kadar bosluk eklicek.
                                                         // Bu baglamda yine iki degiskenin arasina eklemis olduk.
                                                         ////*** BTW karakter uzunlugu coktaaaan 30'dan buyukse hiiiiic bir sey yapmicak

            Console.WriteLine(var1.PadRight(30, '+') + var2); // birlestirirken 30'a tamamlayana kadar + eklicek.

            Console.WriteLine(var2.Remove(5, 3)); // remove icerisine verdigimiz ilk sayi silmeye baslamak istedigimiz index.
                                                  // Virgülden sonraki ise kac tane karakter silmek istedigimiz. Kac tane silmek istedigimizi soylemezsek,
                                                  // basladigi indexin devamindaki her seyi siler

            Console.WriteLine(var2.Replace("CSharp", "C#")); // belirttigimiz degiskende replace icerisine yazdigimiz ilk parametrenin hepsini bulup
                                                             // ikinci parametreyi yerine yazacak. Yani metindeki tum CSharp'lar c#'a donusecek

            Console.WriteLine(var2.Replace(" ", "*")); //bosluklar yerine yildiz yazacak

            Console.WriteLine(var2.Split(' ')); // bosluklara gore veriyi parcalayıp bir dizi haline getirecek
                                                // istersek sonuna index verip olusturdugu dizi icerisindeki elemanı yazdirabiliriz. Asagida ornegini yaziyorum bak

            Console.WriteLine(var2.Split(' ')[0]); // bu bosluklara gore metni parcalayacak dizi yapacak ve dizinin 0. indexini bana yazacak

            Console.WriteLine(var2.Substring(8)); // remove'un tam tersi isi yapiyor. 8. indexten baslayip sonuna kadar tüm elemanlari getiriyor.
                                                  // Duracagi yeri de belirtebiliyoruz tipki remove'daki gibi

            Console.WriteLine(var2.Substring(8, 10)); //  bana 8 ile 10. index arasındaki elemanları yazacak. removeda oraları silip kalanı bana yazacaktı
        }
    }
}















