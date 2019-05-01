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

            //initializes white first row
            Nodes[0, 0] = new Node(Piece.Rook, Player.White, 0, 0);
            Nodes[0, 1] = new Node(Piece.Knight, Player.White, 0, 1);
            Nodes[0, 2] = new Node(Piece.Bishop, Player.White, 0, 2);
            Nodes[0, 3] = new Node(Piece.Queen, Player.White, 0, 3);
            Nodes[0, 4] = new Node(Piece.King, Player.White, 0, 4);
            Nodes[0, 5] = new Node(Piece.Bishop, Player.White, 0, 5);
            Nodes[0, 6] = new Node(Piece.Knight, Player.White, 0, 6);
            Nodes[0, 7] = new Node(Piece.Rook, Player.White, 0, 7);

            //initializes white pawns
            for (int i = 0; i < 8; i++)
            {
                Nodes[1, i] = new Node(Piece.Pawn, Player.White, 1, i);
            }

            //initializes empty spaces
            for (int i = 2; i < 6; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Nodes[i, j] = new Node(Piece.Empty, Player.Empty, i, j);
                }
            }

            //intializes black pawns
            for (int i = 0; i < 8; i++)
            {
                Nodes[6, i] = new Node(Piece.Pawn, Player.Black, 6, i);
            }

            //initializes black first row
            Nodes[7, 0] = new Node(Piece.Rook, Player.White, 7, 0);
            Nodes[7, 1] = new Node(Piece.Knight, Player.White, 7, 1);
            Nodes[7, 2] = new Node(Piece.Bishop, Player.White, 7, 2);
            Nodes[7, 3] = new Node(Piece.Queen, Player.White, 7, 3);
            Nodes[7, 4] = new Node(Piece.King, Player.White, 7, 4);
            Nodes[7, 5] = new Node(Piece.Bishop, Player.White, 7, 5);
            Nodes[7, 6] = new Node(Piece.Knight, Player.White, 7, 6);
            Nodes[7, 7] = new Node(Piece.Rook, Player.White, 7, 7);

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

            if (Nodes[x, y].piece == Piece.Empty)
            {
                correctSpaces.Add(new Tuple<int, int>(x, y));
                return correctSpaces;
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

            for (int x = -2; x <= 2; x++)
            {
                int y = 3 - Math.Abs(x);
                int xp = n.x + x;
                int yp = n.y + y;
                int yn = n.y - y;

                if (x == 0)
                {
                    continue;
                }

                if (xp <= 7 && xp >= 0 && yp <= 7 && Nodes[xp, yp].piece == Piece.Empty)
                {
                    correctSpaces.Add(new Tuple<int, int>(xp, yp));
                }

                if (xp <= 7 && xp >= 0 && yn >= 0 && Nodes[xp, yn].piece == Piece.Empty)
                {
                    correctSpaces.Add(new Tuple<int, int>(xp, yn));
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
