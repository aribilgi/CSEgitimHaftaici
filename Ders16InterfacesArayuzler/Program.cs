namespace Ders16InterfacesArayuzler
{
    interface OrnekArayuz // Örnek interface
    {
        public int Id { get; set; } // interface içindeki prop
    }

    interface IDemo // interface isimleri I ile başlamalıdır
    {
        void Goster(); // Interface içerisinde örnek bir metot imzası
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interfaces - Arayüzler!");
            // C# dilinde arayüz soyut bir veri tipidir. Sınıfa benzer şekilde bildirilir ancak içerdiği öğelerin tanımı değil yalnızca imzaları vardır.

        }
    }
}