using System;

class Program
{
    static void Main() {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        string str;
        int max=0, kright=0, kleft=0;
        string[] minarr;
        Console.WriteLine("Enter array: ");
        str = Console.ReadLine();
        string[] arr = str.Split(' ');
        Console.WriteLine("Enter array: ");
        str = Console.ReadLine();
        string[] arr2 = str.Split(' ');
        if (arr.Length >= arr2.Length)
        {
            minarr = arr2;
        }
        else
        {
            minarr = arr;
        }
        for (int i = 0; i < minarr.Length; i++)
        {
            if (arr[i] == arr2[i]) {
                kleft += 1;
            }
            else
            {
                break;
            }
        }
        for (int i = 0; i < minarr.Length; i++)
        {
            if (arr[arr.Length-i-1] == arr2[arr2.Length - i - 1])
            {
                kright += 1;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine($"Right: {kright}");
        Console.WriteLine($"Left: {kleft}");

        if (kright == 0 && kleft == 0) {
            Console.WriteLine("Немає спільних слів");
        } else if(kright > kleft) {
            Console.Write($"Найбільше справа: ");
            for (int i = kright-1; i >= 0; i--)
            {
                Console.Write($"{minarr[minarr.Length - i - 1]} ");
            }
            Console.WriteLine();
        } else if (kright < kleft) {
            Console.Write($"Найбільше зліва: ");
            for (int i = 0; i < kleft; i++)
            {
                Console.Write($"{minarr[i]} ");
            }
            Console.WriteLine();
        }


    }
}
