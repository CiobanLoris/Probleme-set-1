using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti numarul n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Cifrele numarului {n} in ordine inversa sunt: {inversare(n)}");

        
        Console.ReadKey();
    }

    static int inversare(int number)
    {
        int nrinvers = 0;

        while (number > 0)
        {
            int digit = number % 10;
            nrinvers = nrinvers * 10 + digit;
            number /= 10;
        }

        return nrinvers;
    }
}
