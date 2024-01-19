using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti numarul n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Divizorii numarului {n} sunt:");

        
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                Console.WriteLine(i);
            }
        }

        
        Console.ReadKey();
    }
}
