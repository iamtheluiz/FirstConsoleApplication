using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApplication
{
    internal class PythagoreanTheorem
    {
        public static void Run()
        {
            Console.Clear();
            Console.WriteLine("|======================");
            Console.WriteLine("| Pythagorean Theorem:");
            Console.WriteLine("|======================");

            double a, b, c;
            a = ReadDouble("| -> Altitude (a): ");
            b = ReadDouble("| -> Base (b): ");

            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            Console.WriteLine("|======================");
            Console.WriteLine("| -> Hypotenuse: " + c);
            Console.WriteLine("|======================");

            Console.Write("\nPress any key to exit...");
            Console.ReadLine();
        }

        static double ReadDouble(string message)
        {
            string line = "";
            double value;

            while (!double.TryParse(line, out value))
            {
                Console.Write(message);
                line = Console.ReadLine();
            }

            return value;
        }
    }
}
