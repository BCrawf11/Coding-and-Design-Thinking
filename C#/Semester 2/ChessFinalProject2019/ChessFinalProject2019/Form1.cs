using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessFinalProject2019Home
{
    public partial class Form1 : Form
    {
        //all paths
        string RookWhitePath = AppDomain.CurrentDomain.BaseDirectory + @"RookW.png";
        string RookBlackPath = AppDomain.CurrentDomain.BaseDirectory + @"RookB.png";
        string KnightWhitePath = AppDomain.CurrentDomain.BaseDirectory + @"KnightW.png";
        string KnightBlackPath = AppDomain.CurrentDomain.BaseDirectory + @"KnightB.png";
        string BishopWhitePath = AppDomain.CurrentDomain.BaseDirectory + @"BishopW.png";
        string BishopBlackPath = AppDomain.CurrentDomain.BaseDirectory + @"BishopB.png";
        string QueenWhitePath = AppDomain.CurrentDomain.BaseDirectory + @"QueenW.png";
        string QueenBlackPath = AppDomain.CurrentDomain.BaseDirectory + @"QueenB.png";
        string KingWhitePath = AppDomain.CurrentDomain.BaseDirectory + @"KingW.png";
        string KingBlackPath = AppDomain.CurrentDomain.BaseDirectory + @"KingB.png";
        string PawnWhitePath = AppDomain.CurrentDomain.BaseDirectory + @"PawnW.png";
        string PawnBlackPath = AppDomain.CurrentDomain.BaseDirectory + @"PawnB.png";
        //////

        private bool button1Clicked = false;
        public bool whiteTurn = true;
        Grid chessBoard = new Grid();
        Button[,] buttons = new Button[8, 8];

        public Form1()
        {
            InitializeComponent();

            buttons[0, 7] = H1;
            buttons[1, 7] = H2;
            buttons[2, 7] = H3;
            buttons[3, 7] = H4;
            buttons[4, 7] = H5;
            buttons[5, 7] = H6;
            buttons[6, 7] = H7;
            buttons[7, 7] = H8;

            buttons[0, 6] = G1;
            buttons[1, 6] = G2;
            buttons[2, 6] = G3;
            buttons[3, 6] = G4;
            buttons[4, 6] = G5;
            buttons[5, 6] = G6;
            buttons[6, 6] = G7;
            buttons[7, 6] = G8;

            buttons[0, 5] = F1;
            buttons[1, 5] = F2;
            buttons[2, 5] = F3;
            buttons[3, 5] = F4;
            buttons[4, 5] = F5;
            buttons[5, 5] = F6;
            buttons[6, 5] = F7;
            buttons[7, 5] = F8;
            
            buttons[0, 4] = E1;
            buttons[1, 4] = E2;
            buttons[2, 4] = E3;
            buttons[3, 4] = E4;
            buttons[4, 4] = E5;
            buttons[5, 4] = E6;
            buttons[6, 4] = E7;
            buttons[7, 4] = E8;

            buttons[0, 3] = D1;
            buttons[1, 3] = D2;
            buttons[2, 3] = D3;
            buttons[3, 3] = D4;
            buttons[4, 3] = D5;
            buttons[5, 3] = D6;
            buttons[6, 3] = D7;
            buttons[7, 3] = D8;

            buttons[0, 2] = C1;
            buttons[1, 2] = C2;
            buttons[2, 2] = C3;
            buttons[3, 2] = C4;
            buttons[4, 2] = C5;
            buttons[5, 2] = C6;
            buttons[6, 2] = C7;
            buttons[7, 2] = C8;

            buttons[0, 1] = B1;
            buttons[1, 1] = B2;
            buttons[2, 1] = B3;
            buttons[3, 1] = B4;
            buttons[4, 1] = B5;
            buttons[5, 1] = B6;
            buttons[6, 1] = B7;
            buttons[7, 1] = B8;

            buttons[0, 0] = A1;
            buttons[1, 0] = A2;
            buttons[2, 0] = A3;
            buttons[3, 0] = A4;
            buttons[4, 0] = A5;
            buttons[5, 0] = A6;
            buttons[6, 0] = A7;
            buttons[7, 0] = A8;

            //sets all the white pieces to their buttons
            Image RookW = Image.FromFile(RookWhitePath);
            buttons[0, 0].BackgroundImage = RookW;
            buttons[7, 0].BackgroundImage = RookW;
            Image KnightW = Image.FromFile(KnightWhitePath);
            buttons[1, 0].BackgroundImage = KnightW;
            buttons[6, 0].BackgroundImage = KnightW;
            Image BishopW = Image.FromFile(BishopWhitePath);
            buttons[2, 0].BackgroundImage = BishopW;
            buttons[5, 0].BackgroundImage = BishopW;
            Image QueenW = Image.FromFile(QueenWhitePath);
            buttons[3, 0].BackgroundImage = QueenW;
            Image KingW = Image.FromFile(KingWhitePath);
            buttons[4, 0].BackgroundImage = KingW;

            for (int i = 0; i < 8; i++)
            {
                Image PawnW = Image.FromFile(PawnWhitePath);
                buttons[i, 1].BackgroundImage = PawnW;
            }
            //////

            //sets all the black pieces to their buttons
            Image RookB = Image.FromFile(RookBlackPath);
            buttons[0, 7].BackgroundImage = RookB;
            buttons[7, 7].BackgroundImage = RookB;
            Image KnightB = Image.FromFile(KnightBlackPath);
            buttons[1, 7].BackgroundImage = KnightB;
            buttons[6, 7].BackgroundImage = KnightB;
            Image BishopB = Image.FromFile(BishopBlackPath);
            buttons[2, 7].BackgroundImage = BishopB;
            buttons[5, 7].BackgroundImage = BishopB;
            Image QueenB = Image.FromFile(QueenBlackPath);
            buttons[3, 7].BackgroundImage = QueenB;
            Image KingB = Image.FromFile(KingBlackPath);
            buttons[4, 7].BackgroundImage = KingB;

            for (int i = 0; i < 8; i++)
            {
                Image PawnB = Image.FromFile(PawnBlackPath);
                buttons[i, 6].BackgroundImage = PawnB;
            }
            ////

            //makes the buttons a different color when you mouse over them
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    int x = i, y = j;
                    int x1, y1;

                    buttons[x, y].MouseEnter += (o, e) => HighlightPossibleRoutes(x, y);
                    buttons[x, y].MouseEnter += (o, e) => ChangeColor(x, y, Color.Tan);

                    if (Click1(x, y, e) == true)
                    {
                        x1 = x;
                        y1 = y;
                        buttons[x, y].Click += (o, e) => Click2MovePiece(x1, y1, x, y, e);
                    }

                }
            }
            //////
        }

        public void ChangeColor(int x, int y, Color c)
        {
            buttons[x, y].BackColor = c;
        }

        // when you mouse over the pieces, it shows you where they can move
        public void HighlightPossibleRoutes(int x, int y)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    ChangeColor(i, j, Color.Transparent);
                }
            }

            List<Tuple<int, int>> toColor = new List<Tuple<int, int>>();

            if (chessBoard.Highlight(x, y) == null)
            {
                toColor.Add(new Tuple<int, int>(x, y));
            }
            else
                toColor = chessBoard.Highlight(x, y);

            for (int i = 0; i < toColor.Count; i++)
            {
                if (toColor[i].Item1 == x && toColor[i].Item2 == y)
                {
                    break;
                }
                else
                    buttons[toColor[i].Item1, toColor[i].Item2].BackColor = Color.Cyan;
            }
        }

        private bool Click1(int x, int y, EventArgs e)
        {
            if (chessBoard.GetPieceString(x, y) != "Empty")
            {
                if ((chessBoard.GetPlayerString(x, y) == "White" && whiteTurn == true) || 
                    (chessBoard.GetPlayerString(x, y) == "Black" && whiteTurn == false))
                {
                    button1Clicked = true;
                }
            }
            else
                button1Clicked = false;

            return button1Clicked;
        }

        //only calls if another correct piece is clicked before
        private void Click2MovePiece(int x1, int y1, int x2, int y2, EventArgs e)
        {
            bool canMove = false;
            List<Tuple<int, int>> correctSpaces = new List<Tuple<int, int>>();
            Tuple<int, int> toMove = new Tuple<int, int>(x2, y2);

            Piece piece = chessBoard.GetPiece(x1, y1);
            Player player = chessBoard.GetPlayer(x1, y1);

            chessBoard.PieceMove(x1, y1, x2, y2, piece, player);
            correctSpaces = chessBoard.Highlight(x2, y2);

            for (int i = 0; i < correctSpaces.Count; i++)
            {
                if (correctSpaces[i] == toMove)
                {
                    canMove = true;
                    break;
                }
                else
                {
                    canMove = false;
                }
            }

            if (button1Clicked == true && canMove == true)
            {
                buttons[toMove.Item1, toMove.Item2].BackgroundImage = 
                    Image.FromFile(chessBoard.GetPieceString(toMove.Item1, toMove.Item2) + chessBoard.GetPlayerString(toMove.Item1, toMove.Item2) + "Path");
                buttons[x1, y1].BackgroundImage = null;

                if (chessBoard.GetPlayerString(toMove.Item1, toMove.Item2) == "Black")
                {
                    whiteTurn = true;
                }
                else
                    whiteTurn = false;
            }
            else
                return;
        }
    }
}
