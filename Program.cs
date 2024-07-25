//Somando elementos do vetor 
int[] array = [1, 2, 3, 4, 5];

Console.WriteLine("Array de entrada:  ");
foreach(int i in array)
{
    Console.WriteLine(i);
}

Console.WriteLine("");


Console.WriteLine("Soma de Elementos com Iteração: " + SomaElementosIterando(array));
Console.WriteLine("Maior elemento com Iteração: " + MaiorElementoIterando(array));
Console.WriteLine("Elemento N na sequencia Fibbonaci: " + Fib(0));


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
