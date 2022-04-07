using System;

namespace Sınıf_Kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            calisan calisan1 = new calisan();
            calisan1.Ad = "Ayşe";
            calisan1.Soyad = "Kara";
            calisan1.No = 123456;
            calisan1.Departman = "İnsan Kaynakları";

            calisan1.CalisanBilgileri();

            calisan calisan2 = new calisan();
            calisan2.Ad = "Ataberk";
            calisan2.Soyad = "Anıt";
            calisan2.No = 234567;
            calisan2.Departman = "Yazılım";

            calisan2.CalisanBilgileri();
        }
    }

    class calisan
    {
        public string Ad { get; set; }

        public string Soyad { get; set; }

        public int No { get; set; }

        public string Departman { get; set; }

        public void CalisanBilgileri()
        {
            Console.WriteLine("Calisan Adı:{0}", Ad);

            Console.WriteLine("Calisan Soyadı:{0}", Soyad);

            Console.WriteLine("Calisan Nosu:{0}", No);

            Console.WriteLine("Calisan Departmanı:{0}", Departman);
        }
    }
}
