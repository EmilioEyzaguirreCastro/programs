using System;

namespace Program14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba un número y te dira el numero indicado. Si se escribe un número mayor de 10, se imprimira una exprecion por defecto:");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Escribiste 1");
                    break;
                case 2:
                    Console.WriteLine("Escribiste 2");
                    break;
                case 3:
                    Console.WriteLine("Escribiste 3");
                    break;
                case 4:
                    Console.WriteLine("Escribiste 4");
                    break;
                case 5:
                    Console.WriteLine("Escribiste 5");
                    break;
                case 6:
                    Console.WriteLine("Escribiste 6");
                    break;
                case 7:
                    Console.WriteLine("Escribiste 7");
                    break;
                case 8:
                    Console.WriteLine("Escribiste 8");
                    break;
                case 9:
                    Console.WriteLine("Escribiste 9");
                    break;
                case 10:
                    Console.WriteLine("Escribiste 10");
                    break;
                default:
                    Console.WriteLine("Escribiste un número mayor que 10");
                    break;
            }
        }
    }
}
