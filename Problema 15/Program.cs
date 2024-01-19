using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti primul numar: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduceti al doilea numar: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduceti al treilea numar: ");
        double num3 = Convert.ToDouble(Console.ReadLine());

        ordonare(ref num1, ref num2, ref num3);

        Console.WriteLine($"Numerele in ordine crescatoare sunt: {num1}, {num2}, {num3}");

        
        Console.ReadKey();
    }

    static void ordonare(ref double a, ref double b, ref double c)
    {
        if (a > b)
        {
            Swap(ref a, ref b);
        }

        if (b > c)
        {
            Swap(ref b, ref c);
        }

        if (a > b)
        {
            Swap(ref a, ref b);
        }
    }

    static void Swap(ref double x, ref double y)
    {
        double temp = x;
        x = y;
        y = temp;
    }
}
