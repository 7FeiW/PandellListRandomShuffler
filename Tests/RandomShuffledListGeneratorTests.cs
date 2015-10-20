using NUnit.Framework;
using Pandell.ListShufflers;
using System.Linq;

namespace Pandell.Tests
{
    /// <summary>
    /// Unit Tests for RandomShuffledListGenerator
    /// </summary>
    [TestFixture]
    public class RandomShuffledListGeneratorTests
    {
        private int m_ExpectedListSize = 10000;
        private int m_ExpectedItemMin = 1;
        private int m_ExpectedItemMax = 10000;

        [Test]
        public void ShuffledListSizeShouldBeTenThousand()
        {
            var listSize = RandomShuffledListGenerator.GetShuffledIntListOneToTenThousand().Count;
            Assert.AreEqual(m_ExpectedListSize, listSize);
        }

        [Test]
        public void EachItemInShuffledListShouldBeWithinRange()
        {
            var shuffledList = RandomShuffledListGenerator.GetShuffledIntListOneToTenThousand();
            var min = shuffledList.Max();
            var max = shuffledList.Min();
            Assert.LessOrEqual(m_ExpectedItemMin, min);
            Assert.LessOrEqual(max, m_ExpectedItemMax);
        }

        [Test]
        public void EachItemInShuffledListShouldBeUnique()
        {
            var shuffledList = RandomShuffledListGenerator.GetShuffledIntListOneToTenThousand();
            Assert.AreEqual(shuffledList.Count, shuffledList.Distinct().Count());
        }
    }
}
