using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learnings.DS.Algo.Common
{
    public static class Helper
    {
        /// <summary>
        /// Swaps two values in an IList<T> collection given their indexes.
        /// </summary>
        public static void Swap<T>(this IList<T> list, int firstIndex, int secondIndex)
        {
            if (list.Count < 2 || firstIndex == secondIndex)   //This check is not required but Partition function may make many calls so its for perf reason
                return;

            var temp = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = temp;
        }

        /// <summary>
        /// Populates a collection with a specific value.
        /// </summary>
        public static void Populate<T>(this IList<T> collection, T value)
        {
            if (collection == null)
                return;

            for (int i = 0; i < collection.Count; i++)
            {
                collection[i] = value;
            }
        }
    }
}
