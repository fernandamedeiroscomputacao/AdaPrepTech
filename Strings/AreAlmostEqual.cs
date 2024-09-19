using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaPrepTech.Strings
{
    public class AreAlmostEqual
    {
        /***********1790 check-if-one-string-swap-can-make-strings-equal******************/
        public bool AreAlmostEqualProblem(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                return false;
            }

            if (s1 == s2)
            {
                return true;
            }

            List<int> indexDiff = new List<int>();

            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    indexDiff.Add(i);
                }
            }

            if (indexDiff.Count > 2)
            {
                return false;
            }

            if (indexDiff.Count == 2)
            {
                return s1[indexDiff[0]] == s2[indexDiff[1]] && s1[indexDiff[1]] == s2[indexDiff[0]];
            }

            return false;
        }
    }
}
