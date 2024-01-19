using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Alege un numar intre 1 si 1024 inclusiv.");
        Console.WriteLine("Eu voi incerca sa ghicesc prin intrebari de forma 'Numarul este mai mare sau egal cu x?'.");
        Console.WriteLine("Raspunde cu 'da' sau 'nu'.\n");

        int guess = GuessNumber(1, 1024);

        Console.WriteLine($"Am ghicit! Numarul tau este {guess - 1}.");
        Console.ReadKey();
    }

    static int GuessNumber(int lowerBound, int upperBound)
    {
        while (true)
        {
            int guess = (lowerBound + upperBound) / 2;

            Console.Write($"Numarul tau este mai mare sau egal cu {guess}? (da/nu): ");
            string response = Console.ReadLine().ToLower();

            if (response == "da")
            {
                lowerBound = guess + 1;
            }
            else if (response == "nu")
            {
                upperBound = guess;
            }

            if (lowerBound == upperBound)
            {
                return lowerBound;
            }
        }
    }
}
