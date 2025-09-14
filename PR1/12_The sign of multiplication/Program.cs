using System;
class Program
{
    static void Main()
    {
        int a, b, c;
        char product;
        Console.WriteLine("Enter a, b, c: ");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());
        if (a * b * c < 0) {
            product = '-';
            Console.WriteLine($"Result: {product}");
        } else if (a * b * c > 0) {
            product = '+';
            Console.WriteLine($"Result: {product}");
        }
        else{
            product = '0';
            Console.WriteLine($"Result: {product}");
        }
    }
}
