using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje14_Constructor
{
    internal class Bebek
    {
        // Üye değişkenleri
        public DateTime dogumtarihi;  // Bebeğin doğum tarihi
        public string ad;             // Bebeğin adı
        public string soyad;          // Bebeğin soyadı


        // DogumTarihi özelliği
        public DateTime DogumTarihi
        {
            get
            {
                return dogumtarihi;
            }
            set
            {
                dogumtarihi = value;
            }
        }

        // Ad özelliği
        public string Ad
        {
            get
            {
                return ad;
            }
            set
            {
                ad = value;
            }
        }

        // Soyad özelliği
        public string Soyad
        {
            get
            {
                return soyad;
            }
            set
            {
                soyad = value;
            }
        }


        // Varsayılan yapıcı (constructor)
        public Bebek()
        {
            dogumtarihi = DateTime.Now;  // Doğum tarihini mevcut zaman olarak ayarla
            BebekAglaması();             // Bebek ağlama sesini çıkar
        }

        // Parametreli yapıcı (constructor)
        public Bebek(string ad, string soyad)
        {
            // Sınıfın üye değişkeni 'ad' ile parametre 'ad' arasındaki karışıklığı önler.
            this.ad = ad;                // Bebeğin adını ayarla
            this.soyad = soyad;          // Bebeğin soyadını ayarla
            dogumtarihi = DateTime.Now;  // Doğum tarihini mevcut zaman olarak ayarla
            BebekAglaması();             // Bebek ağlama sesini çıkar

        }

        // Bebeğin bilgilerini yazdıran metot
        public void BabyInfo()
        {
            Console.WriteLine($"Adı: {ad}, \nSoyadı: {soyad}, \nDoğum Zamanı: {dogumtarihi}");
        }

        // Bebek ağlama sesi çıkaran metot
        public void BebekAglaması()
        {
            Console.WriteLine("Ingaaaa Ingaaaaaaaaaa!!!");// Ağlama sesini yazdır
        }

    }
}



