using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessFinalProject2019
{
    public partial class Form1 : Form
    {
        Button[,] buttons = new Button[8, 8];

        public Form1()
        {
            InitializeComponent();

            buttons[7, 0] = H1;
            buttons[7, 1] = H2;
            buttons[7, 2] = H3;
            buttons[7, 3] = H4;
            buttons[7, 4] = H5;
            buttons[7, 5] = H6;
            buttons[7, 6] = H7;
            buttons[7, 7] = H8;

            buttons[6, 0] = G1;
            buttons[6, 1] = G2;
            buttons[6, 2] = G3;
            buttons[6, 3] = G4;
            buttons[6, 4] = G5;
            buttons[6, 5] = G6;
            buttons[6, 6] = G7;
            buttons[6, 7] = G8;

            buttons[5, 0] = F1;
            buttons[5, 1] = F2;
            buttons[5, 2] = F3;
            buttons[5, 3] = F4;
            buttons[5, 4] = F5;
            buttons[5, 5] = F6;
            buttons[5, 6] = F7;
            buttons[5, 7] = F8;
            
            buttons[4, 0] = E1;
            buttons[4, 1] = E2;
            buttons[4, 2] = E3;
            buttons[4, 3] = E4;
            buttons[4, 4] = E5;
            buttons[4, 5] = E6;
            buttons[4, 6] = E7;
            buttons[4, 7] = E8;

            buttons[3, 0] = D1;
            buttons[3, 1] = D2;
            buttons[3, 2] = D3;
            buttons[3, 3] = D4;
            buttons[3, 4] = D5;
            buttons[3, 5] = D6;
            buttons[3, 6] = D7;
            buttons[3, 7] = D8;

            buttons[2, 0] = C1;
            buttons[2, 1] = C2;
            buttons[2, 2] = C3;
            buttons[2, 3] = C4;
            buttons[2, 4] = C5;
            buttons[2, 5] = C6;
            buttons[2, 6] = C7;
            buttons[2, 7] = C8;

            buttons[1, 0] = B1;
            buttons[1, 1] = B2;
            buttons[1, 2] = B3;
            buttons[1, 3] = B4;
            buttons[1, 4] = B5;
            buttons[1, 5] = B6;
            buttons[1, 6] = B7;
            buttons[1, 7] = B8;

            buttons[0, 0] = A1;
            buttons[0, 1] = A2;
            buttons[0, 2] = A3;
            buttons[0, 3] = A4;
            buttons[0, 4] = A5;
            buttons[0, 5] = A6;
            buttons[0, 6] = A7;
            buttons[0, 7] = A8;

            //all paths
            string rwpath = AppDomain.CurrentDomain.BaseDirectory + @"RookW.png";
            string rbpath = AppDomain.CurrentDomain.BaseDirectory + @"RookB.png";
            string knwpath = AppDomain.CurrentDomain.BaseDirectory + @"KnightW.png";
            string knbpath = AppDomain.CurrentDomain.BaseDirectory + @"KnightB.png";
            string bwpath = AppDomain.CurrentDomain.BaseDirectory + @"BishopW.png";
            string bbpath = AppDomain.CurrentDomain.BaseDirectory + @"BishopB.png";
            string qwpath = AppDomain.CurrentDomain.BaseDirectory + @"QueenW.png";
            string qbpath = AppDomain.CurrentDomain.BaseDirectory + @"QueenB.png";
            string kiwpath = AppDomain.CurrentDomain.BaseDirectory + @"KingW.png";
            string kibpath = AppDomain.CurrentDomain.BaseDirectory + @"KingB.png";
            string pwpath = AppDomain.CurrentDomain.BaseDirectory + @"PawnW.png";
            string pbpath = AppDomain.CurrentDomain.BaseDirectory + @"PawnB.png";
            //////
            
            //sets all the white pieces to their buttons
            Image RookW = Image.FromFile(rwpath);
            buttons[0, 0].BackgroundImage = RookW;
            buttons[0, 7].BackgroundImage = RookW;
            Image KnightW = Image.FromFile(knwpath);
            buttons[0, 1].BackgroundImage = KnightW;
            buttons[0, 6].BackgroundImage = KnightW;
            Image BishopW = Image.FromFile(bwpath);
            buttons[0, 2].BackgroundImage = BishopW;
            buttons[0, 5].BackgroundImage = BishopW;
            Image QueenW = Image.FromFile(qwpath);
            buttons[0, 3].BackgroundImage = QueenW;
            Image KingW = Image.FromFile(kiwpath);
            buttons[0, 4].BackgroundImage = KingW;

            for (int i = 0; i < 8; i++)
            {
                Image PawnW = Image.FromFile(pwpath);
                buttons[1, i].BackgroundImage = PawnW;
            }
            //////

            //sets all the black pieces to their buttons
            Image RookB = Image.FromFile(rbpath);
            buttons[7, 0].BackgroundImage = RookB;
            buttons[7, 7].BackgroundImage = RookB;
            Image KnightB = Image.FromFile(knbpath);
            buttons[7, 1].BackgroundImage = KnightB;
            buttons[7, 6].BackgroundImage = KnightB;
            Image BishopB = Image.FromFile(bbpath);
            buttons[7, 2].BackgroundImage = BishopB;
            buttons[7, 5].BackgroundImage = BishopB;
            Image QueenB = Image.FromFile(qbpath);
            buttons[7, 3].BackgroundImage = QueenB;
            Image KingB = Image.FromFile(kibpath);
            buttons[7, 4].BackgroundImage = KingB;

            for (int i = 0; i < 8; i++)
            {
                Image PawnB = Image.FromFile(pbpath);
                buttons[6, i].BackgroundImage = PawnB;
            }
            //////

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    int x = i, y = j;
                    buttons[i, j].MouseEnter += (o, e) => ChangeColor(x, y, Color.Cyan);
                    buttons[i, j].MouseLeave += (o, e) => ChangeColor(x, y, Color.Transparent);
                }
            }
        }

        public void ChangeColor(int x, int y, Color c)
        {
            buttons[x, y].BackColor = c;
        }
    }
}
