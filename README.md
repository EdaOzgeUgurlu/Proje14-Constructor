# Proje14_Constructor

## Proje Tanımı
Bu proje, bir bebek nesnesini temsil eden bir sınıf (`Bebek`) içermektedir. Sınıf, bebeğin adı, soyadı ve doğum tarihi gibi temel bilgileri tutmakta ve bebeğin ağlama sesi çıkarabilmesini sağlamaktadır.

## İçindekiler
- [Kurulum](#kurulum)
- [Kullanım](#kullanım)
- [Örnek Kullanım](#örnek-kullanım)

## Kurulum

1. **Gerekli Araçlar:**
   - Visual Studio veya başka bir C# geliştirme ortamı.
   - .NET Framework 5.0 veya üzeri.

2. **Projenin İndirilmesi:**
   ```bash
   git clone https://github.com/kullaniciadi/proje14_constructor.git
   ```

3. **Proje Klasörüne Geçin:**
   ```bash
   cd proje14_constructor
   ```

4. **Projeyi Çalıştırın:**
   Visual Studio’da projeyi açarak veya terminal üzerinden aşağıdaki komutu çalıştırarak projeyi derleyin ve çalıştırın:
   ```bash
   dotnet run
   ```

## Kullanım

`Bebek` sınıfı, bir bebek nesnesi oluşturmak ve bu nesneye ait bilgileri tutmak için kullanılabilir. Ayrıca, bebek ağlama sesi çıkarmak için bir metot da içermektedir.

### Özellikler
- `DogumTarihi`: Bebeğin doğum tarihini tutar.
- `Ad`: Bebeğin adını tutar.
- `Soyad`: Bebeğin soyadını tutar.

### Metotlar
- `BabyInfo()`: Bebeğin adını, soyadını ve doğum tarihini konsola yazdırır.
- `BebekAglaması()`: Bebeğin ağlama sesini konsola yazdırır.

## Örnek Kullanım

Aşağıda, `Bebek` sınıfının nasıl kullanılacağına dair bir örnek bulunmaktadır:

```csharp
using Proje14_Constructor; // Proje içinde tanımlı olan Bebek sınıfını kullanmak için eklenir.
using System; // Sistem kütüphanesini kullanmak için eklenir.

internal class Program
{
    private static void Main(string[] args)
    {
        // Varsayılan yapıcı ile yeni bir Bebek nesnesi oluştur
        Bebek bebek1 = new Bebek();

        // Bebek1'in adını ve soyadını ayarla
        bebek1.Ad = "Eda";
        bebek1.Soyad = "ÖZGE";

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
