using System;

namespace StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan sayısı : {0} ", Calisan.CalisanSayisi);

            Calisan isci = new Calisan("Ataberk", "Anıt", "Yazılım");

            Console.WriteLine("Çalışan sayısı : {0} ", Calisan.CalisanSayisi);

            Calisan isci1 = new Calisan("Mustafa", "Dere", "Yazılım");
            Calisan isci2= new Calisan("Ahmet", "Ürkmez", "Yazılım");
            Calisan isci3 = new Calisan("Musa", "Aslan", "Yazılım");

            Console.WriteLine("Çalışan sayısı : {0} ", Calisan.CalisanSayisi);

            Console.WriteLine("Toplama islemi sonucu : {0}", Islemler.Topla(100,200));
            Console.WriteLine("Toplama islemi sonucu : {0}", Islemler.Cikar(300, 150));
        }
    }
    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; }

        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calisan()
        {
            calisanSayisi = 0;
        }

        public Calisan(string isim, string soyisim, string departman)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi++;
        }
    }
    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;            
        }
        public static long Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}
