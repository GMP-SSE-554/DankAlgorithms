using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DankAlgorithms.Algorithms;
using DankAlgorithms.Utilities;

namespace AlgorithmTests
{
    [TestClass]
    public class InsertionSortTest
    {
        [TestMethod]
        public void TestAccuracy()
        {
            int arraySize = 100;
            int[] testArray = RandomArray.GetRandomArray(arraySize, 0, 20000);

            int[] sortedArray = InsertionSort.Sort(testArray);
        }
    }
}
