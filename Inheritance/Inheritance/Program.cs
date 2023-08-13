using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    /* Inheretance aynı ozellikleri atadan alabilme icerisinde ise kendini atadan ayristiran ozellikleri methodlari saklamadır.
     * canlılar classindaki her ozellik onun alt gruplarının hepsinde gecerli olacaktir hepsine ayyyynı seyleri yazmaktansa ata class
     * olarak verip onun pzelliklerini ve methodlarını kendi icerimize alabiliriz
     * yapımı ise oldukca basit ata class adını cocuk classın adının oldugu kısımda arasında iki nokta ust uste olacak sekilde yazmak
     * asagida yapicam bak
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            tohumsuzBitkiler tohumsuzBitki1 = new tohumsuzBitkiler(); // instance olusturduk
            tohumsuzBitki1.sporlaUreme();// beslenme methodu canlilar classindaydı ama inherit ettigimiz icin nokta
                                         // koydugumuzda o methoda da ulasabiliyoruz artik onun da ozelligi oldu
            Console.ReadLine();
            ///***ama soyle bir sorun var hepsi publicte su an tabi degistiricem simdi de bunu yazarken ilk publicti
            /// erisim belirtecleri icerisinde protected secenegi var protected sayesinde istedigimiz methodu istedigimiz yere uygun 
            /// erisime acabiliriz. method erisimini protected'a cevirip ulasmak istedigimiz class icerisinde
            /// constructor yazıp base.protectedHaleGetirdigimizMethodunAdi yazarak erisim kontrolunu saglayabiliyoruz asagida yapicam


            surungenler surungen1 = new surungenler();
            surungen1.surunerekHareketEtme();
            Console.ReadLine();
        }
    }

    public class canlilar
    {
        protected void beslenme() // bunu protected yapinca maindeki tohumsuzbitki instancından beslenmeye erisemiyorum cunku o classa constructor yazmam gerek
        {
            Console.WriteLine("canlilar beslenirler");
        }
    }

    
    public class hayvanlar:canlilar
    {
        protected void adaptasyon()
        {
            Console.WriteLine("hayvanlar adaptasyon sağlayabilir");
        }
    }
    public class bitkiler :canlilar
    {
        protected void fotosentez()
        {
            Console.WriteLine("bitkiler fotosentez yapar");
        }
    }
    public class surungenler:hayvanlar
    {
        public surungenler()
        {
            base.adaptasyon();
            base.beslenme();
        }
        public void surunerekHareketEtme()
        {
            Console.WriteLine("surungenler surunerek hareket ederler");
        }
    }
    public class kuslar:canlilar
    {
        public void ucma()
        {
            Console.WriteLine("kuslar ucabilirler");
        }
    }
    public class tohumluBitkiler
    {
        public void TohumlaUreme()
        {
            Console.WriteLine("tohumlu bitkiler tohumla urerler");
        }
    }
    public class tohumsuzBitkiler : bitkiler
    {
        public tohumsuzBitkiler() // bunu da yaptıktan sonra artık canlilardaki methoda erismeme gerek yok ki zaten yapamiyorum da 
            //ama olan su ki sporla ureme methodunu cagirip yazdigimda beslenme methodu da calisacak ve otomatik olarak atasinin
            //methodunu da calistirabilicem istersen calistir gor
        {
            base.beslenme();
            base.fotosentez();
        }

        public void sporlaUreme()
        {
            
            Console.WriteLine("tohumsuz bitkiler sporla urerler");
        }
    }
}
