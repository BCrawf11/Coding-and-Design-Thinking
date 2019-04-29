using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessFinalProject2019
{
    class Grid
    {
        Node[,] Nodes;

        public Grid()
        {
            Nodes = new Node[8, 8];

            //initialize node array here
        }

        public List<Tuple<int, int>> Highlight(int x, int y)
        {
            List<Tuple<int, int>> correctSpaces = new List<Tuple<int, int>>();

            //foreach (var item in correctSpaces)
            //{
            //    item.Item1
            //}

            if (Nodes[x, y].piece == Piece.Rook)
            {
                return RookMovable(Nodes[x, y]);
            }

            if (Nodes[x, y].piece == Piece.Knight)
            {
                return KnightMovable(Nodes[x, y]);
            }

            if (Nodes[x, y].piece == Piece.Bishop)
            {
                return BishopMovable(Nodes[x, y]);
            }

            if (Nodes[x, y].piece == Piece.Queen)
            {
                return QueenMovable(Nodes[x, y]);
            }

            if (Nodes[x, y].piece == Piece.King)
            {
                return KingMovable(Nodes[x, y]);
            }

            if (Nodes[x, y].piece == Piece.Pawn)
            {
                return PawnMovable(Nodes[x, y]);
            }

            else
            {
                return null;
            }
        }

        public List<Tuple<int, int>> RookMovable(Node n)
        {
            List<Tuple<int, int>> correctSpaces = new List<Tuple<int, int>>();

            return correctSpaces;
        }

        public List<Tuple<int, int>> KnightMovable(Node n)
        {
            List<Tuple<int, int>> correctSpaces = new List<Tuple<int, int>>();

            bool taken = false;

            for (int x = -2; x <= 2; x++)
            {
                int y = 3 - Math.Abs(x);

                try
                {
                    if (x == 0)
                    {
                        continue;
                    }

                    if (!taken)
                    {
                        correctSpaces.Add(new Tuple<int, int>(n.x + x, n.y + 1));
                    }
                }

                catch (IndexOutOfRangeException e)
                {
                    taken = true;
                    continue;
                }
            }

            return correctSpaces;
        }

        public List<Tuple<int, int>> BishopMovable(Node n)
        {
            List<Tuple<int, int>> correctSpaces = new List<Tuple<int, int>>();

            return correctSpaces;
        }

        public List<Tuple<int, int>> QueenMovable(Node n)
        {
            List<Tuple<int, int>> correctSpaces = new List<Tuple<int, int>>();

            return correctSpaces;
        }

        public List<Tuple<int, int>> KingMovable(Node n)
        {
            List<Tuple<int, int>> correctSpaces = new List<Tuple<int, int>>();

            return correctSpaces;
        }

        public List<Tuple<int, int>> PawnMovable(Node n)
        {
            List<Tuple<int, int>> correctSpaces = new List<Tuple<int, int>>();

            bool taken = false;

            for (int x = - 1; x < 1; x++)
            {
                int y = x;

                try
                {
                    if (n.player == Player.Black && !taken)
                    {
                        correctSpaces.Add(new Tuple<int, int>(n.x, n.y - 1));
                        correctSpaces.Add(new Tuple<int, int>(n.x, n.y - 2));
                    }

                    if (n.player == Player.White && !taken)
                    {
                        correctSpaces.Add(new Tuple<int, int>(n.x, n.y + 1));
                        correctSpaces.Add(new Tuple<int, int>(n.x, n.y + 2));
                    }
                }

                catch (IndexOutOfRangeException e)
                {
                    taken = true;
                    continue;
                }
            }

            return correctSpaces;
        }
    }
}
