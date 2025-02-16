using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdaPrepTech.MockInterviews.Google
{
    public class PickRandomProblem
    {
        /*
Given a list of events, each with [start time, end time) represented as floating point numbers, write a function that randomly and 
uniformly picks a point in time during which at least one event is happening. Return the picked time.

You should use the predefined random() function, which returns a randomly and uniformly picked number in the [0, 1) interval.

E.g.
[0., 0.5), [3., 5.5), [9, 10.2) -> 0.53 - GOOD, if picked randomly and uniformly
                    -> 10.5 - BAD, no event is happening at time 10.5

0 ...1 3..5.5
  
  
  2.1 -> bad number


  order to star time
  n = radom(0, 10.2)


  loop -> random number fits on any interval 
  
  0..1 100.101


  O(n ^ n)
  
  -> 0, 0.5 
  ... 
  <0.3,1> - interval
  <100.5,2>

  O(n log n) -> O(n)


  left = pointer -> 0 
  rigth = pointer -> size of events

  fits on one of this events

  events[left][0][1] -> interval
  
  -> mid = eventer[right][0] + event[left][1]/2 
  mid = 9 + 0.5 / 2 = 4.75 
0.6 < 4.75 
  rigth pointer = mid of the list; 

  -> BAD

  check if radom - is in the firts interval or in the last one

  random number is 9.9
  
  [0, 1) [1, 2), [2, 3), [9, 11), [19, 20)
                                    
- Dictionary<number of the event, the index> */


//[0., 0.5), [3., 5.5), [9, 10.2) -
//<0, 0.3> <1, 4> <2,9.5> 
/*public float PickRadom(List<List<float>> intervals)
        {

            if (invervals.Length == 0) thow new Exeption("not valid");

            Dictionary<int, float> listOfRandons = new Dictionary<float, int>();

            for (int i = 0; i < intervals.Length; i++)
            {
                float x = intervals[i][0];
                float y = intervals[i][1];

                float n = get_random(x, y)



    listOfRandons(n, i);
            }

            int left = 0;
            int rigth = intervals.Length - 1;


            int index = left + right / 2;

            float choice = listOfRandons(index);//1 

            return choice; //4 

        }

        float get_random(float start, float end)
        {
            // compute it using random() function
            float x = random(); // x is in [0, 1)

            // transform x so that it is between start and end while maintaining uniformity
            float mid = start + end / 2;

            if (mid + random < end)
            {
                return mid + random;
            }
            else
            {
                return mid - random;
            }
        } /*
    }

*/
    public float PickRandom(List<List<float>> intervals)
    {
        // Verificar se os intervalos são válidos
        if (intervals.Count == 0) throw new Exception("No intervals");

        List<float> points = new List<float>();
        float totalLength = 0;

        // Armazenar todos os pontos de início e fim e calcular o comprimento total
        foreach (var interval in intervals)
        {
            points.Add(interval[0]);
            points.Add(interval[1]);
            totalLength += interval[1] - interval[0];
        }

        // Gerar um número aleatório entre 0 e o comprimento total
        float randomPoint = (float)new Random().NextDouble() * totalLength;

        // Encontrar o intervalo que contém esse ponto aleatório
        float currentLength = 0;
        foreach (var interval in intervals)
        {
            float intervalLength = interval[1] - interval[0];
            if (randomPoint < currentLength + intervalLength)
            {
                return interval[0] + (randomPoint - currentLength);  // Retornar o ponto aleatório dentro do intervalo
            }
            currentLength += intervalLength;
        }

        return -1;  // Caso não encontre (não deveria acontecer)
    }

}
