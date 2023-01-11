using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA_ILA2_1300_numberguessing
{
    internal class GUI
    {
        public int guesses = 0;
        public int NumberInput()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter a number between 1 and 100.");
                    string input = Console.ReadLine();
                    int inputInt = Convert.ToInt32(input);
                    if (inputInt >= 1 && inputInt <= 100)
                    {
                        guesses++;
                        return inputInt;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input. Try Again.");
                }
            }
        }
        public int ReloadGame()
        {
            while (true)
            {
                Console.WriteLine("Do you want to play again? [yes/no]");
                string playAgain = Console.ReadLine();
                if (playAgain == "yes")
                {
                    guesses = 0;
                    return 1;
                }
                else if (playAgain == "no")
                {
                    Console.WriteLine("Bye");
                    return 2;
                }
                else
                {
                    Console.WriteLine("Give a valid awnser!");
                }
            }
        }
    }
}
