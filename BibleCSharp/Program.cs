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

            Console.WriteLine("typeof");

            Console.WriteLine("CheckedUnchecked");

            Console.WriteLine("BitwiseComplement");

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
                case "typeof":
                    ClassTypeOf classTypeOf = new ClassTypeOf();
                    classTypeOf.MethodTypeOf();
                    break;
                case "checkedunchecked":
                    CheckedUnchecked.MathOperation();
                    break;
                case "bitwisecomplement":
                    General general3 = new General();
                    general3.BitwiseComplement();
                    break;
                case "exit":
                    Console.WriteLine("\n-------------------------\nGoodbye!");
                    break;
                default:
                    goto Menu;
            }
        }
    }

    public class ClassTypeOf
    {
        public void MethodTypeOf()
        {

            Console.WriteLine("The type of the variable is: {0}", typeof(int));

            Console.ReadKey();
        }
    }
}
