using System;
using System.Collections.Generic;
using System.Text;

namespace DataSorting
{
    class CombSort
    {
        //resource used https://www.growingwiththeweb.com/2016/09/comb-sort.html

        //sort list by the int datatype, return sorted tuple list
        public static List<Tuple<int, Guid, double>> CombSortInt(List<Tuple<int, Guid, double>> unsorted)
        {
            //temporary value
            Tuple<int, Guid, double> temp;

            //gap between numbers checked
            int gap = unsorted.Count;
            //the amount the gap gets shrinked ever pass
            float shrinkFactor = 1.3f;
            //checks if a vaule has been swapped with another value
            bool swapped = false;

            //sorts and swaps the list values
            while (gap > 1 || swapped)
            {
                //shrinks the gap
                if (gap > 1)
                {
                    gap = (int)(gap / shrinkFactor);
                }

                //resets the value of swapped
                swapped = false;

                for (int i = 0; gap + i < unsorted.Count; i++)
                {
                    //swaps the values
                    if ((unsorted[i].Item1).CompareTo(unsorted[i + gap].Item1) > 0)
                    {
                        temp = unsorted[i];
                        unsorted[i] = unsorted[i + gap];
                        unsorted[i + gap] = temp;
                        swapped = true;
                    }
                }
            }


            //return sorted list
            return unsorted;
        }

        public static List<Tuple<int, Guid, double>> CombSortDouble(List<Tuple<int, Guid, double>> unsorted)
        {
            //temporary value
            Tuple<int, Guid, double> temp;

            int gap = unsorted.Count;
            float shrinkFactor = 1.3f;
            bool swapped = false;

            while (gap > 1 || swapped)
            {
                if (gap > 1)
                {
                    gap = (int)(gap / shrinkFactor);
                }

                swapped = false;

                for (int i = 0; gap + i < unsorted.Count; i++)
                {
                    if ((unsorted[i].Item3).CompareTo(unsorted[i + gap].Item3) > 0)
                    {
                        temp = unsorted[i];
                        unsorted[i] = unsorted[i + gap];
                        unsorted[i + gap] = temp;
                        swapped = true;
                    }
                }
            }


            //return sorted list
            return unsorted;
        }

        public static List<Tuple<int, Guid, double>> CombSortGuid(List<Tuple<int, Guid, double>> unsorted)
        {
            //temporary value
            Tuple<int, Guid, double> temp;

            int gap = unsorted.Count;
            float shrinkFactor = 1.3f;
            bool swapped = false;

            while (gap > 1 || swapped)
            {
                if (gap > 1)
                {
                    gap = (int)(gap / shrinkFactor);
                }

                swapped = false;

                for (int i = 0; gap + i < unsorted.Count; i++)
                {
                    if ((unsorted[i].Item2).CompareTo(unsorted[i + gap].Item2) > 0)
                    {
                        temp = unsorted[i];
                        unsorted[i] = unsorted[i + gap];
                        unsorted[i + gap] = temp;
                        swapped = true;
                    }
                }
            }


            //return sorted list
            return unsorted;
        }
    }
}
