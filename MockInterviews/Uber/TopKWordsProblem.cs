using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaPrepTech.MockInterviews.Uber
{
    public class TopKWordsProblem
    {
        public static List<string> TopKWords(string text, int k)
        {
            //uber, vou ser aprovada no uber.
            //k = 2 
            if (k == 0) return new List<string>();
            if (text == null) return new List<string>();

            Dictionary<string, int> dic = new Dictionary<string, int>();
            string aux = "";

            //aux = uber
            //dic = <uber,1> <vou,1> <ser,1>  ...
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ' && text[i] != ',' && text[i] != '.')
                {
                    aux += text[i];
                }
                else
                {
                    if (dic.ContainsKey(aux))
                    {
                        dic[aux] += 1;
                        aux = "";
                    }
                    else if (aux != "")
                    {
                        dic.Add(aux, 1);
                        aux = "";
                    }
                }
            }


            //dic = <uber,2> <vou,1> <ser,1>  ...
            if (aux != "")
            {
                if (dic.ContainsKey(aux))
                {
                    dic[aux] += 1;
                }
                else
                {
                    dic.Add(aux, 1);
                }
            }


            PriorityQueue<string, int> queue = new PriorityQueue<string, int>();

            //dic = <uber,2> <vou,1> <ser,1>  ...
            foreach (var wordCount in dic)
            {
                queue.Enqueue(wordCount.Key, wordCount.Value * -1);
                //Console.WriteLine($"{wordCount.Key} + '' + {wordCount.Value}");          
            }

            //queue = <uber,2> <vou,1> <ser,1> ...
            List<string> res = new List<string>();

            for (int i = 0; i < k; i++)
            {
                res.Add(queue.Dequeue());
            }

            //res = uber, vou

            return res;
        }
    }
}
