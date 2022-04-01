using System;
using System.Collections;
using System.Collections.Generic;

namespace Odev2
{
    class Program
    {
        static void Main(string[] args)
        {



            //Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın.
            //  (ArrayList sınıfını kullanarak yazınız.)

            //- Negatif ve numeric olmayan girişleri engelleyin.
            //- Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            //- Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.

            Console.WriteLine("-----Soru 1-----");

            Manager manager = new Manager();

            ArrayList list = new ArrayList();
            ArrayList asal = new ArrayList();
            ArrayList asalDegil = new ArrayList();

            Console.WriteLine("20 adet pozitif sayı giriniz:");
            try
            {
                for (int i = 1; i < 21; i++)
                {
                    Console.Write("{0}.pozitif sayı :", i);
                    int number = int.Parse(Console.ReadLine());
                    if (number < 0)
                    {
                        Console.WriteLine("Lütfen pozitif bir sayı giriniz");
                        break;
                    }
                    list.Add(number);
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Lütfen pozitif bir sayı girniz");
            }
            Console.WriteLine("----------------------------------------------------------");

            foreach (int item in list)
            {
                if (item == 1)
                {
                    asalDegil.Add(item);
                }
                else if (item == 2)
                {
                    asal.Add(item);
                }
                else
                {
                    int primeNumber = 0;
                    for (int i = 2; i < item; i++)
                    {
                        if (item % i == 0)
                        {
                            primeNumber++;
                        }
                    }
                    if (primeNumber == 0)
                    {
                        asal.Add(item);
                    }
                    else
                    {
                        asalDegil.Add(item);
                    }
                }
            }
            Console.WriteLine("Asal olan sayıların büyükten küçüğe sıralanışı :");
            manager.PrimeProperties(asal);
            Console.WriteLine("Asal olanların eleman sayısı : " + asal.Count);
            manager.Average(asal);
            Console.WriteLine("Asal olmayanların büyükten küçüğe sıralanışı :");
            manager.PrimeProperties(asalDegil);
            Console.WriteLine("Asal olmayanların eleman  sayısı : " + asalDegil.Count);
            manager.Average(asalDegil);


            //Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
            //her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız.

            Console.WriteLine("-----Soru 2-----");


            Console.WriteLine("20 adet sayı giriniz:");

            int[] sayiGrubu = new int[20];

            for (int i = 0; i < 20; i++)
            {
                Console.Write("{0}. sayı :", i + 1);
                sayiGrubu[i] = int.Parse(Console.ReadLine());
            }

            foreach (var item in sayiGrubu)
            {
                Console.WriteLine(item);
            }

            int[] maxSayilar = new int[3];
            int[] minSayilar = new int[3];

            Array.Sort(sayiGrubu);

            minSayilar[0] = sayiGrubu[0];
            minSayilar[1] = sayiGrubu[1];
            minSayilar[2] = sayiGrubu[2];

            maxSayilar[2] = sayiGrubu[19];
            maxSayilar[1] = sayiGrubu[18];
            maxSayilar[0] = sayiGrubu[17];

            Console.WriteLine("Girilen en büyük 3 sayi : ");
            double maxAvg = 0;
            foreach (var item in maxSayilar)
            {
                Console.WriteLine(item);
                maxAvg += item;
            }
            Console.WriteLine("Girilen en küçük 3 sayi : ");
            double minAvg = 0;
            foreach (var item in minSayilar)
            {
                Console.WriteLine(item);
                minAvg += item;
            }
            Console.WriteLine("Girilen en büyük üç sayının toplamı : " + maxAvg);
            Console.WriteLine("Girilen en büyük üç sayının ortalaması : " + maxAvg / 3);
            Console.WriteLine("Girilen en küçük üç sayının toplamı : " + minAvg);
            Console.WriteLine("Girilen en küçük üç sayının ortalaması : " + minAvg / 3);

            //Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.

            Console.WriteLine("-----Soru 3-----");

            List<char> sesliList = new List<char>();
            string sesliChar = "aeıioöuü";

            Console.WriteLine("Metin giriniz.");
            string metin = Console.ReadLine().ToLower();

            for (int i = 0; i < metin.Length; i++)
            {
                if (sesliChar.Contains(metin[i]))
                {
                    sesliList.Add(metin[i]);
                }
            }
            Console.WriteLine("Girilen metindeki sesli harfler: ");
            if (sesliList.Count > 0)
            {
                foreach (var item in sesliList)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.Write("Girilen Cümlede Sesli Harf Bulunmamaktadır.");
            }
        }

    }


    public class Manager
    {
        public ArrayList PrimeProperties(ArrayList arr)
        {
            arr.Sort();
            arr.Reverse();
            foreach (var item in arr)
            {
                Console.WriteLine(item + " ");
            }
            return arr;
        }
        public ArrayList Average(ArrayList arr)
        {
            int total = 0;
            foreach (int item in arr)
            {
                total += item;
            }
            decimal avg = total / arr.Count;
            Console.WriteLine("Ortalama:" + avg);
            return arr;
        }











        //Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)

        //Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.



    }
}

