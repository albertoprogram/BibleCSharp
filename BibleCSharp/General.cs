using System;
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
            Console.WriteLine("CodPizza:{0} - {1}", (int)Pizza.CheeseLovers, Pizza.CheeseLovers);

            Console.ReadKey();
        }

        public void BitwiseComplement()
        {
            int int1 = 123;

            Console.WriteLine(int1);

            int1 = ~int1;

            Console.WriteLine(int1);

            Console.ReadKey();
        }

        public void IncreaseDecrease()
        {
            int int1 = 123;

            Console.WriteLine(int1++); // print 123
            Console.WriteLine(++int1); // print 125

            Console.ReadKey();
        }

        public void ConditionalLogicalOperator()
        {
            int intVar = 5;

            Console.WriteLine("The value: {0}", (intVar == 5) ? "Is 5" : "Is not 5");

            Console.WriteLine("The value: {0}", (intVar == 3) ? "Is 3" : "Is not 3");

            Console.ReadKey();
        }

        public void OutputParameterMethod(out string outputParameter)
        {
            outputParameter = "Output Parameter";
        }

        public void Exponentiation(double numberBase,double power,out double number)
        {
            number = Math.Pow(numberBase, power);
        }
    }
}
