using System;

namespace TipDönüsümleri
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 5;
            short b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine("d : " + d);

            long h = d;
            Console.WriteLine("h : " + h);

            float i = h;
            Console.WriteLine("i : " + i);

            string e = "Ataberk";
            char f = 'k';
            object g = e + f + d;
            Console.WriteLine("g : " + g);

            Console.WriteLine("Dönüsümler");

            int x = 4;
            byte t = (byte)x;
            Console.WriteLine("z : " + x);

            int v = 100;
            byte y = (byte)v;
            Console.WriteLine("s : " + v);


            Console.WriteLine("TO String dönüsümü");

            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine(yy);

            string zz = 12.5f.ToString();
            Console.WriteLine(zz);

            Console.WriteLine("System.convert dönüsümü");

            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            toplam = sayi1 + sayi2;

            Console.WriteLine("toplam : " + toplam);


            Console.WriteLine("Parse Methodu");
            ParseMethod();

            Console.ReadKey();
        }
        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";

            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = double.Parse(metin2);
            Console.WriteLine("Rakam1 : " + rakam1);
            Console.WriteLine("Double1 : " + double1);
        }
      
    }
}
