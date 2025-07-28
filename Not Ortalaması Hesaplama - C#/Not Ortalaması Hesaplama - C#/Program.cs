using System;

namespace Helloworld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Matematik Notunuz : ");
            double math = Convert.ToDouble(Console.ReadLine());

            Console.Write("Fizik Notunuz : ");
            double phy = Convert.ToDouble(Console.ReadLine());

            Console.Write("Türkçe Notunuz : ");
            double turkish = Convert.ToDouble(Console.ReadLine());

            double result = math + phy + turkish;
            result /= 3; 

            Console.WriteLine("Ortalamanız: " + result);
        }
    }
}