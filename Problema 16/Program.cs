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

        Console.Write("Introduceti al patrulea numar: ");
        double num4 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduceti al cincilea numar: ");
        double num5 = Convert.ToDouble(Console.ReadLine());

        ordonare(ref num1, ref num2, ref num3, ref num4, ref num5);

        Console.WriteLine($"Numerele in ordine crescatoare sunt: {num1}, {num2}, {num3}, {num4}, {num5}");

        
        Console.ReadKey();
    }

    static void ordonare(ref double a, ref double b, ref double c, ref double d, ref double e)
    {
        OrderTwo(ref a, ref b);
        OrderTwo(ref a, ref c);
        OrderTwo(ref a, ref d);
        OrderTwo(ref a, ref e);
        OrderTwo(ref b, ref c);
        OrderTwo(ref b, ref d);
        OrderTwo(ref b, ref e);
        OrderTwo(ref c, ref d);
        OrderTwo(ref c, ref e);
        OrderTwo(ref d, ref e);
    }

    static void OrderTwo(ref double x, ref double y)
    {
        if (x > y)
        {
            Swap(ref x, ref y);
        }
    }

    static void Swap(ref double x, ref double y)
    {
        double temp = x;
        x = y;
        y = temp;
    }
}
