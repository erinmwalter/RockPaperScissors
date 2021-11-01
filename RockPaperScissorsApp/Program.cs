using System;

namespace RockPaperScissorsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;
            Console.WriteLine("Let's Play Rock, Paper Scissors!");

            RPSApp gamePlay = new RPSApp();
            while (playAgain)
            {
                gamePlay.Play();

                playAgain = Continue();
            }

            Console.WriteLine("\nFinal Score:");
            Console.WriteLine(gamePlay);
        }


        

        //continue method
        public static bool Continue()
        {
            Console.WriteLine("Play again? (y/n): ");
            string again = Console.ReadLine().Trim().ToLower();
            if(again == "y")
            {
                return true;
            }
            else if (again == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("I'm sorry, I didn't understand. Try Again.");
                return Continue();
            }
        }

    }
}
