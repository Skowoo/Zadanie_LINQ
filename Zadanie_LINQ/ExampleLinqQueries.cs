using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_LINQ
{
    public static class ExampleLinqQueries
    {
        public static void FirstWay() 
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string s = "Krzysztof Molenda,  Jan Kowalski, Anna Abacka , Józef Kabacki, Kazimierz Moksa";

            var query = s.Split(',')                                    //rozbijamy na osoby -> tablica napisów
                          .Select(osoba => osoba.Trim())              //usuwamy spacje
                          .Select(osoba => osoba.Split(' '))          //rozbijamy na wyrazy -> sekwencja tablic 2-elementowych
                          .Select(x => (imie: x[0], nazwisko: x[1]))  //sekwencja obiektów anonimowych (imie, nazwisko)
                          .OrderBy(o => o.nazwisko)                   //sortujemy wg nazwiska,
                          .ThenBy(o => o.imie)                        //... a następnie wg imienia
                          .Select(o => o.imie + " " + o.nazwisko);    //sekwencja naspisów postaci imie-spacja-nazwisko

            string wynik = String.Join(", ", query);                    //łączymy sekwencję z przecinkami
            Console.WriteLine(wynik);
        }

        public static void SecondWay()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string s = "Krzysztof Molenda,  Jan Kowalski, Anna Abacka , Józef Kabacki, Kazimierz Moksa";

            var query = s.Split(',')
                         .Select(x => x.Trim())
                         .Select(x => x.Split(' '));
            //.Select( x => (imie: x[0], nazwisko: x[1]) ) ;

            var query1 =
                from osoba in query
                let imie = osoba[0]
                let nazwisko = osoba[1]
                orderby nazwisko, imie
                select new { imie, nazwisko };

            //string wynik = "";
            //foreach( var osoba in query1 )
            //    wynik += osoba.imie + " " + osoba.nazwisko + ", ";

            string wynik = String.Join(", ", query1.Select(o => o.imie + " " + o.nazwisko));
            Console.WriteLine(wynik);
        }
    }
}
