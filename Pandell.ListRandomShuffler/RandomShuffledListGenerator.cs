using System.Collections.Generic;
using System.Linq;

namespace Pandell.ListShuffler
{
    public class RandomShuffledListGenerator
    {
        private const int m_DefaultListMin = 1;
        private const int m_DefaultListMax = 10000;

        public static List<int> GetShuffledList()
        {
            List<int> list = Enumerable.Range(m_DefaultListMin, m_DefaultListMax).ToList();
            ListRandomShuffler.InPlaceSuffle(list);
            return list;
        }
    }
}