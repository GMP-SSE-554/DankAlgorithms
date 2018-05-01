using System;
using System.Threading;
using System.Threading.Tasks;

namespace DankAlgorithms.Algorithms
{
    public static class ParallelSum
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
            object sync = new object();
            int sum = 0;

            try
            {
                Parallel.For(0, inputArray.Length,
                    i =>
                    {
                    //Only allow one thread at a time
                    lock (sync)
                        {
                            _cts?.Token.ThrowIfCancellationRequested();
                            sum += inputArray[i];
                        }
                    });
            }
            catch (OperationCanceledException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return sum;
        }
    }
}
