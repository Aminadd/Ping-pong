using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace letsgopingpong
{
    class igrac
    {
        public int X { get; set; }
        public int Y { get; set; }
        private int brojac = 0;

        public igrac(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Draw(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Purple, this.X, this.Y, 25, 100);
        }

        public void MoveIgrac()
        {
            if(brojac % 2 == 0)
            {
                if(this.Y >= 330)
                {
                    brojac++;
                }
                MoveDown();
            }
            else
            {
                if(this.Y <= 20)
                {
                    brojac++;
                }
                MoveUp();
            }
        }

        public void MoveDown()
        {
            this.Y += 10;
        }
        public void MoveUp()
        {
            this.Y -= 10;
        }
    }
}
