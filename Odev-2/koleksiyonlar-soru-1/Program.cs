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
            for (int i = 0; i < 20; i++)
            {
                Console.Write($"{i + 1}. sayıyı giriniz:");
                //int sayi = int.Parse(Console.ReadLine());
                string sayi = Console.ReadLine();
                bool sonuc = Int32.TryParse(sayi, out int sayi2);
                if (sayi2 < 0 || !sonuc)
                {
                    i--;
                    continue;
                }
                sayilar.Add(sayi2);
            }
            int sayac = 0;
            foreach (int item in sayilar)
            {
                for (int i = 2; i < item; i++)
                {
                    if (item % i == 0)
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
            asalOlanlar.Sort();
            asalOlmayanlar.Sort();
            double toplam = 0;

            Console.WriteLine($"*** Asal olanlar - Eleman sayısı:{asalOlanlar.Count} ***");
            foreach (int item in asalOlanlar)
            {
                toplam = toplam + item;
                Console.WriteLine(item);
            }
            Console.WriteLine($"Asal olanların ortalaması={toplam / asalOlanlar.Count}");

            toplam = 0;
            Console.WriteLine();

            Console.WriteLine($"*** Asal olmayanlar - Eleman sayısı:{asalOlmayanlar.Count} ***");
            Console.WriteLine($"Asal olmayanların eleman sayısı:{asalOlmayanlar.Count}");
            foreach (int item in asalOlmayanlar)
            {
                toplam = toplam + item;
                Console.WriteLine(item);
            }
            Console.WriteLine($"Asal olmayanların ortalaması={toplam / asalOlmayanlar.Count}");
        }
    }
}
