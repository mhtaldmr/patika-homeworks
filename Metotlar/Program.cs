using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Metotlar
            int a = 2;
            int b = 3;
            int c = a + b;

            Console.WriteLine("a+b={0}", c);
            Console.WriteLine("*************************");

            int d = Topla(a, b);

            Console.WriteLine("a+b={0}", d);

            Metotlar metotlar = new Metotlar();
            metotlar.EkranaYazdır("Merhaba");

        }
        static int Topla(int a, int b)
        {
            return a + b;
        }
    }

    class Metotlar
    {
        public void EkranaYazdır(string yazı)
        {
            Console.WriteLine(yazı);
        }
    }
}
