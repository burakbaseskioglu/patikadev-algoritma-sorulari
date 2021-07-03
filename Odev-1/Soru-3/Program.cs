using System;

namespace Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaç kelime girilsin:");
            int characterLength = int.Parse(Console.ReadLine());

            string[] wordsArray = new string[characterLength];

            for (int i = 0; i < characterLength; i++)
            {
                Console.Write($"{i + 1}. kelimeyi giriniz:");
                wordsArray[i] = Console.ReadLine().ToLower();
            }

            foreach (string item in wordsArray)
            {
                for (int i = item.Length - 1; i >= 0; i--)
                {
                    Console.Write(item[i]);
                }
                Console.WriteLine(" ");
            }
        }
    }
}
