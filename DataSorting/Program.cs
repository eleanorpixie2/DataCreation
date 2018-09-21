using System;
using System.Collections.Generic;
using System.IO;
//https://www.w3resource.com/csharp-exercises/searching-and-sorting-algorithm/searching-and-sorting-algorithm-exercise-9.php

namespace DataSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            //storing the data
            List<Tuple<int, Guid, double>> data = new List<Tuple<int, Guid, double>>();

            //read in the data
            string[] lines = File.ReadAllLines(@"C:\workspace\DataCreation.txt"); //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-read-from-a-text-file

            //store the 3 data types temporarily in a string array
            string[] temp1 = new string[3];
            //seperating character
            char seperatingChar = ',';
            //parsing data
            for (int i = 0; i < lines.Length; i++)
            {
                //add data to tuple list
                temp1 = lines[i].Split(seperatingChar, StringSplitOptions.RemoveEmptyEntries);
                data.Add(new Tuple<int, Guid, double>(Convert.ToInt32(temp1[0]),Guid.Parse(temp1[1]),Convert.ToDouble(temp1[2])));

            }

            //create a temp list to hold data
           List<Tuple<int, Guid, double>> temp;
            //call double sort and display data
            temp = QuickSortDouble(data, 0, data.Count - 1);
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(temp[i]);
            }

            Console.WriteLine("Double Sort Done");

            //printing out sorted int
            temp = QuickSortInt(data, 0, data.Count - 1);
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(temp[i]);
            }

            Console.WriteLine("Int Sort Done");

            //printing out sorted guid
            temp = QuickSortGuid(data, 0, data.Count - 1);
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(temp[i]);
            }

            Console.ReadLine();
        }

        //sort list by the double datatype, return sorted tuple list
        public static List<Tuple<int,Guid,double>> QuickSortInt(List<Tuple<int, Guid, double>> unsorted, int leftMost, int rightMost)
        {
            //indexs
            int i = leftMost;
            int j = rightMost;

            //pivot point
            int pivotIndex = unsorted[(leftMost + rightMost) / 2].Item1;

            //compare and sort list elements
            while ( i <= j)
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
