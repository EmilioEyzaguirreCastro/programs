using System;

namespace Program9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número para redondearlo al entero mas cercano:");
            double rnd = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Round(rnd));
        }
    }
}
