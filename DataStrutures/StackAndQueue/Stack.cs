using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaPrepTech.DataStrutures.Stack
{
    using System;

    public class Stack
    {
        private int[] elements;
        private int top;
        private int capacity;

        public Stack(int size)
        {
            elements = new int[size];
            capacity = size;
            top = -1;
        }

        public void Push(int item)
        {
            if (top == capacity - 1)
            {
                return;
            }
            elements[++top] = item;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                return -1; 
            }
            return elements[top--];
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                return -1; 
            }
            return elements[top];
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public int Size()
        {
            return top + 1;
        }
    }
}
