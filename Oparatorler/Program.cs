using System;

namespace PatikaOperatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 8;
            y = y + 2;
            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);


            bool isSuccess = true;
            bool isComplated = false;

            if (isSuccess && isComplated)
            {
                Console.WriteLine("Perfect");
            }

            if (isSuccess || isComplated)
            {
                Console.WriteLine("Great");
            }
            if (isSuccess && !isComplated)
            {
                Console.WriteLine("Fine");
            }

            Console.WriteLine("İlişkisel Operatörler");
            int a = 3;
            int b = 5;
            bool sonuc = a < b;
            Console.WriteLine(sonuc);
            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a >= b;
            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);

            Console.WriteLine("Aritmetik Operatörler");
            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 - sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1++;
            Console.WriteLine(sonuc1);
            int sonuc2 = 20 % 3;
            Console.WriteLine(sonuc2);

            Console.ReadKey();
        }
    }
}
