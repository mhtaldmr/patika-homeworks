using System;

namespace RekursifExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recurion
            var islemler = new Islemler();

            var sonuc = islemler.Expo(2, 3);
            Console.WriteLine(sonuc);


            //Extension
            string yazi = "Merhaba nasılsin? umarım iyisindir :)";
            Console.WriteLine(yazi);

            if (yazi.CheckSpaces())
            {
                Console.WriteLine("Boşluk var");

                Console.WriteLine("Boşluklar kaldirildiktan sonraki hali\n" + yazi.RemoveWhiteSpaces());
            }
            else
            {
                Console.WriteLine("Boşluk yok");
            }



        }
    }

    class Islemler
    {
        public int Expo(int sayi, int üs)
        {
            if (üs < 2)
                return sayi;

            return Expo(sayi, üs - 1) * sayi;
        }

    }
    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            // var dizi = param.Split(' ');
            // return string.Join("", dizi);
            return param.Replace(" ", "");
        }



    }

}
