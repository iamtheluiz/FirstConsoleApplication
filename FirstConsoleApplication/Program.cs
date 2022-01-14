namespace FirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Data Types
             */

            // Text
            string text = "My name is Luiz";
            char grade = 'A';    // Single quote

            // Numbers
            int age = -20;
            float discount = 0.5F;    // Less precision
            double imc = 1.26;    // Medium precision
            decimal pi = 3.1415M;    // Greater precision

            // Logical
            bool isLogged = true;

            Console.WriteLine(text);
            Console.WriteLine("Grade: " + grade);
        }
    }
}