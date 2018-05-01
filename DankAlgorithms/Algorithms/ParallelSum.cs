using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DankAlgorithms.Algorithms
{
    public static class ParallelSum
    {
        public static int Sum(int[] inputArray)
        {
            object sync = new object();
            int sum = 0;

            Parallel.For(0, inputArray.Length,
                i =>
                {
                    //Only allow one thread at a time
                    lock (sync)
                    {
                        sum += inputArray[i];
                    }
                } );

            return sum;
        }
    }
}
