using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Hex_Battles
{

    class PictureBoxSoldier : PictureBox
    {

        private int[] d = { 104, 88, 75, 62, 49, 36, 23, 10, -6 };
        private int row;
        private int column;
        public PictureBoxSoldier(int i , int j):base()
        {
            this.row = i;
            this.column = j;
            int y = 10 + (35 * i), x = 390, switchcase = j;
            x = (x - i * 35) + (70 * j);
            x = x = (x - i * 35) + (55 * j) - d[j];

            this.BringSoldierImage(SoldierBoard.GetBoard()[i, j]);
            this.Location = new System.Drawing.Point(x, y);
            this.Size = new System.Drawing.Size(60, 60);
        }
        public void BringSoldierImage(int num)
        {
            string image = ImagePath.SoldierImage(num);
            if (image != null)
            {
                Image im = Image.FromFile(image);
                this.Image = new Bitmap(im, 60, 60);
                this.BackColor = Color.Transparent;
                this.BringToFront();
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
