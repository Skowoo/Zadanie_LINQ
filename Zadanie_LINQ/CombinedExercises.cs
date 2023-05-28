using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_LINQ
{
    public static class CombinedExercises
    {
        public static void PseudoMain()
        {

        }

        // The following method should return true if each element in the squares sequence
        // is equal to the square of the corresponding element in the numbers sequence.
        // Try to write the entire method using only LINQ method calls, and without writing
        // any loops.
        public static bool TestForSquares(IEnumerable<int> numbers, IEnumerable<int> squares)
        {
            return numbers
                .Select(x => x * x)
                .SequenceEqual(squares)
                ;
        }

        // Given a sequence of words, get rid of any that don't have the character 'e' in them,
        // then sort the remaining words alphabetically, then return the following phrase using
        // only the final word in the resulting sequence:
        //    -> "The last word is <word>"
        // If there are no words with the character 'e' in them, then return null.
        //
        // TRY to do it all using only LINQ statements. No loops or if statements.
        public static string GetTheLastWord(IEnumerable<string> words)
        {
            return words
                .Where(x => x.Contains("e"))
                .OrderBy(x => x)
                .Select(x => x.Insert(0, "The last word is "))
                .LastOrDefault()
                ;
        }
    }
}
