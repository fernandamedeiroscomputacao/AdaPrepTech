//Somando elementos do vetor 
int[] nums = [1, 2, 3, 4, 5];
int sum = 0; 

//Console.WriteLine("Array de entrada:  ");
//foreach(int i in array)
//{
//    Console.WriteLine(i);
//}

//Console.WriteLine("");


//Console.WriteLine("Soma de Elementos com Iteração: " + SomaElementosIterando(array));
//Console.WriteLine("Maior elemento com Iteração: " + MaiorElementoIterando(array));
//Console.WriteLine("Elemento N na sequencia Fibbonaci: " + Fib(0));


hasPairWithSum(nums, sum); 
Console.WriteLine(hasPairWithSum(nums, sum));

//chamadas recursivas podem dimunuir a complexidade 
int SomaElementosIterando(int[] array)
{
    var sum = 0;
    foreach(int num in array)
    {
        sum += num;
    }
    return sum;
}

int MaiorElementoIterando(int[] array)
{
    var maior = array[0]; 
    for(int i = 1 ; i < array.Length; i++)
    {
        if (array[i] > maior)
        {
            maior = array[i]; 
        }
    }

    return maior;
}

//implementar tbm Menor Elemento Iterando 

//perguntas relevantes a se fazer sobre os problemas:
//Qual a relevância de se usar uma solução mais complexa? (Exemplo, essas funções serão usadas muitas vezes, qual o tamanho da entrada, etc); 
//Qual tipo de entrada? Pode ser vazia? Pode ser nula? Só números inteiros?

//Fibonnaci Number 
//Como um vetor pode ajudar? Memoização - > Iteração vai ser feita uma única vez 
//Complexidade O(n)
//Recursivamente On*n
int Fib(int n)
{
    List<int> fibbo = new List<int>();
    fibbo.Add(0);
    fibbo.Add(1);

    for (int i = 2; i <= n; i++)
    {
        fibbo.Add(fibbo[i - 2] + fibbo[i - 1]);
    }

    return fibbo[n];
}

//Invertendo elementos de um vetor 
//Invertendo elementos de uma string
void ReverseString(char[] s)
{
    var left = 0;
    var right = s.Length - 1;

    while (left < right)
    {
        var temp = s[left];
        s[left] = s[right];
        s[right] = temp;
        left++;
        right--;
    }
}

//shuffle the array [x1,x2,x3] [y1,y2,y3] resposta [x1,y1,...] informa o valor de n (meio do vetor)
//valid soduko

//wallacefavoreto@gmail.com
//cassiokendi@gmail.com

//prova no Everlast

//Buscar Binária
//Vetores ou listas ordenadas -> log n 

int Search(int[] nums, int target)
{
    int left = 0;
    int right = nums.Length - 1;

    while (left <= right)
    {
        int mid = (left + right) / 2;

        if (nums[mid] == target)
        {
            return mid;
        }
        if (nums[mid] < target)
        {
            left = mid + 1;
        }
        else
        {
            right = mid - 1;
        }
    }

    return -1;
}

//números de positivos e número de negativos em um vetor 
//estratégia um: busca linear e contadores
//estratégia dois: busca linear da direta para esquerda procurando o primeiro negativo ou zero para identificar quantos são positivos e vice versa
//estratégia três: buscar binária para achar o primeiro número positivo e o último número negativo 

//target problem = encontrar pares de números que são menores que o valor target
int CountPairs(IList<int> nums, int target)
{
    int count = 0;

    for (int i = 0; i < nums.Count; i++)
    {
        for (int j = i + 1; j < nums.Count; j++)
        {
            if ((nums[i] + nums[j]) < target)
            {
                count++;
            }
        }
    }

    return count;
}

//resolução com busca binária para CountPairs 

//Aula 3
// Two pointers

bool hasPairWithSum(int[] nums, int sum)
{
    int left = 0;
    int right = nums.Length - 1;

    while (left != right)
    {
        int result = nums[left] + nums[right];

        if (result == sum)
        {
            return true;
        }
        else if (result > sum)
        {
            right --;
        }
        else
        {
            left++;
        }
    }

    return false;
}


//complexidade tempo O(n)
//complexidade espaço O(1)

int RemoveDuplicates(int[] nums)
{
    int k = 1;
    for (int i = 1; i < nums.Length; i++)
    {
        if (nums[i] != nums[i - 1])
        {
            nums[k] = nums[i];
            k++;
        }
    }
    return k;
}

 bool IsPalindrome(string s)
    {

        var cleanString = new string(s.Where(char.IsLetterOrDigit).ToArray()).ToLower();
        int left = 0;
        int right = cleanString.Length - 1;

        while (left < right)
        {
            if (cleanString[left] == cleanString[right])
            {
                left++;
                right--;
            }
            else
            {
                return false;
            }
        }

        return true;
    }

//move Zeros -> mover zeros para o final do array

//nao funcinou
bool ValidPalindrome(string s)
{
    var cleanString = new string(s.Where(char.IsLetterOrDigit).ToArray()).ToLower();
    int left = 0;
    int right = cleanString.Length - 1;
    int k = 0;


    while (left < right)
    {
        if (cleanString[left] != cleanString[right])
        {
            k++;
            left--;
        }
        left++;
        right--;
    }


    if (k < 1)
    {
        return true;
    }
    else
    {
        return false;
    }
}

//nao funcionou

     void Rotate(int[] nums, int k)
    {
        int size = k--;
        List<int> subNums = new List<int>();


        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (k <= nums.Length - 1)
            {
                subNums.Add(nums[k]);
                nums[k] = nums[i];
            }
        }

        for (int j = 0; j < size; j++)
        {
            nums[j] = subNums[j];
        }

    }


