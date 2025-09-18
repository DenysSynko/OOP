using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Введіть перший масив: ");
        char[] w1 = Console.ReadLine().Split(' ').Select(s => char.Parse(s)).ToArray();
        Console.WriteLine("Введіть перший масив: ");
        char[] w2 = Console.ReadLine().Split(' ').Select(s => char.Parse(s)).ToArray();
        int min = Math.Min(w1.Length, w2.Length);
        bool b = false;

        for (int i = 0; i < min; i++)
        {
            if (w1[i] > w2[i])
            {
                Console.Write($"{new string(w2)} < ");
                Console.WriteLine(new string(w1));
                b = true;
                break;
            }
            else if (w1[i] < w2[i])
            {
                Console.Write($"{new string(w1)} < ");
                Console.WriteLine(new string(w2));
                b = true;
                break;

            }
        }
        if (!b)
        {
            if (w1.Length == w2.Length)
            {
                Console.WriteLine("Рівні");
            }
            else
            {
                if (w1.Length > w2.Length)
                {
                    Console.Write($"{new string(w2)} < ");
                    Console.WriteLine(new string(w1));
                }
                else if (w1.Length < w2.Length)
                {
                    
                    Console.Write($"{new string(w1)} < ");
                    Console.WriteLine(new string(w2));
                    
                }
            }

        }
    }
}
