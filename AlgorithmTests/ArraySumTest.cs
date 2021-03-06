﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DankAlgorithms.Algorithms;

namespace AlgorithmTests
{
    [TestClass]
    public class ArraySumTest
    {
        [TestMethod]
        public void TestArraySumAccuracy()
        {
            int[] inputArray = { 1, 2, 3, 4, 5 };

            Assert.AreEqual(15, ArraySum.Sum(inputArray));
        }
    }
}
