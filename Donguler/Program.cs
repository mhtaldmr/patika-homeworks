using System;
using System.Linq;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;

            for (int i = 0; i < 10; i++)
            {
                toplam += i;
            }

            Console.WriteLine(toplam);


            foreach (int i in Enumerable.Range(0, 10))
            {
                toplam += i;
            }

            Console.WriteLine(toplam);

            int[] dizi = new int[10];

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = i;
            }

            Console.WriteLine(dizi.Sum());
            Console.WriteLine(dizi.Where(x => x % 5 == 0).Count());

            var n = new String('#', 3).PadLeft(10, '*');

            Console.WriteLine(n);

        }
    }
}
