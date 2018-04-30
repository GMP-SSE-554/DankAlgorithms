using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DankAlgorithms.Utilities
{
    public static class ArrayUtils
    {
        public static bool IsSorted(int[] array)
        {
            bool sorted = true;
            int n = 0;
            while (sorted && n < array.Length - 1)
            {
                sorted = array[n] < array[n + 1];
                n++;
            }
            return sorted;
        }
    }
}
