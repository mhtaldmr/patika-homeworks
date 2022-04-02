using System;
using System.Text;

namespace StringMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz csharp, hosgeldiniz";
            string degisken2 = "Dersimiz csharp";

            //Length
            Console.WriteLine("Degiskenin uzunlugu: " + degisken.Length);

            //ToLower
            Console.WriteLine("Degiskenin kucuk harflerini alan: " + degisken.ToLower());

            //ToUpper
            Console.WriteLine("Degiskenin buyuk harflerini alan: " + degisken.ToUpper());

            //Concat
            Console.WriteLine("Degiskenin sonuna ! eklenmis hali: " + String.Concat(degisken, "!"));

            //Compare  //-1 ve 1 degerleri dondurur. hangisi büyükse onu 1 döndürür.
            Console.WriteLine("Degiskenlerin karsilastirmasi: " + String.Compare(degisken, degisken2, true));
            //CompareTo extension metodu şeklinde döner
            Console.WriteLine("Degiskenlerin karsilastirmasi: " + degisken.CompareTo(degisken2));

            //Contains
            Console.WriteLine("Degisken csharp iceriyor mu: " + degisken.Contains("csharp"));

            //EndsWith
            Console.WriteLine("Degisken sonuna . ekleniyor mu: " + degisken.EndsWith("."));

            //IndexOf
            Console.WriteLine("Degisken icerisinde Indexof: " + degisken.IndexOf("csharp"));

            //Insert
            Console.WriteLine("Degisken icerisinde Insert: " + degisken.Insert(5, "csharp"));

            //LastIndexOf
            Console.WriteLine("Degisken icerisinde Lastindex: " + degisken.LastIndexOf("i"));

            //PadLeft
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(50, '*'));

            //PadRight
            Console.WriteLine(degisken2.PadRight(30, '*') + degisken);

            //Remove
            Console.WriteLine("Degisken icerisinde Remove: " + degisken.Remove(5, 4));

            //Replace
            Console.WriteLine("Degisken icerisinde Replace: " + degisken.Replace("csharp", "C#"));

            //Split
            Console.WriteLine("Degisken icerisinde Split: " + degisken.Split(' ')[0]);

            //Substring
            Console.WriteLine("Degisken icerisinde Substring: " + degisken.Substring(5, 4));

            //Trim
            Console.WriteLine("Degisken icerisinde Trim: " + degisken.Trim());

            //TrimStart
            Console.WriteLine("Degisken icerisinde TrimStart: " + degisken.TrimStart('D', 'e', 'r'));

            //TrimEnd
            Console.WriteLine("Degisken icerisinde TrimEnd: " + degisken.TrimEnd('z'));

            //ToCharArray
            char[] karakterler = degisken.ToCharArray();
            foreach (char karakter in karakterler)
            {
                Console.Write(karakter);
            }
            Console.WriteLine();
            Console.WriteLine("*****************************");
            //StringBuilder
            var sb = new StringBuilder();
            sb.Append("Dersimiz csharp, hosgeldiniz");
            sb.AppendLine();
            sb.Append("Dersimiz csharp, hosgeldiniz");

            Console.WriteLine(sb.ToString().ToUpper());



        }
    }
}
