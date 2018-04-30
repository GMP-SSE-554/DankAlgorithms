using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DankAlgorithms.Utilities
{
    public static class RandomArray
    {
        /// <summary>
        /// Gets an array of random integers between min and max, inclusive..
        /// </summary>
        /// <param name="numElements">The number elements.</param>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <returns></returns>
        public static int[] GetRandomArray(int numElements, int min, int max)
        {
            Random random = new Random();
            int[] array = Enumerable.Repeat(0, numElements).
                Select(i => random.Next(min, max + 1)).ToArray();
            return array;
        }
    }
}
