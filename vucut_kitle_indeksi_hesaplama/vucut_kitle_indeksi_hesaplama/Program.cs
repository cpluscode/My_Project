using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vucut_kitle_indeksi_hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen Boyunuzu (Metre Cinsinden) giriniz : ");
            double boy=Convert.ToDouble(Console.ReadLine());
            Console.Write("Lütfen kilonuzu giriniz : ");
            int kilo = Convert.ToInt32(Console.ReadLine());
            double indeks = kilo / (boy * boy);
            Console.Write("Vücut Kitle indeksiniz : "+indeks);
            Console.ReadKey();
        }
    }
}
