namespace FirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Getting user input
             */
            Console.WriteLine("|======================");
            Console.WriteLine("| Pythagorean Theorem:");
            Console.WriteLine("|======================");

            double a, b, c;
            a = readDouble("| -> Altitude (a): ");
            b = readDouble("| -> Base (b): ");

            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            Console.WriteLine("|======================");
            Console.WriteLine("| -> Hypotenuse: " + c);

            Console.ReadLine();
        }

        static double readDouble(string p)
        {
            Console.Write(p);
            string line = Console.ReadLine();
            return Convert.ToDouble(line);
        }
    }
}