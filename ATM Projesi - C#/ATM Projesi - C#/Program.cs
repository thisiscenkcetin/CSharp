using System;

class Program
{
    static void Main()
    {
        string userName, password;
        int right = 3; // Hatalı giriş hakkı
        int balance = 1500; // Başlangıç bakiyesi
        int select;

        while (right > 0)
        {
            // Kullanıcıdan giriş bilgilerini al
            Console.Write("Kullanıcı Adınız: ");
            userName = Console.ReadLine();
            Console.Write("Parolanız: ");
            password = Console.ReadLine();

            // Kullanıcı adı ve şifre doğrulaması
            if (userName == "cenkcetin" && password == "12345")
            {
                Console.WriteLine("Merhaba, Dünya Bankasına Hoş geldiniz!");
                do
                {
                    // İşlem menüsünü göster
                    Console.WriteLine("1-Para Yatırma");
                    Console.WriteLine("2-Para Çekme");
                    Console.WriteLine("3-Bakiye Sorgula");
                    Console.WriteLine("4-Çıkış Yap");
                    Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz: ");
                    select = int.Parse(Console.ReadLine());

                    // Yapılacak işlemi kontrol et
                    if (select == 1)
                    {
                        Console.Write("Para miktarı: ");
                        int price = int.Parse(Console.ReadLine());
                        balance += price;
                        Console.WriteLine($"{price} TL para yatırıldı.");
                    }
                    else if (select == 2)
                    {
                        Console.Write("Para miktarı: ");
                        int price = int.Parse(Console.ReadLine());
                        if (price > balance)
                        {
                            Console.WriteLine("Bakiye yetersiz.");
                        }
                        else
                        {
                            balance -= price;
                            Console.WriteLine($"{price} TL para çekildi.");
                        }
                    }
                    else if (select == 3)
                    {
                        Console.WriteLine("Bakiyeniz: " + balance + " TL");
                    }
                } while (select != 4);

                Console.WriteLine("Tekrar görüşmek üzere.");
                break;
            }
            else
            {
                right--;
                Console.WriteLine("Hatalı kullanıcı adı veya şifre. Tekrar deneyiniz.");
                if (right == 0)
                {
                    Console.WriteLine("Hesabınız bloke olmuştur, lütfen banka ile iletişime geçiniz.");
                }
                else
                {
                    Console.WriteLine("Kalan Hakkınız: " + right);
                }
            }
        }
    }
}