using System;

namespace Methods2_Recursive_Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recursive

            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result = result * 3;
            }
            Console.WriteLine(result);

            Islemler instance = new Islemler();
            Console.WriteLine(instance.Expo(3, 4));

            //Extension
            string ifade = "Ataberk Anıt";
            bool sonuc = ifade.CheckSpace();
            Console.WriteLine(ifade.CheckSpace());
            Console.WriteLine(sonuc);
            if (sonuc)            
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());

            int[] dizi = { 4, 3, 4, 5, 1 };
            dizi.SortArray();
            dizi.EkranaYazdir();

            int sayi = 5;
            sayi.IsEvenNumber();
            Console.WriteLine(sayi.IsEvenNumber());

            Console.WriteLine(ifade.GetFirstChar());
        }
    }
    public class Islemler
    {
        public int Expo(int sayi, int us)
        {
            if (us < 2)
                return sayi;
            return Expo(sayi, us - 1) * sayi;
        }
    }

    public static class Extension
    {
        public static bool CheckSpace(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("*", dizi);
        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }
        public static void EkranaYazdir(this int[] param)
        {
            foreach (var item in param)
            {
                Console.WriteLine(item);
            }
        }

        public static bool IsEvenNumber(this int param)
        {
            return param % 2 == 0;
        }

        public static string GetFirstChar(this string param)
        {
            return param.Substring(0, 1);
        }
    }
     
}
