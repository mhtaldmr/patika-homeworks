using System;

namespace Condition
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = Convert.ToInt32(DateTime.Now.ToString("hh"));
            Console.WriteLine(time);
            if (time < 10)
                Console.WriteLine("Goodmorning  World!" + "Saat : " + time);
            else if (time < 20)
                Console.WriteLine("Goodday  World!" + "Saat : " + time);
            else
                Console.WriteLine("Goodevening  World!" + "Saat : " + time);

        }
    }
}
