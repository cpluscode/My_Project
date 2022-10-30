using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sifini_gecme_durumi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Matematik Ders Notunuz : ");
            double matematik = Convert.ToDouble(Console.ReadLine());
            Console.Write("Fizik Ders Notunuz : ");
            double fizik = Convert.ToDouble(Console.ReadLine());
            Console.Write("Türkçe Ders Notunuz : ");
            double turkce = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kimya Ders Notunuz : ");
            double kimya = Convert.ToDouble(Console.ReadLine());
            Console.Write("Müzik Ders Notunuz : ");
            double müzik = Convert.ToDouble(Console.ReadLine());
            if ((matematik < 101 && fizik < 101 && turkce < 101 && kimya < 101 && müzik < 101) && (matematik >= 0 && fizik >= 0 && turkce >= 0 && kimya >= 0 && müzik >= 0))
            {
                double ortalama = (matematik + fizik + turkce + kimya + müzik) / 5;
                Console.Write("Ortalamanız : " + ortalama+" ");
                if (ortalama > 55)
                {
                    Console.Write("Sınıfı Geçtiniz !");
                }
                else
                    Console.Write("Sınıfta Kaldınız!");
            }
            else
                Console.Write("Hatalı işlem yapıldı!");
            Console.ReadKey();
        }
    }
}
