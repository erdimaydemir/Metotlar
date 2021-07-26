using System;

namespace Metotlar
{
    class Program
    {
        public static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 1.5;
            urun1.Aciklama = "starking";
            urun1.StokAdedi = 15;

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 5;
            urun2.Aciklama = "Diyarbakır";
            urun2.StokAdedi = 150;
            Urun[] Urunler = new Urun[] { urun1,urun2 };

            foreach (Urun urun in Urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.StokAdedi);
                Console.WriteLine("-------------------");
            }

            Console.WriteLine("-----------metotlar----------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            

           

        }
    }
}
