using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleCSharp
{
    public static class CheckedUnchecked
    {
        public static void MathOperation()
        {
            int int1 = 2_000_000_000;
            int int2 = 2_000_000_000;
            int int1PlusInt2;

            long int1L = 2_000_000_000;
            long int2L = 2_000_000_000;
            long int1PlusInt2L;

            try
            {
                int1PlusInt2 = int1 + int2;

                Console.WriteLine(int1PlusInt2);

                int1PlusInt2 = unchecked(int1 + int2);

                Console.WriteLine(int1PlusInt2);

                int1PlusInt2L = checked(int1L + int2L);

                Console.WriteLine(int1PlusInt2L);

                int1PlusInt2 = checked(int1 + int2);

                Console.WriteLine(int1PlusInt2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
