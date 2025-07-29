using System;

class UcusBiletiHesaplayici
{
    static void Main()
    {
        Console.Write("Mesafeyi km türünden giriniz: ");
        int mesafe = Convert.ToInt32(Console.ReadLine());

        Console.Write("Yaşınızı giriniz: ");
        int yas = Convert.ToInt32(Console.ReadLine());

        Console.Write("Yolculuk tipini giriniz (1 => Tek Yön, 2 => Gidiş-Dönüş): ");
        int yolculukTipi = Convert.ToInt32(Console.ReadLine());

        if (mesafe <= 0 || yas <= 0 || (yolculukTipi != 1 && yolculukTipi != 2))
        {
            Console.WriteLine("Hatalı giriş yaptınız.");
            return;
        }

        double tabanUcret = mesafe * 0.10; // 0.10 TL/km
        double yasIndirimOrani = 0;

        if (yas < 12)
        {
            yasIndirimOrani = 0.50; // %50 indirim
        }
        else if (yas >= 12 && yas <= 24)
        {
            yasIndirimOrani = 0.10; // %10 indirim
        }
        else if (yas >= 65)
        {
            yasIndirimOrani = 0.30; // %30 indirim
        }

        double indirimliUcret = tabanUcret - (tabanUcret * yasIndirimOrani);

        if (yolculukTipi == 2)
        {
            indirimliUcret -= 0.20;
            indirimliUcret *= 2;
        }

        Console.WriteLine("Toplam Tutar = " + indirimliUcret + "TL");

    }
}

