using System;

namespace AlgoritmaSorusu1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru1
            Console.WriteLine("***********************");
            Console.WriteLine("**********Soru1**********");

            Console.Write("Kaç tane sayı gireceksiniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];


            while (n > 0)
            {
                arr[n - 1] = Convert.ToInt32(Console.ReadLine());
                n--;
            }

            Console.WriteLine("2ye bölünen sayılar ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("***********************");
            Console.WriteLine("**********Soru2**********");

            //Soru2

            Console.Write("ilk sayıyı giriniz: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz: ");
            int y = Convert.ToInt32(Console.ReadLine());
            int[] arr2 = new int[x];

            Console.WriteLine("{0} tane sayı giriniz: ", x);

            while (x > 0)
            {
                arr2[x - 1] = Convert.ToInt32(Console.ReadLine());
                x--;
            }

            Console.WriteLine("Cevaplar");
            for (int i = 0; i < arr2.Length; i++)
            {
                if (arr2[i] % y == 0 || arr2[i] == y)
                    Console.Write(arr2[i] + " ");
            }


            Console.WriteLine("***********************");
            Console.WriteLine("**********Soru3**********");

            //Soru3

            Console.Write("Bir tane sayı giriniz: ");
            int k = Convert.ToInt32(Console.ReadLine());
            int[] arr3 = new int[k];

            while (k > 0)
            {
                arr3[k - 1] = Convert.ToInt32(Console.ReadLine());
                k--;
            }

            Console.WriteLine("Sıralı sayılar ");
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write(arr3[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("***********************");
            Console.WriteLine("**********Soru4**********");

            //Soru4

            Console.Write("Bir tane cümle giriniz: ");
            string cümle = Convert.ToString(Console.ReadLine());

            Console.Write("cümlede {0} tane kelimel vardır.", cümle.Split(' ').Length);
            Console.WriteLine();
            Console.WriteLine("cülmede {0} tane harf vardır.", cümle.Replace(" ", "").Length);

        }
    }
}
