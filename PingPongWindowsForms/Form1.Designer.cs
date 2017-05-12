namespace PingPongWindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.aTimer = new System.Windows.Forms.Timer(this.components);
            this.aBallTimer = new System.Windows.Forms.Timer(this.components);
            this.Ball = new System.Windows.Forms.PictureBox();
            this.Field = new System.Windows.Forms.PictureBox();
            this.LeftGoal = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Def1 = new System.Windows.Forms.PictureBox();
            this.Mid1 = new System.Windows.Forms.PictureBox();
            this.Def2 = new System.Windows.Forms.PictureBox();
            this.Mid2 = new System.Windows.Forms.PictureBox();
            this.Mid3 = new System.Windows.Forms.PictureBox();
            this.Mid4 = new System.Windows.Forms.PictureBox();
            this.Mid5 = new System.Windows.Forms.PictureBox();
            this.Forw1 = new System.Windows.Forms.PictureBox();
            this.Forw2 = new System.Windows.Forms.PictureBox();
            this.Forw3 = new System.Windows.Forms.PictureBox();
            this.GoalKeeper = new System.Windows.Forms.PictureBox();
            this.aCompTimer = new System.Windows.Forms.Timer(this.components);
            this.GoalComp = new System.Windows.Forms.PictureBox();
            this.DefComp1 = new System.Windows.Forms.PictureBox();
            this.DefComp2 = new System.Windows.Forms.PictureBox();
            this.MidComp1 = new System.Windows.Forms.PictureBox();
            this.MidComp3 = new System.Windows.Forms.PictureBox();
            this.MidComp2 = new System.Windows.Forms.PictureBox();
            this.MidComp4 = new System.Windows.Forms.PictureBox();
            this.MidComp5 = new System.Windows.Forms.PictureBox();
            this.ForwComp1 = new System.Windows.Forms.PictureBox();
            this.ForwComp2 = new System.Windows.Forms.PictureBox();
            this.ForwComp3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Field)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftGoal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Def1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Def2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mid3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mid4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mid5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Forw1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Forw2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Forw3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoalKeeper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoalComp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefComp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefComp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MidComp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MidComp3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MidComp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MidComp4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MidComp5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForwComp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForwComp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForwComp3)).BeginInit();
            this.SuspendLayout();
            // 
            // aTimer
            // 
            this.aTimer.Enabled = true;
            this.aTimer.Interval = 15;
            this.aTimer.Tick += new System.EventHandler(this.aTimer_Tick);
            // 
            // aBallTimer
            // 
            this.aBallTimer.Enabled = true;
            this.aBallTimer.Interval = 65;
            this.aBallTimer.Tick += new System.EventHandler(this.aBallTimer_Tick);
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.Ball.Image = global::PingPongWindowsForms.Properties.Resources.ball1;
            this.Ball.Location = new System.Drawing.Point(559, 274);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(24, 24);
            this.Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ball.TabIndex = 3;
            this.Ball.TabStop = false;
            // 
            // Field
            // 
            this.Field.Image = ((System.Drawing.Image)(resources.GetObject("Field.Image")));
            this.Field.Location = new System.Drawing.Point(79, 28);
            this.Field.Name = "Field";
            this.Field.Size = new System.Drawing.Size(985, 517);
            this.Field.TabIndex = 4;
            this.Field.TabStop = false;
            // 
            // LeftGoal
            // 
            this.LeftGoal.Image = ((System.Drawing.Image)(resources.GetObject("LeftGoal.Image")));
            this.LeftGoal.Location = new System.Drawing.Point(27, 190);
            this.LeftGoal.Name = "LeftGoal";
            this.LeftGoal.Size = new System.Drawing.Size(52, 192);
            this.LeftGoal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeftGoal.TabIndex = 5;
            this.LeftGoal.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1062, 190);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 192);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(200)))), ((int)(((byte)(90)))));
            this.pictureBox3.Location = new System.Drawing.Point(12, 180);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(67, 214);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(200)))), ((int)(((byte)(90)))));
            this.pictureBox4.Location = new System.Drawing.Point(1060, 180);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(67, 214);
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // Def1
            // 
            this.Def1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Def1.Location = new System.Drawing.Point(243, 180);
            this.Def1.Name = "Def1";
            this.Def1.Size = new System.Drawing.Size(10, 39);
            this.Def1.TabIndex = 9;
            this.Def1.TabStop = false;
            // 
            // Mid1
            // 
            this.Mid1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Mid1.Location = new System.Drawing.Point(459, 66);
            this.Mid1.Name = "Mid1";
            this.Mid1.Size = new System.Drawing.Size(10, 39);
            this.Mid1.TabIndex = 10;
            this.Mid1.TabStop = false;
            // 
            // Def2
            // 
            this.Def2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Def2.Location = new System.Drawing.Point(243, 343);
            this.Def2.Name = "Def2";
            this.Def2.Size = new System.Drawing.Size(10, 39);
            this.Def2.TabIndex = 11;
            this.Def2.TabStop = false;
            // 
            // Mid2
            // 
            this.Mid2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Mid2.Location = new System.Drawing.Point(459, 164);
            this.Mid2.Name = "Mid2";
            this.Mid2.Size = new System.Drawing.Size(10, 39);
            this.Mid2.TabIndex = 12;
            this.Mid2.TabStop = false;
            // 
            // Mid3
            // 
            this.Mid3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Mid3.Location = new System.Drawing.Point(459, 261);
            this.Mid3.Name = "Mid3";
            this.Mid3.Size = new System.Drawing.Size(10, 39);
            this.Mid3.TabIndex = 13;
            this.Mid3.TabStop = false;
            // 
            // Mid4
            // 
            this.Mid4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Mid4.Location = new System.Drawing.Point(459, 358);
            this.Mid4.Name = "Mid4";
            this.Mid4.Size = new System.Drawing.Size(10, 39);
            this.Mid4.TabIndex = 14;
            this.Mid4.TabStop = false;
            // 
            // Mid5
            // 
            this.Mid5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Mid5.Location = new System.Drawing.Point(459, 455);
            this.Mid5.Name = "Mid5";
            this.Mid5.Size = new System.Drawing.Size(10, 39);
            this.Mid5.TabIndex = 15;
            this.Mid5.TabStop = false;
            // 
            // Forw1
            // 
            this.Forw1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Forw1.Location = new System.Drawing.Point(773, 127);
            this.Forw1.Name = "Forw1";
            this.Forw1.Size = new System.Drawing.Size(10, 39);
            this.Forw1.TabIndex = 16;
            this.Forw1.TabStop = false;
            // 
            // Forw2
            // 
            this.Forw2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Forw2.Location = new System.Drawing.Point(773, 261);
            this.Forw2.Name = "Forw2";
            this.Forw2.Size = new System.Drawing.Size(10, 39);
            this.Forw2.TabIndex = 17;
            this.Forw2.TabStop = false;
            // 
            // Forw3
            // 
            this.Forw3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Forw3.Location = new System.Drawing.Point(773, 389);
            this.Forw3.Name = "Forw3";
            this.Forw3.Size = new System.Drawing.Size(10, 39);
            this.Forw3.TabIndex = 18;
            this.Forw3.TabStop = false;
            // 
            // GoalKeeper
            // 
            this.GoalKeeper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GoalKeeper.Location = new System.Drawing.Point(94, 266);
            this.GoalKeeper.Name = "GoalKeeper";
            this.GoalKeeper.Size = new System.Drawing.Size(10, 39);
            this.GoalKeeper.TabIndex = 19;
            this.GoalKeeper.TabStop = false;
            // 
            // aCompTimer
            // 
            this.aCompTimer.Enabled = true;
            this.aCompTimer.Interval = 15;
            this.aCompTimer.Tick += new System.EventHandler(this.aCompTimer_Tick);
            // 
            // GoalComp
            // 
            this.GoalComp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.GoalComp.Location = new System.Drawing.Point(1033, 266);
            this.GoalComp.Name = "GoalComp";
            this.GoalComp.Size = new System.Drawing.Size(10, 39);
            this.GoalComp.TabIndex = 20;
            this.GoalComp.TabStop = false;
            // 
            // DefComp1
            // 
            this.DefComp1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DefComp1.Location = new System.Drawing.Point(889, 180);
            this.DefComp1.Name = "DefComp1";
            this.DefComp1.Size = new System.Drawing.Size(10, 39);
            this.DefComp1.TabIndex = 21;
            this.DefComp1.TabStop = false;
            // 
            // DefComp2
            // 
            this.DefComp2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DefComp2.Location = new System.Drawing.Point(889, 343);
            this.DefComp2.Name = "DefComp2";
            this.DefComp2.Size = new System.Drawing.Size(10, 39);
            this.DefComp2.TabIndex = 22;
            this.DefComp2.TabStop = false;
            // 
            // MidComp1
            // 
            this.MidComp1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MidComp1.Location = new System.Drawing.Point(673, 66);
            this.MidComp1.Name = "MidComp1";
            this.MidComp1.Size = new System.Drawing.Size(10, 39);
            this.MidComp1.TabIndex = 23;
            this.MidComp1.TabStop = false;
            // 
            // MidComp3
            // 
            this.MidComp3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MidComp3.Location = new System.Drawing.Point(673, 260);
            this.MidComp3.Name = "MidComp3";
            this.MidComp3.Size = new System.Drawing.Size(10, 39);
            this.MidComp3.TabIndex = 24;
            this.MidComp3.TabStop = false;
            // 
            // MidComp2
            // 
            this.MidComp2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MidComp2.Location = new System.Drawing.Point(673, 160);
            this.MidComp2.Name = "MidComp2";
            this.MidComp2.Size = new System.Drawing.Size(10, 39);
            this.MidComp2.TabIndex = 25;
            this.MidComp2.TabStop = false;
            // 
            // MidComp4
            // 
            this.MidComp4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MidComp4.Location = new System.Drawing.Point(673, 360);
            this.MidComp4.Name = "MidComp4";
            this.MidComp4.Size = new System.Drawing.Size(10, 39);
            this.MidComp4.TabIndex = 26;
            this.MidComp4.TabStop = false;
            // 
            // MidComp5
            // 
            this.MidComp5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MidComp5.Location = new System.Drawing.Point(673, 460);
            this.MidComp5.Name = "MidComp5";
            this.MidComp5.Size = new System.Drawing.Size(10, 39);
            this.MidComp5.TabIndex = 27;
            this.MidComp5.TabStop = false;
            // 
            // ForwComp1
            // 
            this.ForwComp1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ForwComp1.Location = new System.Drawing.Point(345, 127);
            this.ForwComp1.Name = "ForwComp1";
            this.ForwComp1.Size = new System.Drawing.Size(10, 39);
            this.ForwComp1.TabIndex = 28;
            this.ForwComp1.TabStop = false;
            // 
            // ForwComp2
            // 
            this.ForwComp2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ForwComp2.Location = new System.Drawing.Point(345, 261);
            this.ForwComp2.Name = "ForwComp2";
            this.ForwComp2.Size = new System.Drawing.Size(10, 39);
            this.ForwComp2.TabIndex = 29;
            this.ForwComp2.TabStop = false;
            // 
            // ForwComp3
            // 
            this.ForwComp3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ForwComp3.Location = new System.Drawing.Point(345, 395);
            this.ForwComp3.Name = "ForwComp3";
            this.ForwComp3.Size = new System.Drawing.Size(10, 39);
            this.ForwComp3.TabIndex = 30;
            this.ForwComp3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(75)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1137, 604);
            this.Controls.Add(this.ForwComp3);
            this.Controls.Add(this.ForwComp2);
            this.Controls.Add(this.ForwComp1);
            this.Controls.Add(this.MidComp5);
            this.Controls.Add(this.MidComp4);
            this.Controls.Add(this.MidComp2);
            this.Controls.Add(this.MidComp3);
            this.Controls.Add(this.MidComp1);
            this.Controls.Add(this.DefComp2);
            this.Controls.Add(this.DefComp1);
            this.Controls.Add(this.GoalComp);
            this.Controls.Add(this.GoalKeeper);
            this.Controls.Add(this.Forw3);
            this.Controls.Add(this.Forw2);
            this.Controls.Add(this.Forw1);
            this.Controls.Add(this.Mid5);
            this.Controls.Add(this.Mid4);
            this.Controls.Add(this.Mid3);
            this.Controls.Add(this.Mid2);
            this.Controls.Add(this.Def2);
            this.Controls.Add(this.Mid1);
            this.Controls.Add(this.Def1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LeftGoal);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.Field);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Football";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Field)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftGoal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Def1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Def2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mid3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mid4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mid5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Forw1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Forw2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Forw3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoalKeeper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoalComp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefComp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefComp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MidComp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MidComp3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MidComp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MidComp4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MidComp5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForwComp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForwComp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForwComp3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer aTimer;
        private System.Windows.Forms.Timer aBallTimer;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.PictureBox Field;
        private System.Windows.Forms.PictureBox LeftGoal;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox Def1;
        private System.Windows.Forms.PictureBox Mid1;
        private System.Windows.Forms.PictureBox Def2;
        private System.Windows.Forms.PictureBox Mid2;
        private System.Windows.Forms.PictureBox Mid3;
        private System.Windows.Forms.PictureBox Mid4;
        private System.Windows.Forms.PictureBox Mid5;
        private System.Windows.Forms.PictureBox Forw1;
        private System.Windows.Forms.PictureBox Forw2;
        private System.Windows.Forms.PictureBox Forw3;
        private System.Windows.Forms.PictureBox GoalKeeper;
        private System.Windows.Forms.Timer aCompTimer;
        private System.Windows.Forms.PictureBox GoalComp;
        private System.Windows.Forms.PictureBox DefComp1;
        private System.Windows.Forms.PictureBox DefComp2;
        private System.Windows.Forms.PictureBox MidComp1;
        private System.Windows.Forms.PictureBox MidComp3;
        private System.Windows.Forms.PictureBox MidComp2;
        private System.Windows.Forms.PictureBox MidComp4;
        private System.Windows.Forms.PictureBox MidComp5;
        private System.Windows.Forms.PictureBox ForwComp1;
        private System.Windows.Forms.PictureBox ForwComp2;
        private System.Windows.Forms.PictureBox ForwComp3;
    }
}

