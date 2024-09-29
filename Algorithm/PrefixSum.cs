using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaPrepTech.Algorithm
{
    public class PrefixSum
    {
        /******* 560 subarray-sum-equals-k**************/
        public int SubarraySum(int[] nums, int k)
        {
            //sum(i,j)=sum(0,j)-sum(0,i), where sum(i,j) represents the sum of all the elements from index i to j-1. Can we use this property to optimize it.

            //1,1,1
            Dictionary<int, int> prefixSum = new Dictionary<int, int>();
            prefixSum[0] = 1;

            int currentSum = 0;
            int result = 0;

            //prefiSum 0,1
            // 1,2 
            //2,1
            //3,1
            for (int i = 0; i < nums.Length; i++)
            {
                currentSum += nums[i];

                if (prefixSum.ContainsKey(currentSum - k))
                {
                    result += prefixSum[currentSum - k];
                }

                if (prefixSum.ContainsKey(currentSum))
                {
                    prefixSum[currentSum]++;
                }
                else
                {
                    prefixSum[currentSum] = 1;
                }

            }

            return result;
        }
    }
}
