using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayilari_siralama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Bir sayı giriniz : ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(sayilar);
            foreach (int i in sayilar)
            {
                Console.WriteLine("{0}", i);
            }
            Console.Write("Sıralama Yapıldı!");
            Console.ReadKey();
        }
    }
}
