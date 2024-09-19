using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaPrepTech.LeetCode
{
    public class IsIsomorphic
    {
        /************* 205 - Isomorphic Strings *************/
        public bool IsIsomorphicProblem(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            Dictionary<char, char> charMap = new Dictionary<char, char>();
            Dictionary<char, char> reverseMap = new Dictionary<char, char>();

            for (int i = 0; i < s.Length; i++)
            {
                var original = s[i];
                var rep = t[i];

                if (charMap.ContainsKey(original))
                {
                    if (charMap[original] != rep)
                    {
                        return false;
                    }
                }
                else
                {
                    if (reverseMap.ContainsKey(rep))
                    {
                        if (reverseMap[rep] != original)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        charMap.Add(original, rep);
                        reverseMap.Add(rep, original);
                    }
                }
            }
            return true;
        }
    }
}
