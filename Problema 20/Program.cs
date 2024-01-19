using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti numaratorul (m): ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduceti numitorul (n): ");
        int n = Convert.ToInt32(Console.ReadLine());

        string result = FractionToDecimal(m, n);

        Console.WriteLine($"{m}/{n} = {result}");

        
        Console.ReadKey();
    }

    static string FractionToDecimal(int numarator, int numitor)
    {
        if (numitor== 0)
        {
            return "Eroare: Nu se poate divide la 0";
        }

        if (numarator== 0)
        {
            return "0";
        }

        
        StringBuilder result = new StringBuilder((numarator > 0) ^ (numitor > 0) ? "-" : "");

        long num = Math.Abs((long)numarator);
        long numi = Math.Abs((long)numitor);

        
        result.Append((num / numi).ToString());

        
        long remainder = num % numi;

        if (remainder == 0)
        {
            return result.ToString();
        }

        result.Append(".");

        
        Dictionary<long, int> remainderMap = new Dictionary<long, int>();

        while (remainder != 0)
        {
            if (remainderMap.ContainsKey(remainder))
            {
                
                result.Insert(remainderMap[remainder], "(");
                result.Append(")");
                break;
            }

            remainderMap[remainder] = result.Length;

            remainder *= 10;
            result.Append((remainder / numi).ToString());
            remainder %= numi;
        }

        return result.ToString();
    }
}
