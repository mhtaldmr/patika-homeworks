using System;

namespace MetotOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametlere 
            string sayi = "10";

            bool sonuc = int.TryParse(sayi, out int a);

            if (sonuc)
            {
                Console.WriteLine("Sayı: {0}", a);
            }
            else
            {
                Console.WriteLine("Sayı değeri hatalı");
            }

            Metotlar metotlar = new Metotlar();

            metotlar.Toplama(10, 20, out int toplam);

            Console.WriteLine("Toplam: {0}", toplam);


            //Metot Overload

            int x = 2;
            metotlar.EkranaYazdır(x);
            metotlar.EkranaYazdır(Convert.ToString(x));


        }
    }

    class Metotlar
    {
        public void Toplama(int a, int b, out int toplam)
        {
            toplam = a + b;
        }

        public void EkranaYazdır(string yazı)
        {
            Console.WriteLine(yazı);
        }

        public void EkranaYazdır(int yazı)
        {
            Console.WriteLine(yazı);
        }
    }
}
