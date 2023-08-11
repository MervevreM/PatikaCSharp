using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_notes
{
    class Program
    {
        static void Main(string[] args)
        {
            employee employee1 = new employee("merve", "kasal", 8,"bisiler");
            employee1.GetPlayerInfo();
            Console.ReadLine();

            employee employee2 = new employee("Merve", "Kasal"); // classta 4 property vardı ama ben bu constructorda 2 property verdim
            employee2.GetPlayerInfo();                           // (ki bu constuctor methodu da iki tane alacak sekilde overload etmistim.
                                                                 // get player info methodumla yeni calisanın bilgilerini cekicem ama orada
                                                                 // departmanla no vardı classtaki propertyleri kullanarak yazdırıyou. Onlar default
                                                                 // degerleri ile gelecek. string ise boş int ise 0 bool ise false

            Console.ReadLine();
        }
    }


    class employee
    {
        string name;
        string surname;
        int no;
        string department;

        public employee(string Name,string Surname,int No,string Department) // constructor methodu yazıp prametre verdiğimiz için sınıfı olustururken
                                                                             // assignment yapmadan ozellikleri yazabilicez bir suru satird yaptigimizi
                                                                             // tek satirda ypbilicez. yukarida yapicam izle
        {
            this.name = Name; // bu classtaki name methodda verdigim parametreyle eslessin dedim burada minik bir baglama
            this.surname = Surname;
            this.no = No;
            this.department = Department;
        }

        public employee() { } // constructorlara overload yapabiliriz aynı isimle parametre alan ve almayan iki constructor method yazdık aynı classta

        public employee(string Name,string Surname) // 3. bir constructor method yazdık farklı parametreler sayesinde overload ettik. yukarıda calisicam orya bak
        {
            this.name = Name;
            this.surname = Surname;
        }
        public void GetPlayerInfo()
        {
            Console.WriteLine($"Emplyee's name: {name}");
            Console.WriteLine($"Emplyee's surname: {surname}");
            Console.WriteLine($"Emplyee's no: {no}");
            Console.WriteLine($"Emplyee's department: {department}");


        }
    }
}
