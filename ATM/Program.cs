namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int bakiye = 1000;
            
            Console.WriteLine("ATM'ye Hoşgeldiniz");
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz");
            string secim = Console.ReadLine();


            if (secim == "1")
            {
                Console.WriteLine("Şuanki Bakiyeniz :"+bakiye);
                Console.ReadLine();
                return;
            }

            else if (secim == "2")
            {
                Console.WriteLine("Çekmek istediğiniz tutarı giriniz");
                int çekilecek_tutar = Convert.ToInt32(Console.ReadLine());
                
                if (çekilecek_tutar <= bakiye)
                {
                    Console.WriteLine("Kalan Tutar:" + (bakiye - çekilecek_tutar));
                    Console.ReadLine();
                    return;
                }
                else
                {
                    Console.WriteLine("Bakiyenizden fazla para çekemezsiniz");
                    Console.ReadLine();
                    return;
                }

            }

            else if(secim == "3")
            {

                Console.WriteLine("Yatırmak istediğiniz tutarı giriniz");
                int yatirilacak_tutar = Convert.ToInt32((Console.ReadLine() + Console.ReadLine()));

                Console.WriteLine("Yeni bakiyeniz:"+ (bakiye + yatirilacak_tutar));
                Console.ReadLine();
                return;
            }

            else if (secim == "q")
            {
                Console.WriteLine("ATM ' den çıkış yapılıyor");
                Console.WriteLine("Çıkış yappıldı İyi Günler...");
                Console.ReadLine();
                return;
            }

            else
            {
                Console.WriteLine("Lütfen geçerli bir değer giriniz");
                Console.ReadLine();
                return;
            }


        }
    }
}
