using System;
using System.Threading;
using System.Threading.Tasks;

namespace DankAlgorithms.Algorithms
{
    public class EvenOddSort
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
        /// Sorts the specified array.
        /// </summary>
        /// <param name="array">The array.</param>
        public static int[] Sort(int[] array)
        {
            int i, j, tmp, size = array.Length;
            int[] copy = new int[size];
            array.CopyTo(copy, 0);
            try
            {
                for (i = 0; i < size; i++)
                {
                    _cts?.Token.ThrowIfCancellationRequested();
                    if (i % 2 == 0)
                    {
                        for (j = 1; j < size; j += 2)
                        {
                            if (copy[j - 1] > copy[j])
                            {
                                tmp = copy[j - 1];
                                copy[j - 1] = copy[j];
                                copy[j] = tmp;
                            }
                        }
                    }
                    else
                    {
                        for (j = 1; j < size - 1; j += 2)
                        {
                            if (copy[j] > copy[j + 1])
                            {
                                tmp = copy[j + 1];
                                copy[j + 1] = copy[j];
                                copy[j] = tmp;
                            }
                        }
                    }
                }
            }
            catch (OperationCanceledException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return copy;
        }
    }
}
