using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_LINQ
{
    public static class ThenBy
    {
        public static void PseudoMain()
        {

        }

        public interface Name
        {
            string First { get; }
            string Middle { get; }
            string Last { get; }
        }

        public static class ThenBy1
        {
            // Return the provided list of names, ordered by Last, then
            // First, then Middle
            public static IEnumerable<Name> SortNames(IEnumerable<Name> names)
            {
                return names.OrderBy(x => x.Last).ThenBy(x => x.First).ThenBy(x => x.Middle);
            }
        }
    }
}
