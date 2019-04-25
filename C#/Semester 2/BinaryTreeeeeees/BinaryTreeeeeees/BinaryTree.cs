using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeeeeees
{
    class BinaryTree
    {
        private NOde root;

        public void Print()
        {
            BinaryTreePrinter.printNode(root);
        }
        private int countRecursive(NOde n)
        {
            return 0;
        }

        public void Insert(char c)
        {
            if (root == null)
            {
                root = new NOde(c);
            }
            else
            {
                Insert(root, c);
            }
        }

        private void Insert(NOde n, char c)
        {
            if (c >= n.Value && n.RightChild == null)
            {
                n.RightChild = new NOde(c);
                return;
            }

            if (c < n.Value && n.LeftChild == null)
            {
                n.LeftChild = new NOde(c);
                return;
            }

            if (c >= n.Value)
            {
                Insert(n.RightChild, c);
            }

            if (c <= n.Value)
            {
                Insert(n.LeftChild, c);
            }
        }

        public void Remove(char c)
        {
            if (root == null)
            {
                return;
            }
            else
                root = Remove(root, c);
        }

        private NOde Remove(NOde n, char c)
        {
            if (n == null)
            {
                return n;
            }

            if (c > n.Value)
            {
                n.RightChild = Remove(n.RightChild, c);
            }

            else if (c < n.Value)
            {
                n.LeftChild = Remove(n.LeftChild, c);
            }

            else
            {
                if (n.LeftChild == null)
                {
                    return n.RightChild;
                }

                if (n.RightChild == null)
                {
                    return n.LeftChild;
                }

                n.Value = MinValue(n.RightChild);
                n.RightChild = Remove(n.RightChild, n.Value);
            }
            return n;
        }

        private char MinValue(NOde n)
        {
            char min = n.Value;
            while (n.LeftChild != null)
            {
                min = n.LeftChild.Value;
                n = n.LeftChild;
            }
            return min;
        }

        public bool Search(char c)
        {
            if (root.Value == c)
            {
                return true;
            }
            else
            {
                return Search(root, c);
            }
        }

        private bool Search(NOde n, char c)
        {
            if (c > n.Value && n.RightChild != null)
            {
                return Search(n.RightChild, c);
            }

            if (c < n.Value && n.LeftChild != null)
            {
                return Search(n.LeftChild, c);
            }

            if (c == n.Value)
            {
                return true;
            }
            else
                return false;
        }

        public void PreOrderPrint()
        {
            if (root != null)
            {
                PreOrderPrint(root);
            }
            else
                Console.WriteLine("No tree to process.");
        }

        private void PreOrderPrint(NOde n)
        {
            Console.Write(n.Value + ", ");

            if (n.LeftChild != null)
            {
                PreOrderPrint(n.LeftChild);
            }

            if (n.RightChild != null)
            {
                PreOrderPrint(n.RightChild);
            }
        }

        public void InOrderPrint()
        {
            if (root != null)
            {
                InOrderPrint(root);
            }
            else
                Console.WriteLine("No tree to process.");
        }

        private void InOrderPrint(NOde n)
        {
            if (n.LeftChild != null)
            {
                InOrderPrint(n.LeftChild);
            }

            Console.Write(n.Value + ", ");

            if (n.RightChild != null)
            {
                InOrderPrint(n.RightChild);
            }
        }

        public void PostOrderPrint()
        {
            if (root != null)
            {
                PostOrderPrint(root);
            }
            else
                Console.WriteLine("No tree to process.");
        }

        private void PostOrderPrint(NOde n)
        {
            if (n.LeftChild != null)
            {
                PostOrderPrint(n.LeftChild);
            }

            if (n.RightChild != null)
            {
                PostOrderPrint(n.RightChild);
            }

            Console.Write(n.Value + ", ");
        }
    }
}
