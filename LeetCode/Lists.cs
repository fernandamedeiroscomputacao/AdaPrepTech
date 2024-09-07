using AdaPrepTech.DataStrutures.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaPrepTech.LeetCode
{
    /* ----------------------- 1290 - CONVERT BINARY NUMBER IN A LINKED LIST TO INTEGER --------------------- */
    public class Lists
    {

        //Time: O(N)
        //Space: O(1)
        public int GetDecimalValue(Node head)
        {
            Node current = head;
            int num = 0;

            while (current != null)
            {
                num = num * 2 + current.Data;
                current = current.Next;
            }

            return num;
        }

        /*-----------------------  217 Contains Duplicate - LeetCode* ----------------------- */

        //Time:O(N^2)
        //Space:O(N)
        public bool ContainsDuplicate(int[] nums)
        {
            List<int> list = new List<int>();

            foreach (int num in nums) //O(n)
            {
                if (list.Contains(num)) //O(n)
                {
                    return true;
                }
                else
                {
                    list.Add(num);
                }
            }

            return false;
        }
    }



}
