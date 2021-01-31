using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfHostedNumberGuessingClient
{
    class NumberGuessingGame
    {
        private int secretNumber;
        private int attempts;
        private bool guessedRight;
        private ISelfHostedNumberGuessing numberGuessService;
        public NumberGuessingGame(int lowerLimit, int upperLimit)
        {
            numberGuessService = new SelfHostedNumberGuessingClient();
            secretNumber = numberGuessService.SecretNumber(lowerLimit, upperLimit);
            attempts = 0;
            guessedRight = false;
        }

        public String makeGuess(int number)
        {
            String hint = numberGuessService.checkNumber(number, secretNumber);
            attempts++;
            if (hint.ToLower().Equals("correct"))
            {
                guessedRight = true;
            }

            return hint;
        }

        public bool hasGuessedRight()
        {
            return guessedRight;
        }

        public int getAttempts()
        {
            return attempts;
        }

       
    }
}
