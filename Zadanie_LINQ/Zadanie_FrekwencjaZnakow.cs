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

            StringBuilder outputString = new StringBuilder();

        BeginningOfSingleQuery:
            queryNumber--;

            //Input for single query
            char[] input = Console.ReadLine().ToLower().ToCharArray();
            if (input.Length > 1000) return;

            //Command array
            string query = Console.ReadLine();            
            string[] queryArray = query.Split(' ');

            //Main query (filling up the dictinary)
            var inputQuery = input
                .Select(x => CountChars(x));
            foreach (var x in inputQuery) { } //Use query to fill the dictionary

            var outputQuery = existingChars.Select(x => x);

            if (queryArray.Length == 6)
            {
                if (queryArray[4] == "byfreq" && queryArray[5] == "asc")
                    outputQuery = outputQuery.OrderBy(x => x.Value);
                else if (queryArray[4] == "byfreq" && queryArray[5] == "desc")
                    outputQuery = outputQuery.OrderByDescending(x => x.Value);
                else if (queryArray[4] == "byletter" && queryArray[5] == "asc")
                    outputQuery = outputQuery.OrderBy(x => x.Key);
                else if (queryArray[4] == "byletter" && queryArray[5] == "desc")
                    outputQuery = outputQuery.OrderByDescending(x => x.Key);
            }

            if (queryArray[2] == "byfreq" && queryArray[3] == "asc")
                outputQuery = outputQuery.OrderBy(x => x.Value);
            else if (queryArray[2] == "byfreq" && queryArray[3] == "desc")
                outputQuery = outputQuery.OrderByDescending(x => x.Value);
            else if (queryArray[2] == "byletter" && queryArray[3] == "asc")
                outputQuery = outputQuery.OrderBy(x => x.Key);
            else if (queryArray[2] == "byletter" && queryArray[3] == "desc")
                outputQuery = outputQuery.OrderByDescending(x => x.Key);


            if (queryArray[0] == "first")
                outputQuery = outputQuery.Take(int.Parse(queryArray[1]));
            else
                outputQuery = outputQuery.TakeLast(int.Parse(queryArray[1]));            

            foreach (var x in outputQuery)
                outputString.Append($"{x.Key} {x.Value}" + Environment.NewLine);

            existingChars.Clear();
            outputString.Append(Environment.NewLine);
            if (queryNumber > 0) goto BeginningOfSingleQuery;

            Console.WriteLine(outputString);
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
