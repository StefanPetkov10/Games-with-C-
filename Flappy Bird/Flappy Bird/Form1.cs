using System;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class Form1 : Form
    {

        int pipeSpeed = 8;
        public int gravity = 0;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }
        private void gamekeyisup(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += " Game over!!!";
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top -= gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreText.Text = "Score: " + score;

            if (pipeBottom.Left < -150)
            {
                pipeBottom.Left = 800;
                score++;
            }
            if (pipeTop.Left < -180)
            {
                pipeTop.Left = 950;
                score++;
            }

            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
               flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
               flappyBird.Bounds.IntersectsWith(ground.Bounds)
               )
            {
                endGame();
            }

            if (score > 5)
            {
                pipeSpeed = 15;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void scoreText_Click(object sender, EventArgs e)
        {

        }
    }
}




