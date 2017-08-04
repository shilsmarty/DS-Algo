using System.Collections.Generic;
using System.Linq;
using Learnings.DS.Algo.Common;

namespace Learnings.DS.Algo.Sorting
{
    /// <summary>
    /// Quick sort is one of the best sorting algorithm http://bigocheatsheet.com/
    /// </summary>
    public class QuickSortAlgo
    {
        public List<T> QuickSort<T>(List<T> randomList, Comparer<T> comparer = null)
        {
            var startingIndex = 0;
            var lastIndex = randomList.Count() - 1;
            var defaultComparer = comparer ?? Comparer<T>.Default;

            return InternalSorting(randomList, startingIndex, lastIndex, defaultComparer);
        }

        private List<T> InternalSorting<T>(List<T> randomList, int leftMostIndex, int rightMostIndex,
            Comparer<T> Comparer)
        {
            if (leftMostIndex < rightMostIndex)
            {
                var partitioningIndex = Partitioning(randomList, leftMostIndex, rightMostIndex, Comparer);
                Partitioning(randomList, leftMostIndex, partitioningIndex - 1, Comparer);
                Partitioning(randomList, partitioningIndex + 1, rightMostIndex, Comparer);
            }

            return randomList.ToList();
        }

        private int Partitioning<T>(List<T> randomList, int leftMostIndex, int rightMostindex, Comparer<T> comparer)
        {
            int wallIndex, pivotIndex;

            pivotIndex = rightMostindex;
            var pivotValue = randomList[pivotIndex];

            wallIndex = leftMostIndex;
            for (int i = leftMostIndex; i < rightMostindex; i++)
            {
                if (comparer.Compare(randomList[i], pivotValue) <= 0)
                {
                    randomList.Swap(i, wallIndex);
                    wallIndex++;
                }
            }
            randomList.Swap(wallIndex, pivotIndex);

            return wallIndex;
        }
    }
}
