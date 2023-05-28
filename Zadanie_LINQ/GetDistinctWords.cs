using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_LINQ
{
    public static class GetDistinctWords
    {
        public static void PseudoMain()
        {

        }

        // Return all distinct words that have less than four letters in them.
        public static IEnumerable<string> GetDistinctShortWords(IEnumerable<string> words)
        {
            return words.Where(word => word.Length < 4).Distinct();
        }
    }
}
