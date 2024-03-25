using System.Drawing;
using System.Windows.Forms;

namespace Flappy_Bird
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pipeBottom = new PictureBox();
            flappyBird = new PictureBox();
            ground = new PictureBox();
            scoreText = new Label();
            pipeTop = new PictureBox();
            gameTimer = new Timer(components);
            ((System.ComponentModel.ISupportInitialize)pipeBottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flappyBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeTop).BeginInit();
            SuspendLayout();
            // 
            // pipeBottom
            // 
            pipeBottom.Image = (Image)resources.GetObject("pipeBottom.Image");
            pipeBottom.Location = new Point(1647, 683);
            pipeBottom.Margin = new Padding(7, 8, 7, 8);
            pipeBottom.Name = "pipeBottom";
            pipeBottom.Size = new Size(180, 415);
            pipeBottom.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeBottom.TabIndex = 1;
            pipeBottom.TabStop = false;
            pipeBottom.UseWaitCursor = true;
            // 
            // flappyBird
            // 
            flappyBird.Image = (Image)resources.GetObject("flappyBird.Image");
            flappyBird.Location = new Point(315, 410);
            flappyBird.Margin = new Padding(7, 8, 7, 8);
            flappyBird.Name = "flappyBird";
            flappyBird.Size = new Size(223, 172);
            flappyBird.SizeMode = PictureBoxSizeMode.StretchImage;
            flappyBird.TabIndex = 2;
            flappyBird.TabStop = false;
            flappyBird.UseWaitCursor = true;
            flappyBird.WaitOnLoad = true;
            // 
            // ground
            // 
            ground.Image = (Image)resources.GetObject("ground.Image");
            ground.Location = new Point(-5, 1094);
            ground.Margin = new Padding(7, 8, 7, 8);
            ground.Name = "ground";
            ground.Size = new Size(2124, 246);
            ground.SizeMode = PictureBoxSizeMode.StretchImage;
            ground.TabIndex = 3;
            ground.TabStop = false;
            // 
            // scoreText
            // 
            scoreText.AutoSize = true;
            scoreText.BackColor = Color.Transparent;
            scoreText.BorderStyle = BorderStyle.Fixed3D;
            scoreText.Font = new Font("Sitka Text", 36F, FontStyle.Bold, GraphicsUnit.Point);
            scoreText.Location = new Point(16, 22);
            scoreText.Margin = new Padding(7, 0, 7, 0);
            scoreText.Name = "scoreText";
            scoreText.Size = new Size(543, 176);
            scoreText.TabIndex = 4;
            scoreText.Text = "score: 0";
            scoreText.Click += scoreText_Click;
            // 
            // pipeTop
            // 
            pipeTop.Image = (Image)resources.GetObject("pipeTop.Image");
            pipeTop.Location = new Point(1647, -8);
            pipeTop.Margin = new Padding(7, 8, 7, 8);
            pipeTop.Name = "pipeTop";
            pipeTop.Size = new Size(180, 374);
            pipeTop.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeTop.TabIndex = 0;
            pipeTop.TabStop = false;
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(2097, 1343);
            Controls.Add(scoreText);
            Controls.Add(ground);
            Controls.Add(flappyBird);
            Controls.Add(pipeBottom);
            Controls.Add(pipeTop);
            Margin = new Padding(7, 8, 7, 8);
            Name = "Form1";
            Text = "Flappy Bird Games-Moo ICT";
            Load += Form1_Load;
            KeyDown += gamekeyisdown;
            KeyUp += gamekeyisup;
            ((System.ComponentModel.ISupportInitialize)pipeBottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)flappyBird).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeTop).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pipeBottom;
        private PictureBox flappyBird;
        private PictureBox ground;
        private Label scoreText;

        private PictureBox pipeTop;
        private Timer gameTimer;
    }
}

