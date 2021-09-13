using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteriler)
        {
            Console.WriteLine("Müşteri Ekleme İşlemi Başarılı Bir Şekilde Gerçekleştirildi!");
            Console.WriteLine("Müşteri Adı : " + musteriler.MusteriAdi);
            Console.WriteLine("Müşteri Yaşı : " + musteriler.MusteriYasi);
            Console.WriteLine("Müşteri Telefonu : " + musteriler.MusteriTelefon);
            Console.WriteLine("Müşteri Kimliği : " + musteriler.MusteriTC);
        }

        public void Sil(Musteri musteriler)
        {
            Console.WriteLine("Müşteri Silme İşlemi Başarılı Bir Şekilde Gerçekleştirildi!");
            Console.WriteLine("Silinen Müşteri Hesap No'su : " + musteriler.Id);
            Console.WriteLine("Silinen Müşteri Hesap Adı : " + musteriler.MusteriAdi);
        }
        public void Listele(Musteri musteriler)
        {
            Console.WriteLine(musteriler.Id + ", " + musteriler.MusteriAdi + ", " + musteriler.MusteriYasi);
        }
    }
}
