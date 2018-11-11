using System;

namespace Task09
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Write a program that reads a, b and c from the console and calculates: ax2+bx+c=0.
            double d, x1, x2;
            Console.Write("Enter A (not 0): ");
            double a = int.Parse(Console.ReadLine());
            Console.Write("Enter B: ");
            double b = int.Parse(Console.ReadLine());
            Console.Write("Enter C: ");
            double c = int.Parse(Console.ReadLine());

            d = b * b - 4 * a * c;

            if (d < 0) Console.WriteLine("D={0}, No real roots.", d);
            else if (d == 0)
            {
                x1 = (-b / (2 * a));
                Console.WriteLine("X={0}", x1);
            }
            else
            {
                x1 = (-b + d * d) / (2 * a);
                x2 = (-b - d * d) / (2 * a);
                Console.WriteLine("X1={0}, X2={1}", x1, x2);
            }
            Console.ReadLine();
        }

    }
}
