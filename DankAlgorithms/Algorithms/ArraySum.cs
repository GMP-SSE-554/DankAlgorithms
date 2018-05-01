using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DankAlgorithms.Algorithms
{
    public static class ArraySum
    {
        public static int Sum(int[] inputArray)
        {
            int sum = 0;
            for(int i = 0; i < inputArray.Length; i++)
            {
                sum += inputArray[i];
            }

            return sum;
        }
    }
}
