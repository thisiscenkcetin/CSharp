using System;

class Program
{
    static void Main()
    {
        int total = 0;
        int userInput;

        Console.WriteLine("Negatif bir değer girene kadar sayıları giriniz.");

        // Negatif sayı girilene kadar döngü devam eder
        do
        {
            Console.Write("Bir sayı giriniz: ");
            userInput = Convert.ToInt32(Console.ReadLine());

            // Sayı tek ise toplamaya ekle
            if (userInput % 2 != 0)
            {
                total += userInput;
            }

        } while (userInput >= 0);

        Console.WriteLine("Girilen tek sayıların toplamı: " + total);
    }
}