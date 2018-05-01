using System;
using System.Threading;
using System.Threading.Tasks;

namespace DankAlgorithms.Algorithms
{
    public class ArrayAddition
    {
        private static CancellationTokenSource _cts;

        /// <summary>
        /// Adds the arrays asynchronously.
        /// </summary>
        /// <param name="arrayA">The array a.</param>
        /// <param name="arrayB">The array b.</param>
        /// <param name="cts">The CTS.</param>
        /// <returns></returns>
        public static Task AddArraysAsync(int[] arrayA, int[] arrayB, CancellationTokenSource cts)
        {
            return Task.Run(() =>
            {
                _cts = cts;
                return AddArrays(arrayA, arrayB);
            }, cts.Token);
        }

        /// <summary>
        /// Adds the arrays.
        /// </summary>
        /// <param name="ArrayA">The array a.</param>
        /// <param name="ArrayB">The array b.</param>
        /// <returns></returns>
        public static int[] AddArrays(int[] ArrayA, int[] ArrayB)
        {
            if (ArrayA.Length != ArrayB.Length)
            {
                return null;
            }

            int[] OutputArray = new int[ArrayA.Length];
            
            try
            {
                for(int i = 0; i < ArrayA.Length; i++)
                {
                    _cts?.Token.ThrowIfCancellationRequested();
                    OutputArray[i] = ArrayA[i] + ArrayB[i];
                }
            }
            catch (OperationCanceledException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return OutputArray;
        }
    }
}
