using System;
using System.Collections.Generic;

namespace Pandell.ListShufflers
{
    /// <summary>
    /// A List Random Shuffler
    /// This Class is used to perform inplace random shuffle of a given list
    /// </summary>
    public class ListRandomShuffler
    {
        public static void InPlaceShuffle<T> (List<T> list)
        {
            // Durstenfeld's version of Fisher–Yates in place shuffle
            // referrence at https://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            for (int i = 0; i < list.Count - 1; ++i)
            {
                int j = rand.Next(i, list.Count);
                var tmp = list[i];
                list[i] = list[j];
                list[j] = tmp;
            }
        }
    }
}
