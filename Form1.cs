using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace letsgopingpong
{
    public partial class Form1 : Form
    {
        Keys key;
        
        public Form1()
        {
            InitializeComponent();
        }

        igrac igrac = new igrac(50, 20);
        polja loptica = new polja(350, 250);
        igrac bott = new igrac(710, 20);

        int igrpts = 0;
        int botpts = 0;

        public void IgracMove()
        {
            switch(key)
            {
                case Keys.Up:
                    if (igrac.Y >= 20)
                        igrac.Y -= 10;
                    break;
                case Keys.Down:
                    if (igrac.Y <= 330)
                        igrac.Y += 10;
                    break;
            }
        }

        public void odbijanje()
        {
            if(loptica.Y <= 0) { loptica.speedY *= -1; }
            else if(loptica.Y >= 410) { loptica.speedY *= -1; }
            else if(loptica.X==igrac.X && igrac.Y < loptica.Y && loptica.Y < igrac.Y + 100)
            {
                loptica.speedX *= -1;
            }
            else if(loptica.X == bott.X && bott.Y< loptica.Y && loptica.Y < bott.Y +100)
            {
                loptica.speedX *= -1;
            }
        }

        public void pobeda()
        {
            if(loptica.X <= 0) { botpts++; botpoeni.Text = botpts.ToString(); loptica.Reset(); }
            else if( loptica.X >= 720) { igrpts++; igrpoeni.Text = igrpts.ToString(); loptica.Reset(); }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            IgracMove();
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
            igrac.Draw(e);
            bott.Draw(e);
            bott.MoveIgrac();
            loptica.Draw(e);
            loptica.Move();
            odbijanje();
            pobeda();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            key = e.KeyCode;
        }
    }
}
