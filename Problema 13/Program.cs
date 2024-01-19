using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti anul de inceput (y1): ");
        int y1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduceti anul de sfarsit (y2): ");
        int y2 = Convert.ToInt32(Console.ReadLine());

        int leapYearsCount = ani_bisecti(y1, y2);

        Console.WriteLine($"Numarul de ani bisecti intre anii {y1} si {y2} este: {leapYearsCount}");

        
        Console.ReadKey();
    }

    static int ani_bisecti(int y1, int y2)
    {
        int count = 0;

        for (int an = y1; an <= y2; an++)
        {
            if (bisect(an))
            {
                count++;
            }
        }

        return count;
    }

    static bool bisect(int an)
    {
          return (an % 4 == 0 && an % 100 != 0) || (an % 400 == 0);
    }
}
