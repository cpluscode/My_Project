using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artik_yil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Yıl Giriniz : ");
            int yil = Convert.ToInt32(Console.ReadLine());
            int islem = yil % 4;
            switch (islem)
            {
                case 0:
                    Console.Write("Bu yıl artık yıldır");
                    break;
                case 1:
                    Console.Write("Bu yıl bir Artık Yıl değildir");
                    break;
                case 2:
                    Console.Write("Bu yıl bir Artık Yıl değildir.");
                    break;
                case 3:
                    Console.Write("Bu yıl bir Artık Yıl değildir.");
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
