using System;

namespace CSharp_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.pazar);
            Console.WriteLine((int)Gunler.cumartesi);

            int sicaklik = 32;

            if (sicaklik <= (int)havaDurumu.Normal)
            {
                Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekle.");
            }
            else if (sicaklik >=(int)havaDurumu.Sicak)
            {
                Console.WriteLine("Dışarıya çıkmak için çok sıcak birgün.");
            }
            else if (sicaklik >= (int)havaDurumu.Normal && sicaklik < (int)havaDurumu.CokSicak)
            {
                Console.WriteLine("Dışarıya çıkmak için güzel bir gün.");
            }
        }
    }
    enum Gunler
    {
        pazartesi = 1,
        sali,
        carsamba,
        persembe,
        cuma,
        cumartesi,
        pazar
    }
    enum havaDurumu
    {
        Soguk = 5,
        Normal = 15,
        Sicak = 25,
        CokSicak = 35

    }
}
