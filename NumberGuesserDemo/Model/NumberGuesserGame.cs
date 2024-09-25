using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesserDemo.Model
{
    internal class NumberGuesserGame
    {
        int numberToGuess;
        int attempts;

        public NumberGuesserGame()
        {
            Random random = new Random();
            numberToGuess = random.Next(1, 101);
            attempts = 0;
        }

        public void StartGame()
        {
            bool hasGuessedCorrectly = false;

            while (!hasGuessedCorrectly)
            {
                Console.Write("Enter a guess number between 1 to 100: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int guess))
                {
                    attempts++;
                    hasGuessedCorrectly = CheckGuess(guess);
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a number between 1 and 100");
                }
            }

            Console.WriteLine($"You took {attempts} tries! You win the game!");
        }

        private bool CheckGuess(int guess)
        {
            string message = guess < numberToGuess ? "Sorry,Too Low" :
                             guess > numberToGuess ? "Sorry,Too High" :
                             "Yayy! Your guessed number is correct";

            Console.WriteLine(message);

            return guess == numberToGuess;
        }
    }
}
