using System;

namespace HelLoworld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //100,20,120TL
            Console.Write("Ürünün Fıyatı: ");
            double price = Convert.ToDouble(Console.ReadLine());

            //Kdv orani
            double kdvRate = 0.20;

            //Kdv tutari
            double kdvPrice = price * kdvRate;
            double totalPrice = price + kdvPrice;

            Console.WriteLine("KDV Tutarı : " + kdvPrice);
            Console.WriteLine("KDV'li Tutar : " + totalPrice);
            //Total Price seklinde sur kucuk olacak
        }
    }
}