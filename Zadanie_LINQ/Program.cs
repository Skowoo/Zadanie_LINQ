namespace Zadanie_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lista = {"foo", "bar", "baz", "sra", "gra"};
            Console.WriteLine(FilterAndSort(lista, "ba").ToList());
        }

        public static IEnumerable<string> FilterAndSort(IEnumerable<string> inValues, string pattern)
        {
            return inValues
                .Where(inValues => inValues.Contains(pattern))
                .OrderBy(inValues => inValues)
                ;
        }
    }
}