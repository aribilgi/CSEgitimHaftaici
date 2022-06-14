using System;

namespace Ders05KosulYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Koşul(Karar) Yapıları!");

            Console.WriteLine("Bir sayı girip enter a basınız!");
            /*
            var s = Console.ReadLine(); //var anahtar kelimesi değişken oluşturmak için kullanılır ve oluşan değişkene atanan değerin veri tipine göre değişkenin tipini otomatik belirler. Console.ReadLine() metodu ekrandaki satırdan girilen değeri okur

            int sayi = Convert.ToInt32(s);

            if (sayi > 0) // eğer sayı 0 dan büyükse
            {
                // Buradaki kodları çalıştır
                Console.WriteLine("Girilen sayı 0 dan büyük!");
            }
            else if (sayi == 0) // yukardaki şart değilse eğer sayı 0 e eşit mi
            {
                Console.WriteLine("Girilen sayı 0");
            }
            else // yukardakilerden hiçbiri değilse
            {
                Console.WriteLine("Negatif sayı girdiniz!");
            }
            */
            // Örnek 2
            Console.WriteLine("Kullanıcı Adınızı Giriniz");
            string kullaniciadi = Console.ReadLine();//Console.ReadLine() metodu ekrandan girilen değeri yakalar ve kullaniciadi değişkenine atar
            Console.WriteLine("Şifrenizi Giriniz");
            string sifre = Console.ReadLine();//Console.ReadLine() metodu ekrandan girilen değeri yakalar ve sifre değişkenine atar
            string veritabanindakiKullaniciAdi = "admin";
            string veritabanindakiSifre = "123456";

            if (kullaniciadi == veritabanindakiKullaniciAdi && sifre == veritabanindakiSifre)
            {
                Console.WriteLine("Sisteme giriş yapıldı");
            }
            else
            {
                Console.WriteLine("Kullanıcı Bulunamadı!");
            }
            Console.Read();

        }
    }
}
