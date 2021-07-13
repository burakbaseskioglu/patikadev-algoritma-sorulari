using System;

namespace koleksiyonlar_soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{i + 1}. sayıyı giriniz:");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            EnBuyukUcSayi(numbers);
            EnKucukSayi(numbers);
        }

        public static void EnBuyukUcSayi(int[] arr)
        {
            int maxNumber1 = 0, maxNumber2 = 0, maxNumber3 = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxNumber1)
                {
                    maxNumber3 = maxNumber2;
                    maxNumber2 = maxNumber1;
                    maxNumber1 = arr[i];
                }
                else if (arr[i] > maxNumber2)
                {
                    maxNumber2 = arr[i];
                }
                else if (arr[i] > maxNumber3)
                {
                    maxNumber3 = arr[i];
                }
            }

            double result = AverageOfArray(maxNumber1, maxNumber2, maxNumber3);
            Console.WriteLine($"En büyük üç sayının ortalaması={result}");
        }

        public static void EnKucukSayi(int[] arr)
        {
            int minNumber1 = 0, minNumber2 = 0, minNumber3 = 0;

            Array.Sort(arr);
            minNumber1 = arr[0];
            minNumber2 = arr[1];
            minNumber3 = arr[2];

            double result = AverageOfArray(minNumber1, minNumber2, minNumber3);
            Console.WriteLine($"En küçük üç sayının ortalaması={result}");
        }

        public static double AverageOfArray(int number1, int number2, int number3)
        {
            double sum = number1 + number2 + number3;
            double average = sum / 3;
            return average;
        }
    }
}
