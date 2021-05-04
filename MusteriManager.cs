using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetodDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri a)
        {
            Console.WriteLine("eklenen müşterinin ismi ve soyismi:" + a.AdSoyad);
            Console.WriteLine("eklenen müşterinin tc si:" + a.Tc);
            Console.WriteLine("eklenen müşterinin Id si:" + a.Id);
            Console.WriteLine("müşteri başarıyla eklendi...");
            Console.WriteLine();
        }

        public void MusteriListele(params Musteri[] musteriler)
        {
            Console.WriteLine("müşteri listesi.....");
            Console.WriteLine("------------------------------------------------------------");
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.AdSoyad);
                Console.WriteLine(musteri.Tc);
                Console.WriteLine(musteri.Id);
                Console.WriteLine("*******************");
            }
            Console.WriteLine();
        }

        public void MusteriSil(Musteri a)
        {
            Console.WriteLine("silinen müşterinin ismi ve soyismi:" + a.AdSoyad);
            Console.WriteLine("silinen müşterinin tc si:" + a.Tc);
            Console.WriteLine("silinen müşterinin Id si:" + a.Id);
            Console.WriteLine("müşteri silindi...");
            Console.WriteLine();
        }
    }
}
