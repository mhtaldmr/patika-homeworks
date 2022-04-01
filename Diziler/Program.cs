using System;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[5];

            isimler[0] = "Ahmet";
            isimler[1] = "Mehmet";
            isimler[2] = "Ali";
            isimler[3] = "Veli";
            isimler[4] = "Ayşe";

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler[i]);
            }

            Console.WriteLine("*************************");

            foreach (string isim in isimler)
            {
                Console.WriteLine(isim);
            }

            Console.WriteLine("*************************");

            string[] isimler2 = new string[] { "Ahmet", "Mehmet", "Ali", "Veli", "Ayşe" };

            foreach (string isim in isimler2)
            {
                Console.WriteLine(isim);
            }

            Console.WriteLine("*************************");

            int[] sayilar = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (int sayi in sayilar)
            {
                Console.Write(sayi);
            }

            Console.WriteLine();
            Console.WriteLine("*************************");

            Console.WriteLine("Lütfen bir sayı giriniz:");
            var diziUzunluğu = Convert.ToInt32(Console.ReadLine());
            var sayiDizisi = new int[diziUzunluğu];
            var toplam = 0;
            for (int i = 0; i < sayiDizisi.Length; i++)
            {
                Console.WriteLine("Lütfen {0}. sayıyı giriniz:", i + 1);
                sayiDizisi[i] = Convert.ToInt32(Console.ReadLine());
                toplam += sayiDizisi[i];
            }

            Console.WriteLine(toplam);

        }
    }
}
