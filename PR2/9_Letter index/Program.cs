using System;
using System.Diagnostics.Metrics;
using System.Reflection;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        char[] arr = new char[26];
        for (int i = 0; i < 26; i++)
        {
            arr[i] = (char)('a' + i);
        }
        Console.Write("Введіть слово: ");
        string word = Console.ReadLine();
        for(int i = 0; i < word.Length; i++)
        {
            for(int j = 0; j < arr.Length; j++)
            {
                if (word[i] == arr[j])
                {
                    Console.WriteLine($"{word[i]} -> {j}");
                }
            }
        }

    }
}
