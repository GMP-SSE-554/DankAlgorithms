using DankAlgorithms.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DankAlgorithms.Algorithms
{
    class BogoSort
    {
        public int[] Sort(int[] inputArray)
        {
            int[] temp = inputArray;
            while (!ArrayUtils.IsSorted(temp))
                Shuffle(temp);
            return temp;
        }

        private int[] Shuffle(int[] inputArray)
        {
            Random rnd = new Random();
            int[] newArray = inputArray.OrderBy(x => rnd.Next()).ToArray();
            return newArray;
        }
    }
}
