using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_LINQ
{
    public static class SingleElementExcercise
    {
        public static void PseudoMain()
        {

        }

        // Return the first word with just one letter in it, out of a sequence of words.
        // There will always be at least one.
        public static string GetFirstSingleLetterWord(IEnumerable<string> words)
        {
            return words.First(val => val.Length == 1);
        }

        // Return the last word that contains the substring "her" in it.
        // There will always be at least one.
        public static string GetLastWordWithHerInIt(IEnumerable<string> words)
        {
            return words.Last(val => val.Contains("her"));
        }

        // Return the fifth word in the sequence, if there is one. If there are
        // fewer than 5 words, then return null.
        public static string GetFifthWordIfItExists(IEnumerable<string> words)
        {
            return words.ElementAtOrDefault(4);
        }

        // Return the last word in the sequence. If there are no words in
        // the sequence, return null.
        public static string GetLastWordIfAny(IEnumerable<string> words)
        {
            return words.LastOrDefault();
        }
    }
}
