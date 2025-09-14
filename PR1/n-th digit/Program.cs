using System;

class Program
{
    static void Main() {
        int number, n, ndigit;
        Console.WriteLine("Enter number: ");
        number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter N: ");
        n = int.Parse(Console.ReadLine());
        if ((int)(number / Math.Pow(10, n - 1)) > 0)
        {
            ndigit = (int)(number / Math.Pow(10, n - 1) % 10);
            Console.WriteLine($"ndigit: {ndigit}");
        }
        else
        {
            Console.WriteLine($"Error");
        }
    }
}
