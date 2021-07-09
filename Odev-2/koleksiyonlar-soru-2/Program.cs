using System;

namespace koleksiyonlar_soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[20];
            int[] sayiBuyuk = new int[3];
            int[] sayiKucuk = new int[3];

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write($"{i + 1}. sayıyı giriniz:");
                sayilar[i] = int.Parse(Console.ReadLine());
            }

            int j = 0;
            Array.Sort(sayilar);
            for (int i = sayilar.Length - 1; i > sayilar.Length - 4; i--)
            {
                if (j < 3)
                {
                    sayiBuyuk[j] = sayilar[i];
                    j++;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                sayiKucuk[i] = sayilar[i];
            }

            double toplam = 0;
            double kucukOrtalama = 0;
            double buyukOrtalama = 0;

            foreach (var item in sayiBuyuk)
            {
                toplam = toplam + item;
            }
            buyukOrtalama = toplam / sayiBuyuk.Length;
            Console.WriteLine("En büyük üç sayının ortalaması={0:f2}", buyukOrtalama);

            toplam = 0;

            foreach (var item in sayiKucuk)
            {
                toplam = toplam + item;
            }
            kucukOrtalama = toplam / sayiKucuk.Length;
            Console.WriteLine("En küçük üç sayının ortalaması={0:f2}", kucukOrtalama);

            Console.WriteLine("Ortalama toplamları={0:f2}", kucukOrtalama + buyukOrtalama);
        }
    }
}
