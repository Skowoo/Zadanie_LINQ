using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_LINQ
{
    public static class OrderByExcercise
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

        public static class OrderBy1
        {
            // Return the provided list of names, ordered by Last, in
            // descending order.
            public static IEnumerable<Name> SortNames(IEnumerable<Name> names)
            {
                return names.OrderBy(name => name.Last).Reverse();
            }
        }
    }
}
