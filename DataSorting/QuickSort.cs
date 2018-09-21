using System;
using System.Collections.Generic;
using System.Text;

namespace DataSorting
{
    class QuickSort
    {
        //sort list by the double datatype, return sorted tuple list
        public static List<Tuple<int, Guid, double>> QuickSortInt(List<Tuple<int, Guid, double>> unsorted, int leftMost, int rightMost)
        {
            //indexs
            int i = leftMost;
            int j = rightMost;

            //pivot point
            int pivotIndex = unsorted[(leftMost + rightMost) / 2].Item1;

            //compare and sort list elements
            while (i <= j)
            {
                while ((unsorted[i].Item1).CompareTo(pivotIndex) < 0)
                {
                    i++;
                }
                while ((unsorted[j].Item1).CompareTo(pivotIndex) > 0)
                {
                    j--;
                }
                if (i <= j)
                {
                    // Swap
                    Tuple<int, Guid, double> tmp = unsorted[i];
                    unsorted[i] = unsorted[j];
                    unsorted[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (leftMost < j)
            {
                QuickSortInt(unsorted, leftMost, j);
            }

            if (i < rightMost)
            {
                QuickSortInt(unsorted, i, rightMost);
            }

            //return sorted list
            return unsorted;
        }

        //sort list by the int datatype, return sorted tuple list
        public static List<Tuple<int, Guid, double>> QuickSortDouble(List<Tuple<int, Guid, double>> unsorted, int leftMost, int rightMost)
        {
            //indexs
            int i = leftMost;
            int j = rightMost;

            //pivot point to sort around
            double pivotIndex = unsorted[(leftMost + rightMost) / 2].Item3;

            //compare and sort list elements
            while (i <= j)
            {
                while ((unsorted[i].Item3).CompareTo(pivotIndex) < 0)
                {
                    i++;
                }
                while ((unsorted[j].Item3).CompareTo(pivotIndex) > 0)
                {
                    j--;
                }
                if (i <= j)
                {
                    // Swap
                    Tuple<int, Guid, double> tmp = unsorted[i];
                    unsorted[i] = unsorted[j];
                    unsorted[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (leftMost < j)
            {
                QuickSortDouble(unsorted, leftMost, j);
            }

            if (i < rightMost)
            {
                QuickSortDouble(unsorted, i, rightMost);
            }

            //return sorted list
            return unsorted;
        }

        //sort list by the guid datatype, return sorted tuple list
        public static List<Tuple<int, Guid, double>> QuickSortGuid(List<Tuple<int, Guid, double>> unsorted, int leftMost, int rightMost)
        {
            //indexes
            int i = leftMost;
            int j = rightMost;

            //pivot point to compare around
            Guid pivotIndex = unsorted[(leftMost + rightMost) / 2].Item2;

            //compare and sort list elements
            while (i <= j)
            {
                while ((unsorted[i].Item2).CompareTo(pivotIndex) < 0)
                {
                    i++;
                }
                while ((unsorted[j].Item2).CompareTo(pivotIndex) > 0)
                {
                    j--;
                }
                if (i <= j)
                {
                    // Swap
                    Tuple<int, Guid, double> tmp = unsorted[i];
                    unsorted[i] = unsorted[j];
                    unsorted[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (leftMost < j)
            {
                QuickSortGuid(unsorted, leftMost, j);
            }

            if (i < rightMost)
            {
                QuickSortGuid(unsorted, i, rightMost);
            }

            //return sorted list.
            return unsorted;
        }
    }
}
