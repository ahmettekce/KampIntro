using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Proglamaya başlangıç için temel kurs";
            string kurs3 = "java";



            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı","Proglamaya başlangıç için temel kurs","Java","Python","C#"};



            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti\n");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("\nSayfa sonu - footer");
        }
    }
}
