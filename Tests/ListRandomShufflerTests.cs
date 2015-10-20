using System.Collections.Generic;
using NUnit.Framework;
using Pandell.ListShufflers;
using System.Linq;

namespace Pandell.Tests
{
    /// <summary>
    /// Unit Tests for List Random Shuffler
    /// Note, those test wil NOT prove this shuffler is fully randomiazed, for this part please refer to  https://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle
    /// </summary>
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
        public void RandomShufflerHandleNullAbleList()
        {
            const int expectedNumOfNull = 3;
            const int expectedNumOfOne = 1;

            var list = new List<int?>() { null, null, 1, null};
            ListRandomShuffler.InPlaceShuffle(list);

            var numOfNull = list.Count(i => i == null);
            var numOfOne = list.Count(i => i == 1);
            Assert.AreEqual(numOfNull, expectedNumOfNull);
            Assert.AreEqual(numOfOne, expectedNumOfOne);
        }

        [Test]
        public void RandomShufflerHandleNullAbleRefferenceTypeList()
        {
            const int expectedNumOfNull = 3;
            const int expectedNumOfStr = 1;
            const string str = "This is not null";

            var list = new List<string>() { null, null, str, null };
            ListRandomShuffler.InPlaceShuffle(list);

            var numOfNull = list.Count(i => i == null);
            var numOfStr = list.Count(i => i == str);
            Assert.AreEqual(numOfNull, expectedNumOfNull);
            Assert.AreEqual(numOfStr, expectedNumOfStr);
        }

        [Test]
        public void RandomShufflerShouldNotChangeContentOtherThanOrder()
        {
            const int listSize = 10000;
            var list = Enumerable.Range(1, listSize).ToList();
            var listClone = new List<int>(list);
            ListRandomShuffler.InPlaceShuffle(list);

            var dupCount = list.Intersect(listClone).ToList().Count;
            Assert.AreEqual(dupCount, listSize);

            bool hasDifference = list.Except(listClone).ToList().Any();
            Assert.IsFalse(hasDifference);
        }

        /// <summary>
        /// Use List of String as input, because string is referrence type this test should prove if random shuffle function work well with referrence type
        /// </summary>
        [Test]
        public void RandomShufflerShouldNotChangeStringListContentOtherThanOrder()
        {
            const int listSize = 4;
            var list = new List<string>()
            {
                "This",
                "is",
                "a",
                "Test"
            };
            var listClone = new List<string>(list);
            ListRandomShuffler.InPlaceShuffle(list);

            var dupCount = list.Intersect(listClone).ToList().Count;
            Assert.AreEqual(dupCount, listSize);

            bool hasDifference = list.Except(listClone).ToList().Any();
            Assert.IsFalse(hasDifference);
        }
    }
}