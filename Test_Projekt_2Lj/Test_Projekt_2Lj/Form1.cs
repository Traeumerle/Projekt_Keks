using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Projekt_2Lj
{
    public partial class Form1 : Form
    {
        private int x;
        private int y;
        private int x1;
        private int y1;
            public Form1()
        {
            x = 100;
            y = 100;
            x1 = 250;
            y1 = 250;
            InitializeComponent();
            

            
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.BlueViolet, x1, y1, 100, 50);
            e.Graphics.DrawImage(new Bitmap("creeper.jpg"),x,y,60,60);
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.W)
            {
                if (x +1 <= x1 + 100 && x >= x1-59 && y <= y1+50 && y >= y1)
                {
                    y += 10;
                }
                if (y <= 0)
                {
                    y = 600;
                }
                    y -= 10;
            }
            if (e.KeyCode == Keys.S)
            {
                if (x+1 <= x1 + 99 && x >= x1 -59 && y <= y1 && y+61 >= y1)
                {
                    y -= 10;
                }
                if (y > 600)
                {
                    y = 0;
                }
                    y += 10;
            }
            if (e.KeyCode == Keys.A)
            {
                if (x<=x1+101&& x >= x1 && y <= y1 + 49 && y + 59 >= y1)
                {
                    x += 10;
                }
                if (x <= 0)
                {
                    x = 900;
                }
                x -= 10;
            }
            if (e.KeyCode == Keys.D)
            {
                if (x >= x1-61 && x <= x1+99 && y <= y1 +49 && y+59 >= y1   )
                {
                    x -= 10;
                }
                if (x >= 900)
                {
                    x = 0;
                }
                x += 10;
            }
            Invalidate();
        }
    }
}
