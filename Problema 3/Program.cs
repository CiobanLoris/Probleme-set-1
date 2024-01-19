using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduceti k: ");
        int k = Convert.ToInt32(Console.ReadLine());

        if (k != 0 && n % k == 0)
        {
            Console.WriteLine($"{n} se divide cu {k}.");
        }
        else
        {
            Console.WriteLine($"{n} nu se divide cu {k}.");
        }

        
        Console.ReadKey();
    }
}
