using System;

namespace SınıfMetot
{
    class Program
    {
        static void Main(string[] args)
        {
            var calisan = new Calisan();

            calisan.Ad = "Ali";
            calisan.Soyisim = "Kara";
            calisan.No = 1000;
            calisan.Departman = "Bilgi İşlem";

            calisan.CalisanBilgileri();

            var calisan2 = new Calisan("Ayşe", "Kara", 2000, "IT");
            calisan2.CalisanBilgileri();

        }
    }


    class Calisan
    {
        public string Ad;
        public string Soyisim;
        public int No;
        public string Departman;


        public void CalisanBilgileri()
        {
            Console.WriteLine("Adı: {0}", Ad);
            Console.WriteLine("Soyadı: {0}", Soyisim);
            Console.WriteLine("No: {0}", No);
            Console.WriteLine("Departman: {0}", Departman);
        }

        public Calisan()
        {
        }

        public Calisan(string ad, string soyisim, int no, string departman)
        {
            Ad = ad;
            Soyisim = soyisim;
            No = no;
            Departman = departman;
        }
    }
}
