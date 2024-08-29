using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaPrepTech.LeetCode
{
    public class Strings
    {
        /*------------------ 709. TO LOWER CASE ----------------------- */
        public string ToLowerCase(string s)
        {
            char[] newWord = new char[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                char current = s[i];

                if (current >= 'A' && current <= 'Z')
                {
                    newWord[i] = (char)(current + 32);
                }
                else
                {
                    newWord[i] = current;
                }
            }

            return new string(newWord);

        }
    }
}
