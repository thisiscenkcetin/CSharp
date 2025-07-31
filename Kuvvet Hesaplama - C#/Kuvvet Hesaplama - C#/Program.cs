using System;

class Program
{
    static void Main()
    { 
        //Kullanıcıdan bir sayı alınır
        Console.Write("Bir sayı girin:" );
        int number = int.Parse(Console.ReadLine());

        //3'ün kuvvetlerini hesaplayan for döngüsü
        for (int powerOfThree = 1; powerOfThree <= number; powerOfThree *= 3)

        {
            Console.WriteLine(powerOfThree);
        }

    }
}