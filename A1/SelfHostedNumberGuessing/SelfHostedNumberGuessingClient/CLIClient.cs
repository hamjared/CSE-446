using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfHostedNumberGuessingClient
{
    class CLIClient
    {

        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to the Number Guessing Game...");
            Console.WriteLine("Follow the prompts to generate a secret number");

            NumberGuessingGame game;
            try
            {
                Console.Write("Enter a lower limit: ");
                int lowerLimit = Int32.Parse(Console.ReadLine());
                Console.Write("Enter an upper limit: ");
                int upperLimit = Int32.Parse(Console.ReadLine());
                if(lowerLimit > upperLimit)
                {
                    Console.WriteLine("Lower limit cannot be larger than the upper limit, exiting...");
                    return;
                }
                game = new NumberGuessingGame(lowerLimit, upperLimit);
            }
            catch (Exception ex) when (ex is FormatException || ex is OverflowException)

            {
                Console.WriteLine("Invalid numbers entered. Please enter whole numbers only");
                Console.WriteLine("Exiting...");
                return;
            }

            while(!game.hasGuessedRight())
            {
                try
                {
                    Console.Write("What number do you guess: ");
                    int guess = Int32.Parse(Console.ReadLine().Trim());
                    Console.WriteLine("Your guess was: " + game.makeGuess(guess));
                }catch(Exception ex) when(ex is FormatException || ex is OverflowException)
                {
                    Console.WriteLine("Please enter a valid whole number, try again...");
                    continue;
                }
                
            }

            Console.WriteLine("Congrats! You guessed correctly it took you " + game.getAttempts() + " attempts");

            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
            Console.WriteLine("Exiting...");
           


            
        }

        
    }
}
