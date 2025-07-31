using System;

class Program
{
    static void Main()
    {
        //Kullanıcıdan bir sayı alınır
        Console.Write("Bir sayı giriniz:");
        int number = Convert.ToInt32(Console.ReadLine());

        //Faktöriyel hesaplama işlemi
        long factorial = 1;
        for (int i = 1; i <= number; i++)

        { 
            factorial *= i; 
        }

        {
            //Sonucu ekrana yazdırma
            Console.WriteLine($"{number} sayısının faktöriyeli: {factorial}");
        }

    }
}