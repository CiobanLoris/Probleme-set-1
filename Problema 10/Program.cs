using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti numarul n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (prim(n))
        {
            Console.WriteLine($"{n} este un numar prim.");
        }
        else
        {
            Console.WriteLine($"{n} nu este un numar prim.");
        }

        
        Console.ReadKey();
    }

    static bool prim(int number)
    {
        if (number < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
