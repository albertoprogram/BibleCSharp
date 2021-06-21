using System;

namespace BibleCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Begin:
            Console.WriteLine("\nHello, enter your name\n");

            string name = Console.ReadLine();

            Console.WriteLine("\n" + SimpleString.Welcome(name));

            Console.WriteLine("\nDo you wish to continue?");

            Console.WriteLine("\ntrue or false\n");

            bool decision;

            try
            {
                decision = Convert.ToBoolean(Console.ReadLine());
            }
            catch (Exception)
            {
                decision = false;
            }

            if (decision == true)
            {
                goto Begin;
            }

            Console.WriteLine("\n-------------------------\nGoodbye!");

            Console.ReadKey();
        }
    }
}
