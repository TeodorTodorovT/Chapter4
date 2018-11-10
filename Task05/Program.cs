using System;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Write a program that reads from the console two integer numbers (int) and prints how many numbers between them exist, such that the remainder of their division by 5 is 0. Example: in the range (14, 25) there are 3 such numbers: 15, 20 and 25.
            int c = 0;

            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                if (i % 5 == 0) c++;
            }

            Console.WriteLine("Numbers found - {0}", c);
            Console.ReadLine();
        }
    }
}
