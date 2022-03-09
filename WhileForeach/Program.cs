using System;

namespace WhileForeachDersi
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 den başlayarak consoledan girilen sayı kadar ortalama esaplayıp yazdıran program.
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac<= sayi1)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam / sayi1);

            // a dan z ye kadar olan sayıları yazdır.
            char ch = 'a';
            while (ch <= 'z')
            {
                Console.WriteLine(ch);
                ch++;
            }

            Console.WriteLine("Foreach Örneği :");

            string[] arabalar = { "BMW", "FORD", "TOYOTA", "RENAULT" };
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
