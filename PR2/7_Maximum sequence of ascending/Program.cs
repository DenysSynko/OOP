using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Введіть масив: ");
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] max = new int[arr.Length];
        int k = 1, kmax = 0, ind = 0, r = 0;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] < arr[i + 1])
            {
                k++;
            }
            else
            {
                if (k > kmax)
                {
                    kmax = k;
                    ind = i - k + 1;
                    k = 1;
                }
            }
        }
        if (k > kmax)
        {
            kmax = k;
            ind = arr.Length - k;
            k = 1;
        }
        for (int i = 0; i < kmax; i++)
        {
            max[r] = arr[ind];
            r++;
            ind++;
        }
        Console.WriteLine("Max: ");
        for (int i = 0; i < kmax; i++)
        {
            Console.Write($"{max[i]} ");
        }
        Console.WriteLine();

    }
}
