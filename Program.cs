using System;

namespace Patika
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İlk sayıyı giriniz :");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkici sayıyı giriniz :");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("2 Sayının toplamı :");
            Console.WriteLine(sonuc);

            Console.WriteLine("İsminizi giriniz.");
            string isim = Console.ReadLine();
            Console.WriteLine("SoyAd giriniz :");
            string soyAd = Console.ReadLine();
            Console.WriteLine("Ad SoyAd : " +isim + " " + soyAd);


            double dou = 1.2;
            double dou2 = 20.53;
            Console.WriteLine("1.ondalık sayı :" + dou+ " " + "ikinci ondalık sayı" +dou2 );
             


            Console.ReadKey();
        }
    }
}
