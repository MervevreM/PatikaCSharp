using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sınıf_nedir_ders_notları
{
    class Program
    {
        static void Main(string[] args)
        {
            employee emplooyee1 = new employee(); // classın bir kopyasını yaptık adı calısan1
            emplooyee1.name = "Merve";
            emplooyee1.surname = "KASAL";
            emplooyee1.no = 288132;
            emplooyee1.department = "bisiler";

            employee employee2 = new employee(); // yeni klon aldık
            employee2.name = "baskabisiler";
            employee2.surname = "bla";
            employee2.no = 484;
            employee2.department = "fff";

            employee2.GetEmployeeInfos();

            Console.WriteLine("*******************");

            emplooyee1.GetEmployeeInfos();

            Console.ReadLine();


        }

    }

    class employee // sınıf oluşturup özellikler verdik ayrıca sınıf içerisine özellikleri yazan bir method yazdık
    {
        public string name;
        public string surname;
        public int no;
        public string department;

        public void GetEmployeeInfos()
        {
            Console.WriteLine($"Employee's name {name}");
            Console.WriteLine($"Employee's surname {surname}");
            Console.WriteLine($"Employee's no {no}");
            Console.WriteLine($"Employee's department {department}");

        }

    }
}
