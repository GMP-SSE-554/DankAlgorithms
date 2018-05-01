using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DankAlgorithms.Algorithms;

namespace AlgorithmTests
{
    [TestClass]
    public class ReductionSumTest
    {
        [TestMethod]
        public void TestReductionSumAccuracy()
        {
            int[] inputArray = { 1, 2, 3, 4, 5 };

            Assert.AreEqual(15, ReductionSum.Sum(inputArray));
        }
    }
}
