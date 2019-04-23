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
        public int height;
        public int count;

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
                Remove(root, c);
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

            if (c < n.Value)
            {
                n.LeftChild = Remove(n.LeftChild, c);
            }

            else
            {
                if (n.RightChild == null)
                {
                    return n.LeftChild;
                }

                if (n.LeftChild == null)
                {
                    return n.RightChild;
                }

                NOde right = n.RightChild;
                char min = 'l';

                while (right.LeftChild != null)
                {
                    min = right.LeftChild.Value;
                    n = right.LeftChild;
                }

                n.RightChild = Remove(n.RightChild, min);
            }
            return n;
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

        }

        private void PreOrderPrint(NOde n)
        {

        }

        public void InOrderPrint()
        {

        }

        private void InOrderPrint(NOde n)
        {
            
        }

        public void PostOrderPrint()
        {

        }

        private void PostOrderPrint(NOde n)
        {

        }
    }
}
