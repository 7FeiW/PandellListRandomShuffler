using System.Collections.Generic;
using System.Linq;

namespace Pandell.ListShufflers
{
    /// <summary>
    /// A Random Shuffled List Generator
    /// This Class is used to create a list of 10,000 numbers in random order each time it is run. Each number in the list must be unique and be between 1 and 10,000 (inclusive).
    /// </summary>
    public class RandomShuffledListGenerator
    {
        private const int m_DefaultListMin = 1;
        private const int m_DefaultListMax = 10000;

        public static List<int> GetShuffledIntListOneToTenThousand()
        {
            List<int> list = Enumerable.Range(m_DefaultListMin, m_DefaultListMax).ToList();
            ListRandomShuffler.InPlaceShuffle(list);
            return list;
        }
    }
}