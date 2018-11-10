using System;

namespace Task06
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Write a program that reads two numbers from the console and prints the greater of them. Solve the problem without using conditional statements.
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} >= {1}", Math.Max(a, b), Math.Min(a, b));
            Console.ReadLine();
        }
    }
}
