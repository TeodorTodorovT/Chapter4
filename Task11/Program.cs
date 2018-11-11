using System;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Write a program that reads an integer number n from the console and prints all numbers in the range [1…n], each on a separate line.
            int sum = 0;

            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
