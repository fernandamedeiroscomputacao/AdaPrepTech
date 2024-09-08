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


        /*234 - Palindrome Linked List - LeetCode */
        public bool IsPalindrome(Node head)
        {
            Node fast = head;
            Node slow = head;

            //1 -> 2 -> 2 -> 1

            //fast = 1 
            //slow = 1 

            //O(n/2 - 1 )
            while (fast != null && fast.Next != null)
            {
                fast = fast.Next.Next; //2(second 2)
                slow = slow.Next;  // 2
            }

            Node prev = null;
            //O(n/2 - 1 )
            while (slow != null)
            {
                var temp = slow.Next; //2(second), 1, null 
                slow.Next = prev; //null, 2, 2
                prev = slow; // 2, 2 (second), 1 
                slow = temp; // 2, 1, null 
            }

            // 1, 2, null, 1, 2
            Node left = head; // 1
            Node right = prev; //1(last one that now is in the middle) 

            //O(n/2 - 1 )
            while (right != null)
            {
                if (left.Data != right.Data)
                {
                    return false;
                }
                left = left.Next; //2, 2 
                right = right.Next; //2, null 
            }

            return true;
        }


        /*2095 Delete the Middle Node of a Linked List - LeetCode*/
        public Node DeleteMiddle(Node head)
        {
            if (head == null || head.Next == null)
            {
                return null;
            }

            Node slow = head;
            Node fast = head;
            Node prev = null;

            while (fast != null && fast.Next != null)
            {
                prev = slow;
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            prev.Next = slow.Next;

            return head;
        }
    }



}
