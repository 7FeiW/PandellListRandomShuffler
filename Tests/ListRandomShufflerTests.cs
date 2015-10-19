using System.Collections.Generic;
using NUnit.Framework;
using Pandell.ListShufflers;
using System.Linq;

namespace Pandell.Tests
{
    [TestFixture]
    public class ListRandomShufflerTests
    {
        [Test]
        public void RandomShufflerHandleEmptyList()
        {
            var list = new List<int>(10);
            ListRandomShuffler.InPlaceShuffle(list);
        }

        [Test]
        public void RandomShufflerHandleZeroSizeList()
        {
            var list = new List<int>();
            ListRandomShuffler.InPlaceShuffle(list);
        }

        [Test]
        public void RandomShufflerShouldNotChangeContentOtherThanOrder()
        {
            int listSize = 10000;
            var list = Enumerable.Range(1, listSize).ToList();
            var listClone = new List<int>(list);
            ListRandomShuffler.InPlaceShuffle(list);

            var dupCount = list.Intersect(listClone).ToList().Count;
            Assert.AreEqual(dupCount, listSize);

            bool hasDifference = list.Except(listClone).ToList().Any();
            Assert.IsFalse(hasDifference);
        }
    }
}