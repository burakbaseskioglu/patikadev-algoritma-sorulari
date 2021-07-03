using System;

namespace Soru_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int characterLength = 0;

            Console.Write("Cümle yazınız:");
            string sentence = Console.ReadLine();

            string[] wordsArray = sentence.Split(' ');

            foreach (var item in wordsArray)
            {
                string word = item.Trim('.', ',', ':', ';');
                characterLength = characterLength + word.Length;
            }

            Console.WriteLine($"Girilen cümlenin toplam kelime sayısı {wordsArray.Length}");
            Console.WriteLine($"Girilen cümlenin toplam harf sayısı {characterLength}");
        }
    }
}
