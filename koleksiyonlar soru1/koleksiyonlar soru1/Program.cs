using System;
using System.Collections;


namespace koleksiyonlar_soru1
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

                if((int)Console.ReadLine(), out int number) && number > 0)
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
                Console.WriteLine(item);
            }

            Console.WriteLine("Asal Olmayan Sayılar ");
            foreach (int item in notPrimeNumbers)
            {
                Console.WriteLine(item);
            }

            Double primeNumbersAverage = AverageCalculate(primeNumbers);
            double notPrimeNumbersAverage = AverageCalculate(notPrimeNumbers);

            Console.ReadLine();
        }


        static bool IsPrime(int Number)
        {
            if (Number <= 1)
                return false;
            for (int i = 0; i <= Number; i++)
            {
                if (Number % i == 0)
                    return false;
            }
            return true;
        }

        static Double AverageCalculate(ArrayList listForAverage)
        {
            Double total = 0;
            foreach  (int item in listForAverage)
            {
                total += item;
            }
            return total / listForAverage.Count;
        }
    }
}
