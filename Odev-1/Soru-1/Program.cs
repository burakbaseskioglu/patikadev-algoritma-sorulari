using System;

namespace Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // do
            // {
            //     Console.Write("Dizi boyutunu giriniz:");
            //     boyut = int.Parse(Console.ReadLine());

            // } while (boyut <= 0);

            Console.Write("Kaç elemanlı olsun:");
            int boyut = int.Parse(Console.ReadLine());

            int[] sayiDizisi = new int[boyut];
            for (int i = 0; i < boyut; i++)
            {
                Console.Write($"{i + 1}. sayıyı giriniz:");
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Girilen sayıların çift olanları");
            foreach (var item in sayiDizisi)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}
