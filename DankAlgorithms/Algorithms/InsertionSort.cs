
namespace DankAlgorithms.Algorithms
{
    public class InsertionSort
    {
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
            }

            return copiedArray;
        }
    }
}
