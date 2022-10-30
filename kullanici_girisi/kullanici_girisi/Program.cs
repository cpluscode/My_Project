using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kullanici_girisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sifre = 12345;
            Console.Write("Kullanıcı Adınız : ");
            string kullaniciadi = Convert.ToString(Console.ReadLine());
            Console.Write("Şifrenizi Giriniz :");
            int sifren= Convert.ToInt32(Console.ReadLine());
            if(sifren== sifre && kullaniciadi=="admin")
            {
                Console.WriteLine("Giriş başarılı");
            }
            else
            {
                Console.WriteLine("Hatalı şifre girdiniz!");
                Console.WriteLine("İşlemi iptal etmek istiyorsanız 0 tuşlayınız.\nŞifrenizi Sıfırlamak için Lütfen 1 Tuşlayınız.");
                int sifirla = Convert.ToInt32(Console.ReadLine());
                switch (sifirla)
                {
                    case 0:
                        Console.WriteLine("İşlem iptal edildi!");
                        break;
                    case 1:
                        sifretry:
                        Console.Write("Yeni Şifrenizi Giriiniz: ");
                        int sifretry= Convert.ToInt32(Console.ReadLine());
                        if (sifre == sifretry)
                        {
                            Console.WriteLine("Daha Önce bu şifreyi kullandınız Farklı bir şifre giriniz.");
                            goto sifretry;
                        }
                        else
                            Console.WriteLine("Şifreniz Değiştirildi!");
                        break;
                    default:
                        break;
                }
            }
            Console.ReadKey();

        }
    }
}
