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
            int input = 0;
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

            do
            {
                Console.WriteLine("Enter a number based on the action that you want to perform.");
                Console.WriteLine("1. Search for a letter");
                Console.WriteLine("2. Remove a letter");
                Console.WriteLine("3. Print the tree");
                Console.WriteLine("4. Pre Order Print the tree");
                Console.WriteLine("5. In Order Print the tree");
                Console.WriteLine("6. Post Order Print the tree");
                Console.WriteLine("7. Quit");
                Console.WriteLine();
                input = int.Parse(Console.ReadLine());

                char c;

                switch (input)
                {
                    case 1:
                        Console.WriteLine("Enter a letter to search for:");
                        c = Console.ReadLine()[0];
                        bt.Print();
                        Console.WriteLine(bt.Search(c));
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.WriteLine("Enter a letter to remove:");
                        c = Console.ReadLine()[0];

                        if (!bt.Search(c))
                        {
                            Console.WriteLine("Letter not found.");
                        }
                        else
                        {
                            bt.Remove(c);
                            Console.WriteLine("Letter was removed.");
                            Console.WriteLine();
                        }

                        bt.Print();
                        break;
                    case 3:
                        bt.Print();
                        break;
                    case 4:
                        bt.PreOrderPrint();
                        Console.WriteLine();
                        break;
                    case 5:
                        bt.InOrderPrint();  
                        Console.WriteLine();
                        break;
                    case 6:
                        bt.PostOrderPrint();
                        Console.WriteLine();
                        break;
                }
            }
            while (input != 7);
            Console.WriteLine();
        }
    }
}
