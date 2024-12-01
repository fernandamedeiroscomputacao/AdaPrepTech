using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaPrepTech.LeetCode
{
    public class MergeIntervalsProblem
    {
        public int[][] Merge(int[][] intervals)
        {
            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

            List<int[]> result = new List<int[]>();
            result.Add(intervals[0]);

            int indexResult = 0;

            for (int i = 1; i < intervals.Length; i++)
            {
                if (result[indexResult][1] >= intervals[i][0])
                {
                    result[indexResult][1] = Math.Max(result[indexResult][1], intervals[i][1]);
                }
                else
                {
                    result.Add(intervals[i]);
                    indexResult++;
                }
            }

            return result.ToArray();
        }
    }
}
