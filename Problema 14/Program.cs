using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti numarul n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (palindrom(n))
        {
            Console.WriteLine($"{n} este un numar palindrom.");
        }
        else
        {
            Console.WriteLine($"{n} nu este un numar palindrom.");
        }

        
        Console.ReadKey();
    }

    static bool palindrom(int number)
    {
        int nr = number;
        int invers = 0;

        while (number > 0)
        {
            int digit = number % 10;
            invers = invers * 10 + digit;
            number /= 10;
        }

        return nr == invers;
    }
}
