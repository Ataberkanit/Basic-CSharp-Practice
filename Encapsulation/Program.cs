using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {

            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Ad = "Ataberk";
            ogrenci1.Soyad = "Anıt";
            ogrenci1.OgrenciNo = 123456;
            ogrenci1.Sinif = 5;

            ogrenci1.OgrenciBilgileriGetir();

            ogrenci1.sinifAtlat();
            ogrenci1.OgrenciBilgileriGetir();

            Ogrenci ogrenci2 = new Ogrenci("Deniz", "Güntekin", 234567, 1);
            ogrenci2.sinifDüsür();
            ogrenci2.sinifDüsür();
            ogrenci2.OgrenciBilgileriGetir();
        }
    }
    class Ogrenci
    {

        private string ad;

        private string soyad;

        private int ogrenciNo;

        private int sinif;

        public string Ad 
        {
            get => ad; 
            set => ad = value; 
        }
        public string Soyad 
        { 
            get => soyad; 
            set => soyad = value; 
        }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif
        {
            get => sinif;
            set 
            {
                if (value < 1)
                {
                    Console.WriteLine("Sınıf en az 1 olabilir.");
                    sinif = 1;
                }
                else
                sinif = value;

            }
        }

        public Ogrenci(string ad, string soyad, int ogrenciNo, int sinif)
        {
            Ad = ad;
            Soyad = soyad;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogrenci() { }

        public void OgrenciBilgileriGetir()
        {
            Console.WriteLine("*****Öğrenci Bilgileri*****");
            Console.WriteLine("Öğrenci adı        : {0}", this.Ad);
            Console.WriteLine("Öğrenci Soyad      : {0}", this.Soyad);
            Console.WriteLine("Öğrenci Öğrenci No : {0}", this.OgrenciNo);
            Console.WriteLine("Öğrenci Sinif      : {0}", this.Sinif);
        }
        public void sinifAtlat()
        {
            this.Sinif = this.Sinif + 1;
        }
        public void sinifDüsür()
        {
            this.Sinif = this.Sinif - 1;
        }
    }
}
