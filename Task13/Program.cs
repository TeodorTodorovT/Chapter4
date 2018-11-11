using System;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Write a program that calculates the sum (with precision of 0.001) of the following sequence: 1 + 1/2 - 1/3 + 1/4 - 1/5 + …
            Console.Write("Enter last number: ");
            int l = int.Parse(Console.ReadLine());
            double sum = 1.0;

            for (int i = 2; i <= l; i++)
            {
                sum += (1.0 / i);
            }

            Console.WriteLine("{0:F3}", sum);
            Console.ReadLine();
        }
    }
}
