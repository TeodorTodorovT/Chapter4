using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Write a program that reads from the console the radius "r" of a circle and prints its perimeter and area.
            Console.Write("Enter a radius: ");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("P = {0}  S = {1}", 2 * Math.PI * r, Math.PI * r * r);
            Console.ReadLine();
        }
    }
}
