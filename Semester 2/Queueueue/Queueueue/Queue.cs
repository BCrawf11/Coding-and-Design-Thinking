using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Queueueue
{
    class Queue<T> : IClearable, IPrintable, ICountable where T : IComparable<T>
    {
        List<T> queue = new List<T>();

        public Queue() { }

        public void EnQueue(T val)
        {
            queue.Insert(0, val);
        }

        public T Peek()
        {
            if (queue.Count == 0)
            {
                return default(T);
            }

            return queue[queue.Count - 1];
        }

        public T DeQueue()
        {
            if (queue.Count == 0)
            {
                return default(T);
            }

            T hold = queue[queue.Count - 1];
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

        public int Search(T val)
        {
            for (int i = 0; i < queue.Count; i++)
            {
                if (val.CompareTo(queue[i]) == 0)
                {
                    return i;
                }
            }
            return Int32.MaxValue;
        }

        public void Clear()
        {
            queue.Clear();
        }

        public int Count()
        {
            return queue.Count;
        }
    }
}
