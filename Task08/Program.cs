using System;

namespace Task08
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Write a program that reads five numbers from the console and prints the greatest of them.
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Enter fourth number: ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Enter fifth number: ");
            int e = int.Parse(Console.ReadLine());

            if (a > b && a > c && a > d && a > e) Console.WriteLine("The biggest number is: {0}", a);
            else if (b > a && b > c && b > d && b > e) Console.WriteLine("The biggest number is: {0}", b);
            else if (c > a && c > b && c > d && c > e) Console.WriteLine("The biggest number is: {0}", c);
            else if (d > a && d > b && d > c && d > e) Console.WriteLine("The biggest number is: {0}", d);
            else if (e > a && e > b && e > c && e > d) Console.WriteLine("The biggest number is: {0}", e);
            else Console.WriteLine("The numbers you entered are equal!");
            Console.ReadLine();
        }
    }
}
