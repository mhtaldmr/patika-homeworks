using System;
using System.Collections.Generic;
using System.Linq;

namespace KoleksiyonSoru3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vowel check
            Console.WriteLine("Bir cümle giriniz:");

            var cümle = Convert.ToString(Console.ReadLine());

            var vowel = new char[5] { 'a', 'e', 'i', 'o', 'u' };
            var vowelCount = 0;
            var vowelList = new List<char>();

            foreach (var item in cümle)
            {
                if (vowel.Contains(item))
                {
                    vowelList.Add(item);
                    vowelCount++;
                }
            }

            Console.WriteLine("Vowel count: " + vowelCount);
            vowelList.Sort();
            foreach (var item in vowelList)
            {
                Console.Write(item + " ");
            }
        }
    }
}
