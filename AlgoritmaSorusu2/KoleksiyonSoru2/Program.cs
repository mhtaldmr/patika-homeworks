using System;
using System.Linq;

namespace KoleksiyonSoru2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;

            var maxThree = new int[3];
            var minThree = new int[3];
            Console.WriteLine("20 Tane sayı giriniz:");

            var list = new int[20];

            while (N < 20)
            {
                int sayi = Convert.ToInt32(Console.ReadLine());
                list[N] = sayi;
                N++;
            }



            int maxTemp1 = list.Min();
            int maxTemp2 = list.Min();
            int maxTemp3 = list.Min();
            int minTemp1 = list.Max();
            int minTemp2 = list.Max();
            int minTemp3 = list.Max();

            foreach (var item in list)
            {
                if (item > maxTemp1)
                {
                    maxTemp3 = maxTemp2;
                    maxTemp2 = maxTemp1;
                    maxTemp1 = item;
                }
                else if (item > maxTemp2)
                {
                    maxTemp3 = maxTemp2;
                    maxTemp2 = item;
                }
                else if (item > maxTemp3)
                {
                    maxTemp3 = item;
                }
            }
            foreach (var item in list)
            {
                if (item < minTemp1)
                {
                    minTemp1 = item;
                }
                if (minTemp1 < item && item < minTemp2)
                {
                    minTemp2 = item;
                }
                if (minTemp2 < item && item < minTemp3)
                {
                    minTemp3 = item;
                }

            }



            Console.WriteLine("En büyük sayı: " + list.Max());
            Console.WriteLine("En küçük sayı: " + list.Min());

            Console.WriteLine("En büyük 3 sayı: " + maxTemp1 + " " + maxTemp2 + " " + maxTemp3);
            Console.WriteLine("En küçük 3 sayı: " + minTemp1 + " " + minTemp2 + " " + minTemp3);

            Console.WriteLine("Max Arraylist ortalaması: " + maxTemp1 + maxTemp2 + maxTemp3 / 3);
            Console.WriteLine("Min Arraylist ortalaması: " + minTemp1 + minTemp2 + minTemp3 / 3);

        }
    }
}
