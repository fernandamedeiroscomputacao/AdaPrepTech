using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaPrepTech.Arrays
{
    public class IntersectionProblem
    {
        /*******349 - Intersection of Two Arrays **********/
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            HashSet<int> set = new HashSet<int>(nums1);
            List<int> result = new List<int>();

            for (int i = 0; i < nums2.Length; i++)
            {
                if (set.Remove(nums2[i]))
                {
                    result.Add(nums2[i]);
                }
            }

            return result.ToArray();
        }
    }
}
