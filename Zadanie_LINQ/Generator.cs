using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_LINQ
{
    internal class Generator
    {


        public static IEnumerable<int> LiczbyCalkowiteNaprzemiennie(int n)
        {
            if (n < 0) throw new ArgumentOutOfRangeException("n");

            var list = new List<int>();

            for (int i = 0; i <= n; i++)
            {
                int value = i;
                if (i % 2 == 0 && i > 1)
                    value *= -1;
                list.Add(value);
            }

            return list;
        }


    }
}
