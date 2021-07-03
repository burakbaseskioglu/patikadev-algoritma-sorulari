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
            int arrLength = int.Parse(Console.ReadLine());

            int[] arr = new int[arrLength];
            for (int i = 0; i < arrLength; i++)
            {
                Console.Write($"{i + 1}. sayıyı giriniz:");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Girilen sayıların çift olanları");
            foreach (var item in arr)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}
