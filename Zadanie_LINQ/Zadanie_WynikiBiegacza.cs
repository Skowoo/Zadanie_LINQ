//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.CompilerServices;
//using System.Text;
//using System.Threading.Tasks;

//class Program
//{
//    public static TimeSpan previous;

//    static void Main(string[] args)
//    {
//        string testCase = Console.ReadLine();
//        string data = Console.ReadLine();

//        var singleLapTimes =
//            data.Split(',')
//            .Select(x => TimeSpan.Parse(x.Insert(0, "0:")))
//            .Select(x => OperationTest2(x))
//            ;

//        TimeSpan fastestLap = singleLapTimes.Min();
//        TimeSpan slowestLap = singleLapTimes.Max();

//        TimeSpan totalTime = data.Split(',')
//            .Select(x => TimeSpan.Parse(x.Insert(0, "0:")))
//            .Last();

//        TimeSpan averageLap = TimeSpan.FromSeconds(Math.Ceiling(totalTime.TotalSeconds / singleLapTimes.Count()));

//        switch (testCase)
//        {
//            case "test1": // Liczba okrążeń
//                Console.WriteLine(singleLapTimes.Count());
//                break;
//            case "test2": // wypisania sekwencji czasów kolejnych okrążeń
//                previous = TimeSpan.Zero;
//                string output2 = "";
//                foreach (var x in singleLapTimes)
//                    output2 += x.ToString("mm\\:ss") + " ";

//                Console.WriteLine(output2);
//                break;
//            case "test3": // wypisania czasu i numerów okrążeń najszybszych
//                string output3 = "";

//                if (singleLapTimes.Count() == 1)
//                {
//                    Console.WriteLine($"{TimeSpan.Parse("0:" + data).ToString("mm\\:ss")} 1");
//                    break;
//                }

//                int lapCounter = 0;
//                foreach (var x in singleLapTimes)
//                {
//                    lapCounter++;
//                    if (x == fastestLap)
//                        output3 += " " + lapCounter;
//                }
//                Console.WriteLine(fastestLap.ToString("mm\\:ss") + output3);

//                break;
//            case "test4": // wypisania czasu i numerów okrążeń najwolniejszych
//                string output4 = "";

//                if (singleLapTimes.Count() == 1)
//                {
//                    Console.WriteLine($"{TimeSpan.Parse("0:" + data).ToString("mm\\:ss")} 1");
//                    break;
//                }

//                int lapCounter2 = 0;
//                foreach (var x in singleLapTimes)
//                {
//                    lapCounter2++;
//                    if (x == slowestLap)
//                        output4 += " " + lapCounter2;
//                }

//                Console.WriteLine(slowestLap.ToString("mm\\:ss") + output4);
//                break;
//            case "test5": // obliczenia średniego czasu okrążenia
//                Console.WriteLine(averageLap.ToString("mm\\:ss"));
//                break;
//        }
//    }

//    public static TimeSpan OperationTest2(TimeSpan input)
//    {
//        TimeSpan output = input.Subtract(previous);
//        previous = input;
//        return output;
//    }
//}
