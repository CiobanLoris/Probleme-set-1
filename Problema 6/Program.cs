using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti lungimea laturii a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduceti lungimea laturii b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduceti lungimea laturii c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        if (IsTriangle(a, b, c))
        {
            Console.WriteLine($"Cele trei lungimi {a}, {b}, {c} pot forma laturile unui triunghi.");
        }
        else
        {
            Console.WriteLine($"Cele trei lungimi {a}, {b}, {c} nu pot forma laturile unui triunghi.");
        }

        
        Console.ReadKey();
    }

    static bool IsTriangle(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }
}
