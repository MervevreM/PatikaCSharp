using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Class
{
    class Program
    {
        /* static constructorlar classa ilk erisimde 1 kez calisirlar. 
         * static property ve methodlara erisirken instance almaya gerek yoktur class adı nokta ile static ozellikteki fieldlara erisebiliriz
         * consol writeline alanlarında instance almadan static fildlara eristik asagıda gorebilirsin
         * */
        static void Main(string[] args)
        {

            Console.WriteLine("Number of employees ; {0}", employee.employeeTotalNumberr); // classa ilk kez eristim
                                                                                           // burada static constructor
                                                                                           // calisti bir sonraki class
                                                                                           // eylemimde static constructora
                                                                                           // girilmicek

            employee employee1 = new employee("merve", "kasal", 8); // classa eristim ve bir instance aldım parmetre alan constructor ile
                                                                    // ama ustte ilk kez static
                                                                    // constructora erisip calisan sayısını bir yapmıstı zaten
                                                                    // simdi class icerisindeki calisan sayisini arttırma islemi
                                                                    // uygulanacak ve ilk calismada 0'a set edilmis olan sayı 1 olacak
            Console.WriteLine("Number of employees ; {0}", employee.employeeTotalNumberr);

            Console.ReadLine(); 
        }
    }

    class employee
    {
        private static int employeeTotalNumber;
        private string name;
        private string surname;
        private int no;
        
        public static int employeeTotalNumberr // static degeri get eden encapsulation yazdik set yok bu yuzden deger atanamaz.
        {
            get => employeeTotalNumber;
        }

        public employee (string Name, string Surname, int No) // constructor yazdık static constructor da yzabiliyoruz asagida
        {
            this.name = Name;
            this.surname = Surname;
            this.no = No;
            employeeTotalNumber++;
        }

        static employee() // static constructor yzdik. static constructorlar program calismaya basladiginda
                          // ilk cgirildigi yerde girer bir daha girmez. Bu sebeple baslangicta bir kez yapmak
                          // istedigimiz seyleri buraya yazabiliriz
        {
            employeeTotalNumber = 0;
        }
    }
}
