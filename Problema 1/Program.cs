using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Introduceti a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduceti b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double x = 0;

            if (a == 0)
            {
                if (b == 0)
                    Console.WriteLine("Ecuatia are o infinitate de solutii.");
                else
                    Console.WriteLine("Ecuatia nu are solutie.");
            }
            else
            {
                 x = -b / a;
                Console.WriteLine($"Solutia ecuatiei este x = {x}");
            }

            Console.ReadKey();
        }

    }
}
