using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;
        int k = 0;
        Console.WriteLine("Введіть масив: ");
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Console.WriteLine("Введіть різницю: ");
        int r = int.Parse(Console.ReadLine());
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i; j < arr.Length; j++)
            {
                if (i != j && (arr[i] - arr[j] == r || arr[j] - arr[i] == r)) { 
                    Console.WriteLine($"{arr[i]}, {arr[j]}");
                    k++;
                }
            }
        }
        Console.WriteLine($"Кількість: {k}");

    }
}
