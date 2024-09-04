using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaPrepTech.LeetCode
{
    public class Recursive
    {
        //time: O(2^n)
        //space: O(n) 
        public int FibonacciNumber(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;

            return FibonacciNumber(n - 1) + FibonacciNumber(n - 2);
        }

        public int FiboNumber(int n)
        {
            int[] memo = new int[n + 1];
            for (int i = 0; i < memo.Length; i++)
            {
                memo[i] = -1;
            }

            return FibonacciHelper(n, memo);
        }

        //time: O(n)
        //space: O(n) 
        private int FibonacciHelper(int n, int[] memo)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            if (memo[n] != -1)
            {
                return memo[n];
            }

            memo[n] = FibonacciHelper(n - 1, memo) + FibonacciHelper(n - 2, memo);

            return memo[n];
        }

        //Hanoi Tower

    }
}
