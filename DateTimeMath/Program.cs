using System;

namespace DateTimeMath
{
    class Program
    {
        static void Main(string[] args)
        {
            //Datetime
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);
            Console.WriteLine(DateTime.Now.Millisecond);
            Console.WriteLine(DateTime.Now.Ticks);

            Console.WriteLine("*************************");

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());

            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine("*************************");

            Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            Console.WriteLine(DateTime.Now.ToString("HH"));
            Console.WriteLine(DateTime.Now.ToString("HH:mm"));
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));

            Console.WriteLine("*************************");

            Console.WriteLine(DateTime.Now.ToString("dd"));
            Console.WriteLine(DateTime.Now.ToString("ddd"));
            Console.WriteLine(DateTime.Now.ToString("dddd"));

            Console.WriteLine(DateTime.Now.ToString("MM"));
            Console.WriteLine(DateTime.Now.ToString("MMM"));
            Console.WriteLine(DateTime.Now.ToString("MMMM"));

            Console.WriteLine(DateTime.Now.ToString("yy"));
            Console.WriteLine(DateTime.Now.ToString("yyyy"));

            Console.WriteLine("*************************");

            Console.WriteLine(DateTime.Now.AddDays(1));
            Console.WriteLine(DateTime.Now.AddHours(1));
            Console.WriteLine(DateTime.Now.AddMinutes(1));

            Console.WriteLine("*************************");

            //Math

            Console.WriteLine(Math.Abs(-5));
            Console.WriteLine(Math.Ceiling(5.5));
            Console.WriteLine(Math.Floor(5.5));
            Console.WriteLine(Math.Pow(5, 2));
            Console.WriteLine(Math.Round(5.5));
            Console.WriteLine(Math.Sqrt(25));

            Console.WriteLine(Math.Max(2, 5));

            Console.WriteLine(Math.Sin(30));
            Console.WriteLine(Math.Tan(30));



        }
    }
}
