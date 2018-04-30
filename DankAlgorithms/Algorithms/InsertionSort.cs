using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DankAlgorithms.Algorithms
{
    public static class InsertionSort
    {
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
