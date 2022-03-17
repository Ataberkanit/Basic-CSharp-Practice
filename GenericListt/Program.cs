using System;
using System.Collections.Generic;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayiListeli = new List<int>();

            sayiListeli.Add(2);
            sayiListeli.Add(5);
            sayiListeli.Add(4);
            sayiListeli.Add(7);
            sayiListeli.Add(10);
            sayiListeli.Add(12);

            List<string> metinlistesi = new List<string>();
            metinlistesi.Add("Sarı");
            metinlistesi.Add("Lacivert");
            metinlistesi.Add("Yeşil");
            metinlistesi.Add("Kırmızı");
            metinlistesi.Add("Bordo");

            //Count
            Console.WriteLine(sayiListeli.Count);
            Console.WriteLine(metinlistesi.Count);

            foreach (var sayi in sayiListeli)
            {
                Console.WriteLine(sayi);
            }
            foreach (var renk in metinlistesi)
            {
                Console.WriteLine(renk);
            }
            sayiListeli.ForEach(sayi => Console.WriteLine(sayi));
            metinlistesi.ForEach(metin => Console.WriteLine(metin));


            Console.WriteLine("  ");
            //Listeden eleman çıkarma.
            sayiListeli.Remove(2);
            metinlistesi.Remove("Kırmızı");
            sayiListeli.ForEach(sayi => Console.WriteLine(sayi));
            metinlistesi.ForEach(metin => Console.WriteLine(metin));

            sayiListeli.RemoveAt(0);
            metinlistesi.RemoveAt(1);
            sayiListeli.ForEach(sayi => Console.WriteLine(sayi));
            metinlistesi.ForEach(metin => Console.WriteLine(metin));

            //List içi arama
            if (sayiListeli.Contains(10))
            {
                Console.WriteLine("10 Liste içerisinde bulundu!!");
            }
            //Eleman ile indexe erişme.
            //Console.WriteLine((metinlistesi.BinarySearch("Sarı"))); 

            //Diziyi List'e çevirme.

            string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };
            List<string> hayvanListesi = new List<string>(hayvanlar);

            //Listeyi nasıl temizleriz.
            hayvanListesi.Clear();

            //List içerisinde nesne tutmak.

            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();
            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Isim = "Ataberk";
            kullanıcı1.Soyisim = "Anıt";
            kullanıcı1.Yas = 24;

            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.Isim = "Gökberk";
            kullanıcı2.Soyisim = "Anıt";
            kullanıcı2.Yas = 18;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar()
            {
                Isim = "Ahmet",
                Soyisim = "Anıt",
                Yas = 50
            });

            foreach (Kullanıcılar kullanıcı in kullanıcıListesi)
            {
                Console.WriteLine("Kullanıcı adı : " + kullanıcı.Isim);
                Console.WriteLine("Kullanıcı soyadı : " + kullanıcı.Soyisim);
                Console.WriteLine("Kullanıcı yası : " + kullanıcı.Yas);
            }

            kullanıcıListesi.Clear();
        }
    }
    public class Kullanıcılar
    {
        private string isim;

        private string soyisim;

        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
