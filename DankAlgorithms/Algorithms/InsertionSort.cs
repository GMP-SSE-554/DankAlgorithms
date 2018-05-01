using System;
using System.Threading.Tasks;

namespace DankAlgorithms.Algorithms
{
    public class InsertionSort
    {
        static double progress;
        /// <summary>
        /// Returns asyncronous sorting task.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns></returns>
        public static Task SortAsync(int[] array)
        {
            return Task.Run(() =>
            {
                return Sort(array);
            });
        }

        public static int getProgress()
        {
            return (int)progress;
        }

        public static event EventHandler<ProgressEvent> OnProgress;

        /// <summary>
        /// Sorts the specified input array.
        /// </summary>
        /// <param name="inputArray">The input array.</param>
        /// <returns></returns>
        public static int[] Sort(int[] inputArray)
        {
            progress = 0;
            //Create a copy of inputArray
            int[] copiedArray = new int[inputArray.Length];
            inputArray.CopyTo(copiedArray, 0);

            int key, j;
            for (int i = 1; i < inputArray.Length; i++)
            {
                key = copiedArray[i];
                j = i - 1;

                while (j >= 0 && copiedArray[j] > key)
                {
                    copiedArray[j + 1] = copiedArray[j];
                    j--;
                }

                copiedArray[j + 1] = key;
                EventHandler<ProgressEvent> progressEvent = OnProgress;
                if (progressEvent != null)
                {
                    progressEvent(null, new ProgressEvent(null, (int)progress));
                }
            }

            return copiedArray;
        }

        
    }
}
