using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_LINQ
{
    public static class TakeSkipWhileExcercise
    {
        public static void PseudoMain()
        {
            string[] list = { "One", "start", "more", "end", "thing" };
            var done = GetStartThroughEnd(list);
            foreach ( var item in done ) { Console.WriteLine(item); }
        }

        // Return all words in the sequence between "start" (inclusive)
        // and "end" (non-inclusive)
        // For example, if given { "One", "start", "more", "end", "thing" } ...
        // this method should return { "start", "more" }
        public static IEnumerable<string> GetStartThroughEnd(IEnumerable<string> words)
        {
            return words.SkipWhile(wd => wd != "start").TakeWhile(wd => wd != "end");
        }
    }
}
