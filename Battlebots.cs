using System;

namespace BattleBots
{
    class Program
    {
        static void Main(string[] args)
        {
            displayMenu();


            static void displayMenu()
            {
                Console.WriteLine("\nWelcome to Battle Boats!\n\n");
                Console.WriteLine("Please enter your menu option:");
                Console.WriteLine("1) Start a new game\n2) Resume Game\n3) Display Instructions\n4) Quit the game\n\n");
                int menuInput = Convert.ToInt32(Console.ReadLine());
                switch (menuInput)
                {
                    case 1:
                        newGame();
                        break;
                    case 2:
                        resumeGame();
                        break;
                    case 3:
                        readInstructions();
                        break;
                    case 4:
                        quit();
                        break;
                    default:
                        Console.WriteLine("Error, Please try again");
                        break;
                }

                static void newGame()
                {
                    char[,] playerFleet = new char[8, 8];
                    createGrid(playerFleet);
                    displayGrid(playerFleet);
                    boatPlacement(playerFleet);


                }

                static void boatPlacement(char[,] playerFleet)
                {
                    Console.WriteLine("\n--------------------------------------------------------------------------\nPlease enter the first letter of the coordinate of where you want to place your boat (E.g b)\n--------------------------------------------------------------------------\n");
                    //string boatPlacement = Console.ReadLine();
                    // Console.WriteLine(boatPlacement);
                    string one = Console.ReadLine();

                    Console.WriteLine("\n--------------------------------------------------------------------------\nPlease enter the first letter of the coordinate of where you want to place your boat (E.g b)\n--------------------------------------------------------------------------\n");
                    int y = Convert.ToInt32(Console.ReadLine());
                    // Edit player fleet for boat placement
                    // b7
                    Console.Write(" \n   a b c d e f g h");
                    for (int row = 0; row < playerFleet.GetLength(0); row++)
                    {
                        Console.WriteLine();
                        Console.Write(row + "  ");
                        for (int col = 0; col < playerFleet.GetLength(1); col++)
                        {
                            // int y = boatPlacement[1];

                            // char firsttt = boatPlacement[0];
                            char oo = char.Parse(one);
                            var x = Char.ToUpper(oo) - 'A' + 1; //01
                            //Console.WriteLine(x);
                            // Outputs 2 for B
                            // x is letter corresponding to column
                            //Console.WriteLine(y);
                            //Console.WriteLine(x);
                            //Console.WriteLine(y);
                            //Console.WriteLine(row);
                            //Console.WriteLine(col);
                            /* 2
                             * 55
                             * 7
                             * 7
                             * 
                             * 
                             * 
                             */

                            // if x is equal to column number replace with B

                            int column = col + 1;
                            if (x == column && y == row)
                            {
                                //place boat
                                Console.Write(playerFleet[row, col].ToString() + 'B');

                            }
                            else
                            {
                                Console.Write(playerFleet[row, col].ToString() + ' ');

                            }

                        }
                    }


                }

                static void displayGrid(char[,] playerFleet)
                {
                    Console.Write(" \n   a b c d e f g h");
                    for (int row = 0; row < playerFleet.GetLength(0); row++)
                    {
                        Console.WriteLine();
                        Console.Write(row + "  ");
                        for (int col = 0; col < playerFleet.GetLength(1); col++)
                        {

                            Console.Write(playerFleet[row, col].ToString() + ' ');
                        }
                    }
                    Console.WriteLine("\n");

                }

                static void createGrid(char[,] playerFleet)
                {

                    for (int row = 0; row < playerFleet.GetLength(0); row++)
                    {
                        for (int col = 0; col < playerFleet.GetLength(1); col++)
                        {
                            playerFleet[row, col] = '+';
                        }
                    }

                }

                static void resumeGame()
                {

                }

                static void readInstructions()
                {

                }

                static void quit()
                {
                    Console.WriteLine("\n-----------------\nQuitting The Game\n-----------------\n");
                    System.Environment.Exit(1);
                }
            }
        }
    }
}
