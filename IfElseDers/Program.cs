using System;

namespace IfElseDers
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if (time>=6 && time<11)
            {
                Console.WriteLine("İyi günler.");
            }
            else if (time >18)
            {
                Console.WriteLine("İki Akşamlar.");
            }
            else
            {
                Console.WriteLine("İyi Geceler.");
            }
            string sonuc = time <= 19 ? "İyi Günler" : "İyi geceler.";

            sonuc = time >= 6 && time < 11 ? "Günaydın" : time <= 18 ? "İyi Günler" : "İyi geceler";
            Console.WriteLine(sonuc);
            Console.ReadKey();
        }
    }
}
