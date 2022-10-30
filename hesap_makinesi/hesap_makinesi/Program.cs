using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace hesap_makinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayı Giriniz : ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sayı Giriniz : ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1-Toplama\n2-Çıkarma\n3-Çarpma\n4-Bölme");
            double islem = Convert.ToDouble(Console.ReadLine());
            switch (islem)
            {
                case 1:
                    Console.Write("Toplama İşlemi sonucu : " + (sayi1 + sayi2));
                    break;
                case 2:
                    Console.Write("Çıkarma İşlemi sonucu : " + (sayi1 - sayi2));
                    break;
                case 3:
                    Console.Write("Çarpma İşlemi sonucu : " + (sayi1 * sayi2));
                    break;
                case 4:
                    Console.Write("Bölme İşlemi sonucu : " + (sayi1 / sayi2));
                    break;
                default:
                    Console.WriteLine("HATALI İŞLEM SEÇTİNİZ!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
