using System;

namespace Program10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese 2 números para hallar el menor de los dos:");
            double mn = Convert.ToDouble(Console.ReadLine());
            double mn1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Min(mn, mn1));
        }
    }
}
