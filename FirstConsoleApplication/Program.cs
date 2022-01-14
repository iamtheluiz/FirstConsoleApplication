namespace FirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Working with numbers
             */
            Console.WriteLine("Addition: " + (8 + 5));
            Console.WriteLine("Subtraction: " + (8 - 5));
            Console.WriteLine("Multiplication: " + (8 * 5));
            Console.WriteLine("Division (int)   : " + (8 / 5));  // Returns int
            Console.WriteLine("Division (double): " + (8 / 5.0));    // Returns double
            Console.WriteLine("Modulus: " + (8 % 5));   // Remaining

            Console.WriteLine("\n=========================");

            int num = 5;
            Console.WriteLine("Initial Value: " + num);

            // Increment
            num++;
            Console.WriteLine("Incremented Value: " + num);
            // Decrement
            num--;
            Console.WriteLine("Decremented Value: " + num);

            /**
             * Math methods
             */
            Console.WriteLine("\n=========================");
            Console.WriteLine("Absolute number: " + Math.Abs(-32)); // Absolute value
            Console.WriteLine("Power: " + Math.Pow(3, 2)); // Power
            Console.WriteLine("Square root: " + Math.Sqrt(36)); // Square root
            Console.WriteLine("Max: " + Math.Max(4, 90));   // Get Biggest value
            Console.WriteLine("Min: " + Math.Min(4, 90));   // Get Smaller value
        }
    }
}