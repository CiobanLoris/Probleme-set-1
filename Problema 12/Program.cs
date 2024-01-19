using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduceti a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduceti b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        int count = div_n(n, a, b);

        Console.WriteLine($"In intervalul [{a}, {b}] exista {count} numere intregi divizibile cu {n}.");

        
        Console.ReadKey();
    }

    static int div_n(int n, int a, int b)
    {
        int count = 0;

        for (int i = a; i <= b; i++)
        {
            if (i % n == 0)
            {
                count++;
            }
        }

        return count;
    }
}
