using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaPrepTech.LeetCode
{
    public class NextGreaterElementProblem
    {
        //*******496. Next Greater Element I**********//
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            int[] result = new int[nums1.Length];
            bool find = false;
            int numAux = -1;

            for (int i = 0; i < nums1.Length; i++)
            {
                //4,1,2
                for (int j = 0; j < nums2.Length; j++)
                {
                    //1,3,4,2
                    if (nums2[j] > nums1[i] && find)
                    {
                        numAux = nums2[j];
                        break;
                    }
                    if (nums1[i] == nums2[j])
                    {
                        find = true;
                    }
                }
                result[i] = numAux;
                numAux = -1;
                find = false;
            }

            return result;

        }
    }
}
