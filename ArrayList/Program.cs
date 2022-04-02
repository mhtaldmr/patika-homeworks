using System;
using System.Collections.Generic;
using System.Collections;


namespace ArrayListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arraylist

            ArrayList liste = new ArrayList();

            liste.Add(1);
            liste.Add(2);
            liste.Add(3);
            liste.Add(true);
            liste.Add("Ali");
            liste.Add(new DateTime(2019, 1, 1));

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("***************************");

            liste.AddRange(new int[] { 4, 5, 6 });

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("***************************");

            Console.WriteLine(liste.Count);
            // Console.WriteLine(liste.Sort); //Hata verir. Çünkü arraylist icindekileri neyi sıralamak istediğinizi bilmiyor.
            // Console.WriteLine(liste.BinarySearch(2));

            liste.Reverse();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
        }
    }
}
