namespace FirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Arrays
             */
            string[] musics = {
                "Hated by life itself",
                "Remember When",
                "Antes das Seis",
                "Você pra sempre em mim"
            };

            Console.WriteLine("|=============================|");
            Console.WriteLine("|=      Favorite Musics      =|");
            Console.WriteLine("|=============================|");

            // Show all musics
            for (int i = 0; i < musics.Length; i++)
            {
                Console.WriteLine("|= " + (i+1) + " - " + musics[i]);
            }
            Console.WriteLine("|=============================|");
        }
    }
}