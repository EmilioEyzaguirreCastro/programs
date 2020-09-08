using System;

namespace Program8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un número para hallarle la raíz cuadrada:");
            double sqr = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(sqr));
        }
    }
}
