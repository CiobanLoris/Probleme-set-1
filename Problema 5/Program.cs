using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti numarul: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduceti pozitia k: ");
        int k = Convert.ToInt32(Console.ReadLine());

        int digit = obtinecifra_k(number, k);

        if (digit != -1)
        {
            Console.WriteLine($"Cifra de la pozitia {k} de la sfarsitul numarului {number} este: {digit}");
        }
        else
        {
            Console.WriteLine($"Numarul {number} nu are {k} cifre.");
        }

        
        Console.ReadKey();
    }

    static int obtinecifra_k(int number, int k)
    {
        if (k <= 0)
        {
            Console.WriteLine("Pozitia k trebuie sa fie un numar pozitiv.");
            return -1;
        }

        string lungime = number.ToString();

        if (k <= lungime.Length)
        {
            char cifrak = lungime[lungime.Length - k];
            return Convert.ToInt32(cifrak.ToString());
        }
        else
        {
            return -1; // k depaseste numarul de cifre ale numarului
        }
    }
}
