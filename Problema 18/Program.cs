using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti numarul n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write($"Descompunerea in factori primi ai numarului {n} este: ");
        descompunere(n);

        
        Console.ReadKey();
    }

    static void descompunere(int number)
    {
        if (number < 2)
        {
            Console.Write($"{number}");
            return;
        }

        Console.Write($"{number} = ");

        for (int i = 2; i <= number; i++)
        {
            int exponent = 0;

            while (number % i == 0)
            {
                number /= i;
                exponent++;
            }

            if (exponent > 0)
            {
                Console.Write($"{i}^{exponent}");

                if (number > 1)
                {
                    Console.Write(" x ");
                }
            }
        }

        Console.WriteLine();
    }
}
