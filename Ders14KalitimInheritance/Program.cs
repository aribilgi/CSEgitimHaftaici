﻿namespace Ders14KalitimInheritance
{
    class Arac // Base class (Ata sınıf)
    {
        public string AracTuru;
        public void AracKornasi()
        {
            Console.WriteLine("Dooooooot!");
        }
    }
    class Otomobil : Arac  // Child Class
    {
        public string Marka { get; set; }
        public string Model { get; set; }
    }
    class Motosiklet : Arac // Motosiklet araç sınıfının bir alt türüdür
    {
        public string Marka { get; set; }
        public string Model { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kalıtım(Miras Alma) - Inheritance!");
            Otomobil otomobil = new();
            otomobil.AracTuru = "Karayolu Taşıtı";
            otomobil.Marka = "Tofaşk";
            otomobil.Model = "Doğan SLX";
            otomobil.AracKornasi();

        }
    }
}