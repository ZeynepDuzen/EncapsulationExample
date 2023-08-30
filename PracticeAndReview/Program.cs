using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndReview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            Console.WriteLine("id girin : ");
            musteri.id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adiniz : ");
            musteri.Ad = Console.ReadLine();
            Console.WriteLine("SoyAdiniz : ");
            musteri.Soyad = Console.ReadLine();
            Console.WriteLine("Yasiniz : ");
            musteri.yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mesleginiz : ");
            musteri.Meslek = Console.ReadLine();
            Console.WriteLine("Sehriniz : ");
            musteri.Sehir = Console.ReadLine();

            Console.WriteLine("***** Musteri Kimlik Karti *****");
            Console.WriteLine();
            Console.WriteLine(musteri.id + "-" + musteri.Ad + " " + musteri.Soyad + " " + musteri.yas + " " + musteri.meslek + " " + musteri.Sehir);

            Console.Read();
        }
    }
}
