using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_
{
    class Program
    {

        static void Main(string[] args)
        {
            char[,] board = new char[3, 3];
            int x = 0;
            int y = 0;
            int x2 = 0;
            int y2 = 0;

            bool quit = false;
            bool won = false;

            Console.WriteLine("Welcome to tic tac toe! To play this game, I need two players to play!");

            Console.WriteLine("Player 1, enter X.");
            char player1 = char.Parse(Console.ReadLine());

            Console.WriteLine("Player 2, enter O.");
            char player2 = char.Parse(Console.ReadLine());

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(0); j++)
                {
                    Console.Write("|  " + board[i, j] + "  |");
                }
                Console.WriteLine();
            }

            do
            {
                ProcessTurn(board, player1);

                DrawBoard(board);

                VerifyBoard(board);

                if (VerifyBoard(board) == 'X' || VerifyBoard(board) == 'O')
                {
                    Console.Write(" won!");
                    won = true;
                }

                ProcessTurn(board, player2);

                DrawBoard(board);

                VerifyBoard(board);

                if (VerifyBoard(board) == 'X' || VerifyBoard(board) == 'O')
                {
                    Console.Write(" won!");
                    won = true;
                }
            }
            while (quit == true || won == true);
        }

        static void ProcessTurn(char[,] board, char player)
        {
            bool invalid = false;

            Console.WriteLine();
            Console.WriteLine("Enter an x coordinate to place your marker at.");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a y coordinate to place your marker at.");
            int y = int.Parse(Console.ReadLine());

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(0); j++)
                {
                    if (x == i && y == j)
                    {
                        if (board[i, j] == 'X' || board[i, j] == 'O')
                        {
                            invalid = true;
                        }
                        if (invalid == false)
                        {
                            board[i, j] = player;
                        }
                    }
                    Console.WriteLine();
                }
                if (invalid == true)
                {
                    Console.WriteLine("You have selected an invalid space. Please try again.");
                    ProcessTurn(board, player);
                }
            }
        }

        static void DrawBoard(char[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(0); j++)
                {
                    Console.Write(board[i, j] + " |");
                }
                Console.WriteLine();
            }
        }

        static char VerifyBoard(char[,] board)
        {
            //vertical check (X)
            if (board[0, 0] == 'X' && board[0, 1] == 'X' && board[0, 2] == 'X')
            {
                return 'X';
            }
            else if (board[1, 0] == 'X' && board[1, 1] == 'X' && board[1, 2] == 'X')
            {
                return 'X';
            }
            else if (board[2, 0] == 'X' && board[2, 1] == 'X' && board[2, 2] == 'X')
            {
                return 'X';
            }

            //horizontal check (X)
            else if (board[0, 0] == 'X' && board[1, 0] == 'X' && board[2, 0] == 'X')
            {
                return 'X';
            }
            else if (board[0, 1] == 'X' && board[1, 1] == 'X' && board[2, 1] == 'X')
            {
                return 'X';
            }
            else if (board[0, 2] == 'X' && board[1, 2] == 'X' && board[2, 2] == 'X')
            {
                return 'X';
            }


            //diagonal check (X)
            else if (board[0, 2] == 'X' && board[1, 1] == 'X' && board[2, 0] == 'X')
            {
                return 'X';
            }
            else if (board[0, 0] == 'X' && board[1, 1] == 'X' && board[2, 2] == 'X')
            {
                return 'X';
            }

            //----------------------------------------------------------------------

            //vertical check (O)
            else if (board[0, 0] == 'O' && board[0, 1] == 'O' && board[0, 2] == 'O')
            {
                return 'O';
            }
            else if (board[1, 0] == 'O' && board[1, 1] == 'O' && board[1, 2] == 'O')
            {
                return 'O';
            }
            else if (board[2, 0] == 'O' && board[2, 1] == 'O' && board[2, 2] == 'O')
            {
                return 'O';
            }

            //horizontal check (O)
            else if (board[0, 0] == 'O' && board[1, 0] == 'O' && board[2, 0] == 'O')
            {
                return 'O';
            }
            else if (board[0, 1] == 'O' && board[1, 1] == 'O' && board[2, 1] == 'O')
            {
                return 'O';
            }
            else if (board[0, 2] == 'O' && board[1, 2] == 'O' && board[2, 2] == 'O')
            {
                return 'O';
            }

            //diagonal check (O)
            else if (board[0, 2] == 'O' && board[1, 1] == 'O' && board[2, 0] == 'O')
            {
                return 'O';
            }
            else if (board[0, 0] == 'O' && board[1, 1] == 'O' && board[2, 2] == 'O')
            {
                return 'O';
            }
            else
                return ' ';
        }
    }
}
