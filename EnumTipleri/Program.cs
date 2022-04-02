using System;

namespace EnumTipleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazartesi);

            Console.WriteLine((int)Gunler.Pazar); //26
        }
    }

    enum Gunler
    {
        Pazartesi = 5,
        Sali,
        Carsamba,
        Persembe,
        Cuma,
        Cumartesi = 25,
        Pazar
    }
}
