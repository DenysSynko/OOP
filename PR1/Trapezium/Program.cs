using System;

class Program
{
    static void Main()
    {
        float a, b, h;
        float area;
        Console.WriteLine("Enter a, b, h: ");
        a = float.Parse(Console.ReadLine());
        b = float.Parse(Console.ReadLine());
        h = float.Parse(Console.ReadLine());
        area = (a + b) / 2.0f * h;
        Console.WriteLine($"Area: {area}");
    }
}
