using System;

namespace HazırMetotlar_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "CSharp lesson.";
            string degisken2 = "CSharp practice.";

            //Lenght
            Console.WriteLine(degisken.Length);

            //ToUpper-ToLower 
            Console.WriteLine(degisken.ToLower());
            Console.WriteLine(degisken.ToUpper());

            //Concat
            Console.WriteLine(string.Concat(degisken, "Merhaba"));

            //Compare  CommpareTo
            Console.WriteLine(degisken.CompareTo(degisken2));
            Console.WriteLine(string.Compare(degisken, degisken2, true));

            //Contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("lesson."));
            Console.WriteLine(degisken.StartsWith("CSharp"));


            //IndexOf
            Console.WriteLine(degisken.IndexOf("less"));
            Console.WriteLine(degisken.IndexOf("Ata"));

            //Insert
            Console.WriteLine(degisken.Insert(0, "İzmir"));
            Console.WriteLine(degisken.LastIndexOf("o"));

            //Padleft - Padright

            Console.WriteLine(degisken.PadRight(35, 'y') + degisken2);
            Console.WriteLine(degisken + degisken2.PadLeft(35, 'x'));

            //Remove
            Console.WriteLine(degisken.Remove(6));
            Console.WriteLine(degisken.Remove(6,4));

            //Replace
            Console.WriteLine(degisken.Replace('o','i'));
            Console.WriteLine(degisken.Replace("CSharp" , "C#"));

            //Split
            Console.WriteLine(degisken.Split(' ')[1]);

            //Substring
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,3));
        } 

    }
}
