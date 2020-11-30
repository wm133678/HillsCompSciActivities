using System;
using System.IO;

namespace Fantasy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Fantasy Football ---");
            OutputMenu();




        }

        static void OutputMenu()
        {
            Console.WriteLine("\nWhat would you like to do? ");
            Console.WriteLine("1. Create a new player (Max 5)");
            Console.WriteLine("2. View your existing team");
            Console.WriteLine("3. See the team's current value ");
            Console.WriteLine("4. Quit the program\n");
            int menuChoice = Convert.ToInt32(Console.ReadLine());
            switch (menuChoice)
            {
                case 1:
                    StoreFootballer();
                    break;
                case 2:
                    ViewTeam();
                    break;
                case 3:
                    TeamValue();
                    break;
                case 4:
                    Quit();
                    break;
                default:
                    OutputMenu();
                    break;
            }
        }

        static void StoreFootballer()
        {

            for (int i = 0; i < 5; i++)
            {
                string filename = i + ".txt";
                StreamWriter sw = new StreamWriter(filename);
                Console.WriteLine("\n--- Create player ---\n");

                Console.Write("Full Name: ");
                string name = Console.ReadLine();
                Console.Write("Goals Scored: ");
                string goals = Console.ReadLine();
                Console.Write("Number of Yellow Cards: ");
                string yellows = Console.ReadLine();
                Console.Write("Number of Red Cards: ");
                string reds = Console.ReadLine();

                sw.WriteLine("Full Name: " + name + "\nGoals Scored: " + goals + "\nNumber of Yellow Cards: " + yellows + "\nNumber of Red Cards: " + reds);
                sw.Close();
                Console.WriteLine("\n--- Successfully created player ---\n");
                Console.WriteLine("\n--- Would you like to create another player? (y/n) ---\n");
                string another = Console.ReadLine();
                if (another == "y")
                {
                }
                else
                {
                    OutputMenu();
                }

            }
        }

        static void ViewTeam()
        {
            for (int i = 0; i < 5; i++)
            {
                string filename = i + ".txt";
                using (StreamReader sr = new StreamReader(filename))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line + "\n");
                    }
                }
                Console.WriteLine("\n");
            }
        }

        static void TeamValue()
        {
            for (int i = 0; i < 5; i++)
            {
                string filename = i + ".txt";
                using (StreamReader sr = new StreamReader(filename))
                {
                    string newfile = "goals.txt";
                    StreamWriter sw = new StreamWriter(newfile);
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Contains("Goals Scored: "))
                        {
                            // Combine all goals scored
                            
                            sw.WriteLine(line + "\n");

                        }
                    }
                    sw.Close();

                }
                Console.WriteLine("\n");
            }
        }
        static void Quit()
        {
            Environment.Exit(0);
        }







    }
}
