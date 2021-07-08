using System;
using System.Collections;

namespace koleksiyonlar_soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList asalOlanlar = new ArrayList();
            ArrayList asalOlmayanlar = new ArrayList();
            ArrayList sayilar = new ArrayList();
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{i + 1}. sayyıyı giriniz:");
                int sayi = int.Parse(Console.ReadLine());
                sayilar.Add(sayi);
            }
            int sayac = 0;
            foreach (var item in sayilar)
            {
                for (int i = 2; i < (int)item; i++)
                {
                    if ((int)item % i == 0)
                    {
                        sayac++;
                        break;
                    }
                }
                if (sayac != 0)
                {
                    asalOlmayanlar.Add(item);
                    sayac = 0;
                }
                else
                {
                    asalOlanlar.Add(item);
                }
            }

            Console.WriteLine("**** Asal olanlar ****");
            foreach (var item in asalOlanlar)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("**** Asal olmayanlar ****");
            foreach (var item in asalOlmayanlar)
            {
                Console.WriteLine(item);
            }

        }
    }
}
