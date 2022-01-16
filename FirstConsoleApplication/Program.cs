namespace FirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int selectedApp = 0;

            Console.WriteLine("|============================|");
            Console.WriteLine("|=     C# Console Apps      =|");
            Console.WriteLine("|============================|");
            Console.WriteLine("| Select a app to run:");
            Console.WriteLine("| * 1 - Guessing Game");
            Console.WriteLine("| * 2 - Pythagorean Theorem");
            Console.WriteLine("| * 3 - Tone Shifter");

            Console.Write("| > ");
            selectedApp = Convert.ToInt16(Console.ReadLine());

            if (selectedApp == 1)
            {
                GuessingGame app = new();
                app.Run();
            } else if (selectedApp == 2)
            {
                PythagoreanTheorem.Run();
            }
            else if (selectedApp == 3)
            {
                ToneShifter.Run();
            }
        }
    }
}