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
        const int movementSpeed = 3, top = 0, bottom = 567, rightOfTheField = 983, leftOfTheField = 0;
        bool isUpPressed, isDownPressed;
        int ballSpeedX = 6, ballSpeedY = 3;
        int numberOfTicksUpDirection=0, numberOfTicksDownDirection;
        int n = 0;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.
        }

        public Form1()
        {

            InitializeComponent();
            

        }
        private void aBallTimer_Tick(object sender, EventArgs e)
        {
            
           // Ball.Location = new Point(Ball.Location.X - ballSpeedX, Ball.Location.Y + ballSpeedY);

            if (Ball.Location.Y <= top || Ball.Location.Y >= (bottom -  Ball.Height - 25))
            {
                ballSpeedY *= -1;
            }
            if (Ball.Location.X <= leftOfTheField || Ball.Location.X >= rightOfTheField - Ball.Width)
            {
                ballSpeedX *= -1;
            }
            Ball.Location = new Point(Ball.Location.X + ballSpeedX, Ball.Location.Y + ballSpeedY);

        }
        private void aTimer_Tick(object sender, EventArgs e)
        {

            n += 1;
            if (n % 2 == 0)
            {
                Ball.ImageLocation = "C:\\Users\\Валентин\\Desktop\\Soccerball.png";
            }
            if (n % 2 == 1)
            {
                Ball.ImageLocation = "C:\\Users\\Валентин\\Desktop\\maball.png";
            }





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
