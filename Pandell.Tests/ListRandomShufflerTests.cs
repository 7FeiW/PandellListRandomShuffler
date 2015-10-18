using System;
using System.Collections.Generic;
using NUnit.Framework;
using Pandell.ListShuffler;
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
            ListRandomShuffler.InPlaceSuffle(list);
        }

        [Test]
        public void RandomShufflerHandleZeroSizeList()
        {
            var list = new List<int>();
            ListRandomShuffler.InPlaceSuffle(list);
        }

        [Test]
        public void RandomShufflerShouldNotChangeContentOtherThanOrder()
        {
            int listSize = 10000;
            var list = Enumerable.Range(1, listSize).ToList();
            var listClone = new List<int>(list);
            ListRandomShuffler.InPlaceSuffle(list);

            var dupCount = list.Intersect(listClone).ToList().Count;
            Assert.AreEqual(dupCount, listSize);

            bool hasDifference = list.Except(listClone).ToList().Any();
            Assert.IsFalse(hasDifference);
        }
    }
}