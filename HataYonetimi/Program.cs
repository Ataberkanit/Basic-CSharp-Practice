using System;

namespace HataYonetimi
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Bir Sayı Giriniz.");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girilen sayı : " + sayi);
            }
            catch (Exception ex)
            {

                throw; Console.WriteLine("Hata :" + ex.Message.ToString());
            }
            finally 
            {
                Console.WriteLine("İslem tamamlandı.");
            }

            try
            {
                int a = int.Parse(null);
            }
            catch (ArgumentNullException ex)
            {

                Console.WriteLine("Boş değer girdiniz!");
                Console.WriteLine(ex);
            }
           
        }
    }
}
