using System;

class ActivitySuggestion
{
    static void Main()
    {
        Console.Write("Sıcaklık Giriniz(°C): ");
        int temperature = int.Parse(Console.ReadLine());

        if (temperature < 5)
        {

            Console.WriteLine("Önerilen Etkinlik: Kayak");

        }

        else if (temperature >= 5 && temperature <= 15)
        {
            Console.WriteLine("Önerilen Etkinlik: Sinema");
        }
        else if (temperature > 15 && temperature <= 25)
        {
            Console.WriteLine("Önerilen Etkinlik: Piknik");
        }
        else
        {
            Console.WriteLine("Önerilen Etkinlik: Yüzme");
        }

    }
}