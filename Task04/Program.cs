using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Write a program that prints three numbers in three virtual columns on the console. Each column should have a width of 10 characters and the numbers should be left aligned. The first number should be an integer in hexadecimal; the second should be fractional positive; and the third – a negative fraction. The last two numbers have to be rounded to the second decimal place.
            int nHex = 123;

            Console.WriteLine("|0x{0,-8:X}", nHex);
            double posNum = 2.2236;
            Console.WriteLine("|{0 , -10:f2}", posNum);

            double negNum = -1.4545;
            Console.WriteLine("|{0,-10:f2}", negNum);
            Console.ReadLine();
        }
    }
}
