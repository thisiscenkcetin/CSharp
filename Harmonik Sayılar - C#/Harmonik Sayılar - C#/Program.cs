using System;

class Program
{
    static void Main() // 'class' yerine 'static' olmalı
    {
        // Kullanıcıdan bir sayı alınır
        Console.Write("Bir sayı giriniz: ");
        int number = int.Parse(Console.ReadLine());

        // Harmonik sayı hesaplanır
        double harmonicSum = 0.0;
        for (int i = 1; i <= number; i++)
        {
            harmonicSum += 1.0 / i;
        }

        // Sonuç ekrana yazdır
        Console.WriteLine($"{number} sayısının harmonik serisi: {harmonicSum}");
    }
}