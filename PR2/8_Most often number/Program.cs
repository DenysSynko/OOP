using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Введіть масив: ");
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int k = 0, kmax = 0, v = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            k = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                if(arr[i] == arr[j])
                {
                    k++;
                }
            }
            if(k > kmax)
            {
                kmax = k;
                v = arr[i];
            }
        }
        
        Console.WriteLine($"Most: {v}");
    }
}
