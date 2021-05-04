using System;

namespace ClassMetodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.AdSoyad = "melike şahin";
            musteri1.Tc = "50782644602";
            musteri1.Id = 123;

            Musteri musteri2 = new Musteri();
            musteri2.AdSoyad = "ebru merd";
            musteri2.Tc = "12242506080";
            musteri2.Id = 456;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriListele(musteri1, musteri2);
            musteriManager.MusteriSil(musteri1);

         
        }
    }
}
