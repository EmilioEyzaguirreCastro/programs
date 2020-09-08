    using System;

namespace Program4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar 2 numeros a sumar:");
            double sum1 = Convert.ToDouble(Console.ReadLine());
            double sum2 = Convert.ToDouble(Console.ReadLine());
            double answer = sum1 + sum2;
            Console.WriteLine("El resultado es: " + answer);
        }
    }
}
