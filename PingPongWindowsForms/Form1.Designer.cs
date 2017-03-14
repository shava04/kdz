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
            this.aPanel1 = new System.Windows.Forms.PictureBox();
            this.aPanel2 = new System.Windows.Forms.PictureBox();
            this.aBall = new System.Windows.Forms.PictureBox();
            this.aTimer = new System.Windows.Forms.Timer(this.components);
            this.aBallTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.aPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // aPanel1
            // 
            this.aPanel1.Image = global::PingPongWindowsForms.Properties.Resources.tr_panel;
            this.aPanel1.Location = new System.Drawing.Point(12, 174);
            this.aPanel1.Name = "aPanel1";
            this.aPanel1.Size = new System.Drawing.Size(27, 90);
            this.aPanel1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aPanel1.TabIndex = 0;
            this.aPanel1.TabStop = false;
            // 
            // aPanel2
            // 
            this.aPanel2.Image = global::PingPongWindowsForms.Properties.Resources.tr_panel;
            this.aPanel2.Location = new System.Drawing.Point(624, 174);
            this.aPanel2.Name = "aPanel2";
            this.aPanel2.Size = new System.Drawing.Size(27, 90);
            this.aPanel2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aPanel2.TabIndex = 1;
            this.aPanel2.TabStop = false;
            // 
            // aBall
            // 
            this.aBall.BackColor = System.Drawing.Color.White;
            this.aBall.BackgroundImage = global::PingPongWindowsForms.Properties.Resources.ball1;
            this.aBall.Image = global::PingPongWindowsForms.Properties.Resources.ball1;
            this.aBall.Location = new System.Drawing.Point(297, 174);
            this.aBall.Name = "aBall";
            this.aBall.Size = new System.Drawing.Size(31, 33);
            this.aBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.aBall.TabIndex = 2;
            this.aBall.TabStop = false;
            // 
            // aTimer
            // 
            this.aTimer.Enabled = true;
            this.aTimer.Interval = 1;
            this.aTimer.Tick += new System.EventHandler(this.aTimer_Tick);
            // 
            // aBallTimer
            // 
            this.aBallTimer.Enabled = true;
            this.aBallTimer.Interval = 10;
            this.aBallTimer.Tick += new System.EventHandler(this.aBallTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PingPongWindowsForms.Properties.Resources.ball1;
            this.pictureBox1.Location = new System.Drawing.Point(240, 224);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(377, 183);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 81);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PingPongWindowsForms.Properties.Resources.pitch;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(663, 425);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.aBall);
            this.Controls.Add(this.aPanel2);
            this.Controls.Add(this.aPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.aPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox aPanel1;
        private System.Windows.Forms.PictureBox aPanel2;
        private System.Windows.Forms.PictureBox aBall;
        private System.Windows.Forms.Timer aTimer;
        private System.Windows.Forms.Timer aBallTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

