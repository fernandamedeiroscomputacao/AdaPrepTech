using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaPrepTech.DataStrutures.StackAndQueue
{
    public class MyStack
    {
        /******** 225 - implement-stack-using-queues *********/

        private Queue<int> queue1;
        private Queue<int> queue2;

        public MyStack()
        {
            queue1 = new Queue<int>();
            queue2 = new Queue<int>();
        }

        public void Push(int x)
        {
            queue1.Enqueue(x);
        }

        public int Pop()
        {
            while (queue1.Count > 1)
            {
                queue2.Enqueue(queue1.Dequeue());
            }
            var result = queue1.Dequeue();

            var temp = queue1;
            queue1 = queue2;
            queue2 = temp;

            return result;
        }

        public int Top()
        {
            while (queue1.Count > 1)
            {
                queue2.Enqueue(queue1.Dequeue());
            }
            var result = queue1.Peek();
            queue2.Enqueue(queue1.Dequeue());

            var temp = queue1;
            queue1 = queue2;
            queue2 = temp;


            return result;
        }

        public bool Empty()
        {
            return queue1.Count == 0;
        }

    }

}
