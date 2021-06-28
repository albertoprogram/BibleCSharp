using System;

namespace BibleCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        public static void MainMenu()
        {
        Menu:
            Console.WriteLine("\nWelcome! Enter the command of the program you want to run:\n");

            Console.WriteLine("SimpleString");

            Console.WriteLine("SpecialCharacters");

            Console.WriteLine("\nType 'Exit' to finish\n");

            string selectedOption = Console.ReadLine().ToLower();

            switch (selectedOption)
            {
                case "simplestring":
                    SimpleString.Welcome();
                    break;
                case "specialcharacters":
                    SpecialCharacters.ExamplesOfSpecialCharacters();
                    break;
                case "exit":
                    Console.WriteLine("\n-------------------------\nGoodbye!");
                    break;
                default:
                    goto Menu;
            }

            Console.ReadKey();
        }
    }
}
