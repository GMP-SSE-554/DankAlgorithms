using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DankAlgorithms.Algorithms;
using DankAlgorithms.Utilities;

namespace AlgorithmTests
{
    [TestClass]
    public class BogoSortTest
    {
        [TestMethod]
        public void TestBogoAccuracy()
        {
            int[] testArray = { 3, 6, 2 };
            int[] sortedArray = BogoSort.Sort(testArray);
            Assert.IsTrue(ArrayUtils.IsSorted(sortedArray));
        }
    }
}
