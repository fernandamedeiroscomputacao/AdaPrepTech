using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaPrepTech.LeetCode
{
    public class TwoSumProblem
    {
        /*-------------- Problem 1 ---------------------*/
        public int[] TwoSumBruteForce(int[] nums, int target)
        {
            int[] result = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target && i != j)
                    {
                        result[0] = i;
                        result[1] = j;
                        return result;
                    }
                }
            }

            return result;
        }

        /***** STACK OVERFLOW SOLUTION *****/
        public int[] TwoSum(int[] nums, int target)
        {
            return FindTwoSum(nums, 0, 1, target);
        }

        private int[] FindTwoSum(int[] nums, int i, int j, int target)
        {
            if (i >= nums.Length - 1)
            {
                return new int[] { -1, -1 };
            }

            if (j >= nums.Length)
            {
                return FindTwoSum(nums, i + 1, i + 2, target);
            }

            if (nums[i] + nums[j] == target)
            {
                return new int[] { i, j };
            }

            return FindTwoSum(nums, i, j + 1, target);
        }

    }
}
