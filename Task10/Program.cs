using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Write a program that reads an integer number n from the console. After that reads n numbers from the console and prints their sum.
            int sum = 0;

            Console.Write("Enter numbers count: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter {0} number: ", i + 1);
                sum += int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sum of all numbers is {0}.", sum);
            Console.ReadLine();
        }

    }
}
