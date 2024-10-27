using Proje14_Constructor; // Proje içinde tanımlı olan Bebek sınıfını kullanmak için eklenir.
using System; // Sistem kütüphanesini kullanmak için eklenir.

internal class Program
{
    private static void Main(string[] args)
    {
        // Varsayılan yapıcı ile yeni bir Bebek nesnesi oluştur
        Bebek bebek1 = new Bebek();

        // Bebek1'in adını ve soyadını ayarla
        bebek1.ad = "Eda";
        bebek1.soyad = "ÖZGE";

        // Bebek1'in bilgilerini yazdır
        bebek1.BabyInfo();

        Console.WriteLine();

        // Parametreli yapıcı ile yeni bir Bebek nesnesi oluştur
        Bebek bebek2 = new Bebek("Ali", "ATABAK");

        // Bebek2'nin bilgilerini yazdır
        bebek2.BabyInfo();


        Console.ReadKey();
    }
}

