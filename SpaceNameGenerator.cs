using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Space name\n\n");
            Console.WriteLine("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the name of the town you were born in: ");
            string town = Console.ReadLine();
            Console.WriteLine("Enter the month you were born in: ");
            string month = Console.ReadLine();

            string SfirstName = string.Concat(lastName.Substring(0, 2), firstName.Substring(0,1));
            string SlastName = string.Concat(town.Substring(0, 2), month.Substring(0, 2));
            Console.WriteLine("Your space name is " + SfirstName + " " + SlastName);
        }
    }
}
