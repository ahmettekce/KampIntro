using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int buyukSayi, ortalama, toplam=0;
            int[] sayilar = new int[20];
            Random rasgele = new Random();
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rasgele.Next();
                if (sayilar[i]<0)
                {
                sayilar[i] = rasgele.Next();

                }
                toplam += sayilar[i];
                Console.WriteLine($"{i}.sayı: {sayilar[i]} toplam: {toplam}");
            }

            ortalama = toplam / sayilar.Length;
            Console.WriteLine(ortalama);
        }
    }
}
