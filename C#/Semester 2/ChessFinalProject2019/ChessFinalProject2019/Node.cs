using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessFinalProject2019
{
    public enum Piece { Rook, Knight, Bishop, Queen, King, Pawn, Empty }
    public enum Player { White, Black, Empty }

    public class Node
    {
        public Piece piece;
        public Player player;
        public int x;
        public int y;

        public Node (Piece p, Player pl, int x, int y)
        {
            this.piece = p;
            this.player = pl;
            this.x = x;
            this.y = y;
        }
    }
}
