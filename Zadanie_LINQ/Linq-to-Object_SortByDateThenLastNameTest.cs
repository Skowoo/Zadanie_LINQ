using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_LINQ
{
    internal class Linq_to_Object_SortByDateThenLastNameTest
    {
        static string SortByDateOfBirthThenLastName(string napis)
        {
            var query = napis.Split(';')
                          .Select(osoba => osoba.Trim())
                          .Select(osoba => osoba.Split(' ', StringSplitOptions.RemoveEmptyEntries))
                          .Select(x => (imie: x[0], nazwisko: x[1], data: x[2]))
                          .OrderBy(o => o.data)
                          .ThenBy(o => o.nazwisko)
                          .Select(o => o.imie + " " + o.nazwisko + " " + o.data);

            return String.Join("; ", query);
        }
    }
}
