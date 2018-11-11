using System;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Write a program that prints on the console the first 100 numbers in the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …
            int num1 = 0;
            int num2 = 1;
            int sum = 1;
            int c = 0;

            Console.WriteLine(num1);

            while (c < 1000)
            {
                sum = num1 + num2;
                num1 = num2;
                num2 = sum;
                Console.WriteLine(num2);
                c++;
            }
            Console.ReadLine();
        }
    }
}
