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
            Nodes[1, 0] = new Node(Piece.Knight, Player.White, 1, 0);
            Nodes[2, 0] = new Node(Piece.Bishop, Player.White, 2, 0);
            Nodes[3, 0] = new Node(Piece.Queen, Player.White, 3, 0);
            Nodes[4, 0] = new Node(Piece.King, Player.White, 4, 0);
            Nodes[5, 0] = new Node(Piece.Bishop, Player.White, 5, 0);
            Nodes[6, 0] = new Node(Piece.Knight, Player.White, 6, 0);
            Nodes[7, 0] = new Node(Piece.Rook, Player.White, 7, 0);

            //initializes white pawns
            for (int i = 0; i <= 7; i++)
            {
                Nodes[i, 1] = new Node(Piece.Pawn, Player.White, i, 1);
            }

            //initializes empty spaces
            for (int i = 0; i <= 7; i++)
            {
                for (int j = 2; j <= 5; j++)
                {
                    Nodes[i, j] = new Node(Piece.Empty, Player.Empty, i, j);
                }
            }

            //intializes black pawns
            for (int i = 0; i <= 7; i++)
            {
                Nodes[i, 6] = new Node(Piece.Pawn, Player.Black, i, 6);
            }

            //initializes black first row
            Nodes[0, 7] = new Node(Piece.Rook, Player.Black, 0, 7);
            Nodes[1, 7] = new Node(Piece.Knight, Player.Black, 1, 7);
            Nodes[2, 7] = new Node(Piece.Bishop, Player.Black, 2, 7);
            Nodes[3, 7] = new Node(Piece.Queen, Player.Black, 3, 7);
            Nodes[4, 7] = new Node(Piece.King, Player.Black, 4, 7);
            Nodes[5, 7] = new Node(Piece.Bishop, Player.Black, 5, 7);
            Nodes[6, 7] = new Node(Piece.Knight, Player.Black, 6, 7);
            Nodes[7, 7] = new Node(Piece.Rook, Player.Black, 7, 7);

            //debug
            Nodes[2, 4] = new Node(Piece.Queen, Player.Black, 2, 4);
            //Nodes[2, 4] = new Node(Piece.Bishop, Player.Black, 2, 4);
        }

        public void PieceMove(int x1, int y1, int x2, int y2, Piece piece, Player player)
        {
            Nodes[x2, y2] = new Node(piece, player, x2, y2);
            Nodes[x1, y1] = new Node(Piece.Empty, Player.Empty, x1, y1);
        }

        public Piece GetPiece(int x, int y)
        {
            Piece p = Nodes[x, y].piece;
            return p;
        }

        public string GetPieceString(int x, int y)
        {
            string s = Nodes[x, y].piece.ToString();
            return s;
        }

        public Player GetPlayer(int x, int y)
        {
            Player pl = Nodes[x, y].player;
            return pl;
        }

        public string GetPlayerString(int x, int y)
        {
            string s = Nodes[x, y].player.ToString();
            return s;
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

        //opposite color, etc & curly bois & other methods
        public List<Tuple<int, int>> RookMovable(Node n)
        {
            List<Tuple<int, int>> correctSpaces = new List<Tuple<int, int>>();

            bool lstopped = false;
            bool rstopped = false;

            for (int x = 0; x <= 7; x++)
            {
                int xp = n.x + x;
                int xn = n.x - x;

                if (x == 0)
                {
                    continue;
                }

                if (xp <= 7 && Nodes[xp, n.y].piece == Piece.Empty && !rstopped)
                {
                    correctSpaces.Add(new Tuple<int, int>(xp, n.y));
                }
                else
                    //if opposite color, etc & curly bois & other methods
                    rstopped = true;


                if (xn >= 0 && Nodes[xn, n.y].piece == Piece.Empty && !lstopped)
                {
                    correctSpaces.Add(new Tuple<int, int>(xn, n.y));
                }
                else
                    //if opposite color, etc & curly bois & other methods
                    lstopped = true;
            }

            bool ustopped = false;
            bool bstopped = false;

            for (int y = 0; y <= 7; y++)
            {
                int yp = n.y + y;
                int yn = n.y - y;

                if (y == 0)
                {
                    continue;
                }

                if (yp <= 7 && Nodes[n.x, yp].piece == Piece.Empty && !ustopped)
                {
                    correctSpaces.Add(new Tuple<int, int>(n.x, yp));
                }
                else
                    ustopped = true;

                if (yn >= 0 && Nodes[n.x, yn].piece == Piece.Empty && !bstopped)
                {
                    correctSpaces.Add(new Tuple<int, int>(n.x, yn));
                }
                else
                    bstopped = true;
            }

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

            bool ulstopped = false;
            bool urstopped = false;
            bool blstopped = false;
            bool brstopped = false;

            for (int x = 0; x <= 7; x++)
            {
                for (int y = 0; y <= 7; y++)
                {
                    int xp = n.x + x;
                    int xn = n.x - x;
                    int yp = n.y + y;
                    int yn = n.y - y;

                    if (x == 0 || y == 0)
                    {
                        continue;
                    }

                    if (Math.Abs(x) == Math.Abs(y))
                    {
                        //x is pos, y is pos
                        if (yp <= 7 && xp <= 7 && Nodes[xp, yp].piece == Piece.Empty && !urstopped)
                        {
                            correctSpaces.Add(new Tuple<int, int>(xp, yp));
                        }
                        else
                            urstopped = true;

                        //x is neg, y is pos
                        if (xn >= 0 && yp <= 7 && Nodes[xn, yp].piece == Piece.Empty && !ulstopped)
                        {
                            correctSpaces.Add(new Tuple<int, int>(xn, yp));
                        }
                        else
                            ulstopped = true;

                        //x is pos, y is neg
                        if (xp <= 7 && yn >= 0 && Nodes[xp, yn].piece == Piece.Empty && !brstopped)
                        {
                            correctSpaces.Add(new Tuple<int, int>(xp, yn));
                        }
                        else
                            brstopped = true;

                        //x is neg, y is neg
                        if (xn >= 0 && yn >= 0 && Nodes[xn, yn].piece == Piece.Empty && !blstopped)
                        {
                            correctSpaces.Add(new Tuple<int, int>(xn, yn));
                        }
                        else
                            blstopped = true;
                    }
                }
            }

            return correctSpaces;
        }

        public List<Tuple<int, int>> QueenMovable(Node n)
        {
            List<Tuple<int, int>> correctSpaces = new List<Tuple<int, int>>();

            bool ulstopped = false;
            bool urstopped = false;
            bool blstopped = false;
            bool brstopped = false;
            bool lstopped = false;
            bool rstopped = false;
            bool ustopped = false;
            bool bstopped = false;

            for (int x = 0; x <= 7; x++)
            {
                int xp = n.x + x;
                int xn = n.x - x;

                if (x == 0)
                {
                    continue;
                }

                if (xp <= 7 && Nodes[xp, n.y].piece == Piece.Empty && !rstopped)
                {
                    correctSpaces.Add(new Tuple<int, int>(xp, n.y));
                }
                else
                    rstopped = true;


                if (xn >= 0 && Nodes[xn, n.y].piece == Piece.Empty && !lstopped)
                {
                    correctSpaces.Add(new Tuple<int, int>(xn, n.y));
                }
                else
                    lstopped = true;

                for (int y = 0; y <= 7; y++)
                {
                    int yp = n.y + y;
                    int yn = n.y - y;

                    if (y == 0)
                    {
                        continue;
                    }

                    if (Math.Abs(x) == Math.Abs(y))
                    {
                        //x is pos, y is pos
                        if (yp <= 7 && xp <= 7 && Nodes[xp, yp].piece == Piece.Empty && !urstopped)
                        {
                            correctSpaces.Add(new Tuple<int, int>(xp, yp));
                        }
                        else
                            urstopped = true;

                        //x is neg, y is pos
                        if (xn >= 0 && yp <= 7 && Nodes[xn, yp].piece == Piece.Empty && !ulstopped)
                        {
                            correctSpaces.Add(new Tuple<int, int>(xn, yp));
                        }
                        else
                            ulstopped = true;

                        //x is pos, y is neg
                        if (xp <= 7 && yn >= 0 && Nodes[xp, yn].piece == Piece.Empty && !brstopped)
                        {
                            correctSpaces.Add(new Tuple<int, int>(xp, yn));
                        }
                        else
                            brstopped = true;

                        //x is neg, y is neg
                        if (xn >= 0 && yn >= 0 && Nodes[xn, yn].piece == Piece.Empty && !blstopped)
                        {
                            correctSpaces.Add(new Tuple<int, int>(xn, yn));
                        }
                        else
                            blstopped = true;
                    }

                    if (yp <= 7 && Nodes[n.x, yp].piece == Piece.Empty && !ustopped)
                    {
                        correctSpaces.Add(new Tuple<int, int>(n.x, yp));
                    }
                    else
                        ustopped = true;

                    if (yn >= 0 && Nodes[n.x, yn].piece == Piece.Empty && !bstopped)
                    {
                        correctSpaces.Add(new Tuple<int, int>(n.x, yn));
                    }
                    else
                        bstopped = true;
                }
            }

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

            for (int x = -1; x <= 1; x++)
            {
                int y = x;
                int xx = n.x + x;
                int yn1 = n.y - 1;
                int yn2 = n.y - 2;
                int yp1 = n.y + 1;
                int yp2 = n.y + 2;

                if (n.player == Player.Black && xx >= 0 && xx <= 7 && yn1 >= 0 && yn2 >= 0)
                {
                    if (x == 0)
                    {
                        correctSpaces.Add(new Tuple<int, int>(xx, yn1));

                        if (n.y == 6)
                        {
                            correctSpaces.Add(new Tuple<int, int>(xx, yn2));
                        }
                    }
                    else if (Nodes[xx, yn1].piece != Piece.Empty && Nodes[xx, yn1].player != Player.Black)
                    {
                        correctSpaces.Add(new Tuple<int, int>(xx, yn1));
                    }
                }

                if (n.player == Player.White && xx >= 0 && xx <= 7 && yp1 <= 7 && yp2 <= 7)
                {
                    if (x == 0)
                    {
                        correctSpaces.Add(new Tuple<int, int>(xx, yp1));

                        if (n.y == 1)
                        {
                            correctSpaces.Add(new Tuple<int, int>(xx, yp2));
                        }
                    }
                    else if (Nodes[xx, yp1].piece != Piece.Empty && Nodes[xx, yp1].player != Player.Black)
                    {
                        correctSpaces.Add(new Tuple<int, int>(xx, yp1));
                    }
                }

                continue;
            }

            return correctSpaces;
        }
    }
}
