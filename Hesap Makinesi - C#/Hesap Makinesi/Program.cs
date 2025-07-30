using System;

class Calculator
{
    static void Main()
    {
        Console.Write("1. Sayı: ");
        double sayi1 = double.Parse(Console.ReadLine());

        Console.Write("2. Sayı: ");
        double number2 = double.Parse(Console.ReadLine());

        Console.Write("Yapmak istediğiniz işlemi seçin (+, -, *, /): ");
        char operation = char.Parse(Console.ReadLine());

        try
        {
            double result = operation switch
            {
                '+' => sayi1 + number2,
                '-' => sayi1 - number2,
                '*' => sayi1 * number2,
                '/' => number2 != 0 ? sayi1 / number2
                                    : throw new DivideByZeroException("Bir sayı sıfıra bölünemez."),
                _ => throw new InvalidOperationException("Geçersiz işlem.")
            };

            Console.WriteLine($"Sonuç: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Hata: {ex.Message}");
        }
    }
}