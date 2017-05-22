using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Another_Brick_Off_The_Wall.Properties;

namespace Another_Brick_Off_The_Wall
{
    public partial class NewGame : Form
    {
        private Ball ball;
        private Slider slider;
        List<Tile> tiles;
        Level level;
        int countdown;
        Reward reward;
        bool left;
        bool right;

        public NewGame(Level level)
        {
            InitializeComponent();

            ball = new Ball(pbNewGame, Level.BallSpeeds.MEDIUM);
            
            level = new Level3();
            tiles = level.getTiles();
            slider = new Slider(Level.SliderLengths.LARGE);
            //reward = new Reward(100,100,true);
            reward = new Reward(0,0,false);
            left = right = false;

            countdown = 3;
            DoubleBuffered = true;
            this.BackgroundImage = Resources.newGame_window_background;
        }

        private void pbNewGame_Paint(object sender, PaintEventArgs e)
        {
<<<<<<< HEAD
            pbNewGame.SetBounds(this.Width / 2 - pbNewGame.Width / 2, this.Height / 2 - pbNewGame.Height / 2, pbNewGame.Width, pbNewGame.Height);
            lblCountdown.Location = new Point(this.Width / 2, this.Height / 2);
            e.Graphics.Clear(Color.SlateGray);
=======
          //  e.Graphics.Clear(Color.SlateGray);
>>>>>>> Added class Reward
            Draw(e.Graphics);
            ball.Draw(e.Graphics);
           // lblCountdown.BackColor = Color.SlateGray;
            lblCountdown.Text = countdown.ToString();
            reward.Draw(e.Graphics);
        }

        public void Draw(Graphics g)
        {
            foreach (Tile t in tiles)
            {
                t.Draw(g);
            }
            slider.Draw(g);
        }


        private void NewGame_KeyDown(object sender, KeyEventArgs e)
        {
            //timerSlider.Enabled = true;
            if (e.KeyCode == Keys.Left)
            {
                left = true;
                //timerSlider.Start();
                //slider.Move(-10);
            }
            else if (e.KeyCode == Keys.Right)
            {
                right = true;
                //timerSlider.Start();
                //slider.Move(10);
            }
           // timerSlider.Stop();
               // Invalidate(true);
        }

        

        private void timerForBall_Tick(object sender, EventArgs e)
        {
            ball.Move();
            ball.SliderCollider(slider);
            reward.Move(slider);
            Invalidate(true);
        }

        private void timerCountdown_Tick(object sender, EventArgs e)
        {
            if (countdown == 0)
            {
                timerCountdown.Stop();
                lblCountdown.Hide();
                timerForBall.Start();
            }
            else
            {
                countdown--;

            }
            Invalidate(true);
        }

        private void timerSlider_Tick(object sender, EventArgs e)
        {
            if (left)
                slider.Move(-8);
            if (right)
                slider.Move(8);
            Invalidate(true);
        }

        private void NewGame_KeyUp(object sender, KeyEventArgs e)
        {
            right = left = false;
        }

        

        /*private void pbNewGame_Paint(object sender, PaintEventArgs e)
        {
            /*e.Graphics.Clear(Color.White);
            ball.Draw(e.Graphics);*/
        //}

        



        

        

        

    }
}
