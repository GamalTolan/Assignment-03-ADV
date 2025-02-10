using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_ADV
{
    public delegate bool CompareTypesDelegate(int x, int y);
    public class SortingAlgorithm
    {
        public static void BubbleSort(int[] arr ,CompareTypesDelegate compare)
        {
           
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (compare.Invoke(arr[j],  arr[j + 1]))
                    {
                        swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }
        public static void swap(ref int x, ref int y)
        {

            int temp = x;
            x = y;
            y = temp;
        }
    }
    class comparetypes
    {
        public static bool CompareGraterThan(int x, int y)
        {
            return x > y;
        }
        public static bool CompareLessThan(int x, int y)
        {
            return x < y;
        }

    }
}
