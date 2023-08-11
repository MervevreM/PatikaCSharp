using System;
using System.Collections;



namespace collections_question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList primeNumbers = new ArrayList();
            ArrayList notPrimeNumbers = new ArrayList();

            int counter = 0;

            while (counter < 20)
            {
                Console.WriteLine($"lütfen  {counter + 1}. pozitif sayıyı giriniz");

                if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
                {
                    if (IsPrime(number))
                        primeNumbers.Add(number);
                    else
                        notPrimeNumbers.Add(number);
                    counter++;

                }
                else
                    Console.WriteLine("Geçersiz bir değer girdiniz. Lütfen pozitif bir tam sayı girin");
            }

            primeNumbers.Sort();
            notPrimeNumbers.Sort();

            Console.WriteLine("Asal Sayılar ");
            foreach (int item in primeNumbers)
            {
                Console.Write(item);
            }

            Console.WriteLine("Asal Olmayan Sayılar ");
            foreach (int item in notPrimeNumbers)
            {
                Console.Write(item);
            }

            
            double primeNumbersAverage = AverageCalculate(primeNumbers);
            Console.WriteLine($"Asal Sayıların ortalaması {primeNumbersAverage}'dır");

            double notPrimeNumbersAverage = AverageCalculate(notPrimeNumbers);
            Console.WriteLine($"Asal Olmayan Sayıların ortalaması {notPrimeNumbersAverage}'dır");


            Console.ReadLine();
        }


        static bool IsPrime(int Number)
        {
            if (Number <= 1)
                return false;
            for (int i = 3; i <= Number; i++)
            {
                if (Number % i == 0)
                    return false;
            }
            return true;
        }

        static Double AverageCalculate(ArrayList listForAverage)
        {
            Double total = 0;
            foreach (int item in listForAverage)
            {
                total += item;
            }
            return total / listForAverage.Count;
        }
    }
}
