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
            TestInsert();
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
    }
}
