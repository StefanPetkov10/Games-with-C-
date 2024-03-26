using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_Rex_Endless_Runner_MOO_ICT
{
    public partial class Form1 : Form
    {
        bool jumping = false;
        int jumpSpead = 0;
        int force = 12;
        int score = 0;
        int obstacleSpeed = 10;
        Random rand = new Random();
        int position;
        bool isGameOver = false;
        bool scoreChecked;


        public Form1()
        {
            InitializeComponent();

            GameReset();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GameReset()
        {
            force = 12;
            jumpSpead = 0;
            jumping = false;
            score = 0;
            obstacleSpeed = 10;
            txtScore.Text = "Score: " + score;
            Trex.Image = Properties.Resources.running;
            isGameOver = false;
            Trex.Top = 367;

            foreach (Control x in this.Controls)
            {

                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    position = this.ClientSize.Width + rand.Next(500, 800) + (x.Width * 10);

                    x.Left = position;

                    if (x.Left < -100)
                    {
                        x.Left = this.ClientSize.Width + rand.Next(200, 500) + (x.Width * 15);
                        score++;

                    }
                }

            }
            gameTimer.Start();

        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            Trex.Top += jumpSpead;

            txtScore.Text = "Score: " + score;

            if (jumping == true && force < 0)
            {
                jumping = false;
            }

            if (jumping == true)
            {
                jumpSpead = -12;
                force -= 1;
            }

            else
            {
                jumpSpead = 12;
            }

            if (Trex.Top > 366 && jumping == false)
            {
                force = 12;
                Trex.Top = 367;
                jumpSpead = 0;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= obstacleSpeed;

                    if (x.Left < -100)
                    {
                        x.Left = this.ClientSize.Width + rand.Next(200, 500) + (x.Width * 15);
                        score++;
                    }
                    if (Trex.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameTimer.Stop();
                        Trex.Image = Properties.Resources.dead;
                        txtScore.Text += " Press R to restart the game!";
                        isGameOver = true;
                    }
                }
            }
            //if (score > 5)
            //{
            //    obstacleSpeed = 15;
            //}


            if (score % 2 == 0 && !scoreChecked )
            {
                obstacleSpeed = obstacleSpeed + 1;
                scoreChecked = true;
            }
            else if (score % 2 != 0 && scoreChecked)
            {
                scoreChecked = false;
            }

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (jumping == true)
            {
                jumping = false;
            }

            if (e.KeyCode == Keys.R && isGameOver == true)
            {
                GameReset();
            }
        }
    }
}
