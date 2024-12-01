using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaPrepTech.LeetCode
{
    public class NextGreaterElement2Problem
    {
        public int[] NextGreaterElements(int[] nums)
        {
            int[] result = new int[nums.Length];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = -1;
            }
            Stack<int> stack = new Stack<int>();
            //nums = [1,2,1]
            //result = [-1,-1,-1] [2,-1, 2]
            //stack = [] [0] [1, 1]
            for (int i = 0; i < 2 * nums.Length; i++)
            {
                //i=0 i=1 -> 2 > 1 i=2 1 > 2 i = 0 i > 1 i = 1 2 > 1 i = 2 i > 2 
                while (stack.Count > 0 && nums[i % nums.Length] > nums[stack.Peek()])
                {
                    result[stack.Pop()] = nums[i % nums.Length];
                }

                stack.Push(i % nums.Length);
            }
            return result;
        }
    }
}
