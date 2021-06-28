using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleCSharp
{
    public static class SpecialCharacters
    {
        public static void ExamplesOfSpecialCharacters()
        {
        Begin:

            Console.WriteLine("Welcome to SpecialCharacters");

            Console.ReadKey();

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
            else if (decision == false)
            {
                Program.MainMenu();
            }
        }
    }
}
