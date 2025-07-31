using System;

class Program
{ static void Main()

    {

        Console.Write("Bir sayı giriniz: ");
        int userNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Girilsen sayıya kadar olan çift sayılar:");
        for (int i = 2; i <= userNumber; i += 2)

        {
            Console.WriteLine(i);
        }
    }


}