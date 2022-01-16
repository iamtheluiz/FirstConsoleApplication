using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApplication
{
    internal class GuessingGame
    {
        readonly Random random = new();
        private int generatedNumber;
        private int guessedNumber = 0;
        private int guessCounter = 0;

        public GuessingGame()
        {
            /**
             * Guess the number
             * - Generate a number between 1 and 100
             * - Receive user input with a guess
             *   > Display if input is greater ou lower than the generated number
             */

            // Gerenate random number with min and max value
            generatedNumber = random.Next(1, 100);
        }

        public void Run()
        {
            Console.Clear();
            ShowBanner();
            while (guessedNumber != generatedNumber)
            {
                GetUserGuess();
                VerifyGuess();
            }
        }

        static void ShowBanner()
        {
            Console.WriteLine("|==============================|");
            Console.WriteLine("|=        Guessing Game       =|");
            Console.WriteLine("|==============================|");
            Console.WriteLine("| * Try to guess the number ");
            Console.WriteLine("| between 1 and 100 chosen by");
            Console.WriteLine("| the computer.");
            Console.WriteLine("|------------------------------|");
        }

        private void GetUserGuess()
        {
            guessCounter++;

            Console.WriteLine("| Your guess number " + guessCounter);
            Console.Write("| > ");
            guessedNumber = Convert.ToInt16(Console.ReadLine());
        }

        private void VerifyGuess()
        {
            if (guessedNumber == generatedNumber)
            {
                ShowWin();
            }
            else {
                if (guessedNumber > generatedNumber)
                {
                    Console.WriteLine("| * The generated number is lower than " + guessedNumber);
                }
                else
                {
                    Console.WriteLine("| * The generated number is greater than " + guessedNumber);
                }
                Console.WriteLine("|------------------------------|");
            }
            
        }

        private void ShowWin()
        {
            Console.WriteLine("| Congratulations! ");
            Console.WriteLine("| You guessed after " + guessCounter + " attempts.");
            Console.WriteLine("|==============================|");

            Console.Write("\nPress ENTER to exit...");
            Console.ReadLine();
        }
    }
}
