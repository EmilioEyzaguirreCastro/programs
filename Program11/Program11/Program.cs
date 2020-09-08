using System;

namespace Program11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese 2 números para hallar el mayor de los dos:");
            double mx = Convert.ToDouble(Console.ReadLine());
            double mx1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Max(mx, mx1));
        }
    }
}
