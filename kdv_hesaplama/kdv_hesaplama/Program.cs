using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kdv_hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {         
            Console.Write("Hesaplanıcak tutar : ");
            float sayi1 = Convert.ToSingle(Console.ReadLine());
            if(sayi1 > 1000)
            {
                sayi1 = (sayi1) + sayi1 * 8 / 100;
                Console.WriteLine("KDV Tutarı : "+sayi1);
            }
            else
            {
                sayi1 = (sayi1) + sayi1 * 18 / 100;
                Console.WriteLine("KDV Tutarı : " + sayi1);
            }
            Console.ReadKey();

        }
    }
}
