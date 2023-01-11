using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA_ILA2_1300_numberguessing
{
    internal class Game
    {
        private NumberHandler _numberHandler = new NumberHandler();
        private GUI _gui = new GUI();

        public void StartGame()
        {
            _numberHandler.CreateNumber();
            while (true)
            {
                int userInput = _gui.NumberInput();
                if (_numberHandler.CheckIfWon(userInput, _gui.guesses) == 2)
                {
                    if (_gui.ReloadGame() == 1)
                    {
                        _numberHandler.CreateNumber();
                    }
                    else
                    {
                        Console.ReadKey();
                        break;
                    }
                }
            }
        }
    }
}
