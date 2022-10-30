using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucak_bileti_hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gidilicek KM :");
            int km=Convert.ToInt32(Console.ReadLine());
            Console.Write("Yaşınız :");
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yolculuk Tipinizi Belirtiniz:\nTek Yön ( 1 )\nGidiş - Dönüş ( 2 )");
            int yolculuk_tip = Convert.ToInt32(Console.ReadLine());
            if ((yolculuk_tip == 1 || yolculuk_tip == 2) && (km > 0 && yas > 0))
            {
                double normal_fiyat = km * 0.10;
                Console.WriteLine("Ödenicek Normal Tutar : " + normal_fiyat + "TL");
                if (yas < 12)
                {

                    Console.WriteLine("12 Yaşından küçük olduğunuz için %50 indirimli Fiyat : " + normal_fiyat*50/100+"TL");
                    if(yolculuk_tip == 2)
                    {
                        Console.WriteLine("%20 Dönüşlü Bilet alma indirimi uygulandı :"+normal_fiyat* 80 / 100 + "TL");
                    }
                    else
                        Console.WriteLine("Toplam Ödenecek Miktar : " + normal_fiyat * 50 / 100 + "TL");
                }
                else if (yas < 24 && yas>12)
                {

                    Console.WriteLine("12-24 Yaşından aralığında olduğunuz için %10 indirimli Fiyat : " + normal_fiyat * 90 / 100 + "TL");
                    if (yolculuk_tip == 2)
                    {
                        Console.WriteLine("%20 Dönüşlü Bilet alma indirimi uygulandı :" + normal_fiyat * 80 / 100 + "TL");
                    }
                    else
                        Console.WriteLine("Toplam Ödenecek Miktar : " + normal_fiyat * 90 / 100 + "TL");
                }
                else if (yas >65)
                {

                    Console.WriteLine("65 Yaşından Büyük olduğunuz için %30 indirim uygulanıcaktır : " + normal_fiyat * 70 / 100 + "TL");
                    if (yolculuk_tip == 2)
                    {
                        Console.WriteLine("%20 Dönüşlü Bilet alma indirimi uygulandı :" + normal_fiyat * 80 / 100 + "TL");
                    }
                    else
                        Console.WriteLine("Toplam Ödenecek Miktar : " + normal_fiyat * 70 / 100 + "TL");
                }
                else
                    Console.Write("Hatalı İşlem!");
            }
            else
                Console.Write("Hatalı İşlem!");
            Console.ReadKey();
                
        }
    }
}
