using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti anul: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if (IsLeapYear(year))
        {
            Console.WriteLine($"{year} este un an bisect.");
        }
        else
        {
            Console.WriteLine($"{year} nu este un an bisect.");
        }

        
        Console.ReadKey();
    }

    static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
}
