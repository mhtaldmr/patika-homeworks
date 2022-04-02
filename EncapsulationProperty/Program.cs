using System;

namespace EncapsulationProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            var ogrenci = new Ogrenci();
            ogrenci.Ad = "Ahmet";
            ogrenci.Soyad = "Kaya";
            ogrenci.No = 12345;
            ogrenci.Bolum = "Bilgisayar";

            ogrenci.OgrenciBilgileri();



        }
    }

    class Ogrenci
    {
        private string _ad;
        private string _soyad;
        private int _no;
        private string _bolum;

        public string Ad { get => _ad; set => _ad = value; }
        public string Soyad { get => _soyad; set => _soyad = value; }
        public string Bolum { get => _bolum; set => _bolum = value; }
        public int No { get => _no; set => _no = value; }

        public Ogrenci()
        {
        }


        public Ogrenci(string ad, string soyad, int no, string bolum)
        {
            Ad = ad;
            Soyad = soyad;
            No = no;
            Bolum = bolum;
        }

        public void OgrenciBilgileri()
        {
            Console.WriteLine("Adı: {0}", Ad);
            Console.WriteLine("Soyadı: {0}", Soyad);
            Console.WriteLine("No: {0}", No);
            Console.WriteLine("Bölüm: {0}", Bolum);
        }


    }
}
