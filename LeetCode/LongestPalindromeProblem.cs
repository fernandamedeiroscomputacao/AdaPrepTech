using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaPrepTech.LeetCode
{
    public class LongestPalindromeProblem
    {
        public string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return "";

            int n = s.Length;
            bool[,] dp = new bool[n, n];
            int start = 0, maxLength = 1;

            for (int i = 0; i < n; i++)
            {
                dp[i, i] = true;
            }

            for (int i = 0; i < n - 1; i++)
            {
                if (s[i] == s[i + 1])
                {
                    dp[i, i + 1] = true;
                    start = i;
                    maxLength = 2;
                }
            }

            for (int length = 3; length <= n; length++)
            {
                for (int i = 0; i < n - length + 1; i++)
                {
                    int j = i + length - 1;
                    if (s[i] == s[j] && dp[i + 1, j - 1])
                    {
                        dp[i, j] = true;
                        start = i;
                        maxLength = length;
                    }
                }
            }

            if (start + maxLength > n) maxLength = n - start;

            return s.Substring(start, maxLength);
        }
    }
}
