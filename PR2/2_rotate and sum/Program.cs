using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Введіть масив: ");
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] sum = new int[arr.Length];
        int[] rotated = new int[arr.Length];
        Console.WriteLine("Введіть кількість обертань: ");
        int k = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < k; i++)
        {
            int r = 0;
            for (int j = arr.Length - 1; j >= 0; j--) {
                rotated[r]=arr[j];
                r++;
            }
            for (int h = 0; h < arr.Length; h++)
            {
                sum[h] += rotated[h];
            }
            Array.Copy(rotated, arr, arr.Length);
            for (int l = 0; l < arr.Length; l++)
            {
                Console.Write($"{arr[l]} ");
            }
            Console.WriteLine();
        }
        Console.Write("Sum: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"{sum[i]} ");
        }
        Console.WriteLine();

    }
}
