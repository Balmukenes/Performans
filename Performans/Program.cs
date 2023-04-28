using System;

namespace Performans
{ 
    class Program
    {
        public static int bakiye = 1000;
        public static int tutar;
        static void girisekranı()
        {
            string kadi, ksifre, gadi,gsifre;

            b:
            Console.Write("Kayıt İçin Kullanıcı Adını Giriniz: ");
            kadi = Console.ReadLine();
            Console.Write("Kayıt İçin Kullanıcı şifresini Giriniz: ");
            ksifre = Console.ReadLine();         
            Console.Write("Kayıt Oldunuz Giriş Ekranına Aktarılıyorsunuz...");
            System.Threading.Thread.Sleep(300);
            Console.Clear();
            Console.WriteLine("Son 3.......");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Son 2.......");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Son 1.......");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.Write("Kullanıcı adını giriniz: ");
            gadi = Console.ReadLine();
            Console.Write("Kullanıcı şifresini giriniz: ");
            gsifre = Console.ReadLine();
            if (kadi == gadi && ksifre == gsifre)
            {
                Console.Write("Kullanıcı girişi başarılıdır. ");
            }
            else
            {
                Console.Write("Kullanıcı girişi başarılı değildir. ");
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
                goto b;
            }
            Console.ReadKey();
        }
        static void paraCekme()
        {           
            Console.WriteLine("Bakiyeniz = " + bakiye);
            Console.Write("Çekmek istediğiniz tutarı giriniz: ");
            int tutar = Convert.ToInt32(Console.ReadLine());
            if (tutar > bakiye)
            {
                Console.Write("Yetersiz bakiye. Tekrar giriniz: ");
                tutar = Convert.ToInt32(Console.ReadLine());
            }
            else if(tutar<0)
            {
                Console.WriteLine("Cekilecek Tutar Yanlıs");

            }
            else
            {
                bakiye -= tutar;
                Console.WriteLine("Yeni bakiyeniz = " + bakiye);
            }
            
        }
        static void paraYatırma()
        {
            Console.WriteLine("Bakiyeniz = " + bakiye);
            Console.Write("Yatırmak istediğiniz tutarı giriniz: ");
            tutar = Convert.ToInt32(Console.ReadLine());
            bakiye += tutar;
            Console.WriteLine("Yeni bakiyeniz = " + bakiye);
        }
        static void paraGönder()
        {
            Console.Write("Para Gönderilecek Kişinin Adını giriniz: ");
             string padı= Console.ReadLine();
            Console.Write("Kaç Para Göndereceksiniz: ");
            int gtutar = Convert.ToInt32(Console.ReadLine());
            if (gtutar > bakiye)
            {
                Console.Write("Yetersiz bakiye. Tekrar giriniz: ");
                gtutar = Convert.ToInt32(Console.ReadLine());
            }
            bakiye -= gtutar;
            Console.WriteLine("Yeni bakiyeniz = " + bakiye);
        }
        static void Eftislemleri()
        {
            a:
            Console.WriteLine("Hangi Bankadan Para Transferi Yapmak İstersiniz");
            Console.WriteLine("|         1.AkBank             |");
            Console.WriteLine("|        2.HalkBank            |");
            Console.WriteLine("|       3.Vakıf Banka          |");
            Console.WriteLine("|      4.Ziraat Bankası        |");
            Console.Write("Hangi Banka Seciniz:");
            int secim = Convert.ToInt32(Console.ReadLine());
            Console.Write("Yollanıcak Tutarı Giriniz:");
            int tutare = Convert.ToInt32(Console.ReadLine());
            if (secim==1)
            {
              Console.WriteLine("AkBank Seçildi");
              bakiye -= tutare;
              Console.WriteLine("Yeni bakiyeniz = " + bakiye);
            }
            else if (secim == 2)
            {
                Console.WriteLine("HalkBank Seçildi");

                bakiye -= tutare;
                Console.WriteLine("Yeni bakiyeniz = " + bakiye);
            }
            else if (secim == 3)
            {
                Console.WriteLine("Ziraat Bankası Seçildi");
                bakiye -= tutare;
                Console.WriteLine("Yeni bakiyeniz = " + bakiye);
            }
            else if (secim == 4)
            {
                Console.WriteLine("Vakıf Bankası Seçildi");
                bakiye -= tutare;
                Console.WriteLine("Yeni bakiyeniz = " + bakiye);
            }
            else 
            {
                Console.WriteLine("Yanlış Seçim Yaptınız");
                goto a;
            }
        }

        static void Main(string[] args)
        {
            girisekranı();
            while(true)
            {
                Console.Clear();
                Console.WriteLine("Para = " + bakiye);
                Console.WriteLine("\n-----BANKA-----\n");
                Console.WriteLine("1. Para Çekme");
                Console.WriteLine("2. Para Yatırma");
                Console.WriteLine("3. Para Gönder");
                Console.WriteLine("4. Eft İslemleri");

                Console.Write("\nİsleminizi Seciniz: ");
                int islem = Convert.ToInt32(Console.ReadLine());
                if (islem == 1)
                {
                    paraCekme();
                }
                else if (islem == 2)
                {
                    paraYatırma();
                }
                else if (islem == 3)
                {
                    paraGönder();
                }
                else if (islem == 4)
                {
                    Eftislemleri();
                }
                else
                {
                    Console.WriteLine("Yanlış Bir Seçim Yaptınız");
                }
                Console.ReadKey();
            }
        }
            
    }
}
