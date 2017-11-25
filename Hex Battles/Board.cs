using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hex_Battles
{
    class Board
    {
        private static int[,] HexBoard; // Game Board Array
        public Board()
        {
            int push = 0, pull = -1; 
            HexBoard = new int[9, 9];
            Random rnd = new Random();
            for (int i = 0; i < HexBoard.GetLength(0); i++)
            {
                if(i < 5)
                {
                    for (int j = 0; j <= (HexBoard.GetLength(1) - 5) + push ; j++)
                    {
                        HexBoard[i, j] = Percentage(rnd.Next(1, 101));
                    }
                    push++;
                }

                if(i > 4)
                {
                    for (int j = HexBoard.GetLength(1) - 1; j > 1 + pull; j--)
                    {
                        HexBoard[i, j] = Percentage(rnd.Next(1, 101));
                    }
                    pull++;
                }
            }
        }
        public static int HexNum(int i, int j)
        {
            return HexBoard[i, j];
        } 
        public static int[,] GetBoard()
        {
            return HexBoard;
        }
        public int Percentage(int save)
        {
            if (save <= 60)
                return 1;
            if (save <= 80 && save > 60)
                return 2;
            if (save <= 85 && save > 80)
                return 3;
            else
                return 4;
        }
    }
}
