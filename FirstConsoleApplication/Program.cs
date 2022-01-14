namespace FirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Working with Strings
             */

            Console.WriteLine("=================");
            Console.WriteLine(" \"First\"\n Console\n Application");   // '\n' New line
            Console.WriteLine("=================\n");

            string text = "This Application" + " is COOL";  // Concat
            Console.WriteLine("Original Text: " + text);
            Console.WriteLine("First Character: " + text[0]);   // Get first character
            Console.WriteLine("Text Length: " + text.Length);   // String length
            Console.WriteLine("Lower Case: " + text.ToLower()); // To lower case
            Console.WriteLine("Upper Case: " + text.ToUpper()); // To upper case
            Console.WriteLine("Contains 'cool': " + text.ToLower().Contains("cool"));   // Contains

            // Locate string index inside a string
            Console.WriteLine("\"Application\" index:" + text.IndexOf("Application"));  // Success
            Console.WriteLine("\"Planning\" index:" + text.IndexOf("Planning"));    // "-1" = not found
            Console.WriteLine("Index 5 Substring: " + text.Substring(5));
            Console.WriteLine("Index 5 Substring with length 3: " + text.Substring(5, 3));
        }
    }
}