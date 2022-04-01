using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 1: Console.WriteLine("Merhaba"); break;
                case 2: Console.WriteLine("Selam"); break;
                case 3: Console.WriteLine("Nasılsın"); break;
                case 4: Console.WriteLine("İyi Günler"); break;
                default: Console.WriteLine("Hiçbirşey"); break;
            }

            Console.WriteLine("Bugün aylardan : ");
            int month = DateTime.Now.Month;

            switch (month)
            {
                case 1: Console.WriteLine("Ocak"); break;
                case 2: Console.WriteLine("Şubat"); break;
                case 3: Console.WriteLine("Mart"); break;
                case 4: Console.WriteLine("Nisan"); break;
                case 5: Console.WriteLine("Mayıs"); break;
                case 6: Console.WriteLine("Haziran"); break;
                case 7: Console.WriteLine("Temmuz"); break;
                case 8: Console.WriteLine("Ağustos"); break;
                case 9: Console.WriteLine("Eylül"); break;
                case 10: Console.WriteLine("Ekim"); break;
                case 11: Console.WriteLine("Kasım"); break;
                case 12: Console.WriteLine("Aralık"); break;
                default: Console.WriteLine("Geçersiz"); break;
            }
        }
    }
}
