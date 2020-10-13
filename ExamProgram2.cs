using System;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The first few prime numbers are: ");
            int count1 = 0;
            int count2 = 0;
            string prime = "";
            for (count1 = 2, 50)
            {
                count2 = 2;
                prime = "yes";
                while (count2 * count2 <= count1)
                {
                    if (count1 % count2 = 0)
                    {
                        prime = "no";
                    }
                    count2 = count2 + 1;

                }
                if (prime == "yes")
                {
                    Console.WriteLine(count1);
                }
            }
        }
    }
}
