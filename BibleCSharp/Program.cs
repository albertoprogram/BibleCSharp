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

            Console.WriteLine("MyCharacter");

            Console.WriteLine("EnumPizza");

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
                case "mycharacter":
                    General general = new General();
                    string messageFromClass = general.MyCharacter();
                    Console.WriteLine(messageFromClass);
                    Console.ReadKey();
                    break;
                case "enumpizza":
                    General general2 = new General();
                    general2.EnumPizza();
                    break;
                case "exit":
                    Console.WriteLine("\n-------------------------\nGoodbye!");
                    break;
                default:
                    goto Menu;
            }
        }
    }
}
