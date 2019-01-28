using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Queueueue
{
    class Queue
    {
        List<int> queue = new List<int>();

        public void EnQueue(int val)
        {
            queue.Insert(0, val);
        }

        public int Peek()
        {
            if (queue.Count == 0)
            {
                return Int32.MaxValue;
            }

            return queue[queue.Count - 1];
        }

        public int DeQueue()
        {
            if (queue.Count == 0)
            {
                return Int32.MaxValue;
            }

            int hold = queue[queue.Count - 1];
            queue.RemoveAt(queue.Count - 1);
            return hold;
        }

        public void Print()
        {
            Console.Write("--------------------");
            Console.WriteLine();

            for (int i = 0; i < queue.Count; i++)
            {
                Console.Write(queue[i] + " ");

                if (i == queue.Count - 1)
                {
                    Console.WriteLine();
                }
            }

            if (queue.Count == 0)
            {
                Console.WriteLine("Empty queue!");
            }

            Console.Write("--------------------");
            Console.WriteLine();
        }

        public void Clear()
        {
            queue.Clear();
        }
    }
}
