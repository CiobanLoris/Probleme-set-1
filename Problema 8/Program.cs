using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti valoarea pentru a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduceti valoarea pentru b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Valori initiale: a = {a}, b = {b}");


        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine($"Valori inversate: a = {a}, b = {b}");


        Console.ReadKey();
    }
}
