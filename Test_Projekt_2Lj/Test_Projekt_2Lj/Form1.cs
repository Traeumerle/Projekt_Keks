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
        private int anfangplayerX = 100;
        private int anfangplayerY = 100;
        private int größeplayerX = 60;
        private int größeplayerY = 60;
        private int x1 = 250;
        private int y1 = 250;
        private int gx1 = 100;
        private int gy1 = 50;

        public Form1()
        {
            InitializeComponent();
        }

        public void genPlayer(object sender, PaintEventArgs e)
        {
            Random zufall = new Random(DateTime.Now.Millisecond);
            e.Graphics.FillRectangle(Brushes.Firebrick, zufall.Next(0, 901), zufall.Next(0, 601), zufall.Next(0, 100), zufall.Next(0, 100));
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            genPlayer(sender, e);
            e.Graphics.DrawImage(new Bitmap("creeper.jpg"), anfangplayerX, anfangplayerY, größeplayerX, größeplayerY);

        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                //if (anfangplayerX + 1 <= x1 + gx1 && anfangplayerX >= x1 - 59 && anfangplayerY <= y1 + gy1 && anfangplayerY >= y1)
                //{
                 //   anfangplayerY += 10;
                //}
                if (anfangplayerY <= 0)
                {
                    anfangplayerY = 600;
                }
                anfangplayerY -= 10;
            }
            if (e.KeyCode == Keys.S)
            {
                ////if (anfangplayerX <= x1 + gx1 - 1 && anfangplayerX >= x1 - 60 && anfangplayerY <= y1 && anfangplayerY + 60 >= y1)
                ////{
                 //anfangplayerY -= 10;
                ////}
                if (anfangplayerY > 600)
                {
                    anfangplayerY = 0;
                }
                anfangplayerY += 10;
            }
            if (e.KeyCode == Keys.A)
            {
                //if (anfangplayerX <= x1 + gx1 + 1 && anfangplayerX >= x1 && anfangplayerY <= y1 + gy1 - 1 && anfangplayerY + 59 >= y1)
                //{
                 //   anfangplayerX += 10;
                //}
                if (anfangplayerX <= 0)
                {
                    anfangplayerX = 900;
                }
                anfangplayerX -= 10;
            }
            if (e.KeyCode == Keys.D)
            {
                //if (anfangplayerX >= x1 - 61 && anfangplayerX <= x1 + gx1 - 1 && anfangplayerY <= y1 + gy1 - 1 && anfangplayerY + 59 >= y1)
                //{
                //  anfangplayerX -= 10;
                //}
                if (anfangplayerX >= 900)
                {
                    anfangplayerX = 0;
                }
                anfangplayerX += 10;
            }
            Invalidate();
        }
    }
}
