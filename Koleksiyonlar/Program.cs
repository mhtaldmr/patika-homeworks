using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> liste = new List<int>();
            //T -> obje

            List<int> liste = new List<int>();

            liste.Add(1);
            liste.Add(2);
            liste.Add(3);

            List<string> isimler = new List<string>();

            isimler.Add("Ali");
            isimler.Add("Veli");
            isimler.Add("Ahmet");

            Console.WriteLine(liste[0]);
            Console.WriteLine(liste[1]);
            Console.WriteLine(liste[2]);
            Console.WriteLine("***************************");

            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine("***************************");

            Console.WriteLine(liste.Count);
            Console.WriteLine(isimler.Count);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            foreach (var item in isimler)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("***************************");

            Console.WriteLine(liste.Contains(2));
            Console.WriteLine(liste.Contains(4));
            Console.WriteLine(liste.BinarySearch(2));


            Console.WriteLine("***************************");

            string[] dizi = { "Ali", "Veli", "Ahmet" };

            List<string> dizi2 = new List<string>(dizi);

            foreach (var item in dizi2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("***************************");

            Kullanıcılar kullanıcılar = new Kullanıcılar();
            kullanıcılar.Isim = "Ali";
            kullanıcılar.Soyisim = "Veli";
            kullanıcılar.Yaş = 20;

            Kullanıcılar kullanıcılar2 = new Kullanıcılar();
            kullanıcılar2.Isim = "Ahmet";
            kullanıcılar2.Soyisim = "Kaya";
            kullanıcılar2.Yaş = 30;

            List<Kullanıcılar> kullanıcılarListesi = new List<Kullanıcılar>();
            kullanıcılarListesi.Add(new Kullanıcılar() { Isim = "Ayşe", Soyisim = "kaya", Yaş = 20 });

            foreach (var item in kullanıcılarListesi)
            {
                Console.WriteLine(item.Isim);
            }

            kullanıcılarListesi.Clear();


        }
    }

    public class Kullanıcılar
    {
        private string isim;
        private string soyisim;
        private int yaş;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yaş { get => yaş; set => yaş = value; }

    }
}
