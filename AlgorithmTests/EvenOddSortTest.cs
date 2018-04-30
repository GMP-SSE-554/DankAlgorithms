using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DankAlgorithms.Algorithms;
using DankAlgorithms.Utilities;

namespace AlgorithmTests
{
    [TestClass]
    public class EvenOddSortTest
    {
        [TestMethod]
        public void TestAccuracy()
        {
            int arraySize = 100;
            int[] testArray = RandomArray.GetRandomArray(arraySize, 0, 20000);

            int[] sortedArray = InsertionSort.Sort(testArray);
            Assert.IsTrue(ArrayUtils.IsSorted(sortedArray));
        }

        [TestMethod]
        public void OriginalArrayUnmodified()
        {
            int arraySize = 100;
            int[] testArray = RandomArray.GetRandomArray(arraySize, 0, 20000);
            int[] copyArray = new int[arraySize];
            testArray.CopyTo(copyArray, 0);

            int[] sortedArray = InsertionSort.Sort(testArray);
            for (int i = 0; i < arraySize; i++)
            {
                Assert.IsTrue(testArray[i] == copyArray[i]);
            }
        }
    }
}
