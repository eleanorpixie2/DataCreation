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

            string[] temp1 = new string[3];
            char seperatingChar = ',';
            //parsing data
            for (int i = 0; i < lines.Length; i++)
            {
                temp1 = lines[i].Split(seperatingChar, StringSplitOptions.RemoveEmptyEntries);
                data.Add(new Tuple<int, Guid, double>(Convert.ToInt32(temp1[0]),Guid.Parse(temp1[1]),Convert.ToDouble(temp1[2])));

            }


           List<Tuple<int, Guid, double>> temp = new List<Tuple<int, Guid, double>>();
           temp = QuickSortDouble(data, 0, data.Count-1);
            for(int i=0; i<100;i++)
            {
                Console.WriteLine(temp[i]);
            }

            //printing out sorted int
            Console.ReadLine();
        }

        public static List<Tuple<int,Guid,double>> QuickSortInt(List<Tuple<int, Guid, double>> unsorted, int leftMost, int rightMost)
        {
            int i = leftMost;
            int j = rightMost;

            int pivotIndex = (leftMost + rightMost) / 2;

            while ( i <= j)
            {
                while ((unsorted[i].Item1).CompareTo(unsorted[pivotIndex].Item1) < 0)
                {
                    i++;
                }
                while ((unsorted[j].Item1).CompareTo(unsorted[pivotIndex].Item1) > 0)
                {
                    j--;
                }
                if (i <= j)
                {
                    // Swap
                    Tuple<int, Guid, Double> tmp = unsorted[i];
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

            return unsorted;
        }

        public static List<Tuple<int, Guid, double>> QuickSortDouble(List<Tuple<int, Guid, double>> unsorted, int leftMost, int rightMost)
        {
            int i = leftMost;
            int j = rightMost;

            int pivotIndex = (leftMost + rightMost) / 2;

            while (i <= j)
            {
                while ((unsorted[i].Item3).CompareTo(unsorted[pivotIndex].Item3) < 0)
                {
                    i++;
                }
                while ((unsorted[j].Item3).CompareTo(unsorted[pivotIndex].Item3) > 0)
                {
                    j--;
                }
                if (i <= j)
                {
                    // Swap
                    Tuple<int, Guid, Double> tmp = unsorted[i];
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

            return unsorted;
        }
    }
}
