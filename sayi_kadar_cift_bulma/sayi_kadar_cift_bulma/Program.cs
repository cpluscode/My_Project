using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayi_kadar_cift_bulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0 , toplam=0;
            Console.Write("Sayı Giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= sayi; i++)
            {
                if ((i % 4) == 0 && (i % 3) == 0)
                {
                    toplam += i;
                    sayac++;
                }
            }
            int ortalama = toplam/sayac;
            Console.Write("Toplam Sayı : "+toplam);
            Console.Write("Ortalama Sayı : "+ortalama);
            Console.ReadKey();
        }
    }

}