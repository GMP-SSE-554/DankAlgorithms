using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DankAlgorithms.Algorithms
{
    public class ArrayAddition
    {
        public static int[] AddArrays(int[] ArrayA, int[] ArrayB)
        {
            if (ArrayA.Length != ArrayB.Length)
            {
                return null;
            }

            int[] OutputArray = new int[ArrayA.Length];

            for(int i = 0; i < ArrayA.Length; i++)
            {
                OutputArray[i] = ArrayA[i] + ArrayB[i];
            }

            return OutputArray;
        }
    }
}
