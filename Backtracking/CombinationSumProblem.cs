using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaPrepTech.Backtracking
{
    public class CombinationSumProblem
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();
            Array.Sort(candidates);
            Backtrack(candidates, target, 0, new List<int>(), result);
            return result;
        }

        private void Backtrack(int[] candidates, int target, int start, List<int> currentCombination, IList<IList<int>> result)
        {
            if (target == 0)
            {
                result.Add(new List<int>(currentCombination));
                return;
            }

            if (target < 0)
            {
                return;
            }

            for (int i = start; i < candidates.Length; i++)
            {
                currentCombination.Add(candidates[i]);
                Backtrack(candidates, target - candidates[i], i, currentCombination, result);
                currentCombination.RemoveAt(currentCombination.Count - 1);
            }
        }
    }
}
