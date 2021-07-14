using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleCSharp
{
    public static class SimpleString
    {
        public static void Welcome()
        {
        Begin:

            Console.WriteLine("\nHello, enter your name\n");

            string name = Console.ReadLine();

            Console.WriteLine("\n" + "Welcome " + '\'' + name + '\'' + "!");

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
