using System.Linq;
using System.Threading.Tasks;

namespace DankAlgorithms.Algorithms
{
    public static class ReductionSum
    {
        /// <summary>
        /// Sums the array data asynchronously.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="cts">The CTS.</param>
        /// <returns></returns>
        public static Task SumAsync(int[] array)
        {
            return Task.Run(() =>
            {
                return Sum(array);
            });
        }

        public static int Sum(int[] inputArray)
        {
            return (from x in inputArray.AsParallel() select x).Sum();
        }
    }
}
