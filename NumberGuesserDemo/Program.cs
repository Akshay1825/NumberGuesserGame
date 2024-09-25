using NumberGuesserDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesserDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Guess Number Game!");
            Console.WriteLine("You will be asked to guess a number to win the game.");

            bool play = true;

            while (play)
            {
                NumberGuesserGame numberGuesserGame = new NumberGuesserGame();
                numberGuesserGame.StartGame();

                Console.Write("Do you want to play again? (yes/no): ");
                string playAgainInput = Console.ReadLine().ToLower();

                play = playAgainInput == "yes";
                if (!play)
                {
                    Console.WriteLine("Thanks for playing! Goodbye.");
                }
            }
        }
    }
}
