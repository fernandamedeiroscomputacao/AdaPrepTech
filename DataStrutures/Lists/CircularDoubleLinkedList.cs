using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaPrepTech.DataStrutures.Lists
{
    public class CircularDoubleNode
    {
        public int Data { get; set; }
        public CircularDoubleNode Next { get; set; }
        public CircularDoubleNode Prev { get; set; }

        public CircularDoubleNode(int data)
        {
            Data = data;
            Next = this; 
            Prev = this; 
        }
    }

    public class CircularDoubleLinkedList
    {
        private CircularDoubleNode head;

        public CircularDoubleLinkedList()
        {
            head = null;
        }

        public void Test()
        {
            TestCircularDoubleLinkedListInsert(); 
        }

        public static void TestCircularDoubleLinkedListInsert()
        {
            var list = new CircularDoubleLinkedList();

            Console.WriteLine("Testando inserções em uma lista circular duplamente encadeada:");

            // Teste 1: Inserção no início em uma lista vazia
            list.InsertAtBeggining(10);
            Console.WriteLine("\nApós inserir 10 no início (lista vazia):");
            list.PrintList();  // Esperado: 10 -> 10 ...

            // Teste 2: Inserção no final quando há apenas um elemento
            list.InsertAtEnd(20);
            Console.WriteLine("\nApós inserir 20 no final:");
            list.PrintList();  // Esperado: 10 -> 20 -> 10 -> ...

            // Teste 3: Inserção no início quando há elementos na lista
            list.InsertAtBeggining(30);
            Console.WriteLine("\nApós inserir 30 no início:");
            list.PrintList();  // Esperado: 30 -> 10 -> 20 -> 30 -> ...

            // Teste 4: Inserção em uma posição específica (posição 2, 0-based)
            list.InsertAtPosition(15, 2);
            Console.WriteLine("\nApós inserir 15 na posição 2:");
            list.PrintList();  // Esperado: 30 -> 10 -> 15 -> 20 -> ...

            // Teste 5: Inserção em uma posição específica fora do alcance (posição 10)
            list.InsertAtPosition(40, 10);
            Console.WriteLine("\nApós tentar inserir 40 na posição 10 (fora do alcance):");
            list.PrintList();  // Esperado: 30 -> 10 -> 15 -> 20  ...

            // Teste 6: Inserção em uma posição negativa
            list.InsertAtPosition(5, -1);
            Console.WriteLine("\nApós tentar inserir 5 na posição -1 (início):");
            list.PrintList();  // Esperado: 30 -> 10 -> 15 -> 20 -> ...

            // Teste 7: Inserção no final da lista
            list.InsertAtEnd(50);
            Console.WriteLine("\nApós inserir 50 no final:");
            list.PrintList();  // Esperado: 30 -> 10 -> 15 -> 20 -> 50 -> ...

            // Teste 8: Inserção no meio da lista
            list.InsertAtPosition(25, 4);
            Console.WriteLine("\nApós inserir 25 na posição 4:");
            list.PrintList();  // Esperado: 30 -> 10 -> 15 -> 25 -> 20 -> 50 -> ...
        }

        public void PrintList()
        {
            if (head == null) return;

            var current = head;
            do
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            } while (current != head);
            Console.WriteLine();
        }

        public void InsertAtBeggining(int data)
        {
            var newNode = new CircularDoubleNode(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.Next = head;
                newNode.Prev = head.Prev;
                head.Prev.Next = newNode;
                head.Prev = newNode;
                head = newNode;
            }
        }

        public void InsertAtEnd(int data)
        {
            var newNode = new CircularDoubleNode(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.Next = head;
                newNode.Prev = head.Prev;
                head.Prev.Next = newNode;
                head.Prev = newNode;
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
                InsertAtBeggining(data);
                return;
            }

            var newNode = new CircularDoubleNode(data);
            var current = head;
            var index = 0;

            while (current != null && index < position - 1)
            {
                current = current.Next;
                index++;
                if (current == head) 
                {
                    return;
                }
            }

            if (current == null)
            {
                return;
            }

            newNode.Next = current.Next;
            newNode.Prev = current;
            current.Next.Prev = newNode;
            current.Next = newNode;
        }        
    }

}
