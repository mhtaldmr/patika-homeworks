using System;

namespace StaticSınıf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Sayısı : " + Calisan.CalisanSayisi);

            Calisan calisan = new Calisan("Ali", "Kaya", "Bilgisayar");

            Console.WriteLine("Çalışan Sayısı : " + Calisan.CalisanSayisi);

        }
    }

    class Calisan
    {
        private static int calisanSayisi;
        public static int CalisanSayisi { get => calisanSayisi; /*set => calisanSayisi = value; */ }

        private string ad;
        private string soyad;
        private string departman;

        static Calisan()
        {
            calisanSayisi = 0;
        }

        public Calisan(string ad, string soyad, string departman)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.departman = departman;
            calisanSayisi++;
        }


    }
}
