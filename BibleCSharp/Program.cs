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

            Console.WriteLine("1) SimpleString");

            Console.WriteLine("2) SpecialCharacters");

            Console.WriteLine("3) MyCharacter");

            Console.WriteLine("4) EnumPizza");

            Console.WriteLine("5) typeof");

            Console.WriteLine("6) CheckedUnchecked");

            Console.WriteLine("7) BitwiseComplement");

            Console.WriteLine("8) IncreaseDecrease");

            Console.WriteLine("9) Conditional Logical Operator");

            Console.WriteLine("10) Output Parameter");

            Console.WriteLine("11) Exponentiation");

            Console.WriteLine("\nType '0' to finish\n");

            int selectedOption = Convert.ToInt32(Console.ReadLine());

            switch (selectedOption)
            {
                case 1:
                    SimpleString.Welcome();
                    break;
                case 2:
                    SpecialCharacters.ExamplesOfSpecialCharacters();
                    break;
                case 3:
                    General general = new General();
                    string messageFromClass = general.MyCharacter();
                    Console.WriteLine(messageFromClass);
                    Console.ReadKey();
                    break;
                case 4:
                    General general2 = new General();
                    general2.EnumPizza();
                    break;
                case 5:
                    ClassTypeOf classTypeOf = new ClassTypeOf();
                    classTypeOf.MethodTypeOf();
                    break;
                case 6:
                    CheckedUnchecked.MathOperation();
                    break;
                case 7:
                    General general3 = new General();
                    general3.BitwiseComplement();
                    break;
                case 8:
                    General general4 = new General();
                    general4.IncreaseDecrease();
                    break;
                case 9:
                    General general5 = new General();
                    general5.ConditionalLogicalOperator();
                    break;
                case 10:
                    General general6 = new General();
                    string outputParameter;
                    general6.OutputParameterMethod(out outputParameter);
                    Console.WriteLine(outputParameter);
                    Console.ReadKey();
                    break;
                case 11:
                    General general1 = new General();
                    double result;
                    general1.Exponentiation(5, 3, out result);
                    Console.WriteLine(result);
                    Console.ReadKey();
                    break;
                case 0:
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
