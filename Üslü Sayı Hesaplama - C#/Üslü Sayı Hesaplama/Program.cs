namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Kullanıcıdan üs ve üssü değerlerini alır
            Console.Write("Üssü alınacak sayıyı girin: ");
            double baseNumber = double.Parse(Console.ReadLine());

            Console.Write("Üs değerini girin: ");
            double exponent = double.Parse(Console.ReadLine());

            double result = Math.Pow(baseNumber, exponent);

            //Üssün hesaplanması
            for (int i = 1; i <= exponent; i++)
            {
            result *= baseNumber;
            }

            // Sonucu ekrana yazdırır
            Console.WriteLine($"{baseNumber} üssü {exponent} = {result}");

        }
    }
}