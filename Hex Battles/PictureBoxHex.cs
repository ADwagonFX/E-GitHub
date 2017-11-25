using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Hex_Battles
{

    class PictureBoxHex : PictureBox
    {
        private int row;
        private int column;
        public PictureBoxHex(int i, int j) : base()
        {
            int y = 10 + (35 * i), x = 390, switchcase = j;
            x = (x - i * 35) + (70 * j);
            switch (switchcase)
            {
                case 0:
                    x = (x - i * 35) + (55 * j) - 104;
                    break;
                case 1:
                    x = (x - i * 35) + (55 * j) - 88;
                    break;
                case 2:
                    x = (x - i * 35) + (55 * j) - 75;
                    break;
                case 3:
                    x = (x - i * 35) + (55 * j) - 62;
                    break;
                case 4:
                    x = (x - i * 35) + (55 * j) - 49;
                    break;
                case 5:
                    x = (x - i * 35) + (55 * j) - 36;
                    break;
                case 6:
                    x = (x - i * 35) + (55 * j) - 23;
                    break;
                case 7:
                    x = (x - i * 35) + (55 * j) - 10;
                    break;
                case 8:
                    x = (x - i * 35) + (55 * j) + 6;
                    break;
            }
            this.BringHexImage(Board.GetBoard()[i, j]);
            this.Location = new System.Drawing.Point(x, y);
            this.Size = new System.Drawing.Size(70, 70);
        }
        public void BringHexImage(int num)
        {
            string image = ImagePath.HexImage(num);
            if (image != null)
            {
                Image im = Image.FromFile(image);
                this.Image = new Bitmap(im, 70, 70);
                this.BackColor = Color.Transparent; 

            }
            else
            {
                this.Image = null;
                this.BackColor = Color.Transparent;

            }
        }
        public int GetRow()
        {
            return this.row;
        }
        public int GetColumn()
        {
            return this.column;
        }
    }
}
