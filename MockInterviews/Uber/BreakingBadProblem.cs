using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaPrepTech.MockInterviews.Google
{
    public class BreakingBadProblem
    {
        /**
You are given a set of symbols for the elements in the periodic table
eg. [... Li, Be, B, C, N, F, Ne, Na, Co, Ni, Cu, Ga, Al, Si...]
Write the function BreakingBad(name, symbols) that given a name and a set of symbols returns the phrase with the following format. For example:
Symbols = ["H", "He", "Li", "Be", "B", "C", "N", "F", "Ne", "Na", "Co", "Ni", "Cu", "Ga", "Al", "Si", "Fa"]
BreakingBad("henry alba", symbols) results in "[He]nry [Al]ba"
h -> H = <0, H>
he -> He -><0 ..1, He>
hen -> .. -> continue 2 ...




connor riddle --> [Co]nnor riddle
nicole carry --> [Ni]cole [C]arry
jerry seinfeld --> jerry seinfeld
ben f gabe --> [Be]n [F] [Ga]be
*/


        public BreakingBadProblem()
        {
            string[] symbols = { "H", "He", "Li", "Be", "B", "C", "N", "F", "Ne", "Na", "Co", "Ni", "Cu", "Ga", "Al", "Si", "Fa" };
            Console.WriteLine(BreakingBad("connor riddle", symbols));
            Console.WriteLine(BreakingBad("nicole carry", symbols));
            Console.WriteLine(BreakingBad("jerry seinfeld", symbols));
            Console.WriteLine(BreakingBad("ben f gabe", symbols));
        }

        public static string BreakingBad(string phrase, string[] elements)
        {
            HashSet<string> symbols = new HashSet<string>(elements.Select(s => s.ToLower())); // Case-insensitive

            string[] words = phrase.Split(' ');
            List<string> resultWords = new List<string>();

            foreach (string word in words)
            {
                string formattedWord = word; // Default sem alteração

                for (int len = Math.Min(2, word.Length); len > 0; len--) // Busca substrings de tamanho 2 e 1
                {
                    string sub = word.Substring(0, len).ToLower();
                    if (symbols.Contains(sub))
                    {
                        formattedWord = $"[{char.ToUpper(sub[0])}{sub.Substring(1)}]{word.Substring(len)}";
                        break;
                    }
                }
                resultWords.Add(formattedWord);
            }

            return string.Join(" ", resultWords);
        }
    }
}
