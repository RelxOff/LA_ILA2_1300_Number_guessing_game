using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LA_ILA2_1300_numberguessing
{
    internal class NumberHandler
    {
        private int secretNumber;
        public void CreateNumber()
        {
            Random rand = new Random();
            secretNumber = rand.Next(0, 101);
            Console.WriteLine("Geheimzahl" + " " + secretNumber);
        }
        public int CheckIfWon(int guessedNumber, int userGuesses)
        {
            if (guessedNumber == secretNumber)
            {
                if (userGuesses == 1)
                {
                    Console.WriteLine("You have won. \n You have guessed " + userGuesses + " time.");
                    return 2;
                }
                else
                {
                    Console.WriteLine("You have won. \n You have guessed " + userGuesses + " times.");
                    return 2;
                }
            }
            else if (guessedNumber > secretNumber)
            {
                Console.WriteLine("Your guessed number is too high. Try a lower number.");
                return 1;
            }
            else if (guessedNumber < secretNumber)
            {
                Console.WriteLine("Your guessed number is too low. Try a higher number.");
                return 1;
            }
            return 1;
        }
    }
}
