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
            int[] testArray = { 2, 3, 5, 1, 4 };
            int[] sortedArray = BogoSort.Sort(testArray);
            Assert.AreEqual(sortedArray[0], 1);
        }
    }
}
