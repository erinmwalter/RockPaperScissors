using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsApp
{

    abstract class Player
    {
        public string Name { get; set; }
        public RPS RPSChoice { get; set; }

        public abstract RPS GenerateRPS();

        public override string ToString()
        {
            return $"{Name} chose {RPSChoice}";
        }
    }
}
