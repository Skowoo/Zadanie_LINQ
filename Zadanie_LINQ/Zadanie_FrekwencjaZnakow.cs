using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_LINQ
{
    public class Zadanie_FrekwencjaZnakow
    {
        public static Dictionary<char, int> existingChars = new Dictionary<char, int>();

        public static void Main()
        {
            int queryNumber = Int32.Parse(Console.ReadLine());
            if (queryNumber < 1 | queryNumber > 100) return;

            BeginningOfSingleQuery:
            queryNumber--;

            char[] input = Console.ReadLine().ToLower().ToCharArray();
            if (input.Length > 1000) return;

            string query = Console.ReadLine();

            string[] queryArray = query.Split(' ');

            var inputQuery = input
                .Select(x => CountChars(x));

            foreach (var x in inputQuery) { } //Use query to fill the dictionary

            //foreach (var x in existingChars)
            //    Console.WriteLine($"{x.Key} {x.Value}");



            //first 3 byfreq asc byletter asc

            var outputQuery = existingChars.Select(x => x);

            if (queryArray.Length == 4)
            {
                if (queryArray[2] == "byfreq" && queryArray[3] == "asc")
                    outputQuery = outputQuery.OrderBy(x => x.Value);
                else if (queryArray[2] == "byfreq" && queryArray[3] == "desc")
                    outputQuery = outputQuery.OrderByDescending(x => x.Value);
                else if (queryArray[2] == "byletter" && queryArray[3] == "asc")
                    outputQuery = outputQuery.OrderBy(x => x.Key);
                else if (queryArray[2] == "byletter" && queryArray[3] == "desc")
                    outputQuery = outputQuery.OrderByDescending(x => x.Key);
            }

            if (queryArray[0] == "first")
                outputQuery = outputQuery.Take(int.Parse(queryArray[1]));
            else
                outputQuery = outputQuery.TakeLast(int.Parse(queryArray[1]));


            foreach (var x in outputQuery)
                Console.WriteLine($"{x.Key} {x.Value}");

            existingChars.Clear();
            if (queryNumber > 0) goto BeginningOfSingleQuery;
        }

        public static char CountChars(char input)
        {
            if (existingChars.Keys.Contains(input))
                existingChars[input]++;
            else if (Char.IsLetter(input))
                existingChars.Add(input, 1);

            return input;
        }
    }
}
