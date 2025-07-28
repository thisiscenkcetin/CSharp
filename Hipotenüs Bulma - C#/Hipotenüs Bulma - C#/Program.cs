using System;

internal class Program
{
    static void Main(string[] args)
    {

        // √(a² + b²)
        Console.Write("1. Kenar: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("2. Kendar: ");
        double b = Convert.ToDouble(Console.ReadLine());

        double result = Math.Sqrt(a * a + b * b);

        Console.WriteLine("Hipotenüs: " + result);


    }
}