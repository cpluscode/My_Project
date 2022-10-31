using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tek_sayida_çift_4katları_toplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi,toplam = 0;
            do 
            {
                Console.Write("Sayı giriniz : ");
                sayi = Convert.ToInt32(Console.ReadLine());
                if ((sayi % 2) == 0)
                {
                    toplam += sayi;
                }
            } 
            while (sayi>0);
            Console.Write("Çift Sayıların toplam değeri : "+toplam);
            Console.ReadKey();
        }
    }
}
