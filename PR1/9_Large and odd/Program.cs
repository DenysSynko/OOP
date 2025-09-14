using System;

class Program
{
    static  void Main()
    {
        int n;
        bool result;
        Console.WriteLine("Enter number: ");
        n = int.Parse(Console.ReadLine());
        if (n > 20 && n % 2 != 0)
        {
            result = true;
        }
        else {
            result = false;
        }
        Console.WriteLine($"Result: {result}");
    }
}
