using System;

namespace okuldeneme
{
    class Program
    {
        // Erişim Şekli - Dönüş tipi - metotadı - parametre listesi
        static void Yazilim()
        {
            Console.WriteLine("Merhaba"); // Metot İçerisinde işlenen işlemler
            Console.WriteLine("002!");
            Console.WriteLine("2" + "16");
        }
        static void Main(string[] args)
        {
            Yazilim();  // Metodun çağrırma komudu
            Yazilim();
            Yazilim(); // Tekrarlama
            Yazilim();
            Yazilim();
            Yazilim();
            Console.ReadKey();
      }
   }
}