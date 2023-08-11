using System;
using System.Collections;

namespace collection_question3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bir cümle giriniz");
            string sentence = Console.ReadLine();

            ArrayList vowels = new ArrayList();

            foreach (char letter in sentence)
            {
                if (IsVowel(letter))
                    vowels.Add(letter);

            }

            vowels.Sort();
            if (vowels.Count == 0)
                Console.WriteLine("girdiğiniz metinde sesli harf bulunmamaktadır");
            else
                Console.WriteLine("Sesli harfler ; ");

            foreach (char item in vowels)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            
        }

        

        static bool IsVowel(char letter)
        {
            letter = char.ToLower(letter);

            return letter == 'a' || letter == 'e' || letter == 'ı' || letter == 'i' || letter == 'o' || letter == 'ö' || letter == 'u' || letter == 'ü';
        }
    }
}
