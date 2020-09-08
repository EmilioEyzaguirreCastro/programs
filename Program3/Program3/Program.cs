using System;

namespace Program3
{
    class Program
    {
        static void Main(string[] args)
        {   //Ask the age
            Console.WriteLine("Enter your age:");

            //Store the answer on the variable "age"(first convert it)
            int age = Convert.ToInt32(Console.ReadLine());

            //Say your age
            Console.WriteLine("Your age is " + age);
        }
    }
}
