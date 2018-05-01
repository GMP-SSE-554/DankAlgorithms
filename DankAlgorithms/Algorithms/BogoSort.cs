using DankAlgorithms.Utilities;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DankAlgorithms.Algorithms
{
    public class BogoSort
    {
        private static CancellationTokenSource _cts;

        /// <summary>
        /// Starts an asyncronous sorting task.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="cts">The CTS.</param>
        /// <returns></returns>
        public static Task SortAsync(int[] array, CancellationTokenSource cts)
        {
            return Task.Run(() =>
            {
                _cts = cts;
                return Sort(array);
            }, cts.Token);
        }

        /// <summary>
        /// Sorts an array of ints using bogo algorithm
        /// </summary>
        /// <param name="inputArray"></param>
        /// <returns></returns>
        public static int[] Sort(int[] inputArray)
        {
            int[] temp = inputArray;
            while (!ArrayUtils.IsSorted(temp))
            {
                _cts?.Token.ThrowIfCancellationRequested();
                Shuffle(temp);
            }
            return temp;
        }

        /// <summary>
        /// Shuffles the specified input array.
        /// </summary>
        /// <param name="inputArray">The input array.</param>
        /// <returns></returns>
        private static int[] Shuffle(int[] inputArray)
        {
            Random rnd = new Random();
            int[] newArray = inputArray.OrderBy(x => rnd.Next()).ToArray();
            return newArray;
        }
    }
}
