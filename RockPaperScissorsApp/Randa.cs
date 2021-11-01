using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsApp
{
    class Randa : Player
    {
        public Randa()
        {
            Name = "Randa";
            RPSChoice = GenerateRPS();
        }

        public override RPS GenerateRPS()
        {
            Random rand = new Random();
            int choice = rand.Next(1, 4);
            if(choice == 1)
            {
                RPSChoice = RPS.Rock;
                return RPS.Rock;
            }
            else if (choice == 2)
            {
                RPSChoice = RPS.Paper;
                return RPS.Paper;
            }
            else
            {
                RPSChoice = RPS.Scissors;
                return RPS.Scissors;
            }

        }
    }
}
