using System;

namespace Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dizi boyutunu giriniz:");
            int arrLength = int.Parse(Console.ReadLine());

            Console.Write("Sayıları bölmesini istediğiniz sayıyı giriniz:");
            int divider = int.Parse(Console.ReadLine());

            int[] arr = new int[arrLength];
            for (int i = 0; i < arrLength; i++)
            {
                Console.Write($"{i + 1}. sayıyı giriniz:");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Girilen sayıların, {divider} ile tam bölünen ya da eşit olanları");
            foreach (var item in arr)
            {
                if (item % divider == 0 || item == divider)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
