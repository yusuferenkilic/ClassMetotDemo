using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri kullanici1 = new Musteri();
            kullanici1.Id = 1;
            kullanici1.MusteriAdi = "Yusuf Eren";
            kullanici1.MusteriYasi = 16;
            kullanici1.MusteriTelefon = 5301112233;
            kullanici1.MusteriTC = 12345678912;

            Musteri kullanici2 = new Musteri();
            kullanici2.Id = 2;
            kullanici2.MusteriAdi = "İbrahim Emre";
            kullanici2.MusteriYasi = 21;
            kullanici2.MusteriTelefon = 5410010203;
            kullanici2.MusteriTC = 19876543210;

            Musteri[] kullanicilar = new Musteri[] { kullanici1, kullanici2 };

            MusteriManager musteriManager = new MusteriManager();
            Console.WriteLine("Müşteri Ekleme : ");
            Console.WriteLine(" ");
            musteriManager.Ekle(kullanici1);
            Console.WriteLine(" ");
            musteriManager.Ekle(kullanici2);
            Console.WriteLine(" ");

            Console.WriteLine("Müşteri Silme : ");
            Console.WriteLine(" ");
            musteriManager.Sil(kullanici1);
            Console.WriteLine(" ");
            musteriManager.Sil(kullanici2);
            Console.WriteLine(" ");

            Console.WriteLine("Müşteri Listeleme : ");
            Console.WriteLine(" ");
            musteriManager.Listele(kullanici1);
            Console.WriteLine(" ");
            musteriManager.Listele(kullanici2);
            Console.WriteLine(" ");
        }
    }
}
