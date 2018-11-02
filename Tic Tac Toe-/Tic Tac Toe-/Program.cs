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
            char player1 = ' ';
            char player2 = ' ';
            bool won = false;

            Console.WriteLine("Welcome to tic tac toe. To play this game, I need two players to play!");

            do
            {
                Console.WriteLine("Player 1, enter the marker that you want to be (one character).");
                player1 = char.Parse(Console.ReadLine());

                Console.WriteLine("Player 2, enter the marker that you want to be (one character).");
                player2 = char.Parse(Console.ReadLine());

                if (player1 == player2)
                {
                    Console.WriteLine("Both players have the same character! Choose a different character.");
                    Console.WriteLine();
                }
            }
            while (player1 == player2);

            DrawBoard(board);

            do
            {
                ProcessTurn(board, player1);

                DrawBoard(board);

                if (VerifyBoard(board, player1, player2) == player1)
                {
                    Console.Write("Player 1 wins!");
                    Console.WriteLine();
                    won = true;
                    break;
                }

                if (VerifyBoard(board, player1, player2) == 'T')
                {
                    Console.WriteLine("You tied!");
                    Console.WriteLine();
                    won = true;
                    break;
                }

                ProcessTurn(board, player2);

                DrawBoard(board);

                if (VerifyBoard(board, player1, player2) == player2)
                {
                    Console.Write("Player 2 wins!");
                    Console.WriteLine();
                    won = true;
                }
            }
            while (won == false);
        }

        static void ProcessTurn(char[,] board, char player)
        {
            bool invalid = false;

            Console.WriteLine();
            Console.WriteLine(player + ", enter an x coordinate to place your marker at.");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(player + ", enter a y coordinate to place your marker at.");
            int y = int.Parse(Console.ReadLine());

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(0); j++)
                {
                    if (y == i && x == j)
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

        static char VerifyBoard(char[,] board, char player1, char player2)
        {
            //vertical check (Player 1)
            if (board[0, 0] == player1 && board[0, 1] == player1 && board[0, 2] == player1)
            {
                return player1;
            }
            else if (board[1, 0] == player1 && board[1, 1] == player1 && board[1, 2] == player1)
            {
                return player1;
            }
            else if (board[2, 0] == player1 && board[2, 1] == player1 && board[2, 2] == player1)
            {
                return player1;
            }

            //horizontal check (Player 1)
            else if (board[0, 0] == player1 && board[1, 0] == player1 && board[2, 0] == player1)
            {
                return player1;
            }
            else if (board[0, 1] == player1 && board[1, 1] == player1 && board[2, 1] == player1)
            {
                return player1;
            }
            else if (board[0, 2] == player1 && board[1, 2] == player1 && board[2, 2] == player1)
            {
                return player1;
            }


            //diagonal check (Player 1)
            else if (board[0, 2] == player1 && board[1, 1] == player1 && board[2, 0] == player1)
            {
                return player1;
            }
            else if (board[0, 0] == player1 && board[1, 1] == player1 && board[2, 2] == player1)
            {
                return player1;
            }

            //----------------------------------------------------------------------

            //vertical check (Player 2)
            else if (board[0, 0] == player2 && board[0, 1] == player2 && board[0, 2] == player2)
            {
                return player2;
            }
            else if (board[1, 0] == player2 && board[1, 1] == player2 && board[1, 2] == player2)
            {
                return player2;
            }
            else if (board[2, 0] == player2 && board[2, 1] == player2 && board[2, 2] == player2)
            {
                return player2;
            }

            //horizontal check (Player 2)
            else if (board[0, 0] == player2 && board[1, 0] == player2 && board[2, 0] == player2)
            {
                return player2;
            }
            else if (board[0, 1] == player2 && board[1, 1] == player2 && board[2, 1] == player2)
            {
                return player2;
            }
            else if (board[0, 2] == player2 && board[1, 2] == player2 && board[2, 2] == player2)
            {
                return player2;
            }

            //diagonal check (Player 2)
            else if (board[0, 2] == player2 && board[1, 1] == player2 && board[2, 0] == player2)
            {
                return player2;
            }
            else if (board[0, 0] == player2 && board[1, 1] == player2 && board[2, 2] == player2)
            {
                return player2;
            }
            else
            {
                int count = 0;

                for (int i = 0; i < board.GetLength(0); i++)
                {
                    for (int j = 0; j < board.GetLength(0); j++)
                    {
                        if (board[i, j] == player1 || board[i, j] == player2)
                        {
                            count++;
                        }
                    }
                }
                if (count == 9)
                {
                    return 'T';
                }
            }
            return ' ';
        }
    }
}
