using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hex_Battles
{
    public partial class HexBattles : Form
    {
        Board board;
        SoldierBoard SoldierBoard;
        PictureBoxHex[,] HexBoard;
        PictureBoxSoldier[,] SoldierPicBoard;
        public HexBattles()
        {
            board = new Board();
            SoldierBoard = new SoldierBoard();
            DrawHexBoard();
            InitializeComponent();
        }
        private void DrawHexBoard()
        {
            HexBoard = new PictureBoxHex[9, 9];
            SoldierPicBoard = new PictureBoxSoldier[9, 9];
            for (int i = 0; i < HexBoard.GetLength(0); i++)
            {
                for (int j = 0; j < HexBoard.GetLength(1); j++)
                {
                    HexBoard[i, j] = new PictureBoxHex(i, j);
                    this.Controls.Add(HexBoard[i, j]);

                    if (SoldierBoard.SoldierHexNum(i, j) == 1 || SoldierBoard.SoldierHexNum(i, j) == 2)
                    {
                        SoldierPicBoard[i, j] = new PictureBoxSoldier(i, j);
                        this.Controls.Add(SoldierPicBoard[i, j]);
                        SoldierPicBoard[i, j].Parent = HexBoard[i, j];
                        SoldierPicBoard[i, j].Location = new Point(0, 0);
                    }
                }
            }
        }
        private bool WinCheck(int[,] arr)
        {
            int p1 = 0, p2 = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (arr[i, j] == 1)
                    {
                        p1++;
                    }
                    if (arr[i, j] == 2)
                    {
                        p2++;
                    }
                }
                if (p1 != 0 && p2 != 0)
                    return false;
            }
            if (p1 > p2)
            {
                MessageBox.Show("Player 1 wins");
                return true;
            }
            else
            {
                MessageBox.Show("Player 2 wins");
                return true;
            }
        }
        private void Soldier_Click(object sender, EventArgs e)
        {
            PictureBoxSoldier solpic = (PictureBoxSoldier)sender;
            int player = SoldierBoard.GetBoard()[solpic.GetRow(), solpic.GetColumn()];
        }
        private void HexBattles_Load(object sender, EventArgs e)
        {
            
        }
    }
}
