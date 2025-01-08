using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaPrepTech.DataStrutures.Lists
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node(int data) 
        {
            Data = data;
            Next = null; 
        }
    }

    public class SingleLinkedList
    {
        private Node head; 

        public SingleLinkedList()
        {
            head = null; 
        }

        public void Test()
        {
            TestInsert();
            TestRemove();           
            TestMiddleNodeAndReverseList();
        }

        public static void TestInsert()
        {
            SingleLinkedList list = new SingleLinkedList();

            Console.WriteLine("Testando inserções em uma lista encadeada:");

            // Teste 1: Inserção em uma lista vazia no início
            list.InsertAtBeginning(10);
            Console.WriteLine("\nApós inserir 10 no início (lista vazia):");
            list.PrintList();  // Esperado: 10 -> null

            // Teste 2: Inserção no final quando há apenas um elemento
            list.InsertAtEnd(20);
            Console.WriteLine("\nApós inserir 20 no final:");
            list.PrintList();  // Esperado: 10 -> 20 -> null

            // Teste 3: Inserção no início quando há elementos na lista
            list.InsertAtBeginning(30);
            Console.WriteLine("\nApós inserir 30 no início:");
            list.PrintList();  // Esperado: 30 -> 10 -> 20 -> null

            // Teste 4: Inserção em uma posição específica (posição 2, 1-based)
            list.InsertAtPosition(15, 2);
            Console.WriteLine("\nApós inserir 15 na posição 2:");
            list.PrintList();  // Esperado: 30 -> 10 -> 15 -> 20 -> null

            // Teste 5: Inserção em uma posição específica fora do alcance (posição 10)
            list.InsertAtPosition(40, 10);
            Console.WriteLine("\nApós tentar inserir 40 na posição 10 (fora do alcance):");
            list.PrintList();  // Esperado: 30 -> 10 -> 15 -> 20 -> 40 -> null

            // Teste 6: Inserção em uma posição negativa
            list.InsertAtPosition(5, -1);
            Console.WriteLine("\nApós tentar inserir 5 na posição -1 (início):");
            list.PrintList();  // Esperado: 5 -> 30 -> 10 -> 15 -> 20 -> 40 -> null

            // Teste 7: Inserção no final da lista
            list.InsertAtEnd(50);
            Console.WriteLine("\nApós inserir 50 no final:");
            list.PrintList();  // Esperado: 5 -> 30 -> 10 -> 15 -> 20 -> 40 -> 50 -> null

            // Teste 8: Inserção no meio da lista
            list.InsertAtPosition(25, 4);
            Console.WriteLine("\nApós inserir 25 na posição 4:");
            list.PrintList();  // Esperado: 5 -> 30 -> 10 -> 25 -> 15 -> 20 -> 40 -> 50 -> null
        }


        public static void TestRemove()
        {
            SingleLinkedList list = new SingleLinkedList();

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Testando remoções em uma lista encadeada:");

            // Adicionando elementos à lista
            list.InsertAtEnd(10);
            list.InsertAtEnd(20);
            list.InsertAtEnd(30);
            list.InsertAtEnd(40);
            list.InsertAtEnd(50);

            Console.WriteLine("Lista inicial:");
            list.PrintList();  // Esperado: 10 -> 20 -> 30 -> 40 -> 50 -> null

            // Testando remoção no início
            list.RemoveAtBeginning();
            Console.WriteLine("\nApós remover no início:");
            list.PrintList();  // Esperado: 20 -> 30 -> 40 -> 50 -> null

            // Testando remoção no final
            list.RemoveAtEnd();
            Console.WriteLine("\nApós remover no final:");
            list.PrintList();  // Esperado: 20 -> 30 -> 40 -> null

            // Testando remoção em uma posição específica (posição 2, removendo o valor 30)
            list.RemoveAtPosition(2);
            Console.WriteLine("\nApós remover na posição 2:");
            list.PrintList();  // Esperado: 20 -> 40 -> null

            // Testando remoção em uma posição específica (posição 1, removendo o valor 20)
            list.RemoveAtPosition(1);
            Console.WriteLine("\nApós remover na posição 1:");
            list.PrintList();  // Esperado: 40 -> null

            // Testando remoção em uma posição fora do alcance (posição 5, lista tem 1 elemento)
            list.RemoveAtPosition(5);
            Console.WriteLine("\nApós tentar remover na posição 5 (fora do alcance):");
            list.PrintList();  // Esperado: 40 -> null

            // Testando remoção na última posição existente
            list.RemoveAtPosition(1);
            Console.WriteLine("\nApós remover o último elemento:");
            list.PrintList();  // Esperado: null

            // Testando remoção de uma lista vazia
            list.RemoveAtBeginning();
            Console.WriteLine("\nApós tentar remover de uma lista vazia:");
            list.PrintList();  // Esperado: null
        }

        public static void TestMiddleNodeAndReverseList()
        {

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            // Teste do MiddleNode
            SingleLinkedList list = new SingleLinkedList();

            // Caso 1: Lista vazia
            Console.WriteLine("Teste MiddleNode com lista vazia:");
            Node middle = list.MiddleNode(list.head);
            Console.Write(middle == null ? "Lista vazia" : middle.Data.ToString());
            Console.WriteLine();

            // Adicionando elementos à lista
            list.InsertAtEnd(10);
            list.InsertAtEnd(20);
            list.InsertAtEnd(30);
            list.InsertAtEnd(40);
            list.InsertAtEnd(50);

            Console.WriteLine("\nTeste MiddleNode com lista de número ímpar de elementos:");
            middle = list.MiddleNode(list.head);
            Console.WriteLine(middle == null ? "Lista vazia" : middle.Data.ToString());  // Esperado: 30

            // Adicionando mais elementos para lista com número par de elementos
            list.InsertAtEnd(60);
            list.InsertAtEnd(70);

            Console.WriteLine("\nTeste MiddleNode com lista de número par de elementos:");
            middle = list.MiddleNode(list.head);
            Console.WriteLine(middle == null ? "Lista vazia" : middle.Data.ToString());  // Esperado: 40

            // Teste do ReverseList
            // Resetando a lista
            list = new SingleLinkedList();
            list.InsertAtEnd(10);
            list.InsertAtEnd(20);
            list.InsertAtEnd(30);
            list.InsertAtEnd(40);
            list.InsertAtEnd(50);

            Console.WriteLine("\nTeste ReverseList com lista de vários elementos:");
            Node reversedHead = list.ReverseList(list.head);
            Console.WriteLine("Lista invertida:");
            list.head = reversedHead;  // Atualizando a cabeça da lista para a lista invertida
            list.PrintList();  // Esperado: 50 -> 40 -> 30 -> 20 -> 10 -> null

            // Adicionando apenas um elemento
            list = new SingleLinkedList(); // Resetando a lista
            list.InsertAtEnd(10);

            Console.WriteLine("\nTeste ReverseList com lista de um elemento:");
            reversedHead = list.ReverseList(list.head);
            list.head = reversedHead;  // Atualizando a cabeça da lista
            list.PrintList();  // Esperado: 10 -> null

            // Lista vazia
            list = new SingleLinkedList(); // Resetando a lista

            Console.WriteLine("\nTeste ReverseList com lista vazia:");
            reversedHead = list.ReverseList(list.head);
            list.head = reversedHead;  // Atualizando a cabeça da lista
            list.PrintList();  // Esperado: null
        }

        public void PrintList()
        {
            Node current = head; 

            while(current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }

            Console.Write("null");
        }

        public void InsertAtBeginning(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = head; 
            head = newNode;
        }

        public void InsertAtEnd(int data)
        {
            Node newNode = new Node(data);

            if(head == null)
            {
                head = newNode;
            } else
            {
                Node current = head; 

                while(current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = newNode; 
            }
        }

        public void InsertAtPosition(int data, int position)
        {
            Node newNode = new Node(data);

            if(position <= 0)
            {
                InsertAtBeginning(data); 
            } else
            {
                Node current = head;
                int currentIndex = 0; 

                while(current != null && currentIndex < position - 1)
                {
                    current = current.Next;
                    currentIndex++;
                }

                if(current == null)
                {
                    InsertAtEnd(data); 
                } else
                {
                    newNode.Next = current.Next;
                    current.Next = newNode; 
                }
            }

        }

        public void RemoveAtBeginning()
        {
            if(head == null) { return; }
            head = head.Next; 
        }

        public void RemoveAtEnd()
        {
            // 10 -> 12 -> 14 -> 15 null

            if(head == null) { return; }

            if(head.Next == null)
            {
                head = null;
                return; 
            }

            //10
            Node prev = head; 

            //prev.Next.Next = 14, 15 
            while(prev.Next.Next != null)
            {
                //prev.Next = 12, 14 
                prev = prev.Next;
            }

            prev.Next = null; 
        }

        public void RemoveAtPosition(int position)
        {
            //10 -> 20 -> 30 -> 40 -> null 
            //p = 3 - > 30

            if(head == null) { return; }

            if(position <= 1)
            {
                RemoveAtBeginning();
                return;
            }

            //10
            Node prev = head;
            int currentIndex = 1; 

            while(prev!= null && currentIndex != position - 1)
            {
                //2
                currentIndex++;
                //20
                prev = prev.Next; 
            }


            if(prev == null || prev.Next == null)
            {
                return; 
            }

            prev.Next = prev.Next.Next;  
        }

        public Node MiddleNode(Node head)
        {
            if (head == null || head.Next == null)
            {
                return head;
            }

            Node rabbit = head;
            Node turtle = head;

            while (rabbit != null && rabbit.Next != null)
            {
                turtle = turtle.Next;
                rabbit = rabbit.Next.Next;
            }

            return turtle;
        }

        public Node ReverseList(Node head)
        {

            // 10 -> 20 - > 30 -> null 

            //it = 10
            Node it = head;
            Node prev = null;


            while (it != null)
            {
                //temp = 10, 20, 30
                Node temp = it;

                //it = 20, 30, null
                it = it.Next;

                //temp.next = null, 10, 20
                temp.Next = prev;

                //prev = [10,null] < - [20, 10] , <- [30, 20] 
                prev = temp;
            }

            return prev;
        }

        public Node MergeTwoLists(Node list1, Node list2)
        {
            if (list1 == null) return list2;
            if (list2 == null) return list1;

            if (list1.Data < list2.Data)
            {
                list1.Next = MergeTwoLists(list1.Next, list2);
                return list1;
            }
            else
            {
                list2.Next = MergeTwoLists(list1, list2.Next);
                return list2;
            }
        }
    }
}
