using System;

namespace ForDöngüsüDersi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir Sayı giriniz.");
            int sayac = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= sayac; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i + " tektir.");
                }
                else
                {
                    Console.WriteLine(i + " çifttir.");
                }
            }

            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 0; i <= 1000; i++)
            {
                if (i % 2 == 1)
                    tekToplam = tekToplam + i;
                else
                    ciftToplam = ciftToplam + i;
            }
            Console.WriteLine("Tek sayıların toplamı : " + tekToplam + " Cift Sayıların Toplamı : " + ciftToplam);


            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    break; // continue
                }
               
                Console.WriteLine(i);
            }
        }
    }
}
