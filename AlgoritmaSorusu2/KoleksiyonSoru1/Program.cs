using System;
using System.Collections.Generic;
using System.Collections;
using System.Text.RegularExpressions;

namespace KoleksiyonSoru1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("20 Tane sayı giriniz:");
            int N = 0;
            var list = new List<int>();
            ArrayList asalSayilar = new ArrayList();
            ArrayList asalOlmayanSayilar = new ArrayList();

            try
            {
                while (N < 20)
                {
                    int sayi = Convert.ToInt32(Console.ReadLine());
                    if (sayi > 0)
                        list.Add(sayi);
                    else
                    {
                        Console.WriteLine("Lütfen pozitif sayılar giriniz.");
                        break;
                    }
                    N++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Pozitif Sayı girmediniz! " + e.Message);
            }


            for (var i = 0; i < list.Count; i++)
            {
                if (list[i] == 2)
                    asalSayilar.Add(list[i]);
                else if (list[i] == 1)
                    asalOlmayanSayilar.Add(list[i]);
                else if (list[i] % 2 == 0)
                    asalOlmayanSayilar.Add(list[i]);
                else
                {
                    bool asalMi = true;
                    for (int j = 3; j < list[i] / 2; j += 2)
                    {
                        if (list[i] % j == 0)
                        {
                            asalOlmayanSayilar.Add(list[i]);
                            asalMi = false;
                            break;
                        }
                    }
                    if (asalMi)
                        asalSayilar.Add(list[i]);
                }
            }

            asalSayilar.Sort();
            asalOlmayanSayilar.Sort();

            Console.WriteLine("Asal Sayılar list uzunlugu: ");
            Console.WriteLine(asalSayilar.length);
            Console.WriteLine("Asal Sayılar list uzunlugu: ");
            Console.WriteLine(asalOlmayanSayilar.length);

            Console.WriteLine("Asal Sayılar Ortalaması:");
            Console.WriteLine(asalSayilar.avarage);
            Console.WriteLine("Asal Olmayan Sayılar Ortalaması:");
            Console.WriteLine(asalOlmayanSayilar.avarage);

            Console.WriteLine("Asal Sayılar: ");
            foreach (var item in asalSayilar)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Asal Olmayan Sayılar: ");
            foreach (var item in asalOlmayanSayilar)
            {
                Console.Write(item + " ");
            }





        }
    }
}
