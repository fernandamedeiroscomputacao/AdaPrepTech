using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaPrepTech.Matrix
{
    public class SetZeroesProblem
    {

        /**** 73. Set Matrix Zeroes *********/
        public void SetZeroes(int[][] matrix)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            List<int> indexM = new List<int>();
            List<int> indexN = new List<int>();


            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        indexM.Add(i);
                        indexN.Add(j);
                    }
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (indexM.Contains(i))
                    {
                        matrix[i][j] = 0;
                    }
                    if (indexN.Contains(j))
                    {
                        matrix[i][j] = 0;
                    }
                }
            }
        }
    }
}
