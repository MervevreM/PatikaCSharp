using System;


namespace Encapsulation_Notes
{
    class Program
    {

        /* encapsule ile sınıftaki propertileri kontol edebiliyoruz. her propertinin get ve set methodları var 
         * get read icin set write icin eger bir degerin degismesini istemiyorsak onu readonly kismina cekebiliyoruz 
         * bunu da sınıftaki propertinin set methodunda degisiklik yaparak hallediyoruz. Hatta set edilecek degeri 
         * sınırlayabiliyoruz bunu set edilen baska methodlar icerisinde yapmak mumkun ama bu kesşin cozum degil 
         * ilerleyen gunlerde farklı methodlar yazılıp deger sınırlarımızın dısına cekilebilir bu yuzden bunu propertinin 
         * cıktıgı yerden yaparak istegimizin dısına cikilmadigina emin olabiliriz. bunu da propertinin set methodunda 
         * yapmak en iyi cozum. asagıda yapıcam izle. encapsule edecegimiz propertiyi private tanımyamal onemli sonrasında bu
         * private degisken icin public method hazırlicaz degerleri istedigimiz sekilde dondurucez dondurdugumuzu 
         * classın propertisine esitlicez  asagıda yapıcam ona da bak
         */
        static void Main(string[] args)
        {
            student student1 = new student("merve", "kasal", 88, 5); // constructor method zaten parametre gerekliliklerini direkt yazıyor.
                                                                     // Bu sekilde atama yapmama gerek kalmadı

            student1.GetStudentInfos();
            Console.ReadLine();
            student1.StudentClass = 0; // yazarken sikinti yok ama terminalde set icerisinde yazdigim hatayi verdi ve
                                       // classi 1'e setledi cunku encapsule isleminde eger 1 den kucuk deger gelirse
                                       // 1e setlemesini soyledim
            student1.GetStudentInfos();
            Console.ReadLine();
        }

        
    }
    class student
    {
        private string name;
        private string surname;
        private int studentNo;
        private int studentClass;

        public string Name // ulasmaya calisan buna ulasicak cunku gercek name private. Ben burda ne yazarsam kullanan onu alabilir
        {
            get => name; // Bunun ayyyynısı ******** get { return name; } 
            set => name = value; // bunun ayyynısı  set { name = value ; } // su an publicte property tanimlamamızdan bir farkı olmadı
                                 // ismi de alabiliyorlar isme deger de atayabiliyorlar ama sotle yaparsak bunu degistiririz
        }

        public int StudentClass
        {
            get => studentClass;
            set
            {
                if (value < 1) // classın set methodunu sınırlandırdık eger biri sınıf için 1den küçük
                               // bir deger atamaya calışırsa ona hata mesajı gonderdik be 1den buyuk sayılara izin verdik
                {
                    Console.WriteLine("Student class can be at least 1");
                    value = 1;
                }
                studentClass = value;
            }
        }
        public string Surname // classta public yapmisiz gibi oldu sinirlama getirmedik düz parantez kullanmıyorum dikkat et
        {
            get => surname;
            set => surname = value;

        }

        public int StudentNo
        {
            get => studentNo; // classtaki degeri ver
            set => studentNo = value; // classta private tanimladigimiz halde gel set etmesine izin ver dedik
        }

        



        public void GetStudentInfos()
        {
            Console.WriteLine("***** Student's Infos*****");
            Console.WriteLine("Student's name    : {0}", this.name);
            Console.WriteLine("Student's surname   : {0}", this.surname);
            Console.WriteLine("Student's no   : {0}", this.studentNo);
            Console.WriteLine("Student's class    : {0}", this.studentClass);

        }

        public student(string name, string surname, int studentNo, int studentClass) // parametrelerle direkt set edebilmek icin bir constructo method olusturduk
        {

            Name = name; // ilkler publik yaptigimiz degisken encapsulationları ikinciler ise sontructor parametreleri
            Surname = surname;
            StudentClass = studentClass;
            StudentNo = studentNo; 
        }
    }
}
