using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Введіть n: ");
        int n = int.Parse(Console.ReadLine());
        bool[] primes = new bool[n + 1];
        for (int i = 2; i <= n; i++)
        {
            primes[i] = true; 
        }
        for (int i = 2; i<=n; i++)
        {
            if (primes[i]==true) {
                for (int j = i+1; j <= n; j++) {
                    if (j % i == 0)
                    {
                        primes[j] = false;
                    }
                }
            }
        }
        for (int i = 2; i <= n; i++)
        {
            if (primes[i] == true)
            {
                Console.Write($"{i} ");
            }
        }
        Console.WriteLine();
    }
}
