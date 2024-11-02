using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaPrepTech.Strings
{
    public class IsAnagramProblem
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            char[] sArray = s.ToCharArray();
            Array.Sort(sArray);

            char[] tArray = t.ToCharArray();
            Array.Sort(tArray);

            return sArray.SequenceEqual(tArray);
        }
    }
}
