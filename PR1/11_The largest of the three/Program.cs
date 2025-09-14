using System;
class Program
{
    static void Main()
    {
        int a, b, c;
        Console.WriteLine("Enter 3 numbers: ");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());
        if (a >= b && a >= c) {
            Console.WriteLine($"Largest: {a}");
        }
        else if(b >= c && b >= a)
        {
            Console.WriteLine($"Largest: {b}");
        }
        else if(c >= b && c >= a)
        {
            Console.WriteLine($"Largest: {c}");
        }
    }
}