namespace FirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Gess the number
             * - Generate a number between 1 and 100
             * - Receive user input with a guess
             *   > Display if input is greater ou lower than the generated number
             */
            int guessCounter = 0;
            int guessedNumber = 0;
            Random random = new Random();

            // Gerenate random number with min and max value
            int generatedNumber = random.Next(1, 100);

            Console.WriteLine("|==============================|");
            Console.WriteLine("|=        Guessing Game       =|");
            Console.WriteLine("|==============================|");
            Console.WriteLine("| * Try to guess the number ");
            Console.WriteLine("| between 1 and 100 chosen by");
            Console.WriteLine("| the computer.");
            Console.WriteLine("|------------------------------|");
            while (guessedNumber != generatedNumber)
            {
                guessCounter++;

                Console.WriteLine("| Your guess number " + guessCounter);
                Console.Write("| > ");
                guessedNumber = Convert.ToInt16(Console.ReadLine());

                if (guessedNumber < generatedNumber)
                {
                    Console.WriteLine("| * The generated number is greater than " + guessedNumber);
                } else if (guessedNumber > generatedNumber)
                {
                    Console.WriteLine("| * The generated number is lower than " + guessedNumber);
                }
                Console.WriteLine("|------------------------------|");
            }
            Console.WriteLine("| Congratulations!");
            Console.WriteLine("| You guessed the number after " + guessCounter + " attempts!");
            Console.WriteLine("|==============================|");
        }
    }
}