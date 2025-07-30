using System;
using System.ComponentModel.Design;
using System.Linq.Expressions;

class ZodiacSignFinder
{
    static void Main()
    {
        Console.Write("Doğduğunuz ayı rakam olarak giriniz (1-12): ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Doğduğunuz günü girinizi: ");
        int day = int.Parse(Console.ReadLine());

        string zodiacSign = "";

        switch (month)
        {
            case 1:
                zodiacSign = (day <= 21) ? "Oğlak" : "Kova";
                break;
            case 2:
                if (day <= 19)
                    zodiacSign = "Kova";
                else if (day <= 29) // Şubat için 29 gün kontrolü
                    zodiacSign = "Balık";
                else
                    zodiacSign = "Geçersiz tarih";
                break;
            case 3:
                zodiacSign = (day <= 20) ? "Balık" : "Koç";
                break;
            case 4:
                zodiacSign = (day <= 20) ? "Koç" : "Boğa";
                break;
            case 5:
                zodiacSign = (day <= 21) ? "Boğa" : "İkizler";
                break;
            case 6:
                zodiacSign = (day <= 22) ? "İkizler" : "Yengeç";
                break;
            case 7:
                zodiacSign = (day <= 22) ? "Yengeç" : "Aslan";
                break;
            case 8:
                zodiacSign = (day <= 22) ? "Aslan" : "Başak";
                break;
            case 9:
                zodiacSign = (day <= 22) ? "Başak" : "Terazi";
                break;
            case 10:
                zodiacSign = (day <= 22) ? "Terazi" : "Akrep";
                break;
            case 11:
                zodiacSign = (day <= 21) ? "Akrep" : "Yay";
                break;
            case 12:
                zodiacSign = (day <= 21) ? "Yay" : "Oğlak";
                break;
            default:
                zodiacSign = "Geçersiz tarih";
                break;
        }

        if (zodiacSign == "Geçersiz tarih")
        {
            Console.WriteLine("Lütfen geçerli bir tarih giriniz.");
        }
        else
        {
            Console.WriteLine($"Burcunuz: {zodiacSign}");
        }

    }
}