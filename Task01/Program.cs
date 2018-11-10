using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Write a program that reads from the console three numbers of type int and prints their sum.

            int num1, num2, num3;
            Console.Write("Enter the first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum of the three numbers is: {0}", num1 + num2 + num3);
            Console.ReadLine();


        }
    }
}
