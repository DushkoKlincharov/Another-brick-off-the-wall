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
        public Scene Scene { get; set; }

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
            reward = new Reward(100,100,true);
            //reward = new Reward(0,0,false);
            left = right = false;

            countdown = 3;
            DoubleBuffered = true;
            this.BackgroundImage = Resources.newGame_window_background;
        }

        private void pbNewGame_Paint(object sender, PaintEventArgs e)
        {

          //  e.Graphics.Clear(Color.SlateGray);
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

        private void timerForBall_Tick(object sender, EventArgs e)
        {
            ball.Move();
            ball.SliderCollider(slider);
            reward.Move(slider);
            if (slider.touchReward(reward))
            {
                reward.X = 0;
                reward.Y = 0;
            }
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

        // Slider moving methods

        private void NewGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                Scene.MoveRightSlider = true;
            }
            else if (e.KeyCode == Keys.Right)
            {
                Scene.MoveLeftSlider = true;
            }
        }

        private void NewGame_KeyUp(object sender, KeyEventArgs e)
        {
            Scene.MoveLeftSlider = Scene.MoveRightSlider = false;

        }

        private void timerSlider_Tick(object sender, EventArgs e)
        {
            //Scene.MoveSlider();
            Invalidate(true);
        }


        



        

        

        

    }
}
