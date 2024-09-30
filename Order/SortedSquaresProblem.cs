using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaPrepTech.Order
{
    public class SortedSquaresProblem
    {
        /******** 977 Squares of a Sorted Array **********/
        public int[] SortedSquares(int[] nums)
        {
            int[] result = new int[nums.Length];
            PriorityQueue<int, int> squares = new PriorityQueue<int, int>();

            foreach (int num in nums)
            {
                var square = num * num;
                squares.Enqueue(square, square);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = squares.Dequeue();
            }

            return result;

        }
    }
}
