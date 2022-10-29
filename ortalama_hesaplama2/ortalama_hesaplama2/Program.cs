using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ortalama_hesaplama2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Matematik Sınav Puanı : ");
            int Matematik = Convert.ToInt32(Console.ReadLine());
            Console.Write("Fizik Sınav Puanı : ");
            int Fizik = Convert.ToInt32(Console.ReadLine());
            Console.Write("Türkçe Sınav Puanı : ");
            int Turkce = Convert.ToInt32(Console.ReadLine());
            Console.Write("Tarih Sınav Puanı : ");
            int Muzik = Convert.ToInt32(Console.ReadLine());
            Console.Write("Müzik Sınav Puanı : ");
            int Tarih = Convert.ToInt32(Console.ReadLine());
            int ortalama = (Matematik + Fizik + Turkce + Muzik + Tarih) / 5;
            Console.WriteLine("Not Ortalaması : "+ortalama);
            if (ortalama >= 60)
                Console.Write("Geçtin!");
            else
                Console.Write("Kaldın!");
            Console.ReadKey();

        }
    }
}
