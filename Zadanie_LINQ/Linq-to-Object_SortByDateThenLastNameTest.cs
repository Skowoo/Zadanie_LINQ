using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_LINQ
{
    public class Linq_to_Object_SortByDateThenLastNameTest
    {
        public static string SortByDateOfBirthThenLastName(string napis)
        {
            var zapytanie = napis.Split(';')
                          .Select(obj => obj.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries))
                          .Select(obj => (name: obj[0], sname: obj[1], date: obj[2]))
                          .OrderBy(obj => obj.date).ThenBy(obj => obj.sname)
                          .Select(obj => obj.name + " " + obj.sname + " " + obj.date);

            string result = "";
            foreach (string osoba in zapytanie)
                result += "; " + osoba;
            return result.Remove(0, 2);
        }

        ////Origyniał:
        
        //static string SortByDateOfBirthThenLastName(string napis)
        //{
        //    var query = napis.Split(';')
        //                  .Select(osoba => osoba.Trim())
        //                  .Select(osoba => osoba.Split(' ', StringSplitOptions.RemoveEmptyEntries))
        //                  .Select(x => (imie: x[0], nazwisko: x[1], data: x[2]))
        //                  .OrderBy(o => o.data)
        //                  .ThenBy(o => o.nazwisko)
        //                  .Select(o => o.imie + " " + o.nazwisko + " " + o.data);

        //    return String.Join("; ", query);
        //}

    }
}
