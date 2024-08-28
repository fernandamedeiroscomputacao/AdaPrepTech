using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaPrepTech.DataStrutures.Lists
{
    public class DoubleNode
    {
        public int Data {  get; set; }
        public DoubleNode Next { get; set; }
        public DoubleNode Prev { get; set; }
        public DoubleNode(int data) 
        {
            Data = data;
            Next = null;
            Prev = null; 
        }
    }

    public class DoubleLinkedList
    {
        private DoubleNode head;
        private DoubleNode tail; 

        public DoubleLinkedList()
        {
            head = null;
            tail = null; 
        }

        public void Test()
        {
            //TestInsert();
            TestRemove();
        }

        public static void TestInsert()
        {
            var list = new DoubleLinkedList();

            Console.WriteLine("Testando inserções em uma lista duplamente encadeada:");

            // Teste 1: Inserção em uma lista vazia no início
            list.InsertAtBeginning(10);
            Console.WriteLine("\nApós inserir 10 no início (lista vazia):");
            PrintList(list);  // Esperado: 10 -> null

            // Teste 2: Inserção no final quando há apenas um elemento
            list.InsertAtEnd(20);
            Console.WriteLine("\nApós inserir 20 no final:");
            PrintList(list);  // Esperado: 10 -> 20 -> null

            // Teste 3: Inserção no início quando há elementos na lista
            list.InsertAtBeginning(30);
            Console.WriteLine("\nApós inserir 30 no início:");
            PrintList(list);  // Esperado: 30 -> 10 -> 20 -> null

            // Teste 4: Inserção em uma posição específica (posição 2, 0-based)
            list.InsertAtPosition(15, 2);
            Console.WriteLine("\nApós inserir 15 na posição 2:");
            PrintList(list);  // Esperado: 30 -> 10 -> 15 -> 20 -> null

            // Teste 5: Inserção em uma posição específica fora do alcance (posição 10)
            list.InsertAtPosition(40, 10);
            Console.WriteLine("\nApós tentar inserir 40 na posição 10 (fora do alcance):");
            PrintList(list);  // Esperado: 30 -> 10 -> 15 -> 20 -> null

            // Teste 6: Inserção em uma posição negativa
            list.InsertAtPosition(5, -1);
            Console.WriteLine("\nApós tentar inserir 5 na posição -1 (início):");
            PrintList(list);  // Esperado: 30 -> 10 -> 15 -> 20 -> null

            // Teste 7: Inserção no final da lista
            list.InsertAtEnd(50);
            Console.WriteLine("\nApós inserir 50 no final:");
            PrintList(list);  // Esperado: 30 -> 10 -> 15 -> 20 -> 50 -> null

            // Teste 8: Inserção no meio da lista
            list.InsertAtPosition(25, 4);
            Console.WriteLine("\nApós inserir 25 na posição 4:");
            PrintList(list);  // Esperado: 30 -> 10 -> 15 -> 20 -> 25 -> 50 -> null
        }

        public static void TestRemove()
        {
            var list = new DoubleLinkedList();

            Console.WriteLine("Testando remoções em uma lista duplamente encadeada:");

            // Popula a lista para testes
            list.InsertAtEnd(10);
            list.InsertAtEnd(20);
            list.InsertAtEnd(30);
            list.InsertAtEnd(40);
            list.InsertAtEnd(50);
            Console.WriteLine("\nLista inicial:");
            PrintList(list);  // Esperado: 10 -> 20 -> 30 -> 40 -> 50 -> null

            // Teste 1: Remover o primeiro elemento
            list.RemoveAtBeginning();
            Console.WriteLine("\nApós remover o primeiro elemento:");
            PrintList(list);  // Esperado: 20 -> 30 -> 40 -> 50 -> null

            // Teste 2: Remover o último elemento
            list.RemoveAtEnd();
            Console.WriteLine("\nApós remover o último elemento:");
            PrintList(list);  // Esperado: 20 -> 30 -> 40 -> null

            // Teste 3: Remover elemento no meio da lista (posição 2, 1-based)
            list.RemoveAtPosition(2);
            Console.WriteLine("\nApós remover o elemento na posição 2:");
            PrintList(list);  // Esperado: 20 -> 40 -> null

            // Teste 4: Remover elemento na posição fora do alcance (posição 5)
            list.RemoveAtPosition(5);
            Console.WriteLine("\nApós tentar remover na posição 5 (fora do alcance):");
            PrintList(list);  // Esperado: 20 -> 40 -> null

            // Teste 5: Remover elemento na posição 1 (remover o primeiro)
            list.RemoveAtPosition(1);
            Console.WriteLine("\nApós remover o elemento na posição 1 (primeiro elemento):");
            PrintList(list);  // Esperado: 40 -> null

            // Teste 6: Remover elemento na posição 1 (último elemento restante)
            list.RemoveAtPosition(1);
            Console.WriteLine("\nApós remover o elemento na posição 1 (último elemento restante):");
            PrintList(list);  // Esperado: Lista vazia

            // Teste 7: Remover em uma lista vazia
            list.RemoveAtPosition(1);
            Console.WriteLine("\nApós tentar remover em uma lista vazia:");
            PrintList(list);  // Esperado: Lista vazia
        }

        private static void PrintList(DoubleLinkedList list)
        {
            var current = list.head;
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine();
        }

        public void InsertAtBeginning(int data)
        {
            var newNode = new DoubleNode(data);
            if (head == null)
            {
                head = tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head.Prev = newNode;
                head = newNode;
            }
        }

        public void InsertAtEnd(int data)
        {
            var newNode = new DoubleNode(data);
            if (tail == null)
            {
                head = tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                newNode.Prev = tail;
                tail = newNode;
            }
        }

        public void InsertAtPosition(int data, int position)
        {
            if (position < 0)
            {
                return;
            }

            if (position == 0)
            {
                InsertAtBeginning(data);
                return;
            }

            var newNode = new DoubleNode(data);
            var current = head;
            var index = 0;

            while (current != null && index < position - 1)
            {
                current = current.Next;
                index++;
            }

            if (current == null)
            {
                return;
            }

            if (current == tail)
            {
                InsertAtEnd(data);
            }
            else
            {
                newNode.Next = current.Next;
                newNode.Prev = current;
                current.Next.Prev = newNode;
                current.Next = newNode;
            }
        }

        public void RemoveAtBeginning()
        {
            if(head == null)
            {
                return;
            } 
            else if(head.Next == null)
            {
                head = null; 
            }
            else
            {
                head = head.Next;
                head.Prev = null; 
            }
        }

        public void RemoveAtEnd()
        {
            if (head == null)
            {
                return;
            }
            else if (head.Next == null)
            {
                head = null;
            }
            else
            {
                DoubleNode current = head;
                while (current.Next != null) 
                {
                    current = current.Next;
                }

                current.Prev.Next = null;
            }

        }

        public void RemoveAtPosition(int position)
        {
            if (head == null) 
            {
                return;
            }

            if (position < 1) 
            {
                return;
            }

            if (position == 1) 
            {
                RemoveAtBeginning();
                return;
            }

            DoubleNode current = head;
            int count = 1;

            while (current != null && count < position)
            {
                current = current.Next;
                count++;
            }

            if (current == null) 
            {
                return;
            }

            if (current.Next == null)
            {
                RemoveAtEnd();
                return;
            }

            current.Prev.Next = current.Next;
            current.Next.Prev = current.Prev;
        }

    }
}
