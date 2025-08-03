using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hesap Makinesine Hoş Geldiniz!");
        Console.WriteLine("Yapmak istediğiniz işlemi seçin:");
        Console.WriteLine("1. Toplama");
        Console.WriteLine("2. Çıkarma");
        Console.WriteLine("3. Çarpma");
        Console.WriteLine("4. Bölme");

        Console.Write("Seçiminiz: ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Birinci sayıyı girin: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        double num2 = double.Parse(Console.ReadLine());

        double result = 0;

        switch (choice)
        {
            case 1:
                result = Add(num1, num2);
                Console.WriteLine($"Sonuç: {num1} + {num2} = {result}");
                break;
            case 2:
                result = Subtract(num1, num2);
                Console.WriteLine($"Sonuç: {num1} - {num2} = {result}");
                break;
            case 3:
                result = Multiply(num1, num2);
                Console.WriteLine($"Sonuç: {num1} * {num2} = {result}");
                break;
            case 4:
                if (num2 != 0)
                {
                    result = Divide(num1, num2);
                    Console.WriteLine($"Sonuç: {num1} / {num2} = {result}");
                }
                else
                {
                    Console.WriteLine("Hata: Bir sayı sıfıra bölünemez!");
                }
                break;
            default:
                Console.WriteLine("Geçersiz seçim. Lütfen 1 ile 4 arasında bir değer girin.");
                break;
        }
    }

    // Toplama metodu
    static double Add(double a, double b)
    {
        return a + b;
    }

    // Çıkarma metodu
    static double Subtract(double a, double b)
    {
        return a - b;
    }

    // Çarpma metodu
    static double Multiply(double a, double b)
    {
        return a * b;
    }

    // Bölme metodu
    static double Divide(double a, double b)
    {
        return a / b;
    }
}