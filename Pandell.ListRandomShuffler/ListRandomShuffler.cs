using System;
using System.Collections.Generic;

namespace Pandell.ListShuffler
{
    public class ListRandomShuffler
    {
        public static void InPlaceSuffle<T> (List<T> list)
        {
            // Durstenfeld's version of Fisher–Yates in place suffle
            // referrence at https://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            for (int i = 0; i < list.Count - 1; ++i)
            {
                int j = rand.Next(i, list.Count);
                T tmp = list[i];
                list[i] = list[j];
                list[j] = tmp;
            }
        }
    }
}
