using System;
using System.Collections;

namespace Odev01
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

            //2 - Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin(n, m).
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

            //3 - Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
            //Sonrasında kullanıcıdan n adet kelime girmesi isteyin.Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

            //4 - Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            Soru1();

            Soru2();

            Soru3();

            Soru4();
        }
        public static void Soru1()
        {
            ArrayList sayilar = new ArrayList();

            Console.WriteLine("Kaç adet sayı vermek istediğini girin: ");
            int sayi01 = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= sayi01; i++)
            {
                int sayi02 = Convert.ToInt32(Console.ReadLine());
                sayilar.Add(sayi02);
            }
            Console.WriteLine("Girilenn çift sayılar : ");
            foreach (int sayi in sayilar)
            {
                if ((sayi % 2) == 0)
                {
                    Console.WriteLine(sayi);
                }
            }

        }

        public static void Soru2()
        {
            ArrayList sayilarN = new ArrayList();

            Console.WriteLine("2 adet pozitif sayı giriniz. (n) ve (m).");

            Console.WriteLine("(n):");
            int sayiN = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("(m):");
            int sayiM = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("(n) kadar sayı giriniz.");

            for (int i = 1; i <= sayiN; i++)
            {
                int sayi02 = Convert.ToInt32(Console.ReadLine());
                sayilarN.Add(sayi02);
            }

            Console.WriteLine("(m)'e " + sayiM + " tam bölünen sayılar:");
            foreach (int sayi in sayilarN)
            {

                if (sayi % sayiM == 0)
                {
                    Console.Write(sayi + " , ");
                }

            }

        }

        public static void Soru3()
        {
            Console.WriteLine("Kaç adet kelime girilceğini yazınız:");

            int kelimeSayisi = Convert.ToInt32(Console.ReadLine());
            string[] kelimeler = new string[kelimeSayisi];

            Console.WriteLine("Kelimeleri girin.");

            for (int i = 0; i < kelimeSayisi; i++)
            {
                kelimeler[i] = Console.ReadLine();
            }

            Array.Reverse(kelimeler);

            foreach (var kelime in kelimeler)
            {
                Console.WriteLine(kelime);
            }
        }

        public static void Soru4()
        {
            Console.WriteLine("Bir cümle giriniz: ");
            string cümle = Console.ReadLine();
            string[] kelimeler = cümle.Split(' ');
            Console.WriteLine("Girdiğiniz cümlede " + kelimeler.Length + " adet kelime ve " + (cümle.Length - kelimeler.Length + 1) + " karakter vardır.");

        }

    }
}
