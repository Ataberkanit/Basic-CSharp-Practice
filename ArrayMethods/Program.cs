using System;

namespace ArrayMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //SORT

            int[] sayiDizisi = { 12, 15, 9, 15, 83, 8, 1 , 30 };

            Console.WriteLine("*****Sırasız Dizi.*****");
            foreach (var sayilar in sayiDizisi)
                Console.WriteLine(sayilar);
            Console.WriteLine("*****Sıralı Dizi*****");
            Array.Sort(sayiDizisi);
            foreach (var sayilar in sayiDizisi)
                Console.WriteLine(sayilar);

            Console.WriteLine("***** Array Clear *****");
            Array.Clear(sayiDizisi, 2, 2);
            foreach (var sayilar in sayiDizisi)
                Console.WriteLine(sayilar);


            Console.WriteLine("***** Array Reverse *****");
            Array.Reverse(sayiDizisi);
            foreach (var sayilar in sayiDizisi)
                Console.WriteLine(sayilar);

            Console.WriteLine("***** Array IndexOf *****");

            Console.WriteLine(Array.IndexOf(sayiDizisi,83));

            Console.WriteLine("***** Array Resize *****");
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 99;
            foreach (var sayilar in sayiDizisi)
            {
                Console.WriteLine(sayilar);
            }
        }
    }
}
