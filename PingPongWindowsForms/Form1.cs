using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPongWindowsForms
{
    public partial class Form1 : Form
    {
        const int movementSpeed = 3, top = 0, bottom = 333;
        bool isUpPressed, isDownPressed;
        int ballSpeedX = 3, ballSpeedY = 1;
        int numberOfTicksUpDirection=0, numberOfTicksDownDirection;


        public Form1()
        {
            InitializeComponent();
            //pictureBox3.Controls.Add(pictureBox1);
            //pictureBox3.Location = new Point(0, 0);
            aBall.BackColor = Color.Transparent;
            aPanel1.BackColor = Color.Transparent;
           // aPanel2.BackColor = Color.Transparent;
            //pictureBox1.BackColor = Color.Transparent;

        }
        private void aBallTimer_Tick(object sender, EventArgs e)
        {
            aPanel2.Location = new Point(aPanel2.Location.X,Math.Max(0, Math.Min( aPanel2.Location.Y + (ballSpeedY), bottom)));
            //aBall.Location = new Point(aBall.Location.X + ballSpeedX, aBall.Location.Y + ballSpeedY);
            pictureBox1.Location = new Point(pictureBox1.Location.X - ballSpeedX, pictureBox1.Location.Y + ballSpeedY);

            if (pictureBox1.Location.Y <= top || pictureBox1.Location.Y >= (bottom + aPanel2.Height-pictureBox1.Height))
            {
                ballSpeedY *= -1;
            }

           //else if (aPanel1.Bounds.Contains(pictureBox1.Bounds) || aPanel2.Bounds.Contains(pictureBox1.Bounds))
           // {
           //     ballSpeedX *= 1;
           // }

            if(aBall.Location.Y <= top || aBall.Location.Y >= (bottom+aPanel1.Height-aBall.Height))// || aPanel2.Location.Y>=bottom || aPanel2.Location.Y<=top)
            {
                ballSpeedY *= -1;

            }
            if(aPanel1.Bounds.IntersectsWith(pictureBox1.Bounds) || aPanel2.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                ballSpeedX *= -1;
            }

            if (pictureBox2.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                // ballSpeedX += 1;
                ballSpeedY += 1;
            }
            if (aPanel1.Bounds.IntersectsWith(aBall.Bounds) || (aPanel2.Bounds.IntersectsWith(aBall.Bounds)))
            {
                ballSpeedX *= -1;
            }
            //if ((aBall.Location.X - aPanel1.Location.X)*(aBall.Location.X - aPanel1.Location.X) < 2  && (aPanel1.Location.Y-aBall.Location.Y)*(aPanel1.Location.Y - aBall.Location.Y) < 2)
            //{
            //    ballSpeedX *= -1;
            //}


            //if (((aBall.Location.Y-aPanel1.Location.Y)^2 + (aBall.Location.X - aPanel1.Location.X)^2) <4)
            //{
            //    ballSpeedX *= -1;
            //}
            //if (aPanel2.Location.X == aBall.Location.X)
            //{
            //    ballSpeedX *= -1;
            //}

        }
        private void aTimer_Tick(object sender, EventArgs e)
        {
            //if (isUpPressed == true & isDownPressed == true)
            //while (isUpPressed & isDownPressed)
            //{
            //    aPanel1.Location = new Point(aPanel1.Location.X, aPanel1.Location.Y);
            //    {
            //        if (!isUpPressed  || !isDownPressed )
            //            break;
            //    }
            //}
                
            if (isUpPressed)
            {
                
                aPanel1.Location = new Point(aPanel1.Location.X,
                    Math.Max(top, aPanel1.Location.Y - (movementSpeed + numberOfTicksUpDirection/7))
                        );
                numberOfTicksUpDirection++;
            }  else
                numberOfTicksUpDirection = 0;

           

            if (isDownPressed)
            {
                aPanel1.Location = new Point(aPanel1.Location.X,
                   Math.Min(aPanel1.Location.Y + movementSpeed + numberOfTicksDownDirection/7, bottom)
                    );
                numberOfTicksDownDirection++;
            }
            else numberOfTicksDownDirection = 0;

           


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Up)
            { 
                isUpPressed = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                isDownPressed = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            { 
              isUpPressed = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                isDownPressed = false;
            }
        }
    }
}
