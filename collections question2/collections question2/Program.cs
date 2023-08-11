using System;
using System.Collections;

namespace collections_question2
{
    class Program
    {
        static void Main(string[] args) 
        {
            ArrayList numbers = new ArrayList();

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"Lütfen {i + 1}. sayıyı girin: ");

                if (int.TryParse(Console.ReadLine(), out int number))
                    numbers.Add(number);
                else
                {
                    Console.WriteLine("Geçersiz giriş yaptınız. Lütfen bir sayı girin.");
                    i--;
                }
            }

            numbers.Sort();

            ArrayList largeNumbers = new ArrayList();
            ArrayList smallNumbers = new ArrayList();

            for (int i = 0; i < 3; i++)
            {
                smallNumbers.Add(numbers[i]);

            }

            numbers.Reverse();

            for (int i = 0; i < 3; i++)
            {
                largeNumbers.Add(numbers[i]);

            }

            double largeNumbersAverage = CalculateAverage(largeNumbers);
            double smallNumbersAverage = CalculateAverage(smallNumbers);

            Console.WriteLine("En küçük sayılar");
            foreach (int item in smallNumbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"En küçük sayıların ortalaması : {smallNumbersAverage}");

            Console.WriteLine("*************************************");

            Console.WriteLine("En büyük sayılar:");
            foreach (int item in largeNumbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"En büyük sayıların ortalaması{largeNumbersAverage}");

            Console.WriteLine($"İki ortalamanın ortalaması :) {(largeNumbersAverage + smallNumbersAverage) / 2}");
            Console.ReadLine();


        }

        static double CalculateAverage(ArrayList list4Calculate)
        {
            int total = 0;
            foreach (int item in list4Calculate)
            {
                total += item;
            }
            return total / list4Calculate.Count;
        }
    }
}
