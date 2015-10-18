using System;
using System.Collections.Generic;
using System.Linq;
using Pandell.ListShuffler;

namespace Pandell
{
    class Program
    {
        static void Main(string[] args)
        {
             var shuffledList = RandomShuffledListGenerator.GetShuffledList();
             foreach (var i in shuffledList)
             {
                 Console.WriteLine(i);
             }
        }

        static void GetFreqenceStd()
        {
            int listSize = 10;
            var counts = Enumerable.Repeat(0, listSize * listSize).ToList();
            for (var i = 0; i < listSize * 1000; ++i)
            {
                var shuffledList = Enumerable.Range(0, listSize).ToList();
                ListRandomShuffler.InPlaceSuffle(shuffledList);//RandomShuffledListGenerator.GetShuffledList();
                for (var j = 0; j < shuffledList.Count; ++j)
                {
                    counts[listSize * j + shuffledList[j]] += 1;
                }
            }
            double avg = counts.Average();
            var std = Math.Sqrt(counts.Average(v => Math.Pow(v - avg, 2)));

            return std;
        }

    }
}
