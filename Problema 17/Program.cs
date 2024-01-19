using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti primul numar: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduceti al doilea numar: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int gcd = CalculateGCD(num1, num2);
        int lcm = CalculateLCM(num1, num2, gcd);

        Console.WriteLine($"Cel mai mare divizor comun al numerelor {num1} si {num2} este: {gcd}");
        Console.WriteLine($"Cel mai mic multiplu comun al numerelor {num1} si {num2} este: {lcm}");

        
        Console.ReadKey();
    }

    static int CalculateGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static int CalculateLCM(int a, int b, int gcd)
    {
        
        return Math.Abs(a * b) / gcd;
    }
}
