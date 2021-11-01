using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsApp
{
    class RPSApp
    {
        public UserPlayer User { get; set; }
        public Player Opponent { get; set; }
        public int UserWins { get; set; } = 0;
        public int OpponentWins { get; set; } = 0;
        public int Draws { get; set; } = 0;

        //constructor, makes new UserPlayer and New opponent
        public RPSApp()
        {
            User = new UserPlayer();
            Opponent = GetOpponent();
        }


        //lets player select an opponent to play against
        public Player GetOpponent()
        {
            Console.WriteLine("Opponents");
            Console.WriteLine("1. Rocky");
            Console.WriteLine("2. Randa");
            Console.Write("Make your selection: ");
            string userChoice = Console.ReadLine();
            if (userChoice == "1")
            {
                return new Rocky();
            }
            else if (userChoice == "2")
            {
                return new Randa();
            }
            else
            {
                Console.WriteLine("Invalid Selection, try again.");
                return GetOpponent();
            }
        }

        //Play method to push game play along.
        public void Play()
        {
            User.GenerateRPS();
            Opponent.GenerateRPS();
            Console.WriteLine(User);
            Console.WriteLine(Opponent);
            GetWinner(User.RPSChoice, Opponent.RPSChoice);
            
        
        }

        //compares the user and opponents RPS values to determine winner.
        //once determined, adds one to the corresponding tally and prints out who won.
        public void GetWinner(RPS userChoice, RPS opponentChoice)
        {
            if(userChoice == opponentChoice)
            {
                Console.WriteLine("It's a Draw!");
                Draws++;
            }
            else if ((userChoice == RPS.Rock && opponentChoice == RPS.Scissors) || (userChoice == RPS.Paper && opponentChoice == RPS.Rock) || (userChoice == RPS.Scissors && opponentChoice == RPS.Paper))
            {
                Console.WriteLine("You Win!");
                UserWins++;
            }
            else
            {
                Console.WriteLine("You have been defeated...");
                OpponentWins++;
            }

        }

        //override for the ToString to print out final tally at end. 
        public override string ToString()
        {
            return $"User Wins: {UserWins}\nOpponent Wins: {OpponentWins}\nDraws: {Draws}";
        }
    }
}
