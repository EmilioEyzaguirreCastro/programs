using System;

namespace Program6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar 2 numeros a multiplicar:");
            double sum1 = Convert.ToDouble(Console.ReadLine());
            double sum2 = Convert.ToDouble(Console.ReadLine());
            double answer = sum1 * sum2;
            Console.WriteLine("El resultado es: " + answer);
        }
    }
}
