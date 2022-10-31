using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cin_zodyagi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Doğum Yılınızı Giriniz : ");
            int dyil=Convert.ToInt32(Console.ReadLine());
            float zodyak = dyil % 12;
            if (zodyak == 0)
                Console.Write("Maymun");
            else if (zodyak == 1)
                Console.Write("Horoz");
            else if (zodyak == 2)
                Console.Write("Köpek");
            else if (zodyak == 3)
                Console.Write("Domuz");
            else if (zodyak == 4)
                Console.Write("Fare");
            else if (zodyak == 5)
                Console.Write("Öküz");
            else if (zodyak == 6)
                Console.Write("Kaplan");
            else if (zodyak == 7)
                Console.Write("Tavşan");
            else if (zodyak == 8)
                Console.Write("Ejderha");
            else if (zodyak == 9)
                Console.Write("Yılan");
            else if (zodyak == 10)
                Console.Write("At");
            else if (zodyak == 11)
                Console.Write("Koyun");
            else
                Console.Write("Hatalı Kodlaama");
            Console.ReadKey();
        }
    }
}
