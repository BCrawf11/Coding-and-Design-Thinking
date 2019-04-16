using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sthachke
{
    class Stack
    {
        List<int> holder;

        public Stack()
        {
            holder = new List<int>();
        }

        //Push
        public void Push(int val)
        {
            holder.Add(val);
        }

        //Pop
        public int Pop()
        {
            if (holder.Count == 0)
            {
                return -1;
            }
            else
            {
                int hold = holder[holder.Count - 1];
                holder.RemoveAt(holder.Count - 1);
                return hold;
            }
        }

        //Peek
        public int Peek()
        {
            if (holder.Count == 0)
            {
                return -1;
            }
            else
            {
                return holder[holder.Count - 1];
            }
        }

        //Search
        public int Search(int val)
        {
            for (int i = holder.Count - 1; i >= 0; i--)
            {
                if (holder[i] == val)
                {
                    return (holder.Count - 1) - i;
                }
            }
            return -1;
        }

        //Print
        public void Print()
        {
            for (int i = 0; i < holder.Count; i++)
            {
                Console.Write(holder[i]);
            }
            Console.WriteLine();
        }
    }
}
