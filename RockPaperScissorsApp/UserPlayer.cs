using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsApp
{
    class UserPlayer : Player
    {
        public UserPlayer()
        {
            Console.Write("Enter Your Name: ");
            Name = Console.ReadLine();
        }

        public override RPS GenerateRPS()
        {
            Console.WriteLine("Enter R for Rock, P for Paper, S for scissors: ");
            string userChoice = Console.ReadLine().Trim().ToLower();
            if(userChoice == "r")
            {
                RPSChoice = RPS.Rock;
                return RPS.Rock;
            }
            else if (userChoice == "p")
            {
                RPSChoice = RPS.Paper;
                return RPS.Paper;
            }
            else if (userChoice == "s")
            {
                RPSChoice = RPS.Scissors;
                return RPS.Scissors;
            }
            else
            {
                Console.WriteLine("Error, invalid selection. Please choose R, P, or S. Try again.");
                return GenerateRPS();
            }
        }

    }
}
