using System;
using Pandell.ListShufflers;

namespace Pandell.RandomShuffledListGeneratorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
             var shuffledList = RandomShuffledListGenerator.GetShuffledList();
             foreach (var num in shuffledList)
             {
                 Console.WriteLine(num);
             }
        }
    }
}
