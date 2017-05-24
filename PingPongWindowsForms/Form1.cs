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
using System.IO;
namespace PingPongWindowsForms
{

    public partial class Form1 : Form
    {
        const int top = 39, bottom = 510, rightOfTheField = 1050, leftOfTheField = 84;
        int movementSpeed = 6;
        int compSpeed = 2;
        bool isUpPressed, isDownPressed, gameEnd = false;        
        int ballSpeedX = 10, ballSpeedY = 4;
        int ballSpeedXClone = 10, ballSpeedYClone = 10;
        int playerScore = 0, compScore = 0;
        int compdirect;
        int n = 0;
        int m = 1;
        int sec = 0,secTen = 0, min = 0;
        int accelerationDefPlayer, accelerationAttPlayer, acceleration3;
        int countForAcceleration = 0, countForAccelerationDelete = 0, countForAccelerationToAttack = 0;
        int countForFinalWhistle, countForbuffoniche=0;
        int addedTime, addedTimeEnd, countForAddTime;
        int timing=1;
        int myForm = 2, compForm=3;
        int pauseButtonClick = 0;
        bool buffonicheWasPlayed;
        

        string yourTeam, compTeam;
        

        SoundPlayer goalScored = new SoundPlayer("goalscored.wav");
        SoundPlayer buffoniche = new SoundPlayer("буффонище.wav");
        SoundPlayer whistle = new SoundPlayer("whistlee.wav");
        SoundPlayer finalWhistle = new SoundPlayer("FinalWhistle.wav");
        SoundPlayer shot = new SoundPlayer("shot.wav");
        SoundPlayer goalCatch = new SoundPlayer("goalcatch.wav");

        ToolTip tl = new ToolTip();

        private void pauseBox_Click(object sender, EventArgs e)
        {
            pauseButtonClick++;
            if (pauseButtonClick % 2 == 1)
            {
                pauseBox.ImageLocation = "Play.png";
                aTimer.Enabled = false;                
                aTimeShowing.Enabled = false;
                aCompTimer.Enabled = false;
            }
            else
            {               
                pauseBox.ImageLocation = "Pause.png";
                aTimer.Enabled = true;                
                aTimeShowing.Enabled = true;
                aCompTimer.Enabled = true;
            }
        }

        

        private void pauseBox_MouseEnter(object sender, EventArgs e)
        {
            pauseBox.Location = new Point(1087, 27);
            pauseBox.Width = 32;
            pauseBox.Height = 32;

        }

        private void pauseBox_MouseLeave(object sender, EventArgs e)
        {
            pauseBox.Location = new Point(1088, 28);
            pauseBox.Width = 29;
            pauseBox.Height = 29;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
                     
            if (min != addedTimeEnd)
            {
                if (MessageBox.Show("Вы уверены что хотите закрыть приложение? \nЗакрытие программы во время игры ведет к техническому поражению", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
                e.Cancel = true;
            else
                e.Cancel = false;


                playerScore = 0;
                compScore = 3;

                FileStream fl = new FileStream("score.txt", FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fl);
                sw.WriteLine(playerScore);
                sw.WriteLine(compScore);
                sw.Close();
                fl.Close();
            }

        }

        private void pauseBox_MouseHover(object sender, EventArgs e)
        {
            //if (pauseButtonClick % 2 == 1)
            //{
            //    tl.Show("Продолжить игру", pauseBox);
            //}
            //if (pauseButtonClick % 2 == 0)
            //{
            //    tl.Show("Пауза", pauseBox);
            //}
        }


       

        public Form1()
        {
            InitializeComponent();
            Random r = new Random();
            addedTime = r.Next(7)+3;
            addedTimeEnd = 90 + addedTime;


            FileStream fl = new FileStream("teams.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fl);
            yourTeam = sr.ReadLine();
            compTeam = sr.ReadLine();
            compSpeed = int.Parse(sr.ReadLine());
            myForm = int.Parse(sr.ReadLine());
            compForm = int.Parse(sr.ReadLine());
            timing = 4 - int.Parse(sr.ReadLine());



        }
        

        private void Clothes()
        {
            if (myForm == 0)//black
            {
                aYourTeamColor.BackColor = Color.FromArgb(64,64,64);
                GoalKeeper.BackColor = Color.FromArgb(64, 64, 64);
                Def1.BackColor = Color.FromArgb(64, 64, 64);
                Def2.BackColor = Color.FromArgb(64, 64, 64);
                Mid1.BackColor = Color.FromArgb(64, 64, 64);
                Mid2.BackColor = Color.FromArgb(64, 64, 64);
                Mid3.BackColor = Color.FromArgb(64, 64, 64);
                Mid4.BackColor = Color.FromArgb(64, 64, 64);
                Mid5.BackColor = Color.FromArgb(64, 64, 64);
                Forw1.BackColor = Color.FromArgb(64, 64, 64);
                Forw2.BackColor = Color.FromArgb(64, 64, 64); 
                Forw3.BackColor = Color.FromArgb(64, 64, 64); 
            }
            if (myForm == 1)//orange
            {
                aYourTeamColor.BackColor = Color.FromArgb(255, 128, 0);
                GoalKeeper.BackColor = Color.FromArgb(255, 128, 0);
                Def1.BackColor = Color.FromArgb(255, 128, 0);
                Def2.BackColor = Color.FromArgb(255, 128, 0);
                Mid1.BackColor = Color.FromArgb(255, 128, 0);
                Mid2.BackColor = Color.FromArgb(255, 128, 0);
                Mid3.BackColor = Color.FromArgb(255, 128, 0);
                Mid4.BackColor = Color.FromArgb(255, 128, 0);
                Mid5.BackColor = Color.FromArgb(255, 128, 0);
                Forw1.BackColor = Color.FromArgb(255, 128, 0);
                Forw2.BackColor = Color.FromArgb(255, 128, 0);
                Forw3.BackColor = Color.FromArgb(255, 128, 0);
            }
            if (myForm == 2)//blue
            {
                aYourTeamColor.BackColor = Color.FromArgb(40, 30, 150);
                GoalKeeper.BackColor = Color.FromArgb(40, 30, 150);
                Def1.BackColor = Color.FromArgb(40, 30, 150);
                Def2.BackColor = Color.FromArgb(40, 30, 150);
                Mid1.BackColor = Color.FromArgb(40, 30, 150);
                Mid2.BackColor = Color.FromArgb(40, 30, 150);
                Mid3.BackColor = Color.FromArgb(40, 30, 150);
                Mid4.BackColor = Color.FromArgb(40, 30, 150);
                Mid5.BackColor = Color.FromArgb(40, 30, 150);
                Forw1.BackColor = Color.FromArgb(40, 30, 150);
                Forw2.BackColor = Color.FromArgb(40, 30, 150);
                Forw3.BackColor = Color.FromArgb(40, 30, 150);
            }
            if (myForm == 3)//red
            {
                aYourTeamColor.BackColor = Color.FromArgb(192, 33, 40);
                GoalKeeper.BackColor = Color.FromArgb(192, 33, 40);
                Def1.BackColor = Color.FromArgb(192, 33, 40);
                Def2.BackColor = Color.FromArgb(192, 33, 40);
                Mid1.BackColor = Color.FromArgb(192, 33, 40);
                Mid2.BackColor = Color.FromArgb(192, 33, 40);
                Mid3.BackColor = Color.FromArgb(192, 33, 40);
                Mid4.BackColor = Color.FromArgb(192, 33, 40);
                Mid5.BackColor = Color.FromArgb(192, 33, 40);
                Forw1.BackColor = Color.FromArgb(192, 33, 40);
                Forw2.BackColor = Color.FromArgb(192, 33, 40);
                Forw3.BackColor = Color.FromArgb(192, 33, 40);
            }
            if (myForm == 4)//yellow
            {
                aYourTeamColor.BackColor = Color.Gold;
                GoalKeeper.BackColor = Color.Gold;
                Def1.BackColor = Color.Gold;
                Def2.BackColor = Color.Gold;
                Mid1.BackColor = Color.Gold;
                Mid2.BackColor = Color.Gold;
                Mid3.BackColor = Color.Gold;
                Mid4.BackColor = Color.Gold;
                Mid5.BackColor = Color.Gold;
                Forw1.BackColor = Color.Gold;
                Forw2.BackColor = Color.Gold;
                Forw3.BackColor = Color.Gold;
            }

            if (compForm == 0)
            {
                aCompTeamColor.BackColor = Color.FromArgb(64,64,64);
                GoalComp.BackColor = Color.FromArgb(64, 64, 64);
                DefComp1.BackColor = Color.FromArgb(64, 64, 64);
                DefComp2.BackColor = Color.FromArgb(64, 64, 64);
                MidComp1.BackColor = Color.FromArgb(64, 64, 64);
                MidComp2.BackColor = Color.FromArgb(64, 64, 64);
                MidComp3.BackColor = Color.FromArgb(64, 64, 64);
                MidComp4.BackColor = Color.FromArgb(64, 64, 64);
                MidComp5.BackColor = Color.FromArgb(64, 64, 64);
                ForwComp1.BackColor = Color.FromArgb(64, 64, 64);
                ForwComp2.BackColor = Color.FromArgb(64, 64, 64);
                ForwComp3.BackColor = Color.FromArgb(64, 64, 64);
            }
            if (compForm == 1)
            {
                aCompTeamColor.BackColor = Color.FromArgb(255, 128, 0);
                GoalComp.BackColor = Color.FromArgb(255, 128, 0);
                DefComp1.BackColor = Color.FromArgb(255, 128, 0);
                DefComp2.BackColor = Color.FromArgb(255, 128, 0);
                MidComp1.BackColor = Color.FromArgb(255, 128, 0);
                MidComp2.BackColor = Color.FromArgb(255, 128, 0);
                MidComp3.BackColor = Color.FromArgb(255, 128, 0);
                MidComp4.BackColor = Color.FromArgb(255, 128, 0);
                MidComp5.BackColor = Color.FromArgb(255, 128, 0);
                ForwComp1.BackColor = Color.FromArgb(255, 128, 0);
                ForwComp2.BackColor = Color.FromArgb(255, 128, 0);
                ForwComp3.BackColor = Color.FromArgb(255, 128, 0);
            }
            if (compForm == 2)//blue
            {
                aCompTeamColor.BackColor = Color.FromArgb(40, 30, 150);
                GoalComp.BackColor = Color.FromArgb(40, 30, 150);
                DefComp1.BackColor = Color.FromArgb(40, 30, 150);
                DefComp2.BackColor = Color.FromArgb(40, 30, 150);
                MidComp1.BackColor = Color.FromArgb(40, 30, 150);
                MidComp2.BackColor = Color.FromArgb(40, 30, 150);
                MidComp3.BackColor = Color.FromArgb(40, 30, 150);
                MidComp4.BackColor = Color.FromArgb(40, 30, 150);
                MidComp5.BackColor = Color.FromArgb(40, 30, 150);
                ForwComp1.BackColor = Color.FromArgb(40, 30, 150);
                ForwComp2.BackColor = Color.FromArgb(40, 30, 150);
                ForwComp3.BackColor = Color.FromArgb(40, 30, 150);
            }
            if (compForm == 3)//red
            {
                aCompTeamColor.BackColor = Color.FromArgb(192, 33, 40);
                GoalComp.BackColor = Color.FromArgb(192, 33, 40);
                DefComp1.BackColor = Color.FromArgb(192, 33, 40);
                DefComp2.BackColor = Color.FromArgb(192, 33, 40);
                MidComp1.BackColor = Color.FromArgb(192, 33, 40);
                MidComp2.BackColor = Color.FromArgb(192, 33, 40);
                MidComp3.BackColor = Color.FromArgb(192, 33, 40);
                MidComp4.BackColor = Color.FromArgb(192, 33, 40);
                MidComp5.BackColor = Color.FromArgb(192, 33, 40);
                ForwComp1.BackColor = Color.FromArgb(192, 33, 40);
                ForwComp2.BackColor = Color.FromArgb(192, 33, 40);
                ForwComp3.BackColor = Color.FromArgb(192, 33, 40);
            }
            if (compForm == 4)//yellow
            {
                aCompTeamColor.BackColor = Color.Gold;
                GoalComp.BackColor = Color.Gold;
                DefComp1.BackColor = Color.Gold;
                DefComp2.BackColor = Color.Gold;
                MidComp1.BackColor = Color.Gold;
                MidComp2.BackColor = Color.Gold;
                MidComp3.BackColor = Color.Gold;
                MidComp4.BackColor = Color.Gold;
                MidComp5.BackColor = Color.Gold;
                ForwComp1.BackColor = Color.Gold;
                ForwComp2.BackColor = Color.Gold;
                ForwComp3.BackColor = Color.Gold;
            }
        }

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

            ballSpeedX *= -1;


            //Player Team Reset
            GoalKeeper.Location = new Point(94, 266);
            Def1.Location = new Point(243, 180);
            Def2.Location = new Point(243, 343);
            Mid1.Location = new Point(459, 66);
            Mid2.Location = new Point(459, 164);
            Mid3.Location = new Point(459, 261);
            Mid4.Location = new Point(459, 358);
            Mid5.Location = new Point(459, 455);
            Forw1.Location = new Point(773, 127);
            Forw2.Location = new Point(773, 261);
            Forw3.Location = new Point(773, 389);


            //Comp Team Reset
            GoalComp.Location = new Point(1035, 269);
            ForwComp1.Location = new Point(345, 127);
            ForwComp2.Location = new Point(345, 261);
            ForwComp3.Location = new Point(345, 395);
            MidComp1.Location = new Point(673, 66);
            MidComp2.Location = new Point(673, 160);
            MidComp3.Location = new Point(673, 260);
            MidComp4.Location = new Point(673, 360);
            MidComp5.Location = new Point(673, 460);
            DefComp1.Location = new Point(889, 180);
            DefComp2.Location = new Point(889, 343);


            PlayerScore.Text = playerScore.ToString();
            CmpScore.Text = compScore.ToString();                                           
        }

        private void TeamsLeaving()
        {
            //if (GoalKeeper.Location.X < 1117 || GoalKeeper.Location.Y < 652)
            //{
            //    GoalKeeper.Location = new Point(GoalKeeper.Location.X + movementSpeed, GoalKeeper.Location.Y + movementSpeed);
            //}

            ForwComp1.Location = new Point(ForwComp1.Location.X, ForwComp1.Location.Y + 3);
            ForwComp2.Location = new Point(ForwComp2.Location.X, ForwComp2.Location.Y + 3);
            ForwComp3.Location = new Point(ForwComp3.Location.X, ForwComp3.Location.Y + 3);
            MidComp1.Location = new Point(MidComp1.Location.X, MidComp1.Location.Y + 3);
            MidComp2.Location = new Point(MidComp2.Location.X, MidComp2.Location.Y + 3);
            MidComp3.Location = new Point(MidComp3.Location.X, MidComp3.Location.Y + 3);
            MidComp4.Location = new Point(MidComp4.Location.X, MidComp4.Location.Y + 3);
            MidComp5.Location = new Point(MidComp5.Location.X, MidComp5.Location.Y + 3);
            DefComp1.Location = new Point(DefComp1.Location.X, DefComp1.Location.Y + 3);
            DefComp2.Location = new Point(DefComp2.Location.X, DefComp2.Location.Y + 3);
            GoalComp.Location = new Point(GoalComp.Location.X, GoalComp.Location.Y + 3);

            GoalKeeper.Location = new Point(GoalKeeper.Location.X, GoalKeeper.Location.Y +3);
            Def1.Location = new Point(Def1.Location.X, Def1.Location.Y + 3);
            Def2.Location = new Point(Def2.Location.X, Def2.Location.Y + 3);
            Mid1.Location = new Point(Mid1.Location.X, Mid1.Location.Y + 3);
            Mid2.Location = new Point(Mid2.Location.X, Mid2.Location.Y + 3);
            Mid3.Location = new Point(Mid3.Location.X, Mid3.Location.Y + 3);
            Mid4.Location = new Point(Mid4.Location.X, Mid4.Location.Y + 3);
            Mid5.Location = new Point(Mid5.Location.X, Mid5.Location.Y + 3);
            Forw1.Location = new Point(Forw1.Location.X, Forw1.Location.Y + 3);
            Forw2.Location = new Point(Forw2.Location.X, Forw2.Location.Y + 3);
            Forw3.Location = new Point(Forw3.Location.X, Forw3.Location.Y + 3);



        }


        private void AccelerationDefPlayer()
        {
            if (ballSpeedX < 0 && isUpPressed == false && isDownPressed == false)
            {
                ballSpeedX = Math.Abs(ballSpeedX) + accelerationDefPlayer;

            }
            else if (ballSpeedX < 0 && isUpPressed == true && ballSpeedY < 0)
            {
                ballSpeedX = Math.Abs(ballSpeedX) + accelerationDefPlayer;

            }
            else if (ballSpeedX < 0 && isUpPressed == true && ballSpeedY > 0)
            {
                ballSpeedX = Math.Abs(ballSpeedX) + accelerationDefPlayer;

                ballSpeedY *= -1;
            }
            else if (ballSpeedX < 0 && isDownPressed == true && ballSpeedY < 0)
            {
                ballSpeedX = Math.Abs(ballSpeedX) + accelerationDefPlayer;

                ballSpeedY *= -1;
            }
            else if (ballSpeedX < 0 && isDownPressed == true && ballSpeedY > 0)
            {
                ballSpeedX = Math.Abs(ballSpeedX) + accelerationDefPlayer;

            }
        }

        private void AccelerationAttackPlayer()
        {
            
        }



        public void CompTeamUp()
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



        public void CompTeamDown()
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

        private void aTimeShowing_Tick(object sender, EventArgs e)
        {
            //10ms
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
                sec += timing;
                if (sec == 60)
                {
                    sec = 0;
                    min++;
                }
                int ss = sec % 10;
                int st = sec / 10;
                aSec.Text = ss.ToString();
                aSecTen.Text = st.ToString();
                aMin.Text = min.ToString();
                //if (sec % 10 !=0)
                //{
                //    aSec.Text = sec.ToString();
                //}
                //else if (sec % 10 ==0)
                //{
                //    sec = 0;
                //    aSec.Text = sec.ToString();
                //    secTen++;
                //    if (secTen % 6 != 0)
                //    {
                //        aSecTen.Text = secTen.ToString();
                //    }
                //    else
                //    {
                //        secTen = 0;
                //        min++;
                //        aSecTen.Text = secTen.ToString();
                //        aMin.Text = min.ToString();
                //    }
                //}
            }
            if (min >= 90)
            {

                countForAddTime++;

                additionalTimeLabel.Text = String.Format("+ {0} MINS", addedTime);
                additionalTimeLabel.Visible = true;
                if (countForAddTime % 3 == 0)
                {
                    aMin.ForeColor = Color.Firebrick;
                    aDoubleDot.ForeColor = Color.Firebrick;
                    aSecTen.ForeColor = Color.Firebrick;
                    aSec.ForeColor = Color.Firebrick;
                }
                else
                {
                    aMin.ForeColor = Color.Black;
                    aDoubleDot.ForeColor = Color.Black;
                    aSecTen.ForeColor = Color.Black;
                    aSec.ForeColor = Color.Black;
                }

            }
            if (min == addedTimeEnd)
            {
                news.Text = "GAME OVER";
                news.Location = new Point(426, 193);
                aBallTimer.Enabled = true;
                aTimer.Enabled = false;
                aCompTimer.Enabled = false;
                aTimeShowing.Enabled = false;
                gameEnd = true;

                FileStream fl = new FileStream("score.txt", FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fl);
                sw.WriteLine(playerScore);
                sw.WriteLine(compScore);
                sw.Close();
                fl.Close();

                if (playerScore > compScore)
                {
                    aWinnerTable.Location = new Point(453, 372);
                    aWinnerTable.Text = "YOU WON!";
                    aWinnerTable.Visible = true;
                }
                else if (playerScore == compScore)
                {
                    aWinnerTable.Location = new Point(495, 372);
                    aWinnerTable.Text = "DRAW!";
                    aWinnerTable.Visible = true;
                }
                else
                {
                    aWinnerTable.Location = new Point(449, 372);
                    aWinnerTable.Text = "YOU LOST!";
                    aWinnerTable.Visible = true;
                }
            }


            if (GoalKeeper.Bounds.IntersectsWith(Ball.Bounds))
            {
                if (!buffonicheWasPlayed)
                {
                    if (Ball.Location.Y > 197 && Ball.Location.Y < 391)
                    {
                        buffoniche.PlaySync();
                        buffonicheWasPlayed = true;
                        countForbuffoniche = 0;
                    }
                    else                        
                        shot.Play();
                }
            }
            if (buffonicheWasPlayed)
            {
                countForbuffoniche++;
                if (countForbuffoniche / 84 == 1)
                {
                    buffonicheWasPlayed = false;
                }
            }
            //if (buffonicheWasPlayed)
            //{
            //    if (GoalComp.Bounds.IntersectsWith(Ball.Bounds) || DefComp1.Bounds.IntersectsWith(Ball.Bounds) || DefComp2.Bounds.IntersectsWith(Ball.Bounds) || MidComp1.Bounds.IntersectsWith(Ball.Bounds) || MidComp2.Bounds.IntersectsWith(Ball.Bounds) || MidComp3.Bounds.IntersectsWith(Ball.Bounds) || MidComp4.Bounds.IntersectsWith(Ball.Bounds) || MidComp5.Bounds.IntersectsWith(Ball.Bounds) || ForwComp1.Bounds.IntersectsWith(Ball.Bounds) || ForwComp2.Bounds.IntersectsWith(Ball.Bounds) || ForwComp3.Bounds.IntersectsWith(Ball.Bounds) || Def1.Bounds.IntersectsWith(Ball.Bounds) || Def2.Bounds.IntersectsWith(Ball.Bounds) || Mid1.Bounds.IntersectsWith(Ball.Bounds) || Mid2.Bounds.IntersectsWith(Ball.Bounds) || Mid3.Bounds.IntersectsWith(Ball.Bounds) || Mid4.Bounds.IntersectsWith(Ball.Bounds) || Mid5.Bounds.IntersectsWith(Ball.Bounds) || Forw1.Bounds.IntersectsWith(Ball.Bounds) || Forw2.Bounds.IntersectsWith(Ball.Bounds) || Forw3.Bounds.IntersectsWith(Ball.Bounds))
            //    {
            //        buffonicheWasPlayed = false;
            //    }
            //}
            if (!buffonicheWasPlayed)
            {
                if (GoalComp.Bounds.IntersectsWith(Ball.Bounds) || DefComp1.Bounds.IntersectsWith(Ball.Bounds) || DefComp2.Bounds.IntersectsWith(Ball.Bounds) || MidComp1.Bounds.IntersectsWith(Ball.Bounds) || MidComp2.Bounds.IntersectsWith(Ball.Bounds) || MidComp3.Bounds.IntersectsWith(Ball.Bounds) || MidComp4.Bounds.IntersectsWith(Ball.Bounds) || MidComp5.Bounds.IntersectsWith(Ball.Bounds) || ForwComp1.Bounds.IntersectsWith(Ball.Bounds) || ForwComp2.Bounds.IntersectsWith(Ball.Bounds) || ForwComp3.Bounds.IntersectsWith(Ball.Bounds))
                {
                    shot.Play();
                }
                if (Def1.Bounds.IntersectsWith(Ball.Bounds) || Def2.Bounds.IntersectsWith(Ball.Bounds) || Mid1.Bounds.IntersectsWith(Ball.Bounds) || Mid2.Bounds.IntersectsWith(Ball.Bounds) || Mid3.Bounds.IntersectsWith(Ball.Bounds) || Mid4.Bounds.IntersectsWith(Ball.Bounds) || Mid5.Bounds.IntersectsWith(Ball.Bounds) || Forw1.Bounds.IntersectsWith(Ball.Bounds) || Forw2.Bounds.IntersectsWith(Ball.Bounds) || Forw3.Bounds.IntersectsWith(Ball.Bounds))
                {
                    shot.Play();
                }
            }
        }
            
        
                                           
        private void aCompTimer_Tick(object sender, EventArgs e)
        {
           

            //TIME  tick = 30 ms
           


            //BALL MOVEMENT
            Ball.Location = new Point(Ball.Location.X + ballSpeedX, Ball.Location.Y + ballSpeedY);

            //COMP CONTROL

            //if (Ball.Location.Y > 150 && Ball.Location.Y < 387)
            //{
            //    if (Ball.Location.Y > GoalComp.Location.Y)
            //    {
            //        GoalComp.Location = new Point(GoalComp.Location.X, GoalComp.Location.Y + compSpeed);
            //    }
            //    else
            //    {
            //        GoalComp.Location = new Point(GoalComp.Location.X, GoalComp.Location.Y - compSpeed);
            //    }
            //}
            if (Ball.Location.X < 509)
            {
                if (Ball.Location.Y < 194)
                {
                    if (Ball.Location.Y < ForwComp1.Location.Y)
                    {
                        CompTeamUp();
                        GoalComp.Location = new Point(GoalComp.Location.X, GoalComp.Location.Y - compSpeed);
                    }
                    else
                    {
                        CompTeamDown();
                        GoalComp.Location = new Point(GoalComp.Location.X, GoalComp.Location.Y + compSpeed);
                    }
                }
                if (Ball.Location.Y > 194 && Ball.Location.Y < 335)
                {
                    if (Ball.Location.Y < ForwComp2.Location.Y)
                    {
                        CompTeamUp();
                        GoalComp.Location = new Point(GoalComp.Location.X, GoalComp.Location.Y - compSpeed);
                    }
                    else
                    {
                        CompTeamDown();
                        GoalComp.Location = new Point(GoalComp.Location.X, GoalComp.Location.Y + compSpeed);
                    }
                }
                if (Ball.Location.Y > 335 && Ball.Location.Y < bottom)
                {
                    if (Ball.Location.Y < ForwComp3.Location.Y)
                    {
                        CompTeamUp();
                        GoalComp.Location = new Point(GoalComp.Location.X, GoalComp.Location.Y - compSpeed);
                    }
                    else
                    {
                        CompTeamDown();
                        GoalComp.Location = new Point(GoalComp.Location.X, GoalComp.Location.Y + compSpeed);
                    }
                }
            }
            if (Ball.Location.X > 509)
            {
                if (Ball.Location.X < 795)
                {
                    if (Ball.Location.Y < 116)
                    {
                        if (Ball.Location.Y < MidComp1.Location.Y)
                        {
                            CompTeamUp();
                            GoalComp.Location = new Point(GoalComp.Location.X, GoalComp.Location.Y - compSpeed);
                        }
                        else
                        {
                            CompTeamDown();
                            GoalComp.Location = new Point(GoalComp.Location.X, GoalComp.Location.Y + compSpeed);
                        }
                    }
                    if (Ball.Location.Y > 110 && Ball.Location.Y < 210)
                    {
                        if (Ball.Location.Y < MidComp2.Location.Y)
                        {
                            CompTeamUp();
                            GoalComp.Location = new Point(GoalComp.Location.X, GoalComp.Location.Y - compSpeed);
                        }
                        else
                        {
                            CompTeamDown();
                            GoalComp.Location = new Point(GoalComp.Location.X, GoalComp.Location.Y + compSpeed);
                        }
                    }
                    if (Ball.Location.Y > 210 && Ball.Location.Y < 310)
                    {
                        if (Ball.Location.Y < MidComp3.Location.Y)
                        {
                            CompTeamUp();
                            GoalComp.Location = new Point(GoalComp.Location.X, GoalComp.Location.Y - compSpeed);
                        }
                        else
                        {
                            CompTeamDown();
                            GoalComp.Location = new Point(GoalComp.Location.X, GoalComp.Location.Y + compSpeed);
                        }
                    }
                    if (Ball.Location.Y > 310 && Ball.Location.Y < 410)
                    {
                        if (Ball.Location.Y < MidComp4.Location.Y)
                        {
                            CompTeamUp();
                            GoalComp.Location = new Point(GoalComp.Location.X, GoalComp.Location.Y - compSpeed);
                        }
                        else
                        {
                            CompTeamDown();
                            GoalComp.Location = new Point(GoalComp.Location.X, GoalComp.Location.Y + compSpeed);
                        }
                    }
                    if (Ball.Location.Y > 410 && Ball.Location.Y < bottom)
                    {
                        if (Ball.Location.Y < MidComp5.Location.Y)
                        {
                            CompTeamUp();
                            GoalComp.Location = new Point(GoalComp.Location.X, GoalComp.Location.Y - compSpeed);
                        }
                        else
                        {
                            CompTeamDown();
                            GoalComp.Location = new Point(GoalComp.Location.X, GoalComp.Location.Y + compSpeed);
                        }
                    }
                }
                else if (Ball.Location.X > 795)
                {
                    if (Ball.Location.Y < 150)
                    {
                        if (GoalComp.Location.Y > 150)
                        {
                            CompTeamUp();
                            GoalComp.Location = new Point(GoalComp.Location.X, GoalComp.Location.Y - compSpeed);
                        }
                        
                    }
                    if (Ball.Location.Y > 150 && Ball.Location.Y < 387)
                    {
                        if (Ball.Location.Y > GoalComp.Location.Y)
                        {
                            GoalComp.Location = new Point(GoalComp.Location.X, GoalComp.Location.Y + compSpeed);
                            CompTeamDown();
                        }
                        else
                        {
                            GoalComp.Location = new Point(GoalComp.Location.X, GoalComp.Location.Y - compSpeed);
                            CompTeamUp();
                        }
                    }
                    if (Ball.Location.Y > 387)
                    {
                        if (GoalComp.Location.Y < 350)
                        {
                            CompTeamDown();
                            GoalComp.Location = new Point(GoalComp.Location.X, GoalComp.Location.Y + compSpeed);

                        }
                    }
                }
            }
        }

        private void aBallTimer_Tick(object sender, EventArgs e)
        {
            if (!gameEnd)
            {
                aYourTeamLabel.Text = yourTeam;
                aCompTeamLabel.Text = compTeam;
                Clothes();

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
                    aTimeShowing.Enabled = true;
                    aTimer.Enabled = true;
                    aCompTimer.Enabled = true;
                    aBallTimer.Enabled = false;

                }
            }
            else if(gameEnd)
            {
                countForFinalWhistle++;
                if (countForFinalWhistle / 1 == 1)
                {
                    finalWhistle.Play();
                }
                news.Visible = true;
                playerScoreBig.Visible = true;
                compScoreBig.Visible = true;
                TeamsLeaving();

            }

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
            
          
            //SCORING
            if (Ball.Location.X >= 1059) //(1040; 197) ; (1040; 351)
            {
                if (Ball.Location.Y >= 190 && Ball.Location.Y <= 368)
                {
                    playerScore++;
                    Scoring();
                    ShowGoal();
                    goalScored.Play();

                }
            }
            if (Ball.Location.X <= 55) // (79; 193) (80; 358)
            {
                if (Ball.Location.Y >= 188 && Ball.Location.Y <= 362)
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
                ballSpeedX = -Math.Abs(ballSpeedX);
            }
            // COMP COLLISION FROM LEFT
            if (DefComp1.Bounds.IntersectsWith(Ball.Bounds) || DefComp2.Bounds.IntersectsWith(Ball.Bounds) || MidComp1.Bounds.IntersectsWith(Ball.Bounds) || MidComp2.Bounds.IntersectsWith(Ball.Bounds) || MidComp3.Bounds.IntersectsWith(Ball.Bounds) || MidComp4.Bounds.IntersectsWith(Ball.Bounds) || MidComp5.Bounds.IntersectsWith(Ball.Bounds) || ForwComp1.Bounds.IntersectsWith(Ball.Bounds) || ForwComp2.Bounds.IntersectsWith(Ball.Bounds) || ForwComp3.Bounds.IntersectsWith(Ball.Bounds))
            {


                if (ballSpeedX > 0)
                {
                    if (Ball.Location.X < 335)
                    {
                        if (Ball.Location.Y < 276)
                        {
                            ballSpeedY = -Math.Abs(ballSpeedY);
                        }
                        else
                        {
                            ballSpeedY = Math.Abs(ballSpeedY);
                        }
                    }
                    else
                    {
                        if (compdirect < 0)
                        {
                            ballSpeedY *= 1;
                            ballSpeedX *= -1;
                        }
                        else
                        {
                            ballSpeedY *= -1;
                            ballSpeedX *= -1;
                        }
                    }
                }
                else
                {                                      
                        ballSpeedY *= -1;                    
                }
                
            }



            //ACCELERATION only X            
            //BALL COLLISON TO ATTACK

            countForAccelerationToAttack++;

           

            if (ballSpeedX > 0)
            {
                if (Ball.Location.Y < 266)
                {
                    if (ballSpeedY < 0)
                    {
                        if (GoalKeeper.Bounds.IntersectsWith(Ball.Bounds) || Def1.Bounds.IntersectsWith(Ball.Bounds) || Def2.Bounds.IntersectsWith(Ball.Bounds) || Mid1.Bounds.IntersectsWith(Ball.Bounds) || Mid2.Bounds.IntersectsWith(Ball.Bounds) || Mid3.Bounds.IntersectsWith(Ball.Bounds) || Mid4.Bounds.IntersectsWith(Ball.Bounds) || Mid5.Bounds.IntersectsWith(Ball.Bounds) || Forw1.Bounds.IntersectsWith(Ball.Bounds) || Forw2.Bounds.IntersectsWith(Ball.Bounds) || Forw3.Bounds.IntersectsWith(Ball.Bounds))
                        {
                            
                            if (countForAccelerationToAttack % 3 == 1)
                            {
                                accelerationAttPlayer = 3;
                                ballSpeedY *= -1;
                                ballSpeedX += accelerationAttPlayer;
                                
                            }
                            if (countForAccelerationToAttack % 3 == 2)
                            {
                                accelerationAttPlayer = 4;
                                ballSpeedY *= -1;
                                ballSpeedX += accelerationAttPlayer;
                                
                            }
                            if (countForAccelerationToAttack % 3 == 0)
                            {
                                accelerationAttPlayer = 5;
                                ballSpeedY *= -1;
                                ballSpeedX += accelerationAttPlayer;
                                
                            }

                           
                        }

                    }
                }
                else
                {
                    if (ballSpeedY > 0)
                    {
                        if (GoalKeeper.Bounds.IntersectsWith(Ball.Bounds) || Def1.Bounds.IntersectsWith(Ball.Bounds) || Def2.Bounds.IntersectsWith(Ball.Bounds) || Mid1.Bounds.IntersectsWith(Ball.Bounds) || Mid2.Bounds.IntersectsWith(Ball.Bounds) || Mid3.Bounds.IntersectsWith(Ball.Bounds) || Mid4.Bounds.IntersectsWith(Ball.Bounds) || Mid5.Bounds.IntersectsWith(Ball.Bounds) || Forw1.Bounds.IntersectsWith(Ball.Bounds) || Forw2.Bounds.IntersectsWith(Ball.Bounds) || Forw3.Bounds.IntersectsWith(Ball.Bounds))
                        {
                            if (countForAccelerationToAttack % 3 == 1)
                            {
                                accelerationAttPlayer = 3;
                                ballSpeedY *= -1;
                                ballSpeedX += accelerationAttPlayer;
                                
                            }
                            if (countForAccelerationToAttack % 3 == 2)
                            {
                                accelerationAttPlayer = 4;
                                ballSpeedY *= -1;
                                ballSpeedX += accelerationAttPlayer;
                                
                            }
                            if (countForAccelerationToAttack % 3 == 0)
                            {
                                accelerationAttPlayer = 5;
                                ballSpeedY *= -1;
                                ballSpeedX += accelerationAttPlayer;
                                
                            }

                        }
                    }
                }
                if (isDownPressed == true && ballSpeedY < 0)
                {
                    if (GoalKeeper.Bounds.IntersectsWith(Ball.Bounds) || Def1.Bounds.IntersectsWith(Ball.Bounds) || Def2.Bounds.IntersectsWith(Ball.Bounds) || Mid1.Bounds.IntersectsWith(Ball.Bounds) || Mid2.Bounds.IntersectsWith(Ball.Bounds) || Mid3.Bounds.IntersectsWith(Ball.Bounds) || Mid4.Bounds.IntersectsWith(Ball.Bounds) || Mid5.Bounds.IntersectsWith(Ball.Bounds) || Forw1.Bounds.IntersectsWith(Ball.Bounds) || Forw2.Bounds.IntersectsWith(Ball.Bounds) || Forw3.Bounds.IntersectsWith(Ball.Bounds))
                    {                        
                        if (countForAccelerationToAttack % 3 == 1)
                        {
                            accelerationAttPlayer = 3;
                            ballSpeedY *= -1;
                            ballSpeedX += accelerationAttPlayer;                            
                        }
                        if (countForAccelerationToAttack % 3 == 2)
                        {
                            accelerationAttPlayer = 4;
                            ballSpeedY *= -1;
                            ballSpeedX += accelerationAttPlayer;
                            
                        }
                        if (countForAccelerationToAttack % 3 == 0)
                        {
                            accelerationAttPlayer = 5;
                            ballSpeedY *= -1;
                            ballSpeedX += accelerationAttPlayer;
                            
                        }

                    }
                }
                if (isUpPressed == true && ballSpeedY > 0)
                {
                    if (GoalKeeper.Bounds.IntersectsWith(Ball.Bounds) || Def1.Bounds.IntersectsWith(Ball.Bounds) || Def2.Bounds.IntersectsWith(Ball.Bounds) || Mid1.Bounds.IntersectsWith(Ball.Bounds) || Mid2.Bounds.IntersectsWith(Ball.Bounds) || Mid3.Bounds.IntersectsWith(Ball.Bounds) || Mid4.Bounds.IntersectsWith(Ball.Bounds) || Mid5.Bounds.IntersectsWith(Ball.Bounds) || Forw1.Bounds.IntersectsWith(Ball.Bounds) || Forw2.Bounds.IntersectsWith(Ball.Bounds) || Forw3.Bounds.IntersectsWith(Ball.Bounds))
                    {
                        
                        if (countForAccelerationToAttack % 3 == 1)
                        {
                            accelerationAttPlayer = 3;
                            ballSpeedY *= -1;
                            ballSpeedX += accelerationAttPlayer;
                            
                        }
                        if (countForAccelerationToAttack % 3 == 2)
                        {
                            accelerationAttPlayer = 4;
                            ballSpeedY *= -1;
                            ballSpeedX += accelerationAttPlayer;
                            
                        }
                        if (countForAccelerationToAttack % 3 == 0)
                        {
                            accelerationAttPlayer = 5;
                            ballSpeedY *= -1;
                            ballSpeedX += accelerationAttPlayer;
                                                      
                        }

                    }
                }

            }
            
            if (ballSpeedX > ballSpeedXClone)
            {
                if (countForAccelerationDelete % 2 == 0)
                {
                    ballSpeedX--;
                }
            }

            //COLLISION FROM RIGHT

            countForAcceleration++;

            if (ballSpeedX < 0)
            {
                if (GoalKeeper.Bounds.IntersectsWith(Ball.Bounds) || Def1.Bounds.IntersectsWith(Ball.Bounds) || Def2.Bounds.IntersectsWith(Ball.Bounds) || Mid1.Bounds.IntersectsWith(Ball.Bounds) || Mid2.Bounds.IntersectsWith(Ball.Bounds) || Mid3.Bounds.IntersectsWith(Ball.Bounds) || Mid4.Bounds.IntersectsWith(Ball.Bounds) || Mid5.Bounds.IntersectsWith(Ball.Bounds) || Forw1.Bounds.IntersectsWith(Ball.Bounds) || Forw2.Bounds.IntersectsWith(Ball.Bounds) || Forw3.Bounds.IntersectsWith(Ball.Bounds))
                {
                    
                    if (countForAcceleration % 3 == 1)
                    {
                        accelerationDefPlayer = 2;
                        AccelerationDefPlayer();
                        
                    }
                    else if (countForAcceleration % 3 == 2)
                    {
                        accelerationDefPlayer = 4;
                        AccelerationDefPlayer();
                        
                    }
                    else
                    {
                        accelerationDefPlayer = 7;
                        AccelerationDefPlayer();                                               
                    }
                }
            }

            //BALL COLLISION WITH BORDERS

            if (Ball.Location.Y <= top)
            {
                ballSpeedY = Math.Abs(ballSpeedY);
            }
            else if (Ball.Location.Y >= bottom)
            {
                ballSpeedY = -Math.Abs(ballSpeedY);
            }
            if (Ball.Location.X <= leftOfTheField)
            {
                if (Ball.Location.Y < 188 || Ball.Location.Y > 362)
                {
                    ballSpeedX = Math.Abs(ballSpeedX);
                }
            }
            else if(Ball.Location.X >= rightOfTheField - Ball.Width)
            {
                if (Ball.Location.Y < 190 || Ball.Location.Y > 368)
                {
                    ballSpeedX = -Math.Abs(ballSpeedX);
                }
            }

            

            if (isUpPressed)
            {                
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
