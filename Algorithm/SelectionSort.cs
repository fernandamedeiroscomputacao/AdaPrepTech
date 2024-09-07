using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaPrepTech.Algorithm
{
    public class SelectionSort
    {
        //O(n^2)
        public static int[] IntArraySelectionSort(int[] data)
        {
            for (int i = 0; i < data.Length - 1; i++)
            {
                int minorIndex = SelectMinor(data, i);
                if (i != minorIndex)
                    SwapValues(data, i, minorIndex);
            }
            return data;
        }

        public static int SelectMinor(int[] data, int index)
        {
            int minPos = index;
            for (int pos = index + 1; pos < data.Length; pos++)
            {
                if (data[pos] < data[minPos])
                    minPos = pos;
            }
            return minPos;
        }
        public static int[] SwapValues(int[] arr, int m, int n)
        {
            int temp;
            temp = arr[m];
            arr[m] = arr[n];
            arr[n] = temp;
            return arr;
        }
    }

}
