using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaPrepTech.LeetCode
{
    public class Stacks
    {
        /* ------------------- 20 VALID PARENTHESES --------------------------------*/
        public bool IsValid(string s)
        {
            Stack<char> stackS = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stackS.Push(c);
                }
                else
                {
                    if (stackS.Count == 0)
                    {
                        return false;
                    }
                    var r = stackS.Pop();
                    if (r == '(' && c != ')')
                    {
                        return false;
                    }
                    if (r == '{' && c != '}')
                    {
                        return false;
                    }
                    if (r == '[' && c != ']')
                    {
                        return false;
                    }
                }
            }

            return stackS.Count == 0;
        }
    }   

}
