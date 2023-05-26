using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_LINQ
{
    public static class LambdaExpressions
    {
        public static void MainMethod()
        {
            //----------Lambda expression----------
            //Anonymous function with one input an one output parameter
            Func<int, int> multiplyByFive = num => num * 5;
            Console.WriteLine(multiplyByFive(7));

            //Anonymous function with two input an one output parameter
            Func<int, int, int> multiplyTwoNumbers = (a, b) => a * b;
            Console.WriteLine(multiplyTwoNumbers(7, 5));

            //Anonymous function in written differently (with curly brackets and RETURN keyword
            Func<int, int> multiplyByFive2 = num =>
            {
                int product = num * 5;
                return product;
            };
            // Returns 35
            Console.WriteLine(multiplyByFive2(5));
        }
    }
}
