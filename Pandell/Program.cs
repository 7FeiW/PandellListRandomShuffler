using System;
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
    }
}
