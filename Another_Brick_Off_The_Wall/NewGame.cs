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
            
<<<<<<< HEAD
            ball = new Ball(pbNewGame, Level.BallSpeeds.MEDIUM);
=======
>>>>>>> Colliding with tiles
            level = new Level3();
            tiles = level.getTiles();
            slider = new Slider(Level.SliderLengths.LARGE);
            reward = new Reward(100,100,true);
            //reward = new Reward(0,0,false);
            left = right = false;

            countdown = 3;
            DoubleBuffered = true;
<<<<<<< HEAD
            this.BackgroundImage = Resources.newGame_window_background;
=======
            
>>>>>>> Colliding with tiles
        }

        private void pbNewGame_Paint(object sender, PaintEventArgs e)
        {
<<<<<<< HEAD
=======
            pbNewGame.SetBounds(this.Width / 2 - pbNewGame.Width / 2, this.Height / 2 - pbNewGame.Height / 2, pbNewGame.Width, pbNewGame.Height);
            lblCountdown.Location = new Point(this.Width / 2, this.Height / 2);
            e.Graphics.Clear(Color.SlateGray);
            Draw(e.Graphics);
            ball.Draw(e.Graphics);
            lblCountdown.BackColor = Color.SlateGray;
            lblCountdown.Text = countdown.ToString();
            
        }

        private void CheckForCollision()
        {
            for (int i = 0; i < tiles.Count; i++)
            {
                if(ball.collides(tiles[i]))
                {
                    tiles.RemoveAt(i);
                    break;
                }
            }
            
        }

        public void Draw(Graphics g)
        {
            foreach (Tile t in tiles)
            {
                t.Draw(g);
            }
            slider.Draw(g);
        }

        /*private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate(true);
        }*/

        private void NewGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                slider.Move(-10);
            else if (e.KeyCode == Keys.Right)
                slider.Move(10);
            Invalidate(true);
        }
>>>>>>> Colliding with tiles

           // lblCountdown.BackColor = Color.SlateGray;
            lblCountdown.Text = countdown.ToString();
            Scene.Draw(e.Graphics);
        }   

        private void timerForBall_Tick(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Scene.Ball.Move();
            Scene.Ball.SliderCollider(slider);
            /*reward.Move(slider);
            if (slider.touchReward(reward))
            {
                reward.X = 0;
                reward.Y = 0;
            }*/
=======
            ball.Move();
            ball.SliderCollider(slider);
            CheckForCollision();
>>>>>>> Colliding with tiles
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

<<<<<<< HEAD
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
            Scene.MoveLeftSlider = Scene.MoveRightSlider = false;

        }

        private void timerSlider_Tick(object sender, EventArgs e)
        {
            Scene.MoveSlider();
            Invalidate(true);
        }


=======
>>>>>>> Colliding with tiles
        



        

        

        

        

    }
}
