using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaPrepTech.Arrays
{
    public class TopKFrequentWordsProblem
    {
        /********** 692 - Top K Frequent Words ***************/
        public IList<string> TopKFrequent(string[] words, int k)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            List<string> result = new List<string>();

            foreach (string word in words)
            {
                if (dict.ContainsKey(word))
                {
                    dict[word] += 1;
                }
                else
                {
                    dict.Add(word, 1);
                }
            }

            var sortedDict = dict.OrderByDescending(pair => pair.Value).ThenBy(pair => pair.Key);

            foreach (var pair in sortedDict.Take(k))
            {
                result.Add(pair.Key);
            }

            return result;
        }
    }
}
