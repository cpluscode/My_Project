using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dairenin_alanını_ve_cevresini_hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14;
            Console.Write("Dairenin Yarı Çapı : ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dairenin Merkez Ölçüsü : ");
            int a = Convert.ToInt32(Console.ReadLine());
            double alan = (pi * (r * r) * a) / 360;
            Console.Write("Dairenin alanı : " + alan);
            Console.ReadKey();
        }
    }
}
