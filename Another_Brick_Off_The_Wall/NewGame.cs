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
        public Level Level { get; set; }
        public PictureBox PictureBox { get; set; }
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
            Level = level;
            PictureBox = pbNewGame;
            Scene = new Scene(Level, PictureBox);

            ball = new Ball(pbNewGame, Level.BallSpeeds.MEDIUM);
            level = new Level3();
            tiles = level.getTiles();
            slider = new Slider(Level.SliderLengths.LARGE);
            reward = new Reward(100, 100, true);
            //reward = new Reward(0,0,false);
            left = right = false;

            countdown = 3;
            DoubleBuffered = true;
            this.BackgroundImage = Resources.newGame_window_background;
        }

        private void pbNewGame_Paint(object sender, PaintEventArgs e)
        {

            // lblCountdown.BackColor = Color.SlateGray;
            lblCountdown.Text = countdown.ToString();
            Scene.Draw(e.Graphics);
        }

        private void timerForBall_Tick(object sender, EventArgs e)
        {
            Scene.TimerTick();
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
                Scene.MoveLeftSlider = true;
            }
            else if (e.KeyCode == Keys.Right)
            {
                Scene.MoveRightSlider = true;
            }
        }

        private void NewGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                Scene.MoveLeftSlider = false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                Scene.MoveRightSlider = false;
            }

        }

       /* private void timerSlider_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello");
            Scene.MoveSlider();
            Invalidate(true);
        }*/

       












    }
}