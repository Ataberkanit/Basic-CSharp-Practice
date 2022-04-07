using System;

namespace KurucuMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan 1");
            calisan calisan1 = new calisan("Ayşe","Kara",123456,"İnsan Kaynakları");    
            calisan1.CalisanBilgileri();

            Console.WriteLine("Çalışan 2");
            calisan calisan2 = new calisan();
            calisan2.Ad = "Ataberk";
            calisan2.Soyad = "Anıt";
            calisan2.No = 234567;
            calisan2.Departman = "Yazılım";

            calisan2.CalisanBilgileri();

            calisan calisan3 = new calisan("Ürkmez", "Çetin");
            calisan3.CalisanBilgileri();


        }
    }
    class calisan
    {
        public string Ad { get; set; }

        public string Soyad { get; set; }

        public int No { get; set; }

        public string Departman { get; set; }

        public calisan (string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }
        public calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;      
        }
        public calisan() { }

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı: {0}", Ad);

            Console.WriteLine("Çalışan Soyadı: {0}", Soyad);

            Console.WriteLine("Çalışan Nosu: {0}", No);

            Console.WriteLine("Çalışan Departmanı: {0}", Departman);
        }
    }
}
