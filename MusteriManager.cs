using System;
using System.Collections;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine( "Hoşgeldiniz:"+musteri.Ad+ musteri.Soyad );

        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + musteri.Soyad  + ""+ "Sistemden çıkarıldı"  );

        }

        public void List (params Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Ad Soyad:" + musteri.Ad + "" + musteri.Soyad + "\n" + "Id:" + musteri.Id + "\n" + "TC:" + musteri.TC);
            }
        }



    }
}

