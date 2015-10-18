using NUnit.Framework;
using Pandell.ListShuffler;
using System.Linq;

namespace Pandell.Tests
{
    [TestFixture]
    public class RandomShuffledListGeneratorTests
    {
        private int m_ExpectedListSize = 10000;
        private int m_ExpectedItemMin = 1;
        private int m_ExpectedItemMax = 10000;

        [Test]
        public void ShuffledListSizeShouldBeTenThousand()
        {
            var listSize = RandomShuffledListGenerator.GetShuffledList().Count;
            Assert.AreEqual(m_ExpectedListSize, listSize);
        }

        [Test]
        public void EachItemInShuffledListShouldBeWithinRange()
        {
            var shuffledList = RandomShuffledListGenerator.GetShuffledList();
            var min = shuffledList.Max();
            var max = shuffledList.Min();
            Assert.LessOrEqual(m_ExpectedItemMin, min);
            Assert.LessOrEqual(max, m_ExpectedItemMax);
        }

        [Test]
        public void EachItemInShuffledListShouldBeUnique()
        {
            var shuffledList = RandomShuffledListGenerator.GetShuffledList();
            Assert.AreEqual(shuffledList.Count, shuffledList.Distinct().Count());
        }
    }
}
