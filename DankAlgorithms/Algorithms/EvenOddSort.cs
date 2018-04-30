
namespace DankAlgorithms.Algorithms
{
    public class EvenOddSort : ISort
    {
        /// <summary>
        /// Sorts the specified array.
        /// </summary>
        /// <param name="array">The array.</param>
        public void Sort(int[] array)
        {
            int i, j, tmp, size = array.Length;
            for (i = 0; i < size; i++)
            {
                if (i % 2 == 0)
                {
                    for (j = 1; j < size; j += 2)
                    {
                        if (array[j - 1] > array[j])
                        {
                            tmp = array[j - 1];
                            array[j - 1] = array[j];
                            array[j] = tmp;
                        }
                    }
                }
                else
                {
                    for (j = 1; j < size; j += 2)
                    {
                        if (array[j] > array[j + 1])
                        {
                            tmp = array[j + 1];
                            array[j + 1] = array[j];
                            array[j] = tmp;
                        }
                    }
                }
            }
        }
    }
}
