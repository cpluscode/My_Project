using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace burc_ogrenme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen Doğum ayınızı giriniz :");
            int ay = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen Doğum gününüzü giriniz :");
            int gun = Convert.ToInt32(Console.ReadLine());
            if (ay == 1)
                if (gun >= 1 && gun <= 31)
                    if (gun < 22)
                    {
                        Console.Write("Oğlak Burcu");
                    }
                    else
                        Console.Write("Kova Burcu");
            if (ay == 2)
                if (gun >= 1 && gun <= 28)
                    if (gun < 22)
                    {
                        Console.Write("Oğlak Burcu");
                    }
                    else
                        Console.Write("Balık Burcu");
                else
                    Console.Write("Hatalı İşlem!");
            if (ay == 3)
                if (gun >= 1 && gun <= 31)
                    if (gun < 22)
                    {
                        Console.Write("Balık Burcu");
                    }
                    else
                        Console.Write("Koç Burcu");
                else
                    Console.Write("Hatalı İşlem!");
            if (ay == 4)
                if (gun >= 1 && gun <= 30)
                    if (gun < 22)
                    {
                        Console.Write("Koç Burcu");
                    }
                    else
                        Console.Write("Boğa Burcu");
                else
                    Console.Write("Hatalı İşlem!");
            if (ay == 5)
                if (gun >= 1 && gun <= 31)
                    if (gun < 22)
                    {
                        Console.Write("Boğa Burcu");
                    }
                    else
                        Console.Write("İkizler Burcu");
                else
                    Console.Write("Hatalı İşlem!");
            if (ay == 6)
                if (gun >= 1 && gun <= 31)
                    if (gun < 23)
                    {
                        Console.Write("İkizler Burcu");
                    }
                    else
                        Console.Write("Yengeç Burcu");
                else
                    Console.Write("Hatalı İşlem!");
            if (ay == 7)
                if (gun >= 1 && gun <= 31)
                    if (gun < 23)
                    {
                        Console.Write("Yengeç Burcu");
                    }
                    else
                        Console.Write("Aslan Burcu");
                else
                    Console.Write("Hatalı İşlem!");
            if (ay == 8)
                if (gun >= 1 && gun <= 31)
                    if (gun < 23)
                    {
                        Console.Write("Aslan Burcu");
                    }
                    else
                        Console.Write("Başak Burcu");
                else
                    Console.Write("Hatalı İşlem!");
            if (ay == 9)
                if (gun >= 1 && gun <= 31)
                    if (gun < 23)
                    {
                        Console.Write("Başak Burcu");
                    }
                    else
                        Console.Write("Terazi Burcu");
                else
                    Console.Write("Hatalı İşlem!");
            if (ay == 10)
                if (gun >= 1 && gun <= 31)
                    if (gun < 23)
                    {
                        Console.Write("Terazi Burcu");
                    }
                    else
                        Console.Write("Akrep Burcu");
                else
                    Console.Write("Hatalı İşlem!");
            if (ay == 11)
                if (gun >= 1 && gun <= 31)
                    if (gun < 22)
                    {
                        Console.Write("Akrep Burcu");
                    }
                    else
                        Console.Write("Yay Burcu");
                else
                    Console.Write("Hatalı İşlem!");
            if (ay == 12)
                if (gun >= 1 && gun <= 31)
                    if (gun < 22)
                    {
                        Console.Write("Yay Burcu");
                    }
                    else
                        Console.Write("Oğlak Burcu");
                else
                    Console.Write("Hatalı İşlem!");
            else
                Console.Write("Hatalı İşlem!");
            Console.ReadKey();
        }
    }
}
