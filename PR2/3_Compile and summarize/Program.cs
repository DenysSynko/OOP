using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Введіть масив (k%4): ");
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int n = arr.Length/4;
        int[] head = new int[n];
        int[] tail = new int[n];
        for (int i = 0; i < n; i++) {
            head[i] = arr[n-1-i];
        }
        for (int i = 0; i < n; i++)
        {
            tail[i] = arr[arr.Length-1-i];
        }
        int[] arr2 = head.Concat(tail).ToArray();
        int[] sum = new int [arr2.Length];
        for (int i = 0; i < arr2.Length; i++)
        {
            sum[i] = arr[n+i] + arr2[i];
        }
        for (int i = 0; i < arr2.Length; i++)
        {
            Console.Write($"{arr[n+i]} ");
        }
        Console.WriteLine();
        for (int i = 0; i < arr2.Length; i++)
        {
            Console.Write($"{arr2[i]} ");
        }
        Console.WriteLine();
        Console.Write("Sum: ");
        for (int i = 0; i < arr2.Length; i++)
        {
            Console.Write($"{sum[i]} ");
        }
        Console.WriteLine();
    }
}
