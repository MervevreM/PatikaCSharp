using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    /*  enumlar ile rakmlara anlam yukleyebilirsin. deger belirtmezsen ardisik devam eder index mantigi vardir defaulta 'dn baslar
     *  ilk üyeye sayı verirsen digerlerine vermezsen digerlerinin degerleini ardisik yazar. class olusturur gibi olusturulur 
     */
    class Program
    {
        static void Main(string[] args)
        {
            // koşulun okunabilirligi inanilmaz arttı
            int temperature = 40;

            if (temperature < (int)weather.cold)
                Console.WriteLine("Don't go outside. It's freezing");
            else if (temperature > (int)weather.hot)
                Console.WriteLine("If u wanna go, go but be carefull it's hot");
            else if (temperature > (int)weather.soHot)
                Console.WriteLine("Don't go outside. It's dangerously hot");
            else
                Console.WriteLine("Let's go outside");

            Console.ReadLine();

        }
    }
    enum days // deger vermedigim icin ilkine 0 verip digerlerini ardışık devam ettirdi. yaniii
    {
        sunday, //0
        monday, // 1
        tuesday, // 2
        wednesday, // 3
        thursday, // 4
        friday, // 5 
        saturday, // 6 
        // eger sunday = 1 deseydim digerlerine yine ardısık verecekti 2 3 diye. Araya birden yuksek bir sayı da girebilirim oradan
        // itibaren ardısık deger vermeye baslar 
    }

    enum weather // degerlere isim verdik anlamli hale getirdik programda kullanırken okunabilirligi inanilmaz arttı.
                 // Ama enumdan gelen degeri kullanmak icin int parse etmeyi unutma. Cunku veri enumda doner int islemde parsesız kullanamazsın
    {
        cold = 10,
        warm = 20,
        hot = 30,
        soHot = 40
    }
}
