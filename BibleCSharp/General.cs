﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleCSharp
{
    public class General
    {
        public string MyCharacter()
        {
            char myCharacter;

            string myString = "Hello from C#";

            myCharacter = myString[11];

            return myCharacter.ToString();
        }

        private enum Pizza
        {
            Supreme,
            MeatLovers,
            CheeseLovers,
            Vegetable
        }

        public void EnumPizza()
        {
            Console.WriteLine("CodPizza:{0} - {1}",(int)Pizza.CheeseLovers,Pizza.CheeseLovers);

            Console.ReadKey();
        }
    }
}