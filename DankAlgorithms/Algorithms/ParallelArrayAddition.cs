using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DankAlgorithms.Algorithms
{
    public class ParallelArrayAddition
    {
        public static int[] AddArrays(int[] ArrayA, int[] ArrayB)
        {
            if(ArrayA.Length != ArrayB.Length)
            {
                return null;
            }

            int[] OutputArray = new int[ArrayA.Length];

            Parallel.For(0, ArrayA.Length,
                i =>
                {
                    OutputArray[i] = ArrayA[i] + ArrayB[i];
                });

            return OutputArray;
        }
    }
}
