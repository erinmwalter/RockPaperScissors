using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsApp
{
    class Rocky : Player
    {
        public Rocky()
        {
            Name = "Rocky";
            RPSChoice = GenerateRPS(); ;
        }

        public override RPS GenerateRPS()
        {
            return RPS.Rock;
        }
    }
}
