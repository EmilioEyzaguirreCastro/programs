using System;

namespace Program15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba algo: un número o un texto. Recomendamos probar ambos");
            try
            {
                int err = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Escribiste " + err);
            }
            catch (Exception e) { Console.WriteLine("Oh no. Something went wrong. Try to write a not too long number"); }
        }
    }
}
