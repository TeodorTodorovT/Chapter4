using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {   //task:  A given company has name, address, phone number, fax number, web site and manager.
            //The manager has name, surname and phone number. Write a program that reads information about the company and its manager and then prints it on the console.
            Console.Write("Enter company name: ");
            string compName = Console.ReadLine();
            Console.Write("Enter company address: ");
            string compAdrs = Console.ReadLine();
            Console.Write("Enter company phone number: ");
            string compPhone = Console.ReadLine();
            Console.Write("Enter company fax: ");
            string compFax = Console.ReadLine();
            Console.Write("Enter company website: ");
            string compSite = Console.ReadLine();
            Console.Write("Enter company manager: ");
            string compMan = Console.ReadLine();
            Console.Write("Enter manager first name: ");
            string manFN = Console.ReadLine();
            Console.Write("Enter manager last name: ");
            string manLN = Console.ReadLine();
            Console.Write("Enter manager phone: ");
            string manPhone = Console.ReadLine();

            Console.WriteLine("Firm: Name - {0}, Address - {1}, Number - {2}, Fax - {3}, Website - {4}, Manager - {5}", compName, compAdrs, compPhone, compFax, compSite, compMan);
            Console.WriteLine("Manager: Name - {0} {1}, Phone - {2}", manFN, manLN, manPhone);
            Console.ReadLine();
        }
    }
}
