using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Bir Sayı giriniz!");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girdiğiniz sayı: " + a);

                // int b = int.Parse(Console.ReadLine());

                // int c = a + b;

                // Console.WriteLine(c);
            }
            catch (Exception e)
            {
                Console.WriteLine("Hata Oluştu: " + e.Message);
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı.");
            }


            try
            {
                int a = int.Parse(null);
            }
            catch (ArgumentNullException)
            {
                throw new Exception("Girilen değer boş olamaz.");
            }


            try
            {
                int a = int.Parse(null);
            }
            catch (ArgumentNullException)
            {
                throw new Exception("Girilen değer boş olamaz.");
            }




        }
    }
}
