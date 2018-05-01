using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DankAlgorithms.Algorithms
{
    public static class ReductionSum
    {
        public static int Sum(int[] inputArray)
        {
            inputArray.Sum();
            return (from x in inputArray.AsParallel() select x).Sum();
        }
    }
}
