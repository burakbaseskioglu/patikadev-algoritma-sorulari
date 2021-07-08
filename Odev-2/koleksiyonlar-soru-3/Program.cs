using System;
using System.Collections;

namespace koleksiyonlar_soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            Console.Write("Cümle giriniz:");
            string expression = Console.ReadLine();

            ArrayList vowelsSentence = new ArrayList();
            for (int i = 0; i < expression.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (expression[i] == vowels[j] && !vowelsSentence.Contains(expression[i]))
                    {
                        vowelsSentence.Add(expression[i]);
                    }
                }
            }
            
            Console.WriteLine("**** Cümledeki sesli harfler ****");
            vowelsSentence.Sort();
            foreach (var item in vowelsSentence)
            {
                Console.WriteLine(item);
            }
        }
    }
}
