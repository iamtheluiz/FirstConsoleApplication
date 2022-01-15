namespace FirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Methods
             */
            SayHi("Luiz");
            SayHi("Maria", true);
            SayHi("Balog");
            SayHi("Bolize", true);
            SayHi("Sara", true);

            Console.ReadLine();
        }

        static void SayHi(string name, bool hug = false)
        {
            Console.Write("Hello "+name+ "!\n");
            if (hug == true)
            {
                Console.WriteLine(" |-> You've been hugged!");
            }
        }
    }
}