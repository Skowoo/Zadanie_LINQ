using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_LINQ
{
    public static class Aggregate
    {
        public static void PseudoMain()
        {
            string[] input = { "abcd", "abcde", "abcdef" };
            Console.WriteLine(TotalCharactersInSequence(input));
        }

        public static int TotalCharactersInSequence(IEnumerable<string> words)
        {
            return words.Aggregate(0, (charCounter, wordFromArray) => charCounter + wordFromArray.Length);
        }
    }
}
