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
            List<Tuple<int, Guid, double>> temp= new List<Tuple<int, Guid, double>>();
            int selection,index;
            string s_selection, s_index;

            Console.WriteLine("Choose sort:\n1. QuickSortInt\n2. QuickSortGuid\n3. QuickSortDouble\n4. CombSortInt\n5. CombSortGuid\n6. CombSortDouble");
            s_selection = Console.ReadLine();
            while(true)
            {
                try
                {
                    selection = Convert.ToInt32(s_selection);
                    break;
                }
                catch(Exception e)
                {
                    Console.WriteLine("Please enter valid number choice");
                }
            }
            Console.WriteLine("Choose index you want to check:");
            s_index = Console.ReadLine();
            while (true)
            {
                try
                {
                    index = Convert.ToInt32(s_index);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please enter valid number");
                }
            }

            switch(selection)
            {
                case 1:
                    temp = QuickSort.QuickSortInt(data,0,data.Count-1);
                    break;
                case 2:
                    temp = QuickSort.QuickSortGuid(data, 0, data.Count - 1);
                    break;
                case 3:
                    temp = QuickSort.QuickSortDouble (data, 0, data.Count - 1);
                    break;
                case 4:
                    temp = CombSort.CombSortInt(data);
                    break;
                case 5:
                    temp = CombSort.CombSortGuid(data);
                    break;
                case 6:
                    temp = CombSort.CombSortDouble(data);
                    break;
            }

            Console.WriteLine(temp[index]);
            Console.ReadLine();
        }

        

       

    }
}
