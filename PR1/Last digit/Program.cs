using System;

class Program
{
    static void Main()
    {
        int n, lastdigit;
        Console.WriteLine("Enter number: ");
        n = int.Parse(Console.ReadLine());
        lastdigit = n % 10;
        Console.WriteLine($"Last digit: {lastdigit}"); 
    }
}
