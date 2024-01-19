using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduceti b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduceti c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double delta = b * b - 4 * a * c;

        if (delta > 0)
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"Solutiile ecuatiei sunt x1 = {x1} si x2 = {x2}");
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"Ecuatia are o solutie dubla x = {x}");
        }
        else
        {
            double partereala = -b / (2 * a);
            double parteimaginara = Math.Sqrt(-delta) / (2 * a);
            Console.WriteLine($"Solutiile complexe ale ecuatiei sunt: {partereala} + {parteimaginara}i si {partereala} - {parteimaginara}i");
        }

        
        Console.ReadKey();
    }
}
