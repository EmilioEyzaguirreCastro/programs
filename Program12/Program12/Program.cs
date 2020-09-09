using System;

namespace Program12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa la contraseña correcta(buscala en about.docx):");
            Console.Write("Contraseña: ");string pwd = Console.ReadLine(); string answer = "thepassword";
            if (pwd == answer) { Console.WriteLine("Bienvenido");}
            else{ Console.WriteLine("Contraseña incorrecta. Inténtelo de nuevo");}
        }
    }
}
