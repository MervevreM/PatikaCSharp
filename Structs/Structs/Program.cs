using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        /* EN TEMEL FARK VERİLERİ TUTTUKLARI YER */ 
        /* sınıflara cok benzerler constructor yazılabilir icinde property mthod tutulabilir. Classlar referans tipinde heap bolgesinde
         * tutulurken structlar deger tipinde stack bolgesinde tutulur bu da performanssal degisikliklere yol acar.
         * 16 byte'a kadar tutulacak verilerin structt tutulmasi onerilirken üzeri verilerde classlarin kullanilmasi onerilir.
         * birkac farki var ypisal olarak onlari asagida gostericem bak
         */

        /* classlarda parametresiz constructorlar ile default degerleri ezip kendimiz belirleyebiliyoruz. 
         * ama structlarda parametresiz explicit degerli constructor olusturamıyruz illa parametreli olmak zorunda
         * demek istedigim su ki class icerisinde constructori parametresiz olusturup method icinde nokta koyarak propertylere ulasip
         * default degerler verebiliyoruz. Ama structlarda parametresiz explicit yani asagida noktyla erisilip assignment etmeye izin vermiyor
         * parametre koymak zorundasin cok da buyuk bi olay yok gibi :d yapilarin icine bak gostericem
         */


        /* clsslarda deger atamadan intance yaratıp icindeki propertyleri kullananan bir methodu cagirabiliriz
         * veri tipine gore default degerler atayip hesaplayip bize getirir ma structta bunu yapamayız
         * struct default deger tasimıyor (yapi icinde ya da isinda bir tama yapmazsak program bizim icin default string null,
         * int 0, bool false gibi dfault atamiyor
         */
        static void Main(string[] args)
        {

            rectangle rectangle1 = new rectangle(); // classi instancelayip deger verdik ve classtaki methodu kullanarak
                                                    // verilen degerlerdeki dikdörtgenin alanını hesaplayıp yazdık
            rectangle1.longEdge = 4;
            rectangle1.shortEdge = 3;
            Console.WriteLine("Class'taki dikdörtgen hesaplama : {0}", rectangle1.calculateArea());

            rectangle_struct rectangle1ButStruct = new rectangle_struct(); // classtakilerin aynısını yaptık
            rectangle1ButStruct.longEdge = 4;
            rectangle1ButStruct.shortEdge = 3;
            Console.WriteLine("Structtaki dikdörtgeni hesaplama : {0}", rectangle1ButStruct.calculateArea());

            Console.ReadLine();

            //*************** structlarda new le yaratmadan da yeni nesne ypbiliyoruz o da soyle

            rectangle_struct rectangle2ButStruct; // new'e gerek yok. Classta bunu yapamazsın classta newlemen gerek
            rectangle2ButStruct.shortEdge = 3;
            rectangle2ButStruct.longEdge = 4;
            Console.WriteLine("Newlemeden instance alinan struct alanı : {0}", rectangle2ButStruct.calculateArea());
        }

        class rectangle 
        {
            public int shortEdge;
            public int longEdge;

            public long calculateArea()
            {
                return this.longEdge * this.shortEdge;
            }

            public rectangle()
            { // constructorda parametresiz olarak default degerler verdim ama bunu classta yapabildim bir de structa bak
                longEdge = 5;
                shortEdge = 2;
            }
        }

        struct rectangle_struct // class yerine struct yzip icini copy paste ettim yani yazilislari ayni
        {
            public int shortEdge;
            public int longEdge;

            public long calculateArea()
            {
                return this.longEdge * this.shortEdge;
            }

            /* public rectangle_struct() ************************** HATA verdigi icin yoruma aldim bunu yapamazsin ama 
                                         * parametreli olur ama o da newlerken kullandigin parametreleri esitlyerek bak asagiya
             {
                 shortEdge = 5;
                 longEdge = 8;
             } 

            public rectangle_struct (int SHORTEdge, int LONGEdge) // bu da olmaz 
            {
                SHORTEdge = 5;
                LONGEdge = 8;
            } */

            public rectangle_struct(int SHORTEdge, int LONGEdge) //bu da düz constructor gibi oldu aslinda tam anlamadım
            {
                shortEdge = SHORTEdge;
                longEdge = LONGEdge;
            }

        }
    }
}
