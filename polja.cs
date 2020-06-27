using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace letsgopingpong
{
    class polja
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int speedX = 10;
        public int speedY = 10;

        public polja(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Draw(PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Blue, this.X, this.Y, 20, 20);
        }

        public void Move()
        {
            this.X -= speedX;
            this.Y -= speedY;
        }

        public void Reset()
        {
            this.X = 350;
            this.Y = 250;
        }

    }
}
