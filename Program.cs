﻿//using AdaPrepTech.DataStrutures.Lists;

////SingleLinkedList singleLinkedList = new SingleLinkedList();
////Console.WriteLine("SingleLinkedList");
////singleLinkedList.Test();

////DoubleLinkedList doubleLinkedList = new DoubleLinkedList();
////Console.WriteLine("DoubleLinkedList");
////doubleLinkedList.Test();

//CircularDoubleLinkedList circularDoubleLinkedList = new CircularDoubleLinkedList();
//Console.WriteLine("CircularDoubleLinkedList");
//circularDoubleLinkedList.Test();


//int Pow(int x, int n)
//{
//    // Caso base: x^0 = 1
//    if (n == 0)
//        return 1;

//    // Caso base: x^1 = x
//    if (n == 1)
//        return x;

//    // Se n é par, utiliza a propriedade (x^n) = (x^(n/2))^2
//    if (n % 2 == 0)
//        return Pow(x * x, n / 2);
//    else // Se n é ímpar, utiliza a propriedade (x^n) = x * (x^(n-1))
//        return x * Pow(x, n - 1);
//}


//Console.WriteLine(Pow(20, 10)); 


//using AdaPrepTech.Algorithm;

//int[] numeros = { 230, 45, 345, 14,3, 324, 90, 76, 34, 67, 3 };
//Console.WriteLine("######## Ordenação com Selecion Sort ########\n");
//Console.WriteLine("Array original\n");

//foreach (int numero in numeros)
//    Console.Write($"{numero} ");
//Console.WriteLine("\n\nOrdenando o array usando Selection Short\n");
//int[] arrayOrdenado = SelectionSort.IntArraySelectionSort(numeros);
//Console.WriteLine("Array Ordenado\n");
//foreach (int numero in arrayOrdenado)
//    Console.Write($"{numero} ");
//Console.ReadLine();


//using AdaPrepTech.DataStrutures.Stack;

//Stack stack = new Stack(5);

//stack.Push(10);
//stack.Push(20);
//stack.Push(30);

//Console.WriteLine($"Elemento no topo: {stack.Peek()}");
//Console.WriteLine($"Tamanho da pilha: {stack.Size()}");

//Console.WriteLine($"{stack.Pop()} removido da pilha.");
//Console.WriteLine($"Tamanho da pilha: {stack.Size()}");

//stack.Push(40);
//stack.Push(50);
//stack.Push(60); // Teste de overflow


//using AdaPrepTech.DataStrutures.StackAndQueue;

//Queue queue = new Queue(5);

//queue.Enqueue(10);
//queue.Enqueue(20);
//queue.Enqueue(30);

//Console.WriteLine($"Elemento no início da fila: {queue.Peek()}");
//Console.WriteLine($"Tamanho da fila: {queue.Size()}");

//Console.WriteLine($"{queue.Dequeue()} removido da fila.");
//Console.WriteLine($"Tamanho da fila: {queue.Size()}");

//queue.Enqueue(40);
//queue.Enqueue(50);
//queue.Enqueue(60); // Teste de overflow


//int[] series = [1, 3, 2, 1, 4];
//int serie1 = 1;
//int serie2 = 2;

//Console.WriteLine("result: " + WatchSeries(series, serie1, serie2));

////o(n^3)
//int WatchSeries(int[] series, int serie1, int serie2)
//{
//    int min_watch = 100000;
//    int start = 0;
//    int end = 0;

//    while (start < series.Length)
//    {
//        while (end < series.Length)
//        {
//            Console.WriteLine("start: " + start);
//            Console.WriteLine("end: " + end);

//            List<int> current = new List<int>();

//            for (int i = start; i < end; i++)
//            {
//                current.Add(series[i]);
//                Console.WriteLine("current: " + series[i]);

//            }

//            if (current.Contains(serie1) && current.Contains(serie2))
//            {
//                int temp = current.Count;
//                if (temp < min_watch)
//                {
//                    min_watch = temp;
//                    Console.WriteLine("min_watch: " + min_watch);

//                }
//            }
            
//            end++;
//        }

//        start++;
//        end = start; 
//    }


//    return min_watch;
//}
