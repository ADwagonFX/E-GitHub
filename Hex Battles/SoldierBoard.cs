using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hex_Battles
{
    class SoldierBoard
    {
        private static int[,] SoldierHexBoard;
        public SoldierBoard()
        {
            {
                int push = 0, pull = -1;
                SoldierHexBoard = new int[9, 9];
                for (int i = 0; i < SoldierHexBoard.GetLength(0); i++)
                {
                    if (i < 5)
                    {
                        for (int j = 0; j <= (SoldierHexBoard.GetLength(1) - 5) + push; j++)
                        {
                            SoldierHexBoard[i, j] = -99;
                        }
                        push++;
                    }

                    if (i > 4)
                    {
                        for (int j = SoldierHexBoard.GetLength(1) - 1; j > 1 + pull; j--)
                        {
                            SoldierHexBoard[i, j] = -99;
                        }
                        pull++;
                    }
                }
                SoldierHexBoard[4, 0] = 1;
                SoldierHexBoard[4, 8] = 2;
            }
        }
        public static int SoldierHexNum(int i, int j)
        {
            return SoldierHexBoard[i, j];
        }
        public static int[,] GetBoard()
        {
            return SoldierHexBoard;
        }
        public bool LegalMove(int i1, int j1, int i2, int j2)
        {
            if (Board.GetBoard()[i2, j2] == 4)
                return false;
            if ((i1 + 2 == i2 || i1 - 2 == i2 && j1 + 2 == j2 || j1 - 2 == j2))
                if (i1 - 1 == i2 && j1 == j2 || (i1 + 1 == i2 && j1 == j2))
                    if (i1 - 1 == i2 && j1 - 1 == j2 || i1 + 1 == i2 && j1 == j2)
                        return true;
            return false;
        }
    }
}
