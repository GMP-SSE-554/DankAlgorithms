
using DankAlgorithms.Utilities;
using System;
using System.Linq;

namespace DankAlgorithms.Algorithms
{
    public class BogoSort
    {
        /// <summary>
        /// Sorts an array of ints using bogo algorithm
        /// </summary>
        /// <param name="inputArray"></param>
        /// <returns></returns>
        public static int[] Sort(int[] inputArray)
        {
            int[] temp = inputArray;
            while (!ArrayUtils.IsSorted(temp))
                Shuffle(temp);
            return temp;
        }

        private static int[] Shuffle(int[] inputArray)
        {
            Random rnd = new Random();
            int[] newArray = inputArray.OrderBy(x => rnd.Next()).ToArray();
            return newArray;
        }
    }
}
