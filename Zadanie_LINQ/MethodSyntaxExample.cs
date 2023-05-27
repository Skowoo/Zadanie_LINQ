using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_LINQ
{
    public static class MethodSyntaxExample
    {
        public static void PseudoMain()
        {
            //----------------------------------Example from tutorial:
            List<string> animalNames = new List<string> { "fawn", "gibbon", "heron", "ibex", "jackalope" };

            foreach (var animal in animalNames)
                Console.WriteLine(animal);

            IEnumerable<string> longAnimalNames =
                animalNames
                .Where(name => name.Length >= 5)
                .OrderBy(name => name.Length);

            foreach (var animal in longAnimalNames)
                Console.WriteLine(animal);


            //----------------------------------own example with function:
            string[] lista = { "foo", "bar", "baz", "sra", "gra" };
            foreach (string s in lista) Console.WriteLine(s);
            Console.WriteLine("\n");
            var lista2 = FilterAndSort(lista, "ba");
            foreach (string s in lista2) Console.WriteLine(s);
        }

        public static IEnumerable<string> FilterAndSort(IEnumerable<string> inValues, string pattern)
        {
            return inValues
                .Where(value => value.Contains(pattern))
                .OrderBy(value => value)
                ;
        }
    }
}
