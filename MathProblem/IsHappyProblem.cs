using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaPrepTech.MathProblem
{
    public class IsHappyProblem
    {
        /***********202 Happy Number *************/
        public bool IsHappy(int n)
        {
            HashSet<int> squares = new HashSet<int>();
            var sum = n;

            while (sum != 1)
            {
                sum = SumSquare(sum);
                if (squares.Contains(sum))
                {
                    return false;
                }

                squares.Add(sum);
            }

            return true;
        }

        private int SumSquare(int n)
        {
            int sum = 0;

            while (n > 0)
            {
                int dig = n % 10;
                sum += dig * dig;
                n /= 10;
            }

            return sum;
        }
    }
}
