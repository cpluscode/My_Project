using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dik_ucgen_hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Üçgenin A Kenar Uzunluğunu Giriniz : ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Üçgenin B Kenar Uzunluğunu Giriniz : ");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.Write("Üçgenin C Kenar Uzunluğunu Giriniz : ");
            int C = Convert.ToInt32(Console.ReadLine());
            int d = (A + B + C) / 2;
            double alan = Math.Sqrt(d * (d - A) * (d - B)*(d - C));
            Console.Write("Üçgenin Alanı : " + alan);
            Console.ReadKey();
        }
    }
}
