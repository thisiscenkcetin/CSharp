using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Palindrom sayıları bulmak için bir başlangıç ve bitiş aralığı girin:");

        Console.Write("Başlangıç: ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("Bitiş: ");
        int end = int.Parse(Console.ReadLine());

        Console.WriteLine($"\n{start} ile {end} arasındaki palindrom sayılar:");
        FindPalindromes(start, end);
    }

    // Bir sayının palindrom olup olmadığını kontrol eden metot
    static bool IsPalindrome(int number)
    {
        int original = number;
        int reversed = 0;

        while (number > 0)
        {
            int remainder = number % 10; // Son basamağı al
            reversed = (reversed * 10) + remainder; // Ters sayıyı oluştur
            number /= 10; // Sayıyı bir basamak küçült
        }

        return original == reversed;
    }

    // Belirtilen aralıktaki palindrom sayıları bulan metot
    static void FindPalindromes(int start, int end)
    {
        for (int i = start; i <= end; i++)
        {
            if (IsPalindrome(i))
            {
                Console.WriteLine(i);
            }
        }
    }
}