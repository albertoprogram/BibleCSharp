using System;

namespace BibleCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, enter your name\n");

            string name = Console.ReadLine();

            Console.WriteLine("\n" + SimpleString.Welcome(name));

            Console.WriteLine("\n\nPress a key, please");

            Console.ReadKey();

            Console.WriteLine("\n-------------------------\nGoodbye!");

            Console.ReadKey();
        }
    }
}
