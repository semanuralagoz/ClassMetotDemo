using System;
using System.Collections;
using System.Text;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            

            Musteri musteri1 = new Musteri();

            musteri1.Id = 123;
            musteri1.Ad = "sema";
            musteri1.Soyad = "Alagoz";
            musteri1.TC = "12349876543";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 10;
            musteri2.Ad = "Seda";
            musteri2.Soyad = "Lale";
            musteri2.TC = "09876543211";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine(musteri.TC);


            }
            Console.WriteLine("---------------metotlar-------------------");
            MusteriManager musteriManager = new MusteriManager ();
           
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);

            musteriManager.Delete(musteri1);
            musteriManager.Delete(musteri2);

            musteriManager.List(musteri1);
            musteriManager.List(musteri2);


        }
        
    }
}

