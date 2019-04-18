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

        public bool Remove(char c)
        {
            return false;
        }

        private bool Remove(NOde n, char c)
        {
            return false;
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
