﻿
namespace DankAlgorithms.Algorithms
{
    public class EvenOddSort
    {
        /// <summary>
        /// Sorts the specified array.
        /// </summary>
        /// <param name="array">The array.</param>
        public static int[] Sort(int[] array)
        {
            int i, j, tmp, size = array.Length;
            int[] copy = new int[size];
            array.CopyTo(copy, 0);
            for (i = 0; i < size; i++)
            {
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
                    for (j = 1; j < size; j += 2)
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
            return copy;
        }
    }
}
