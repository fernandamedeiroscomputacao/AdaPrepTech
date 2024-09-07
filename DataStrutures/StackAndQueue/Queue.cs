using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaPrepTech.DataStrutures.StackAndQueue
{
    using System;

    public class Queue
    {
        private int[] elements;
        private int front;
        private int rear;
        private int capacity;
        private int size;

        // Construtor
        public Queue(int size)
        {
            elements = new int[size];
            capacity = size;
            front = 0;
            rear = -1;
            this.size = 0;
        }

        public void Enqueue(int item)
        {
            if (size == capacity)
            {
                return;
            }
            rear = (rear + 1) % capacity; 
            elements[rear] = item;
            size++;
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                return -1; 
            }
            int item = elements[front];
            front = (front + 1) % capacity; 
            size--;
            return item;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                return -1; 
            }
            return elements[front];
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public int Size()
        {
            return size;
        }
    }
}
