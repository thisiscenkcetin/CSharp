using System;
using System.Security.Cryptography;

namespace Helloworld
{
    internal class Program
    {
        static void Main (string[] args)
        {
            // Alan: π * r * r
            // Cevre: 2 * π * r

            Console.Write("Yarıçap: ");
            double r = Convert.ToDouble(Console.ReadLine());

            double pi = Math.PI;
            double alan = pi * r * r;
            double cevre = 2 * pi * r;

            Console.WriteLine("Dairenin Alanı: " + alan);
            Console.WriteLine("Dairenin Çevresi: " + cevre);
        }
    }
}