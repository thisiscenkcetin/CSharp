using System;

namespace Helloworld
{
    internal class Program
    {
       static void Main(string[] args)
       {
        // Acilis Ucreti: 15 TL      
        // KM Basina Ucret: 13.20 TL
        // Minimum Ucret:   100 TL  

        double startPrice = 15;
        double perKmPrice = 13.20;
        double minPrice = 100;

        Console.Write("Mesafeyi giriniz : ");
        double km = Convert.ToDouble(Console.ReadLine());

        double payPrice = startPrice + (km * perKmPrice);

        // Ensure the fare is at least the minimum charge
        payPrice = (payPrice < minPrice) ? minPrice : payPrice;

        Console.WriteLine("Taksi Ücreti : " + payPrice);

       }
    }
}