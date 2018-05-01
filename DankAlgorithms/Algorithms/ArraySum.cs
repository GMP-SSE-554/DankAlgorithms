using System;
using System.Threading;
using System.Threading.Tasks;

namespace DankAlgorithms.Algorithms
{
    public static class ArraySum
    {
        private static CancellationTokenSource _cts;

        /// <summary>
        /// Sums the array data asynchronously.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="cts">The CTS.</param>
        /// <returns></returns>
        public static Task SumAsync(int[] array, CancellationTokenSource cts)
        {
            return Task.Run(() =>
            {
                _cts = cts;
                return Sum(array);
            }, cts.Token);
        }

        /// <summary>
        /// Sums the specified input array.
        /// </summary>
        /// <param name="inputArray">The input array.</param>
        /// <returns></returns>
        public static int Sum(int[] inputArray)
        {
            int sum = 0;
            try
            {
                for (int i = 0; i < inputArray.Length; i++)
                {
                    _cts?.Token.ThrowIfCancellationRequested();
                    sum += inputArray[i];
                }
            }
            catch (OperationCanceledException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return sum;
        }
    }
}
