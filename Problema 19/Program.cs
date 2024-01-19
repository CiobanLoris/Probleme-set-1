using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti numarul: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (repetare(number))
        {
            Console.WriteLine($"{number} este format doar cu 2 cifre care se pot repeta.");
        }
        else
        {
            Console.WriteLine($"{number} nu este format doar cu 2 cifre care se pot repeta.");
        }

        
        Console.ReadKey();
    }

    static bool repetare(int n)
    {
        
        string numberString = n.ToString();

        
        return numberString.Distinct().Count() == 2;
    }
}
