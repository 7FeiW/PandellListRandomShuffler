using System;
using Pandell.ListShufflers;

namespace Pandell.RandomShuffledListGeneratorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
             var shuffledList = RandomShuffledListGenerator.GetShuffledIntListOneToTenThousand();
             foreach (var num in shuffledList)
             {
                 Console.WriteLine(num);
             }
             Console.ReadKey();
        }
    }
}
