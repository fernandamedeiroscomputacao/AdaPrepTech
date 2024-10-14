using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaPrepTech.LeetCode
{
    public class CombinationSum2Problem
    {
        //40
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();
            Array.Sort(candidates);  // Ordenar os candidatos para evitar combinações duplicadas
            FindSum(candidates, target, new List<int>(), result, 0);
            return result;
        }

        // Método recursivo para encontrar combinações que somam ao alvo
        private void FindSum(int[] candidates, int target, IList<int> combination, IList<IList<int>> result, int start)
        {
            if (target == 0)
            {
                // Se o target for 0, adiciona a combinação ao resultado
                result.Add(new List<int>(combination));
                return;
            }

            for (int i = start; i < candidates.Length; i++)
            {
                // Evita duplicatas
                if (i > start && candidates[i] == candidates[i - 1]) continue;

                // Se o número for maior que o target, pare (como a lista está ordenada, não há mais candidatos válidos)
                if (candidates[i] > target) break;

                // Adiciona o número atual à combinação e recursivamente busca pelo restante
                combination.Add(candidates[i]);
                FindSum(candidates, target - candidates[i], combination, result, i + 1);
                combination.RemoveAt(combination.Count - 1); // Remove o último número para backtracking
            }
        }
    }
}
