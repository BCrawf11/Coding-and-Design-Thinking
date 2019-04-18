using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeeeeees
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree bt = new BinaryTree();
            bt.Insert('k');
            bt.Insert('v');
            bt.Insert('r');
            bt.Insert('l');
            bt.Insert('c');
            bt.Insert('o');
            bt.Insert('t');
            bt.Insert('g');
            bt.Insert('a');
            bt.Insert('n');
            bt.Insert('y');
            bt.Print();
            Console.WriteLine("Enter a letter to search for:");
            char input = Console.ReadLine()[0];
            bt.Print();
            Console.WriteLine(bt.Search(input));
        }
    }
}
