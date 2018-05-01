using System;
using System.Threading;
using System.Threading.Tasks;

namespace DankAlgorithms.Algorithms
{
    public class InsertionSort
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
        /// Sorts the specified input array.
        /// </summary>
        /// <param name="inputArray">The input array.</param>
        /// <returns></returns>
        public static int[] Sort(int[] inputArray)
        {
            //Create a copy of inputArray
            int[] copiedArray = new int[inputArray.Length];
            inputArray.CopyTo(copiedArray, 0);

            try
            {
                int key, j;
                for (int i = 1; i < inputArray.Length; i++)
                {
                    key = copiedArray[i];
                    j = i - 1;

                    while (j >= 0 && copiedArray[j] > key)
                    {
                        _cts?.Token.ThrowIfCancellationRequested();
                        copiedArray[j + 1] = copiedArray[j];
                        j--;
                    }

                    copiedArray[j + 1] = key;
                }
            }
            catch (OperationCanceledException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return copiedArray;
        }
    }
}
