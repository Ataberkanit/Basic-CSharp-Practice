using System;

namespace HazırMetotlar_DateTime_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine("");
            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);
            Console.WriteLine("");
            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine("");

            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());
            Console.WriteLine("");

            Console.WriteLine(DateTime.Now.AddYears(15));
            Console.WriteLine(DateTime.Now.AddDays(5));
            Console.WriteLine(DateTime.Now.AddHours(5));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddMinutes(34));

            // DateTime Format

            Console.WriteLine(DateTime.Now.ToString("dd"));
            Console.WriteLine(DateTime.Now.ToString("ddd"));
            Console.WriteLine(DateTime.Now.ToString("dddd"));

            Console.WriteLine(DateTime.Now.ToString("MM"));
            Console.WriteLine(DateTime.Now.ToString("MMM"));
            Console.WriteLine(DateTime.Now.ToString("MMMM"));

            Console.WriteLine(DateTime.Now.ToString("yy"));
            Console.WriteLine(DateTime.Now.ToString("yyy"));

            //MATH Kütüphanesi
            Console.WriteLine("Math Kütüphanesi");
            Console.WriteLine(Math.Abs(-55));
            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(30));
            Console.WriteLine(Math.Tan(35));

            Console.WriteLine("");
            Console.WriteLine(Math.Ceiling(10.55));
            Console.WriteLine(Math.Round(50.15));
            Console.WriteLine(Math.Floor(30.65));

            Console.WriteLine(Math.Max(10,20));
            Console.WriteLine(Math.Min(10,20));

            Console.WriteLine(Math.Pow(3,4)); //3^4
            Console.WriteLine(Math.Sqrt(9)); //karakök
            Console.WriteLine(Math.Log(9)); //logaritma
            Console.WriteLine(Math.Exp(3)); //e^3
            Console.WriteLine(Math.Log10(10)); 

        }
    }
}
