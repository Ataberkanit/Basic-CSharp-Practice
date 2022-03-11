using System;

namespace Methods2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sayi = "999";
            
            bool sonuc = int.TryParse(sayi, out int outSayi);
            if (sonuc)
            {
                Console.WriteLine("Çevirme Başarılı.");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Çevirme Başarısız.");
            }

            Metotlar instance = new Metotlar();
            instance.Topla(3, 5, out int toplamSonuc);
            Console.WriteLine(toplamSonuc);

            int ifade = 911;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("Ataberk" , "Anıt");
        }
    }
    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1+veri2);
        }
    }
        
}
