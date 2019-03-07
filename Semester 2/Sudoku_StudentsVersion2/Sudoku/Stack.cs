using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Stack<T>
    {
        List<T> stack = new List<T>();

        static int timesPushed = 0;
        static int timesPopped = 0;
        static int maxAmount = 0;

        /// <summary>
        /// Default constructor to create a stack class
        /// </summary>
        public Stack()
        {

        }

        public int Count { get { return stack.Count; } }

        /// <summary>
        /// Enstacks a new board to the back of the stack.
        /// </summary>
        /// <param name="value">The board to add</param>

        public void Push(T value)
        {
            stack.Add(value);
            timesPushed++;
            if (maxAmount < stack.Count)
                maxAmount = stack.Count;
        }

        /// <summary>
        /// Takes the front element of the stack and returns it. Removes it from the stack
        /// </summary>
        /// <returns>The removed board</returns>
        public T Pop()
        {
            timesPopped++;
            T retVal = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);
            return retVal;
        }

        /// <summary>
        /// Peeks at the front of the stack without removing it.
        /// </summary>
        /// <returns>The board at the front of the stack</returns>
        public T Peek()
        {
            return stack[stack.Count - 1];
        }
    }
}
