using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DankAlgorithms.Algorithms;

namespace AlgorithmTests
{
    [TestClass]
    public class ParallelArrayAdditionTest
    {
        [TestMethod]
        public void TestParallelArrayAdditionAccuracy()
        {
            int[] ArrayA = { 1, 2, 3 };
            int[] ArrayB = { 1, 2, 3 };

            int[] OutputArray = ParallelArrayAddition.AddArrays(ArrayA, ArrayB);

            Assert.AreEqual(2, OutputArray[0]);
            Assert.AreEqual(4, OutputArray[1]);
            Assert.AreEqual(6, OutputArray[2]);
        }

    }
}
