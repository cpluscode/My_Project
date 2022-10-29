using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taksimetre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double taksimetre = 2.20 , acilis = 10;
            Console.WriteLine("Taksi Metre Açılış Tutarı : "+acilis);
            Console.Write("Kaç km yol gidilecek : ");
            int yol = Convert.ToInt32(Console.ReadLine());
            taksimetre = taksimetre * yol + acilis;
            if (taksimetre >= 20)
            {
                Console.WriteLine("Toplam km : "+ yol + "\nToplam Tutar : " + taksimetre);
            }
            else
                Console.WriteLine("Borcunuz : 20TL");
            Console.ReadKey();
        }
    }
}
