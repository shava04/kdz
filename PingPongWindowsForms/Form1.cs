using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace PingPongWindowsForms
{

    public partial class Form1 : Form
    {
        const int top = 39, bottom = 510, rightOfTheField = 1050, leftOfTheField = 84;
        int movementSpeed = 6, directionSpeed;
        int compSpeed = 2;
        bool isUpPressed, isDownPressed, gameEnd = false;
        int ballSpeedX = 10, ballSpeedY = 4;
        int numberOfTicksUpDirection=0, numberOfTicksDownDirection;
        int playerScore = 0, compScore = 0;
        int compdirect;
        int n = 0;
        int m = 1;
        int sec = 0,secTen = 0, min = 0;
        

        SoundPlayer goalScored = new SoundPlayer("goalscored.wav");
        SoundPlayer buffoniche = new SoundPlayer("буффонище.wav");
        SoundPlayer whistle = new SoundPlayer("whistlee.wav");

        private void Time()
        {

        }
        

        private void ShowGoal()
        {
            news.Visible = true;
            playerScoreBig.Visible = true;
            compScoreBig.Visible = true;
            aTimer.Enabled = false;
            aCompTimer.Enabled = false;
            n = 0;
            aBallTimer.Enabled = true;
            compScoreBig.Text = compScore.ToString();
            playerScoreBig.Text = playerScore.ToString();
        }

        private void Scoring()
        {          
            Ball.Location = new Point(558, 271);
            PlayerScore.Text = playerScore.ToString();
            CmpScore.Text = compScore.ToString();                                           
        }




        private void CompTeamUp()
        {
            ForwComp1.Location = new Point(ForwComp1.Location.X, ForwComp1.Location.Y - compSpeed);
            ForwComp2.Location = new Point(ForwComp2.Location.X, ForwComp2.Location.Y - compSpeed);
            ForwComp3.Location = new Point(ForwComp3.Location.X, ForwComp3.Location.Y - compSpeed);
            MidComp1.Location = new Point(MidComp1.Location.X, MidComp1.Location.Y - compSpeed);
            MidComp2.Location = new Point(MidComp2.Location.X, MidComp2.Location.Y - compSpeed);
            MidComp3.Location = new Point(MidComp3.Location.X, MidComp3.Location.Y - compSpeed);
            MidComp4.Location = new Point(MidComp4.Location.X, MidComp4.Location.Y - compSpeed);
            MidComp5.Location = new Point(MidComp5.Location.X, MidComp5.Location.Y - compSpeed);
            DefComp1.Location = new Point(DefComp1.Location.X, DefComp1.Location.Y - compSpeed);
            DefComp2.Location = new Point(DefComp2.Location.X, DefComp2.Location.Y - compSpeed);
            compdirect = 1;
        }

        private void Score_Click(object sender, EventArgs e)
        {

        }

        private void CompTeamDown()
        {
            ForwComp1.Location = new Point(ForwComp1.Location.X, ForwComp1.Location.Y + compSpeed);
            ForwComp2.Location = new Point(ForwComp2.Location.X, ForwComp2.Location.Y + compSpeed);
            ForwComp3.Location = new Point(ForwComp3.Location.X, ForwComp3.Location.Y + compSpeed);
            MidComp1.Location = new Point(MidComp1.Location.X, MidComp1.Location.Y + compSpeed);
            MidComp2.Location = new Point(MidComp2.Location.X, MidComp2.Location.Y + compSpeed);
            MidComp3.Location = new Point(MidComp3.Location.X, MidComp3.Location.Y + compSpeed);
            MidComp4.Location = new Point(MidComp4.Location.X, MidComp4.Location.Y + compSpeed);
            MidComp5.Location = new Point(MidComp5.Location.X, MidComp5.Location.Y + compSpeed);
            DefComp1.Location = new Point(DefComp1.Location.X, DefComp1.Location.Y + compSpeed);
            DefComp2.Location = new Point(DefComp2.Location.X, DefComp2.Location.Y + compSpeed);
            compdirect = -1;
        }

        private void aCompTimer_Tick(object sender, EventArgs e)
        {

            //TIME  tick = 30 ms
            m++;          
            if (m % 11 == 0)
            {
                aDoubleDot.Visible = false;
            }
            else
            {
                aDoubleDot.Visible = true;
            }

            if (m % 1 == 0)
            {
                sec++;
                if (sec % 10 != 0)
                {
                    aSec.Text = sec.ToString();
                }
                else if(sec % 10== 0)
                {
                    sec = 0;
                    aSec.Text = sec.ToString();
                    secTen++;
                    if (secTen % 6 != 0)
                    {
                        aSecTen.Text = secTen.ToString();
                    }
                    else
                    {
                        secTen = 0;
                        min++;
                        aSecTen.Text = secTen.ToString();
                        aMin.Text = min.ToString();
                    }
                }
            }
            if (min == 90)
            {
                news.Text = "GAME OVER";
                aBallTimer.Enabled = true;
                aTimer.Enabled = false;
                aCompTimer.Enabled = false;
                gameEnd = true;
            }


            //BALL MOVEMENT
            Ball.Location = new Point(Ball.Location.X + ballSpeedX, Ball.Location.Y + ballSpeedY);

            //if (m % 3 != 0)
            //{
            //    m++;
            //}
            //else
            //{
            //    System.Threading.Thread.Sleep(300);
            //}


            if (Ball.Location.Y > 150 && Ball.Location.Y < 387)
            {
                if (Ball.Location.Y > GoalComp.Location.Y)
                {
                    GoalComp.Location = new Point(GoalComp.Location.X, GoalComp.Location.Y + compSpeed);
                }
                else //if (Ball.Location.Y < GoalComp.Location.Y)
                {
                    GoalComp.Location = new Point(GoalComp.Location.X, GoalComp.Location.Y - compSpeed);
                }
            }
            if (Ball.Location.X < 509)
            {
                if (Ball.Location.Y < 194)
                {
                    if (Ball.Location.Y < ForwComp1.Location.Y)
                    {
                        CompTeamUp();
                    }
                    else
                    {
                        CompTeamDown();
                    }
                }
                if (Ball.Location.Y > 194 && Ball.Location.Y < 335)
                {
                    if (Ball.Location.Y < ForwComp2.Location.Y)
                    {
                        CompTeamUp();
                    }
                    else
                    {
                        CompTeamDown();
                    }
                }
                if (Ball.Location.Y > 335 && Ball.Location.Y < bottom)
                {
                    if (Ball.Location.Y < ForwComp3.Location.Y)
                    {
                        CompTeamUp();
                    }
                    else
                    {
                        CompTeamDown();
                    }
                }
            }
            if (Ball.Location.X > 509)
            {
                if (Ball.Location.Y < 116)
                {
                    if (Ball.Location.Y < MidComp1.Location.Y)
                    {
                        CompTeamUp();
                    }
                    else
                    {
                        CompTeamDown();
                    }
                }
                if (Ball.Location.Y > 110 && Ball.Location.Y < 210)
                {
                    if (Ball.Location.Y < MidComp2.Location.Y)
                    {
                        CompTeamUp();
                    }
                    else
                    {
                        CompTeamDown();
                    }
                }
                if (Ball.Location.Y > 210 && Ball.Location.Y < 310)
                {
                    if (Ball.Location.Y < MidComp3.Location.Y)
                    {
                        CompTeamUp();
                    }
                    else
                    {
                        CompTeamDown();
                    }
                }
                if (Ball.Location.Y > 310 && Ball.Location.Y < 410)
                {
                    if (Ball.Location.Y < MidComp4.Location.Y)
                    {
                        CompTeamUp();
                    }
                    else
                    {
                        CompTeamDown();
                    }
                }
                if (Ball.Location.Y > 410 && Ball.Location.Y < bottom)
                {
                    if (Ball.Location.Y < MidComp5.Location.Y)
                    {
                        CompTeamUp();
                    }
                    else
                    {
                        CompTeamDown();
                    }
                }
            }








            ////CHANGING IMAGE
            //n += 1;
            //if (n % 2 == 0)
            //{
            //    Ball.ImageLocation = "C:\\Users\\Валентин\\Desktop\\Soccerball.png";
            //}
            //if (n % 2 == 1)
            //{
            //    Ball.ImageLocation = "C:\\Users\\Валентин\\Desktop\\maball.png";
            //}
        }



        // Player player;



        public Form1()
        {

            InitializeComponent();
            
            

        }
        private void aBallTimer_Tick(object sender, EventArgs e)
        {
            if (!gameEnd)
            {
                if (n % 12 == 0)
                {
                    playerScoreBig.Visible = false;
                    compScoreBig.Visible = false;
                }
                else
                {
                    playerScoreBig.Visible = true;
                    compScoreBig.Visible = true;
                }

                if (n % 2 == 0)
                {
                    news.ForeColor = Color.Tomato;
                    n++;
                }
                else
                {
                    news.ForeColor = Color.Yellow;
                    n++;
                }
                if (n % 35 == 0)
                {
                    whistle.Play();
                    news.Visible = false;
                    playerScoreBig.Visible = false;
                    compScoreBig.Visible = false;
                    aTimer.Enabled = true;
                    aCompTimer.Enabled = true;
                    aBallTimer.Enabled = false;

                }
            }
            else if(gameEnd)
            {
                news.Visible = true;
                
            }



            // Ball.Location = new Point(Ball.Location.X - ballSpeedX, Ball.Location.Y + ballSpeedY);





            //if ((Ball.Bounds.IntersectsWith(Mid1.Bounds) || Ball.Bounds.IntersectsWith(Mid2.Bounds) || (Ball.Bounds.IntersectsWith(Mid3.Bounds)) || Ball.Bounds.IntersectsWith(Mid4.Bounds) || Ball.Bounds.IntersectsWith(Mid5.Bounds)));
            //{
            //    if (ballSpeedX > 0)
            //    {
            //        Random ne = new Random();
            //        int r = ne.Next(5) - 2;
            //        ballSpeedY += r;
            //    }
            //}

        }

        

        private void aTimer_Tick(object sender, EventArgs e)
        {
            if(GoalKeeper.Bounds.IntersectsWith(Ball.Bounds))
            {
                buffoniche.Play();
            }

            //BALL 
            if (GoalKeeper.Bounds.IntersectsWith(Ball.Bounds) || Def1.Bounds.IntersectsWith(Ball.Bounds) || Def2.Bounds.IntersectsWith(Ball.Bounds) || Mid1.Bounds.IntersectsWith(Ball.Bounds) || Mid2.Bounds.IntersectsWith(Ball.Bounds) || Mid3.Bounds.IntersectsWith(Ball.Bounds) || Mid4.Bounds.IntersectsWith(Ball.Bounds) || Mid5.Bounds.IntersectsWith(Ball.Bounds) || Forw1.Bounds.IntersectsWith(Ball.Bounds) || Forw2.Bounds.IntersectsWith(Ball.Bounds) || Forw3.Bounds.IntersectsWith(Ball.Bounds))
            {
                if (ballSpeedX > 0)
                {
                    ballSpeedY *= -1;
                }

            }
            if (DefComp1.Bounds.IntersectsWith(Ball.Bounds) || DefComp2.Bounds.IntersectsWith(Ball.Bounds) || MidComp1.Bounds.IntersectsWith(Ball.Bounds) || MidComp2.Bounds.IntersectsWith(Ball.Bounds) || MidComp3.Bounds.IntersectsWith(Ball.Bounds) || MidComp4.Bounds.IntersectsWith(Ball.Bounds) || MidComp5.Bounds.IntersectsWith(Ball.Bounds) || ForwComp1.Bounds.IntersectsWith(Ball.Bounds) || ForwComp2.Bounds.IntersectsWith(Ball.Bounds) || ForwComp3.Bounds.IntersectsWith(Ball.Bounds))
            {
                ballSpeedY *= -1;
            }


            //SCORING

            //if (LeftGoal.Bounds.IntersectsWith(Ball.Bounds))
            //{
            //    compScore++;
            //    Scoring();
            //}
            //if (RightGoal.Bounds.IntersectsWith(Ball.Bounds))
            //{
            //    playerScore++;
            //    Scoring();
            //}


            if (Ball.Location.X > 1027)
            {
                if (Ball.Location.Y > 197 && Ball.Location.Y < 379)
                {
                    playerScore++;
                    Scoring();
                    ShowGoal();
                    goalScored.Play();

                }
            }
            if (Ball.Location.X < 90)
            {
                if (Ball.Location.Y > 197 && Ball.Location.Y < 379)
                {
                    compScore++;
                    Scoring();
                    ShowGoal();
                    goalScored.Play();
                }
            }


            //COMP
            if (GoalComp.Bounds.IntersectsWith(Ball.Bounds))
            {
                ballSpeedX *= -1;
            }
            // COMP COLLISION FROM LEFT
            if (DefComp1.Bounds.IntersectsWith(Ball.Bounds) || DefComp2.Bounds.IntersectsWith(Ball.Bounds) || MidComp1.Bounds.IntersectsWith(Ball.Bounds) || MidComp2.Bounds.IntersectsWith(Ball.Bounds) || MidComp3.Bounds.IntersectsWith(Ball.Bounds) || MidComp4.Bounds.IntersectsWith(Ball.Bounds) || MidComp5.Bounds.IntersectsWith(Ball.Bounds) || ForwComp1.Bounds.IntersectsWith(Ball.Bounds) || ForwComp2.Bounds.IntersectsWith(Ball.Bounds) || ForwComp3.Bounds.IntersectsWith(Ball.Bounds))
            {
                if (ballSpeedX > 0)
                {
                    ballSpeedX *= -1;
                }
            }



            //COLLISION FROM RIGHT
            if (GoalKeeper.Bounds.IntersectsWith(Ball.Bounds) || Def1.Bounds.IntersectsWith(Ball.Bounds) || Def2.Bounds.IntersectsWith(Ball.Bounds) || Mid1.Bounds.IntersectsWith(Ball.Bounds) || Mid2.Bounds.IntersectsWith(Ball.Bounds) || Mid3.Bounds.IntersectsWith(Ball.Bounds) || Mid4.Bounds.IntersectsWith(Ball.Bounds) || Mid5.Bounds.IntersectsWith(Ball.Bounds) || Forw1.Bounds.IntersectsWith(Ball.Bounds) || Forw2.Bounds.IntersectsWith(Ball.Bounds) || Forw3.Bounds.IntersectsWith(Ball.Bounds))
            {
                if (ballSpeedX < 0 && isUpPressed==false && isDownPressed==false)
                {
                    ballSpeedX *= -1;
                }
                else if (ballSpeedX < 0 && isUpPressed == true && ballSpeedY < 0)
                {
                    ballSpeedX *= -1;
                }
                else if (ballSpeedX < 0 && isUpPressed == true && ballSpeedY > 0)
                {
                    ballSpeedX *= -1;
                    ballSpeedY *= -1;
                }
                else if (ballSpeedX < 0 && isDownPressed == true && ballSpeedY < 0)
                {
                    ballSpeedX *= -1;
                    ballSpeedY *= -1;
                }
                else if (ballSpeedX < 0 && isDownPressed == true && ballSpeedY > 0)
                {
                    ballSpeedX *= -1;
                }
            }


                if (Ball.Location.Y <= top || Ball.Location.Y >= bottom)
            {
                ballSpeedY *= -1;
            }
            if (Ball.Location.X <= leftOfTheField || Ball.Location.X >= rightOfTheField - Ball.Width)
            {
                ballSpeedX *= -1;
            }

            

            if (isUpPressed)
            {
                //directionSpeed = -movementSpeed;

                GoalKeeper.Location = new Point(GoalKeeper.Location.X, GoalKeeper.Location.Y - movementSpeed);
                Def1.Location = new Point(Def1.Location.X, Def1.Location.Y - movementSpeed);
                Def2.Location = new Point(Def2.Location.X, Def2.Location.Y - movementSpeed);
                Mid1.Location = new Point(Mid1.Location.X, Mid1.Location.Y - movementSpeed);
                Mid2.Location = new Point(Mid2.Location.X, Mid2.Location.Y - movementSpeed);
                Mid3.Location = new Point(Mid3.Location.X, Mid3.Location.Y - movementSpeed);
                Mid4.Location = new Point(Mid4.Location.X, Mid4.Location.Y - movementSpeed);
                Mid5.Location = new Point(Mid5.Location.X, Mid5.Location.Y - movementSpeed);
                Forw1.Location = new Point(Forw1.Location.X, Forw1.Location.Y - movementSpeed);
                Forw2.Location = new Point(Forw2.Location.X, Forw2.Location.Y - movementSpeed);
                Forw3.Location = new Point(Forw3.Location.X, Forw3.Location.Y - movementSpeed);
            }
            else if (isDownPressed)
            {
               // directionSpeed = movementSpeed;

                GoalKeeper.Location = new Point(GoalKeeper.Location.X, GoalKeeper.Location.Y + movementSpeed);
                Def1.Location = new Point(Def1.Location.X, Def1.Location.Y + movementSpeed);
                Def2.Location = new Point(Def2.Location.X, Def2.Location.Y + movementSpeed);
                Mid1.Location = new Point(Mid1.Location.X, Mid1.Location.Y + movementSpeed);
                Mid2.Location = new Point(Mid2.Location.X, Mid2.Location.Y + movementSpeed);
                Mid3.Location = new Point(Mid3.Location.X, Mid3.Location.Y + movementSpeed);
                Mid4.Location = new Point(Mid4.Location.X, Mid4.Location.Y + movementSpeed);
                Mid5.Location = new Point(Mid5.Location.X, Mid5.Location.Y + movementSpeed);
                Forw1.Location = new Point(Forw1.Location.X, Forw1.Location.Y + movementSpeed);
                Forw2.Location = new Point(Forw2.Location.X, Forw2.Location.Y + movementSpeed);
                Forw3.Location = new Point(Forw3.Location.X, Forw3.Location.Y + movementSpeed);
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
