using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_LINQ
{
    public static class Zadanie_PlytaCD
    {
        public static void Metoda()
        {
            //string input = Console.ReadLine();
            string input = "1:01,2:20,3:10,59:59";

            var inputQuery =
                input.Split(',')
                .Select(x => TimeSpan.Parse(x.Insert(0, "0:")));

            int tracksCount = inputQuery.Count();

            TimeSpan totalTime = inputQuery.Aggregate(new TimeSpan(), (total, songTime) => total.Add(songTime));
            TimeSpan roundedTotalTime = TimeSpan.FromSeconds(Math.Ceiling(totalTime.TotalSeconds));

            TimeSpan roundedAverageTrack = TimeSpan.FromSeconds(Math.Ceiling(totalTime.TotalSeconds / tracksCount));

            // :)
            if (roundedTotalTime.TotalMinutes < 60)
                Console.WriteLine($"{tracksCount} {roundedAverageTrack.ToString("m':'ss")} {roundedTotalTime.ToString("m':'ss")}");
            else
                Console.WriteLine($"{tracksCount} {roundedAverageTrack.ToString("m':'ss")} {roundedTotalTime.ToString("g")}");
        }
    }
}
