using System;

namespace Task07
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Write a program that reads five integer numbers and prints their sum.
            int a, b, c, d, e;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());
            Console.WriteLine(a + b + c + d + e);
            Console.ReadLine();
        }
    }
}
