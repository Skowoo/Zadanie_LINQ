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

        public static void Zadanie()
        {
            int queryNumber = Int32.Parse(Console.ReadLine());
            if (queryNumber < 1 | queryNumber > 100) return;

            //BeginningOfSingleQuery:
            queryNumber--;

            string input = Console.ReadLine().ToLower();
            if (input.Length > 1000) return;

            string query = Console.ReadLine();

            string[] queryArray = query.Split(' ');

            var inputQuery = input
                .Select(x => CountChars(x));

            foreach ( var x in existingChars)
                Console.WriteLine(existingChars.Keys);
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
