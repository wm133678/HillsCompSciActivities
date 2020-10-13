using System;
using System.ComponentModel;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice game! ");
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Random rnd = new Random();
            int computerScore = 0;
            int playerScore = 0;
            bool finished = false;
            while(finished == false)
            {
                // random number generated
                
                int playerRoll = rnd.Next(1, 7);
                int computerRoll = rnd.Next(1, 7);
                playerScore += playerRoll;
                computerScore += computerRoll;
                Console.WriteLine(name + "'s score: " + playerScore);
                if (playerScore > 21)
                {
                    finished = true;
                }
                else
                {
                    finished = false;
                }
                Console.WriteLine("Computer's score: " + computerScore + "\n");
            
                    if (computerScore > 21)
                {
                    finished = true;
                }

                else
                {
                    finished = false;
                }

            } 
            if (computerScore >= 21)
            {
                Console.WriteLine("Computer wins! ");
            }
            else if (playerScore >= 21) {
                Console.WriteLine(name + " wins!");
            }
            else
            {
            }
        }
    }
}
