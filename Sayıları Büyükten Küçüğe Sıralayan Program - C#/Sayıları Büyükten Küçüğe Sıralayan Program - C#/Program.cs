using System;

class SortNumbers
{
    static void Main()
    {
        Console.Write("1. sayıyı giriniz: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("2. sayıyı giriniz: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("3. sayıyı giriniz:");
        int c = int.Parse(Console.ReadLine());

        // Küçükten büyüğe sırala
        int[] nums = { a, b, c };
        Array.Sort(nums);
        Console.WriteLine($"Küçükten Büyüğe Sıralama: {nums[0]}, {nums[1]}, {nums[2]}");

        // Ters çevirerek büyükten küçüğe yazdır
        Console.WriteLine($"Büyükten Küçüğe Sıralama: {nums[2]}, {nums[1]}, {nums[0]}");

    }
}