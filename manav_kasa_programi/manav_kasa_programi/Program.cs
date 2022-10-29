using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manav_kasa_programi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double armut = 2.14 , elma = 3.67 , domates = 1.11 , muz = 0.95 , patlıcan = 5.00;
            Console.Write("Armut Kaç Kilo : ");
            double value_armut = Convert.ToDouble(Console.ReadLine());
            Console.Write("elma Kaç Kilo : ");
            double value_elma = Convert.ToDouble(Console.ReadLine());
            Console.Write("Domates Kaç Kilo : ");
            double value_domates = Convert.ToDouble(Console.ReadLine());
            Console.Write("Muz Kaç Kilo : ");
            double value_muz = Convert.ToDouble(Console.ReadLine());
            Console.Write("patlıcan Kaç Kilo : ");
            double value_patlıcan = Convert.ToDouble(Console.ReadLine());
            double toplam = (armut * value_armut) + (elma * value_elma) + (domates * value_domates) + (muz * value_muz) + (patlıcan * value_patlıcan);
            Console.Write("Toplam Kasa Değeri : "+toplam);
            Console.ReadKey();
        }
    }
}
