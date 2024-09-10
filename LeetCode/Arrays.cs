using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaPrepTech.LeetCode
{
    public class Arrays
    {
        /*------------------------ 704. BINARY SEARCH ------------------------*/
        public int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (nums[mid] == target)
                {
                    return mid;
                }
                if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }


        /*------------------- 88 MERGE SORTED ARRAY ------------- */
        public void MergeArray(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1; // Último elemento válido em nums1
            int j = n - 1; // Último elemento em nums2
            int k = m + n - 1; // Última posição em nums1

            // Mesclando os arrays de trás para frente
            while (i >= 0 && j >= 0)
            {
                if (nums1[i] > nums2[j])
                {
                    nums1[k] = nums1[i];
                    i--;
                }
                else
                {
                    nums1[k] = nums2[j];
                    j--;
                }
                k--;
            }

            // Copiando os elementos restantes de nums2, se houver
            while (j >= 0)
            {
                nums1[k] = nums2[j];
                j--;
                k--;
            }
        }


        /*-----------169 Majority Element --------------*/
        public int MajorityElement(int[] nums)
        {
            int majority = nums.Length / 2;
            Array.Sort(nums);
            return nums[majority];
        }
    }
}
