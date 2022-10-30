using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etkinlik_önerme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sıcalık Değerini Giriniz : ");
            int hava = Convert.ToInt32(Console.ReadLine());
            if (hava < 5)
                Console.Write("Bu havada kayak yapabilirsiniz");
            else if (hava < 15 && hava > 5)
                Console.Write("Bu havada Sinama izleyebilirsiniz");
            else if (hava < 25 && hava > 15)
                Console.Write("Bu havada Piknik yapabilirsiniz");
            else if (hava >= 25)
                Console.Write("Bu havada Yüzme yapabilirsiniz");
            else
                Console.Write("yapıcak etkinlik yok!");
            Console.ReadKey();
        }
    }
}
