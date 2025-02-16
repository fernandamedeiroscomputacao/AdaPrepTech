using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AdaPrepTech.MockInterviews.Google
{
    public class MaxLengthProblem
    {
        /*     You're given an array of integers. Please find the length of the longest contiguous non-decreasing subarray.



       4


       1 < 7 
       max = sq++ 
       sq++ 

       -> O(n) O(1)


       [-1,1,0,2,4] */

        public int MaxLength(int[] arr)
        {
            int maxLength = int.MinValue;
            int currentLength = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] <= arr[i])
                { //-1 < 1, 1 < 0, 0 < 2 2 < 4 
                    currentLength++; // 1 -> 0 1 2 
                }
                else
                {
                    maxLength = Math.Max(maxLength, currentLength + 1); //1 
                    currentLength = 0;
                }
            }
            maxLength = Math.Max(maxLength, currentLength + 1); //2 

            return maxLength; //3  
        }

        /*
                [-1,1,0,2,4]
                [1, 1, 0, 2, 4]
                [- 1, -1, 0, 2, 4] - 5 - check if length == arr.length
                  [-1, 1, 1, 2, 4] ... 
              i = i - 1 

              i = i + 1

              [99, 100, 0, 1, 2]
                [99, 99, 0, 1, 2]
                O(n^2)



         [1, 7, 7, 2, 3, 6, 7, 0, 8, 2, 4, 9, 8, -20]
          ----3--- -----4----  --2-- ---3---- -1-  -1-
        <index of boundered, length currentLength> */

        public int MaxLengthWithOneChange(int[] arr)
        {
            if (arr.Length == 0) return 0;

            // Função auxiliar para calcular o comprimento da maior sequência não decrescente
            int GetMaxNonDecreasingLength(int[] arr)
            {
                int maxLength = 1;
                int currentLength = 1;

                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] >= arr[i - 1])
                    {
                        currentLength++;
                    }
                    else
                    {
                        maxLength = Math.Max(maxLength, currentLength);
                        currentLength = 1;
                    }
                }

                return Math.Max(maxLength, currentLength);
            }

            // Verifique a maior sequência sem fazer nenhuma mudança
            int maxLengthWithoutChange = GetMaxNonDecreasingLength(arr);

            int maxLengthWithChange = maxLengthWithoutChange;

            for (int i = 0; i < arr.Length; i++)
            {
                // Teste alterando o valor arr[i] por um valor que seja válido
                // Para cada i, teste as alterações possíveis com os vizinhos arr[i-1] e arr[i+1]
                int originalValue = arr[i];

                if (i > 0) arr[i] = arr[i - 1]; // Tente mudar arr[i] para arr[i-1]
                maxLengthWithChange = Math.Max(maxLengthWithChange, GetMaxNonDecreasingLength(arr));

                arr[i] = originalValue; // Restaurar valor original

                if (i < arr.Length - 1) arr[i] = arr[i + 1]; // Tente mudar arr[i] para arr[i+1]
                maxLengthWithChange = Math.Max(maxLengthWithChange, GetMaxNonDecreasingLength(arr));

                arr[i] = originalValue; // Restaurar valor original
            }

            return maxLengthWithChange;
        }

    }
}